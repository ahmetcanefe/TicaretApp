using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TicaretApp.Entity.Concrete;
using TicaretApp.Entity.Dtos;
using TicaretApp.Shared.Results.Abstract;

namespace TicaretApp.Services.Abstract
{
    public interface IProductService 
    {
        Task<IDataResult<ProductDto>> GetAsync(int productId);     
        Task<IDataResult<ProductListDto>> GetAllAsync();
        Task<IDataResult<ProductListDto>> GetAllByNonDeletedAsync();
        Task<IDataResult<ProductListDto>> GetAllByFeaturedAsync();
        Task<IDataResult<ProductListDto>> GetAllByCategoryIdAndNonDeletedAsync(int categoryId);
        Task<IDataResult<ProductListDto>> GetAllByFilter(int[] categoryIds, int[] brandIds, int? priceMin, int? priceMax, int? orderBy, int currentPage = 1, int pageSize = 20);
        Task<IDataResult<ProductListDto>> GetAllByDateAsync();
        Task<IDataResult<ProductListDto>> GetAllByOrderCountAsync();
        Task<IDataResult<ProductListDto>> GetAllByPagingAsync(int? categoryId, int currentPage=1, int pageSize=20);
        Task<IDataResult<ProductListDto>> GetAllByCategoryIdOnFilder(List<int> categoryId,int takeSize);
        Task<IDataResult<ProductListDto>> GetAllByWishAsync();
        Task<IDataResult<ProductUpdateDto>> GetProductUpdateDto(int productId);
        Task<IDataResult<int>> CountByNonDeletedAsync();

        Task<IResult> AddAsync(Product product);
        Task<IResult> UpdateAsync(ProductUpdateDto productUpdateDto);
        Task<IResult> DeleteAsync(int productId);
    }
}
