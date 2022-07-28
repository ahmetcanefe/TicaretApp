using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TicaretApp.Services.Abstract;
using TicaretApp.Shared.Results.ComplexTypes;

namespace TicaretApp.Mvc.ViewComponents
{
    public class NewProductsViewComponent : ViewComponent
    {
        private readonly IProductService _productService;
        private readonly ICategoryService _categoryService;
        public NewProductsViewComponent(IProductService productService, ICategoryService categoryService)
        {
            _productService = productService;
            _categoryService = categoryService;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var newProductsResult = await _productService.GetAllByDateAsync();
            var categoriesResult = await _categoryService.GetAllAsync();

            ViewBag.Categories = categoriesResult.Data.Categories;
            return View(newProductsResult.Data);
        }
    }
}
