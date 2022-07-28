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
    public class CategoryManager : ICategoryService
    {
        private readonly IUnitOfWork _unitOfWork;
        public CategoryManager(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task<IDataResult<int>> CountByNonDeleted()
        {
            var categoriesCount = await _unitOfWork.Categories.CountAsync(c => !c.IsDeleted);
            if (categoriesCount > -1)
            {
                return new DataResult<int>(ResultStatus.Success, categoriesCount);
            }
            else
            {
                return new DataResult<int>(ResultStatus.Error, $"Beklenmeyen bir hata ile karşılaşıldı.", -1);
            }
        }
        public async Task<IDataResult<CategoryListDto>> GetAllAsync()
        {
            var categories = await _unitOfWork.Categories.GetAllAsync(predicate: null, include: category=>category.Include(c=>c.ProductCategories));
            if (categories.Count() > -1)
            {
                return new DataResult<CategoryListDto>(ResultStatus.Success, new CategoryListDto
                {
                    Categories = categories
                });
            }
            else
            {
                return new DataResult<CategoryListDto>(ResultStatus.Error, "Hata", null);
            }
        }

        public async Task<IDataResult<CategoryListDto>> GetAllOrderByAsync()
        {
            var categories = await _unitOfWork.Categories.GetAllAsync(predicate:null, include: category=>category.Include(c=>c.ProductCategories));
            if(categories.Count() > -1)
            {
                var sortedCategories = categories.OrderByDescending(c => c.ProductCategories.Count).ToList();
                return new DataResult<CategoryListDto>(ResultStatus.Success, new CategoryListDto
                {
                    Categories = sortedCategories
                });
            }
            else
            {
                return new DataResult<CategoryListDto>(ResultStatus.Error, "Hata", null);
            }
        }

        public async Task<IDataResult<CategoryListDto>> GetAllByProductCount()
        {
            var categories = await _unitOfWork.Categories.GetAllAsync(predicate: c=>!c.IsDeleted && c.IsActive, c=>c.Include(c=>c.ProductCategories));
            
            if (categories.Count() > -1)
            {
                var sortedCategories = categories.OrderByDescending(c => c.ProductCategories.Count).Take(3).ToList();
                return new DataResult<CategoryListDto>(ResultStatus.Success, new CategoryListDto
                {
                    Categories = sortedCategories,
                    ResultStatus = ResultStatus.Success
                });
            }
            else
            {
                return new DataResult<CategoryListDto>(ResultStatus.Error, "Hata", new CategoryListDto
                {
                    Categories = null,
                    ResultStatus = ResultStatus.Error,
                    Message = "Hata"
                });
            }
        }

        public async Task<IDataResult<CategoryListDto>> GetAllByNonDeletedAsync()
        {
            var categories = await _unitOfWork.Categories.GetAllAsync(predicate: c=>!c.IsDeleted, include: category=>category.Include(c=>c.ProductCategories));
            if (categories.Count() > -1)
            {
                var sortedCategories = categories.OrderByDescending(c => c.ProductCategories.Count).ToList();
                return new DataResult<CategoryListDto>(ResultStatus.Success, new CategoryListDto
                {
                    Categories = sortedCategories
                });
            }
            else
            {
                return new DataResult<CategoryListDto>(ResultStatus.Error, "Hata", null);
            }
        }

        public async Task<IResult> AddAsync(CategoryAddDto categoryAddDto)
        {
            var category = new Category()
            {
                Name = categoryAddDto.Name,
                IsActive = categoryAddDto.IsActive
            };

            await _unitOfWork.Categories.AddAsync(category);
            await _unitOfWork.SaveAsync();

            return new Result(ResultStatus.Success, "Başarılı");
        }

        public async Task<IDataResult<CategoryUpdateDto>> GetCategoryUpdateDtoAsync(int categoryId)
        {
            var result = await _unitOfWork.Categories.AnyAsync(predicate: c => c.Id == categoryId);
            if (result)
            {
                var category = await _unitOfWork.Categories.GetAsync(predicate: c => c.Id == categoryId, include: null);
                var categoryUpdateDto = new CategoryUpdateDto()
                {
                    Id = category.Id,
                    Name = category.Name,
                    IsActive = category.IsActive
                };
                return new DataResult<CategoryUpdateDto>(ResultStatus.Success, categoryUpdateDto);
            }
            return new DataResult<CategoryUpdateDto>(ResultStatus.Error, "hat", null);
        }

        public async Task<IResult> UpdateAsync(CategoryUpdateDto categoryUpdateDto)
        {
            var result = await _unitOfWork.Categories.AnyAsync(predicate: c => c.Id == categoryUpdateDto.Id);
            if (result)
            {
                var category = await _unitOfWork.Categories.GetAsync(predicate: c => c.Id == categoryUpdateDto.Id, include: null);

                category.Name = categoryUpdateDto.Name;
                category.IsActive = categoryUpdateDto.IsActive;
                category.ModifiedDate = DateTime.Now;

                await _unitOfWork.Categories.UpdateAsync(category);
                int count = await _unitOfWork.SaveAsync();

                if (count > -1)
                {
                    return new Result(ResultStatus.Success, "başarılı");
                }
            }
            return new Result(ResultStatus.Error, "Hata");
        }

        public async Task<IResult> DeleteAsync(int categoryId)
        {
            var result = await _unitOfWork.Categories.AnyAsync(predicate: c => c.Id == categoryId);
            if (result)
            {
                var category = await _unitOfWork.Categories.GetAsync(predicate: c => c.Id == categoryId, include:null);
                category.IsDeleted = true;
                category.IsActive = false;

                await _unitOfWork.Categories.UpdateAsync(category);
                var count = await _unitOfWork.SaveAsync();

                if (count > -1)
                {
                    return new Result(ResultStatus.Success, "Başarılı");
                }
            }
            return new Result(ResultStatus.Error, "Hata");
        }
    }
}
