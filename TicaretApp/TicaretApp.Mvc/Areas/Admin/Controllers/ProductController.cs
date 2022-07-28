using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using NToastNotify;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TicaretApp.Entity.ComplexTypes;
using TicaretApp.Entity.Concrete;
using TicaretApp.Entity.Dtos;
using TicaretApp.Mvc.Areas.Admin.Models;
using TicaretApp.Mvc.Helpers.Abstract;
using TicaretApp.Mvc.Models;
using TicaretApp.Services.Abstract;
using TicaretApp.Shared.Results.ComplexTypes;

namespace TicaretApp.Mvc.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class ProductController : Controller
    {
        private readonly IProductService _productService;
        private readonly ICategoryService _categoryService;
        private readonly IImageHelper _imageHelper;
        private readonly IBrandService _brandService;
        private readonly IImageService _imageService;
        private readonly IToastNotification _toastNotification;
        public ProductController(IProductService productService, ICategoryService categoryService, IImageHelper imageHelper, IBrandService brandService, IToastNotification toastNotification, IImageService imageService)
        {
            _productService = productService;
            _categoryService = categoryService;
            _imageHelper = imageHelper;
            _brandService = brandService;
            _imageService = imageService;
            _toastNotification = toastNotification;
        }
        [Authorize]
        public async Task<IActionResult> Index()
        {
            var productsResult = await _productService.GetAllAsync();
            if(productsResult.ResultStatus == ResultStatus.Success)
            {
                return View(productsResult.Data);
            }
            else
            {
                return NotFound();
            }
        }

        [Authorize]
        [HttpGet]
        public async Task<IActionResult> Add()
        {
            var categoriesResult = await _categoryService.GetAllByNonDeletedAsync();
            var brandsResult = await _brandService.GetAllByNonDeletedAsync();
            if(categoriesResult.ResultStatus==ResultStatus.Success && brandsResult.ResultStatus == ResultStatus.Success)
            {
                var colors = new List<string>() { "Kırmızı", "Siyah", "Beyaz" };
                var sizes = new List<string>() { "s", "m", "L" };
                

                return View(new ProductAddViewModel
                {
                    Categories = categoriesResult.Data.Categories,
                    Brands = brandsResult.Data.Brands,
                    Colors = colors,
                    Sizes = sizes
                });
            }
            else
            {
                return NotFound();
            }
        }

        [Authorize]
        [HttpPost]
        public async Task<IActionResult> Add(ProductAddViewModel productAddViewModel)
        {
            if(ModelState.IsValid)
            {
                var product = new Product();
                product.Name = productAddViewModel.Name;
                product.CreatedDate = productAddViewModel.Date;
                product.ModifiedDate = productAddViewModel.Date;
                product.Description = productAddViewModel.Description;
                product.OldPrice = productAddViewModel.Price;
                product.IsActive = productAddViewModel.IsActive;
                product.ProductCategories = productAddViewModel.CategoryIds.Select(c => new ProductCategory
                {
                    ProductId = product.Id,
                    CategoryId = c
                }).ToList();
                product.BrandId = productAddViewModel.BrandId;
                product.ProductDetails = productAddViewModel.SelectedColors.Select(c => new ProductDetail
                {
                    Color = c,
                    Size = c,
                    stock = 5
                }).ToList();

                var imageResult = await _imageHelper.Upload(productAddViewModel.Name, productAddViewModel.ThumbnailFile, PictureType.Post);

                product.ImageUrl = imageResult.Data.FullName;

                product.Images = new List<Image>();

                foreach (var file in productAddViewModel.ThumbnailFiles)
                {
                    var detailImageResult = await _imageHelper.Upload(productAddViewModel.Name, file, PictureType.Post);
                    product.Images.Add(new Image
                    {
                        ImageUrl = detailImageResult.Data.FullName
                    });
                }

                var productAddResult = await _productService.AddAsync(product);

                if (productAddResult.ResultStatus == ResultStatus.Success)
                {
                    _toastNotification.AddSuccessToastMessage(productAddResult.Message, new ToastrOptions
                    {
                        Title = "Başarılı İşlem"
                    });
                    return RedirectToAction("Index");
                }
            }

            var categoriesResult = await _categoryService.GetAllByNonDeletedAsync();
            var brandsResult = await _brandService.GetAllByNonDeletedAsync();
            if (categoriesResult.ResultStatus == ResultStatus.Success && brandsResult.ResultStatus == ResultStatus.Success)
            {
                return View(new ProductAddViewModel
                {
                    Categories = categoriesResult.Data.Categories,
                    Brands = brandsResult.Data.Brands
                });
            }
            else
            {
                return NotFound();
            }
        }

        [Authorize]
        [HttpGet]
        public async Task<IActionResult> Update(int productId)
        {
            var productResult = await _productService.GetProductUpdateDto(productId);
            
            var categoriesResult = await _categoryService.GetAllByNonDeletedAsync();
            var brandsResult = await _brandService.GetAllByNonDeletedAsync();

            if (productResult.ResultStatus == ResultStatus.Success && categoriesResult.ResultStatus == ResultStatus.Success && brandsResult.ResultStatus==ResultStatus.Success)
            {
                return View(new ProductUpdateViewModel
                {
                    Id = productResult.Data.Id,
                    Name = productResult.Data.Name,
                    Description = productResult.Data.Description,
                    Price = productResult.Data.Price,
                    ImageUrl = productResult.Data.ImageUrl,
                    Date = productResult.Data.Date,
                    CategoryIds = productResult.Data.ProductCategories.Select(pc=>pc.CategoryId).ToList(),
                    DetailImageUrls = productResult.Data.Images.Select(i=>i.ImageUrl).ToList(),
                    BrandId = productResult.Data.BrandId,
                    IsActive = productResult.Data.IsActive,
                    Categories = categoriesResult.Data.Categories,
                    Brands = brandsResult.Data.Brands
                });
            }
            else
            {
                return NotFound();
            }
        }

        [Authorize]
        [HttpPost]
        public async Task<IActionResult> Update(ProductUpdateViewModel productUpdateViewModel)
        {

            if (ModelState.IsValid)
            {
                bool isNewThumbnailUploaded = false;
                var oldThumbnail = productUpdateViewModel.ImageUrl;
                if (productUpdateViewModel.ThumbnailFile != null)
                {
                    var uploadedImageResult = await _imageHelper.Upload(productUpdateViewModel.Name,productUpdateViewModel.ThumbnailFile, PictureType.Post);
                    productUpdateViewModel.ImageUrl = uploadedImageResult.ResultStatus == ResultStatus.Success
                        ? uploadedImageResult.Data.FullName
                        : "postImages/defaultThumbnail.jpg";
                    if (oldThumbnail != "postImages/defaultThumbnail.jpg")
                    {
                        isNewThumbnailUploaded = true;
                    }
                }
                if (productUpdateViewModel.ThumbnailFiles != null)
                {
                    for(int i=0;i<productUpdateViewModel.ThumbnailFiles.Count();i++)
                    {
                        var uploadedImageResult = await _imageHelper.Upload(productUpdateViewModel.Name,productUpdateViewModel.ThumbnailFiles[i], PictureType.Post);
                        productUpdateViewModel.DetailImageUrls[i] = uploadedImageResult.ResultStatus == ResultStatus.Success ? uploadedImageResult.Data.FullName: "postImages/defaultThumbnail.jpg";
                        if (oldThumbnail != "postImages/defaultThumbnail.jpg")
                        {
                            isNewThumbnailUploaded = true;
                        }
                    }
                    
                }
                var productUpdateDto = new ProductUpdateDto();
                productUpdateDto.Id = productUpdateViewModel.Id;
                productUpdateDto.Name = productUpdateViewModel.Name;
                productUpdateDto.Description = productUpdateViewModel.Description;
                productUpdateDto.Price = productUpdateViewModel.Price;
                productUpdateDto.IsActive = productUpdateViewModel.IsActive;
                productUpdateDto.ImageUrl = productUpdateViewModel.ImageUrl;
                productUpdateDto.Images = productUpdateViewModel.DetailImageUrls.Select(i => new Image
                {
                    ImageUrl = i
                }).ToList();
                productUpdateDto.ProductCategories = productUpdateViewModel.CategoryIds.Select(c => new ProductCategory
                {
                    CategoryId = c,
                    ProductId = productUpdateViewModel.Id
                }).ToList();
                
                var result = await _productService.UpdateAsync(productUpdateDto);
                if (result.ResultStatus == ResultStatus.Success)
                {
                    if (isNewThumbnailUploaded)
                    {
                        _imageHelper.Delete(oldThumbnail);
                    }
                    _toastNotification.AddSuccessToastMessage(result.Message, new ToastrOptions
                    {
                        Title = "Başarılı İşlem"
                    });
                    return RedirectToAction("Index", "Product");
                }
                else
                {
                    ModelState.AddModelError("", result.Message);
                }
            }

            var categoriesResult = await _categoryService.GetAllByNonDeletedAsync();
            var brandsResult = await _brandService.GetAllByNonDeletedAsync();
            if(categoriesResult.ResultStatus==ResultStatus.Success && brandsResult.ResultStatus == ResultStatus.Success)
            {
                productUpdateViewModel.Categories = categoriesResult.Data.Categories;
                productUpdateViewModel.Brands = brandsResult.Data.Brands;
                return View(productUpdateViewModel);
            }
            else
            {
                return NotFound();
            }
        }

        [Authorize]
        [HttpPost]
        public async Task<IActionResult> Delete(int productId)
        {
            var productResult = await _productService.DeleteAsync(productId);
            if (productResult.ResultStatus == ResultStatus.Success)
            {
                _toastNotification.AddSuccessToastMessage(productResult.Message, new ToastrOptions
                {
                    Title = "Başarılı İşlem"
                });
                return RedirectToAction("Index");
            }
            else
            {
                _toastNotification.AddErrorToastMessage(productResult.Message, new ToastrOptions
                {
                    Title = "Başarısız İşlem"
                });
                return RedirectToAction("Index");
            };
        }
    }
}
