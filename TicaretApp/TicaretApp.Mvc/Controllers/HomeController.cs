using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TicaretApp.Mvc.Models;
using TicaretApp.Services.Abstract;
using TicaretApp.Shared.Results.ComplexTypes;

namespace TicaretApp.Mvc.Controllers
{
    public class HomeController : Controller
    {
        private readonly IProductService _productService;
        private readonly ICategoryService _categoryService;
        public HomeController(IProductService productService, ICategoryService categoryService)
        {
            _productService = productService;
            _categoryService = categoryService;
        }

        public async Task<IActionResult> Index()
        {
            var topCategories = await _categoryService.GetAllByProductCount();
            var newProducts = await _productService.GetAllByDateAsync();
            var topSellingProducts = await _productService.GetAllByOrderCountAsync();

            var categories = await _categoryService.GetAllByNonDeletedAsync();

            if (topCategories.ResultStatus == ResultStatus.Success &&
                newProducts.ResultStatus == ResultStatus.Success &&
                topSellingProducts.ResultStatus == ResultStatus.Success)
            {
                ViewBag.Categories = categories.Data.Categories;
                return View(new HomePageViewModel() 
                {
                    TopCategories = topCategories.Data,
                    NewProducts = newProducts.Data,
                    TopSellingProducts = topSellingProducts.Data
                });
            }
            return NotFound();
        }
    }
}
