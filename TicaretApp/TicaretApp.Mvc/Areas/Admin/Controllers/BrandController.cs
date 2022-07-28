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
    public class BrandController : Controller
    {
        private readonly IBrandService _brandService;
        private readonly IToastNotification _toastNotification;
        public BrandController(IBrandService brandService, IToastNotification toastNotification)
        {
            _brandService = brandService;
            _toastNotification = toastNotification;
        }

        [Authorize]
        [HttpGet]
        public async Task<IActionResult> Index()
        {
            var brandsResult = await _brandService.GetAllAsync();
            if (brandsResult.ResultStatus == ResultStatus.Success)
            {
                return View(brandsResult.Data);
            }
            return NotFound();
        }

        [Authorize]
        [HttpGet]
        public async Task<IActionResult> Add()
        {
            return View();
        }

        [Authorize]
        [HttpPost]
        public async Task<IActionResult> Add(BrandAddViewModel brandAddViewModel)
        {
            if (ModelState.IsValid)
            {
                var brandAddDto = new BrandAddDto()
                {
                    Name = brandAddViewModel.Name,
                    IsActive = brandAddViewModel.IsActive
                };
                var result = await _brandService.AddAsync(brandAddDto);

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
                    return View(brandAddViewModel);
                }
            }
            return View(brandAddViewModel); 
        }

        [Authorize]
        [HttpGet]
        public async Task<IActionResult> Update(int brandId)
        {
            var brandUpdateDto = await _brandService.GetBrandUpdateDto(brandId);
            if (brandUpdateDto.ResultStatus == ResultStatus.Success)
            {
                var brandUpdateViewModel = new BrandUpdateViewModel()
                {
                    Id = brandUpdateDto.Data.Id,
                    Name = brandUpdateDto.Data.Name,
                    IsActive = brandUpdateDto.Data.IsActive
                };

                return View(brandUpdateViewModel);
            }
            else
            {
                return NotFound();
            }
        }

        [Authorize]
        [HttpPost]
        public async Task<IActionResult> Update(BrandUpdateViewModel brandUpdateViewModel)
        {
            if (ModelState.IsValid)
            {
                var brandUpdateDto = new BrandUpdateDto()
                {
                    Id = brandUpdateViewModel.Id,
                    Name = brandUpdateViewModel.Name,
                    IsActive = brandUpdateViewModel.IsActive
                };

                var result = await _brandService.UpdateAsync(brandUpdateDto);
                if (result.ResultStatus == ResultStatus.Success)
                {
                    _toastNotification.AddSuccessToastMessage(result.Message, new ToastrOptions
                    {
                        Title = "Başarılı İşlem"
                    });
                }
                else
                {
                    _toastNotification.AddErrorToastMessage(result.Message, new ToastrOptions
                    {
                        Title = "Başarısız İşlem"
                    });
                }
            }
            return View(brandUpdateViewModel);
        }

        [Authorize]
        [HttpPost]
        public async Task<IActionResult> Delete(int brandId)
        {
            var result = await _brandService.DeleteAsync(brandId);
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
                _toastNotification.AddSuccessToastMessage(result.Message, new ToastrOptions
                {
                    Title = "Başarısız İşlem"
                });
                return RedirectToAction("Index");
            }
        }
    }
}
