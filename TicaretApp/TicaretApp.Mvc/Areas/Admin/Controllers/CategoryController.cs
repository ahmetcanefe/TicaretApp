using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using NToastNotify;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TicaretApp.Entity.Dtos;
using TicaretApp.Mvc.Areas.Admin.Models;
using TicaretApp.Services.Abstract;
using TicaretApp.Shared.Results.ComplexTypes;

namespace TicaretApp.Mvc.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class CategoryController : Controller
    {
        private readonly ICategoryService _categoryService;
        private readonly IToastNotification _toastNotification;
        public CategoryController(ICategoryService categoryService, IToastNotification toastNotification)
        {
            _categoryService = categoryService;
            _toastNotification = toastNotification;
        }

        [Authorize]
        [HttpGet]
        public async Task<IActionResult> Index()
        {
            var categoriesResult = await _categoryService.GetAllAsync();
            if (categoriesResult.ResultStatus == ResultStatus.Success)
            {
                return View(categoriesResult.Data);
            }
            return NotFound();
        }

        [Authorize]
        [HttpGet]
        public IActionResult Add()
        {
            return View();
        }

        [Authorize]
        [HttpPost]
        public async Task<IActionResult> Add(CategoryAddViewModel categoryAddViewModel)
        {
            if (ModelState.IsValid)
            {
                var categoryAddDto = new CategoryAddDto() 
                {
                    Name = categoryAddViewModel.Name,
                    IsActive = categoryAddViewModel.IsActive
                };

                var result = await _categoryService.AddAsync(categoryAddDto);
                if (result.ResultStatus == ResultStatus.Success)
                {
                    _toastNotification.AddAlertToastMessage(result.Message, new ToastrOptions
                    {
                        Title = "Başarılı işlem"
                    });
                    return RedirectToAction("Index");
                }          
            }
            return View(categoryAddViewModel);
        }

        [Authorize]
        [HttpGet]
        public async Task<IActionResult> Update(int categoryId)
        {
            var categoryUpdateDtoResult = await _categoryService.GetCategoryUpdateDtoAsync(categoryId);
            if (categoryUpdateDtoResult.ResultStatus == ResultStatus.Success)
            {
                var categoryUpdateViewModel = new CategoryUpdateViewModel()
                {
                    Id = categoryUpdateDtoResult.Data.Id,
                    Name = categoryUpdateDtoResult.Data.Name,
                    IsActive = categoryUpdateDtoResult.Data.IsActive
                };
                return View(categoryUpdateViewModel);
            }
            else
            {
                return NotFound();
            }
        }

        [Authorize]
        [HttpPost]
        public async Task<IActionResult> Update(CategoryUpdateViewModel categoryUpdateViewModel)
        {
            if (ModelState.IsValid)
            {
                var categoryUpdateDto = new CategoryUpdateDto() 
                {
                    Id = categoryUpdateViewModel.Id,
                    Name = categoryUpdateViewModel.Name,
                    IsActive = categoryUpdateViewModel.IsActive
                };

                var result = await _categoryService.UpdateAsync(categoryUpdateDto);
                if (result.ResultStatus == ResultStatus.Success)
                {
                    _toastNotification.AddSuccessToastMessage(result.Message, new ToastrOptions
                    {
                        Title = "Başarılı İşlem"
                    });
                    return RedirectToAction("Index");
                }
                else
                {
                    _toastNotification.AddErrorToastMessage(result.Message, new ToastrOptions
                    {
                        Title = "Başarısız İşlem"
                    });
                    return View(categoryUpdateViewModel);
                }
            }
            else
            { 
                return View(categoryUpdateViewModel);
            }
        }

        [Authorize]
        [HttpPost]
        public async Task<IActionResult> Delete(int categoryId)
        {
            var result = await _categoryService.DeleteAsync(categoryId);
            if (result.ResultStatus == ResultStatus.Success)
            {
                _toastNotification.AddSuccessToastMessage(result.Message, new ToastrOptions
                {
                    Title = "Başarılı işlem"
                });
                return RedirectToAction("Index");
            }
            else
            {
                _toastNotification.AddErrorToastMessage(result.Message, new ToastrOptions
                {
                    Title = "Başarrısız işlem"
                });
                return RedirectToAction("Index");
            }
        }
    }  
}
