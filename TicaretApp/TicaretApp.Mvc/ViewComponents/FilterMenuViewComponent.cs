using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TicaretApp.Mvc.Models;
using TicaretApp.Services.Abstract;
using TicaretApp.Shared.Results.ComplexTypes;

namespace TicaretApp.Mvc.ViewComponents
{
    public class FilterMenuViewComponent : ViewComponent
    {
        private readonly ICategoryService _categoryService;
        private readonly IBrandService _brandService;
        public FilterMenuViewComponent(ICategoryService categoryService, IBrandService brandService)
        {
            _categoryService = categoryService;
            _brandService = brandService;
        }
        public async Task<IViewComponentResult> InvokeAsync()
        {
            var categoriesResult = await _categoryService.GetAllAsync();
            var brandsResult = await _brandService.GetAllAsync();
            if(categoriesResult.ResultStatus==ResultStatus.Success && brandsResult.ResultStatus == ResultStatus.Success)
            {
                return View(new FilterMenuViewModel()
                {
                    Brands = brandsResult.Data.Brands,
                    CategoriesWithCount = categoriesResult.Data.Categories.Select(c=> new CategoryByCount() 
                    {
                        Category = c,
                        Count = c.ProductCategories.Count()
                    }).ToList()
                   
                });
            }
            return View();
        }
    }
}
