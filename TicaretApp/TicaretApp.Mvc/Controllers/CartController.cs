using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TicaretApp.Entity.Concrete;
using TicaretApp.Services.Abstract;
using TicaretApp.Shared.Results.ComplexTypes;

namespace TicaretApp.Mvc.Controllers
{
    public class CartController : Controller
    {
        private readonly ICartService _cartService;
        private readonly UserManager<User> _userManager;
        private readonly IProductService _productService;
        public CartController(ICartService cartService, UserManager<User> userManager, IProductService productService)
        {
            _cartService = cartService;
            _userManager = userManager;
            _productService = productService;
        }

        [Authorize]
        public async Task<IActionResult> Checkout()
        {
            var cartResult = await _cartService.GetCartByUserId(_userManager.GetUserAsync(HttpContext.User).Result.Id);
            if (cartResult.ResultStatus == ResultStatus.Success)
            {
                return View(cartResult.Data.Cart);
            }
            else
            {
                return View();
            }
        }

        [Authorize]
        [HttpGet]
        public async Task<IActionResult> AddToCart()
        {
            return RedirectToAction("Checkout");
        }

        [Authorize]
        [HttpPost]
        public async Task<IActionResult> AddToCart(int productId, int quantity)
        {
            var cartResult = await _cartService.AddToCartAsync(_userManager.GetUserAsync(HttpContext.User).Result.Id,productId,quantity);
            var productUpdateResult = await _productService.GetProductUpdateDto(productId);
            if (productUpdateResult.Data.HotDeal == true)
            {
                productUpdateResult.Data.HotDeal = false;
                await _productService.UpdateAsync(productUpdateResult.Data);
            }

            return RedirectToAction("Checkout");  
        }

        [Authorize]
        [HttpPost]
        public async Task<IActionResult> DeleteFromCart(int productId)
        {
            var result = await _cartService.DeleteFromCart(_userManager.GetUserAsync(HttpContext.User).Result.Id, productId);
            if (result.ResultStatus == ResultStatus.Success)
            {
                return RedirectToAction("Checkout");
            }
            return RedirectToAction("Checkout");
        }
    }
}
