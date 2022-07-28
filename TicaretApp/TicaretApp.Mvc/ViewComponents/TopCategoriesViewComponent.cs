using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TicaretApp.Services.Abstract;
using TicaretApp.Shared.Results.ComplexTypes;

namespace TicaretApp.Mvc.ViewComponents
{
    public class TopCategoriesViewComponent: ViewComponent
    {
        private readonly ICategoryService _categoryService;
        public TopCategoriesViewComponent(ICategoryService categoryService)
        {
            _categoryService = categoryService;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var topCategoriesResult = await _categoryService.GetAllByProductCount();
            if (topCategoriesResult.ResultStatus == ResultStatus.Success)
            {
                return View(topCategoriesResult);
            }
            return Content("Hata");
        }
    }
}
