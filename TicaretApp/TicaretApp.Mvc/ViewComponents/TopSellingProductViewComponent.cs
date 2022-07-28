using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TicaretApp.Services.Abstract;

namespace TicaretApp.Mvc.ViewComponents
{
    public class TopSellingProductViewComponent : ViewComponent
    {
        private readonly IProductService _productService;
        private readonly ICategoryService _categoryService;
        public TopSellingProductViewComponent(IProductService productService, ICategoryService categoryService)
        {
            _productService = productService;
            _categoryService = categoryService;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var topProductsResult = await _productService.GetAllByOrderCountAsync();
            var categoriesResult = await _categoryService.GetAllAsync();

            ViewBag.Categories = categoriesResult.Data.Categories;
            return View(topProductsResult.Data);
        }

        
    }
}
