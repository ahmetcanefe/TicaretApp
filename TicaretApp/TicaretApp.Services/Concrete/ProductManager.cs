using LinqKit;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TicaretApp.Data.Abstract;
using TicaretApp.Entity.Concrete;
using TicaretApp.Entity.Dtos;
using TicaretApp.Services.Abstract;
using TicaretApp.Shared.Results.Abstract;
using TicaretApp.Shared.Results.ComplexTypes;
using TicaretApp.Shared.Results.Concrete;

namespace TicaretApp.Services.Concrete
{
    public class ProductManager : IProductService
    {
        private readonly IUnitOfWork _unitOfWork;
        public ProductManager(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task<IDataResult<ProductListDto>> GetAllAsync()
        {
            var products = await _unitOfWork.Products.GetAllAsync(predicate: null,
                                                                  include: null);
            if (products.Count() > -1)
            {
                return new DataResult<ProductListDto>(ResultStatus.Success, new ProductListDto
                {
                    Products = products
                });
            }
            else
            {
                return new DataResult<ProductListDto>(ResultStatus.Error, "Hata", null);
            }
        }

        public async Task<IDataResult<ProductListDto>> GetAllByNonDeletedAsync()
        {
            var products = await _unitOfWork.Products.GetAllAsync(predicate: p => !p.IsDeleted,
                                                                  include: null);
            if (products.Count() > -1)
            {
                return new DataResult<ProductListDto>(ResultStatus.Success, new ProductListDto
                {
                    Products = products
                });
            }
            else
            {
                return new DataResult<ProductListDto>(ResultStatus.Error, "Hata", null);
            }
        }

        public async Task<IDataResult<ProductListDto>> GetAllByCategoryIdAndNonDeletedAsync(int categoryId)
        {
            var anyCategory = await _unitOfWork.Categories.AnyAsync(c => c.Id == categoryId);
            if (anyCategory)
            {
                var products = await _unitOfWork.Products.GetAllAsync(
                                           predicate: p => p.ProductCategories.Any(c => c.CategoryId == categoryId),
                                           include: product => product.Include(p => p.ProductCategories).ThenInclude(p => p.Category));
                if (products.Count() > -1)
                {
                    return new DataResult<ProductListDto>(ResultStatus.Success, new ProductListDto
                    {
                        Products = products
                    });
                }
                else
                {
                    return new DataResult<ProductListDto>(ResultStatus.Error, "hata", null);
                }
            }
            else
            {
                return new DataResult<ProductListDto>(ResultStatus.Error, "hata", null);
            }


            //var products = _unitOfWork.Products.GetAsQueryable();
            //products = products.Include(p => p.ProductCategories).ThenInclude(p => p.Category);

            //products = products.Where(p => p.ProductCategories.Any(c => c.CategoryId == categoryId))
        }

        public async Task<IDataResult<ProductListDto>> GetAllByDateAsync()
        {

            var newProducts = await _unitOfWork.Products.GetAllAsync(predicate: p => p.ModifiedDate.Date >= (DateTime.Today.AddDays(-7)), include: p => p.Include(p => p.ProductCategories).ThenInclude(pc => pc.Category));
            if (newProducts.Count() > -1)
            {
                var sortedProducts = newProducts.OrderBy(p => p.ModifiedDate).Take(10).ToList();
                return new DataResult<ProductListDto>(ResultStatus.Success, new ProductListDto
                {
                    Products = sortedProducts,
                    ResultStatus = ResultStatus.Success,
                });
            }
            else
            {
                return new DataResult<ProductListDto>(ResultStatus.Error, "Hata", new ProductListDto
                {
                    Products = null,
                    ResultStatus = ResultStatus.Success,
                    Message = "Hata"
                });
            }
        }

        public async Task<IDataResult<ProductListDto>> GetAllByFeaturedAsync()
        {
            var products = await _unitOfWork.Products.GetAllAsync();
            if (products.Count() > -1)
            {
                return new DataResult<ProductListDto>(ResultStatus.Success, new ProductListDto
                {
                    Products = products
                });
            }
            else
            {
                return new DataResult<ProductListDto>(ResultStatus.Error, "Hata", null);
            }
        }

       



        public async Task<IDataResult<ProductListDto>> GetAllByOrderCountAsync()
        {
            var products = await _unitOfWork.Products.GetAllAsync(predicate: p => !p.IsDeleted && p.IsActive, include: product => product.Include(p => p.ProductCategories).ThenInclude(pc => pc.Category));
            if (products.Count() > -1)
            {
                var sortedProducts = products.OrderByDescending(p => p.OrderCount).Take(10).ToList();
                return new DataResult<ProductListDto>(ResultStatus.Success, new ProductListDto
                {
                    Products = sortedProducts
                });
            }
            else
            {
                return new DataResult<ProductListDto>(ResultStatus.Error, "Hata", null);
            }
        }

        public async Task<IDataResult<ProductListDto>> GetAllByFilter(int[] categoryIds, int[] brandIds, int? priceMin, int? priceMax, int? orderBy, int currentPage = 1, int pageSize = 20)
        {
            var products = _unitOfWork.Products.GetAsQueryable();
            if (categoryIds.Count() > 0)
            {
                var categoryChain = PredicateBuilder.New<Product>();
                foreach (var categoryId in categoryIds)
                {
                    // predicate1 && predicate2 && predicate3 && predicateN
                    // predicate1 || predicate2 || predicate3 || predicateN
                    categoryChain.Or(p => p.ProductCategories.Any(pc => pc.CategoryId == categoryId));
                }

                products = products.Where(categoryChain);

            }
            if (brandIds.Count() > 0)
            {
                var brandChain = PredicateBuilder.New<Product>();
                foreach (var brandId in brandIds)
                {
                    // predicate1 && predicate2 && predicate3 && predicateN
                    // predicate1 || predicate2 || predicate3 || predicateN
                    brandChain.Or(p => p.BrandId == brandId);
                }

                products = products.Where(brandChain);
            }

            products = products.Where(p => p.OldPrice >= priceMin && p.OldPrice <= priceMax);

            var sortedProducts = products.ToList();
            if (orderBy == 0)
                sortedProducts = products.OrderByDescending(p => p.OldPrice).ToList();
            if (orderBy == 1)
                sortedProducts = products.OrderBy(p => p.OldPrice).ToList();
            if (orderBy == 2)
                sortedProducts = products.OrderByDescending(p => p.ViewCount).ToList();
            if (orderBy == 3)
                sortedProducts = products.OrderBy(p => p.ViewCount).ToList();

            var pagingProducts = sortedProducts.Skip((currentPage - 1) * pageSize).Take(pageSize).ToList();

            return new DataResult<ProductListDto>(ResultStatus.Success, new ProductListDto
            {
                Products = pagingProducts,
                CategoryIds = categoryIds == null ? null : categoryIds,
                BrandIds = brandIds == null ? null : brandIds,
                priceMax = priceMax == null ? null : priceMax,
                priceMin = priceMin == null ? null : priceMin,
                orderBy = orderBy,
                CurrentPage = currentPage,
                PageSize = pageSize,
                TotalCount = products.Count()
            });
        }

        public async Task<IDataResult<ProductDto>> GetAsync(int productId)
        {
            var product = await _unitOfWork.Products.GetAsync(predicate: p => p.Id == productId,
                                                              include: p => p.Include(p => p.ProductCategories).ThenInclude(pc => pc.Category)
                                                                           .Include(p => p.Images)
                                                                           .Include(p => p.ProductDetails)
                                                                           .Include(p => p.Comments));

            if (product != null)
            {
                return new DataResult<ProductDto>(ResultStatus.Success, new ProductDto
                {
                    Product = product
                });
            }
            else
            {
                return new DataResult<ProductDto>(ResultStatus.Error, "Hata", null);
            }
        }

        public async Task<IDataResult<ProductListDto>> GetAllByPagingAsync(int? categoryId, int currentPage = 1, int pageSize = 20)
        {
            var products = categoryId == null
                                     ? await _unitOfWork.Products.GetAllAsync(predicate: p => p.IsActive && !p.IsDeleted, include: product => product.Include(p => p.ProductCategories).ThenInclude(p => p.Category))
                                     : await _unitOfWork.Products.GetAllAsync(predicate: p => p.ProductCategories.Any(pc => pc.CategoryId == categoryId) && p.IsActive && !p.IsDeleted, include: product => product.Include(p => p.ProductCategories).ThenInclude(p => p.Category));

            var pagingProducts = products.Skip((currentPage - 1) * pageSize).Take(pageSize).ToList();

            return new DataResult<ProductListDto>(ResultStatus.Success, new ProductListDto
            {
                Products = pagingProducts,
                CategoryId = categoryId == null ? null : categoryId.Value,
                CurrentPage = currentPage,
                PageSize = pageSize,
                TotalCount = products.Count
            });
        }

        public async Task<IDataResult<ProductListDto>> GetAllByCategoryIdOnFilder(List<int> categoryIds, int takeSize)
        {
            var products = _unitOfWork.Products.GetAsQueryable();
            foreach (var categoryId in categoryIds)
            {
                products = products.Where(p => p.ProductCategories.Any(pc => pc.CategoryId == categoryId));
            }

            var sortedProducts = products.Include(p=>p.ProductCategories).ThenInclude(p=>p.Category).ToList();

            sortedProducts = sortedProducts.Take(takeSize).ToList();

            return new DataResult<ProductListDto>(ResultStatus.Success, new ProductListDto
            {
                Products = sortedProducts
            });
        }

        public async Task<IDataResult<int>> CountByNonDeletedAsync()
        {
            var productsCount = await _unitOfWork.Products.CountAsync(p => !p.IsDeleted);
            if (productsCount > -1)
            {
                return new DataResult<int>(ResultStatus.Success, productsCount);
            }
            else
            {
                return new DataResult<int>(ResultStatus.Error, $"Beklenmeyen bir hata ile karşılaşıldı.", -1);
            }
        }

        public async Task<IResult> AddAsync(Product product)
        {
            await _unitOfWork.Products.AddAsync(product);
            await _unitOfWork.SaveAsync();

            return new Result(ResultStatus.Success, "Başarılı");
        }

        public async Task<IDataResult<ProductUpdateDto>> GetProductUpdateDto(int productId)
        {
            var result = await _unitOfWork.Products.AnyAsync(p => p.Id == productId);
            if (result)
            {
                var productResult = await _unitOfWork.Products.GetAsync(predicate: p => p.Id == productId, include: product=>product.Include(p=>p.ProductCategories).Include(p=>p.Images));

                var productUpdateDto = new ProductUpdateDto();

                productUpdateDto.Id = productResult.Id;
                productUpdateDto.Name = productResult.Name;
                productUpdateDto.Description = productResult.Description;
                productUpdateDto.Price = productResult.OldPrice;
                productUpdateDto.ImageUrl = productResult.ImageUrl;
                productUpdateDto.Date = productResult.CreatedDate;
                productUpdateDto.ProductCategories = productResult.ProductCategories.ToList();
                productUpdateDto.Images = productResult.Images.ToList();
                productUpdateDto.BrandId = productResult.BrandId;
                productUpdateDto.IsActive = productResult.IsActive;
                productUpdateDto.HotDeal = productResult.HotDeal;
            
            return new DataResult<ProductUpdateDto>(ResultStatus.Success, productUpdateDto);
             }
            else
            {
                return new DataResult<ProductUpdateDto>(ResultStatus.Error, null);
            }

         }

        public async Task<IResult> UpdateAsync(ProductUpdateDto productUpdateDto)
        {
            var product = await _unitOfWork.Products.GetAsync(predicate: p => p.Id == productUpdateDto.Id, include:product=>product.Include(p=>p.ProductCategories).Include(p=>p.Images));
            if (product != null)
            {
                product.Name = productUpdateDto.Name;
                product.Description = productUpdateDto.Description;
                product.OldPrice = productUpdateDto.Price;
                product.IsActive = productUpdateDto.IsActive;
                product.HotDeal = productUpdateDto.HotDeal;
                product.IsDeleted = false;
                product.ModifiedDate = DateTime.Now;
                product.ImageUrl = productUpdateDto.ImageUrl;
                product.ProductCategories = productUpdateDto.ProductCategories;
                product.Images = productUpdateDto.Images;
                
                await _unitOfWork.Products.UpdateAsync(product);
                await _unitOfWork.SaveAsync();
                return new Result(ResultStatus.Success, "başarılı");

            }
            else
            {
                return new Result(ResultStatus.Error, "hata");
            }
        }

        public async Task<IResult> DeleteAsync(int productId)
        {
            var result = await _unitOfWork.Products.AnyAsync(p => p.Id == productId);
            if (result)
            {
                var product = await _unitOfWork.Products.GetAsync(predicate: p => p.Id == productId, include: null);
                product.IsDeleted = true;
                product.IsActive = false;
                product.ModifiedDate = DateTime.Now;

                await _unitOfWork.Products.UpdateAsync(product);
                await _unitOfWork.SaveAsync();

                return new Result(ResultStatus.Success, "başarılı");
            }
            else
            {
                return new Result(ResultStatus.Error, "Hata");
            }
        }

        public async Task<IDataResult<ProductListDto>> GetAllByWishAsync()
        {
            var products = await _unitOfWork.Products.GetAllAsync(predicate: p => p.HotDeal, include: null);
            if (products.Count() > -1)
            {
                return new DataResult<ProductListDto>(ResultStatus.Success, new ProductListDto
                {
                    Products = products
                });
            }
            return new DataResult<ProductListDto>(ResultStatus.Error, "Hata", null);
        }
    }
}
