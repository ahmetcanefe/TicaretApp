using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TicaretApp.Entity.Dtos;
using TicaretApp.Shared.Results.Abstract;

namespace TicaretApp.Services.Abstract
{
    public interface IBrandService
    {
        Task<IDataResult<BrandListDto>> GetAllAsync();
        Task<IDataResult<BrandListDto>> GetAllByNonDeletedAsync();
        Task<IDataResult<BrandUpdateDto>> GetBrandUpdateDto(int brandId);
        Task<IDataResult<int>> CountByNonDeleted();

        Task<IResult> AddAsync(BrandAddDto brandAddDto);
        Task<IResult> UpdateAsync(BrandUpdateDto brandUpdateDto);
        Task<IResult> DeleteAsync(int brandId);
    }
}
