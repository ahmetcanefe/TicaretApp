using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TicaretApp.Mvc.Models;
using TicaretApp.Services.Abstract;
using TicaretApp.Shared.Results.ComplexTypes;

namespace TicaretApp.Mvc.Controllers
{
    public class ProductController : Controller
    {
        private readonly IProductService _productService;
        public ProductController(IProductService productService)
        {
            _productService = productService;
        }
        public async Task<IActionResult> List(int? categoryId, int currentPage=1, int pageSize=20)
        {
            var productsResult = categoryId == null 
                ? await _productService.GetAllByPagingAsync(null, currentPage, pageSize) 
                : await _productService.GetAllByPagingAsync(categoryId.Value,currentPage,pageSize);
            if (productsResult.ResultStatus == ResultStatus.Success)
            {
                return View(productsResult.Data);
            }
            return NotFound();
          
        }    

        [HttpPost]
        public async Task<IActionResult> Filter(int[] categoryIds, int[] brandIds, int? priceMin, int? priceMax,int? orderBy, int currentPage = 1, int pageSize = 20)
        {
            var productsResult = await _productService.GetAllByFilter(categoryIds, brandIds, priceMin, priceMax, orderBy,currentPage);
            if (productsResult.ResultStatus == ResultStatus.Success)
            {
                return View(productsResult.Data);
            }
            return NotFound();
        }

        public async Task<IActionResult> Detail(int productId)
        {
            var productResult = await _productService.GetAsync(productId);
            if (productResult.ResultStatus == ResultStatus.Success)
            {
                var productsBySameCategoriesResult = await _productService.GetAllByCategoryIdOnFilder(productResult.Data.Product.ProductCategories.Select(pc => pc.CategoryId).ToList(),5);
                if (productsBySameCategoriesResult.ResultStatus == ResultStatus.Success)
                {
                    return View(new ProductDetailViewModel()
                    {
                        ProductDto = productResult.Data,
                        ProductDetailSideBarViewModel = new ProductDetailSideBarViewModel
                        {
                            Header = "Proucts On Same Categories",
                            ProductListDto = productsBySameCategoriesResult.Data
                        }
                    });
                }          
            }
            return NotFound();
        }

        [Authorize]
        [HttpPost]
        public async Task<IActionResult> DeleteFromWishList(int productId)
        {
            var productUpdateResult = await _productService.GetProductUpdateDto(productId);
            if (productUpdateResult.ResultStatus == ResultStatus.Success)
            {
                productUpdateResult.Data.HotDeal = false;
                await _productService.UpdateAsync(productUpdateResult.Data);

                return RedirectToAction("Index", "Home");
            }
            else
            {
                return NotFound();
            }
        }

        [Authorize]
        [HttpPost]
        public async Task<IActionResult> AddToWishList(int productId)
        {
            var productUpdateResult = await _productService.GetProductUpdateDto(productId);
            if (productUpdateResult.ResultStatus == ResultStatus.Success)
            {
                productUpdateResult.Data.HotDeal = true;
                await _productService.UpdateAsync(productUpdateResult.Data);

                return RedirectToAction("Index", "Home");
            }
            else
            {
                return NotFound();
            }
        }
    }
}
