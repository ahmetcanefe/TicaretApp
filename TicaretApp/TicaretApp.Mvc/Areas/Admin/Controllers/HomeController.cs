using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TicaretApp.Entity.Concrete;
using TicaretApp.Mvc.Areas.Admin.Models;
using TicaretApp.Services.Abstract;
using TicaretApp.Shared.Results.ComplexTypes;

namespace TicaretApp.Mvc.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class HomeController : Controller
    {
        private readonly IProductService _productService;
        private readonly ICategoryService _categoryService;
        private readonly IBrandService _brandService;
        private readonly UserManager<User> _userManager;
        public HomeController(IProductService productService, ICategoryService categoryService, IBrandService brandService, UserManager<User> userManager)
        {
            _productService = productService;
            _categoryService = categoryService;
            _brandService = brandService;
            _userManager = userManager;
        }

        [Authorize]
        [HttpGet]
        public async Task<IActionResult> Index()
        {
            var productsResult = await _productService.GetAllAsync();
            var productsCountResult = await _productService.CountByNonDeletedAsync();
            var categoriesCountResult = await _categoryService.CountByNonDeleted();
            var brandsCountResult = await _brandService.CountByNonDeleted();
            var usersCount = _userManager.Users.Count();

            if(productsResult.ResultStatus==ResultStatus.Success 
               && productsCountResult.ResultStatus == ResultStatus.Success
               && categoriesCountResult.ResultStatus == ResultStatus.Success
               && brandsCountResult.ResultStatus == ResultStatus.Success
               && usersCount > -1)
            {
                return View(new DashboardViewModel
                {
                    ProductListDto = productsResult.Data,
                    ProductsCount = productsCountResult.Data,
                    CategoriesCount = categoriesCountResult.Data,
                    BrandsCount = brandsCountResult.Data,
                    UsersCount = usersCount
                });
            }
            else
            {
                return NotFound();
            }
            
        }
    }
}
