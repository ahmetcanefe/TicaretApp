using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TicaretApp.Services.Abstract;
using TicaretApp.Shared.Results.ComplexTypes;

namespace TicaretApp.Mvc.ViewComponents
{
    public class FeaturedMenuViewComponent : ViewComponent
    {
        private readonly IProductService _productService;
        public FeaturedMenuViewComponent(IProductService productService)
        {
            _productService = productService;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var featuredProductsResult = await _productService.GetAllByFeaturedAsync();
         
            return View(featuredProductsResult.Data);
        }

    }
}
