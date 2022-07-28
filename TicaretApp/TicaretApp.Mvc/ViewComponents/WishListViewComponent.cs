using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TicaretApp.Services.Abstract;

namespace TicaretApp.Mvc.ViewComponents
{
    public class WishListViewComponent : ViewComponent
    {
        private readonly IProductService _productService;
        public WishListViewComponent(IProductService productService)
        {
            _productService = productService;
        } 
        public async Task<IViewComponentResult> InvokeAsync()
        {
            var productsResult = await _productService.GetAllByWishAsync();
            return View(productsResult);
        }
    }
}
