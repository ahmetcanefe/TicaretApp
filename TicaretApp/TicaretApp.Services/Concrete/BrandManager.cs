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
    public class BrandManager : IBrandService
    {
        private readonly IUnitOfWork _unitOfWork;
        public BrandManager(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task<IResult> AddAsync(BrandAddDto brandAddDto)
        {
            var brand = new Brand()
            {
                Name = brandAddDto.Name,
                IsActive = brandAddDto.IsActive
            };

            await _unitOfWork.Brands.AddAsync(brand);
            var count = await _unitOfWork.SaveAsync();
            if (count > -1)
            {
                return new Result(ResultStatus.Success, "Başarılı");
            }
            else
            {
                return new Result(ResultStatus.Error, "Hata");
            }
        }

        public async Task<IDataResult<int>> CountByNonDeleted()
        {
            var brandsCount = await _unitOfWork.Brands.CountAsync(b => !b.IsDeleted);
            if (brandsCount > -1)
            {
                return new DataResult<int>(ResultStatus.Success, brandsCount);
            }
            else
            {
                return new DataResult<int>(ResultStatus.Error, "Hata", -1);
            }
        }

        public async Task<IResult> DeleteAsync(int brandId)
        {
            var result = await _unitOfWork.Brands.AnyAsync(predicate: b => b.Id == brandId);
            if (result)
            {
                var brand = await _unitOfWork.Brands.GetAsync(predicate: b => b.Id == brandId, include: null);
                brand.IsDeleted = true;
                brand.IsActive = false;
                brand.ModifiedDate = DateTime.Now;

                await _unitOfWork.Brands.UpdateAsync(brand);
                var count = await _unitOfWork.SaveAsync();
                if (count > -1)
                {
                    return new Result(ResultStatus.Success, "Başarılı");
                }
            }
            return new Result(ResultStatus.Error, "Başarısız");
        }

        public async Task<IDataResult<BrandListDto>> GetAllAsync()
        {
            var brands = await _unitOfWork.Brands.GetAllAsync(predicate: null, include: brand => brand.Include(b=>b.Products));
            if (brands.Count > -1)
            {
                return new DataResult<BrandListDto>(ResultStatus.Success, new BrandListDto
                {
                    Brands = brands
                });
            }
            else
            {
                return new DataResult<BrandListDto>(ResultStatus.Success, "hata", null);
            }
        }

        public async Task<IDataResult<BrandListDto>> GetAllByNonDeletedAsync()
        {
            var brands = await _unitOfWork.Brands.GetAllAsync(predicate: b=>!b.IsDeleted, include: brand => brand.Include(b => b.Products));
            if (brands.Count > -1)
            {
                return new DataResult<BrandListDto>(ResultStatus.Success, new BrandListDto
                {
                    Brands = brands
                });
            }
            else
            {
                return new DataResult<BrandListDto>(ResultStatus.Success, "hata", null);
            }
        }

        public async Task<IDataResult<BrandUpdateDto>> GetBrandUpdateDto(int brandId)
        {
            var result = await _unitOfWork.Brands.AnyAsync(predicate: b => b.Id == brandId);
            if (result)
            {
                var brand = await _unitOfWork.Brands.GetAsync(predicate: b => b.Id == brandId);
                var brandUpdtoDto = new BrandUpdateDto()
                {
                    Id = brand.Id,
                    Name = brand.Name,
                    IsActive = brand.IsActive
                };

                return new DataResult<BrandUpdateDto>(ResultStatus.Success, brandUpdtoDto);
            }
            else
            {
                return new DataResult<BrandUpdateDto>(ResultStatus.Error, "Hata", null);
            }
        }

        public async Task<IResult> UpdateAsync(BrandUpdateDto brandUpdateDto)
        {
            var result = await _unitOfWork.Brands.AnyAsync(predicate: b => b.Id == brandUpdateDto.Id);
            if (result)
            {
                var brand = await _unitOfWork.Brands.GetAsync(predicate: b => b.Id == brandUpdateDto.Id, include:null);
                brand.Name = brandUpdateDto.Name;
                brand.IsActive = brandUpdateDto.IsActive;
                brand.ModifiedDate = DateTime.Now;

                await _unitOfWork.Brands.UpdateAsync(brand);
                var count = await _unitOfWork.SaveAsync();

                if (count > -1)
                {
                    return new Result(ResultStatus.Success, "Başarılı");
                }
            }
            return new Result(ResultStatus.Error, "Başarısız");
        }
    }
}
