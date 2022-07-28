using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TicaretApp.Data.Abstract;
using TicaretApp.Entity.Concrete;
using TicaretApp.Entity.Dtos;
using TicaretApp.Services.Abstract;
using TicaretApp.Shared.Results.Abstract;
using TicaretApp.Shared.Results.ComplexTypes;
using TicaretApp.Shared.Results.Concrete;

namespace TicaretApp.Services.Concrete
{
    public class CartManager : ICartService
    {
        private readonly IUnitOfWork _unitOfWork;
        public CartManager(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task<IResult> AddToCartAsync(int userId, int productId, int quantity)
        {
            var cart = await _unitOfWork.Carts.GetAsync(predicate: c => c.UserId == userId, include: cart=>cart.Include(c=>c.CartItems).ThenInclude(c=>c.Product));
            if (cart != null)
            {
                var cartItem = cart.CartItems.Where(i => i.ProductId == productId).SingleOrDefault();

                if (cartItem == null)
                {
                    cart.CartItems.Add(new CartItem()
                    {
                        ProductId = productId,
                        Quantity = quantity,
                        CartId = cart.Id
                    });
                }
                else
                {
                    cartItem.Quantity += quantity;
                }
                
                await _unitOfWork.Carts.UpdateAsync(cart);
                var count = await _unitOfWork.SaveAsync();

                if (count > -1)
                {
                    return new Result(ResultStatus.Success, "Başarılı");
                }
            }
            return new Result(ResultStatus.Error, "Hata");
        }

        public async Task<IResult> DeleteFromCart(int userId, int productId)
        {
            var cart = await _unitOfWork.Carts.GetAsync(predicate: c => c.UserId == userId, include: c=>c.Include(c=>c.CartItems));
            if (cart != null)
            {
                var cartItem = cart.CartItems.Where(ci => ci.ProductId == productId).SingleOrDefault();
                cart.CartItems.Remove(cartItem);

                await _unitOfWork.Carts.UpdateAsync(cart);
                var count = await _unitOfWork.SaveAsync();
                if (count > -1)
                {
                    return new Result(ResultStatus.Success, "Başarılı");
                }
            }
            return new Result(ResultStatus.Error, "Hata");
        }

        public async Task<IDataResult<CartDto>> GetCartByUserId(int? userId)
        {
            var result = await _unitOfWork.Carts.AnyAsync(c => c.UserId == userId);
            if (result)
            {
                var cart = await _unitOfWork.Carts.GetAsync(predicate: c => c.UserId == userId, include: c => c.Include(c => c.CartItems).ThenInclude(ci=>ci.Product));
                return new DataResult<CartDto>(ResultStatus.Success, new CartDto
                {
                    Cart = cart
                });
            }
            return new DataResult<CartDto>(ResultStatus.Error, "Hata", null);

           
        }

        public async Task<IResult> InitializeCart(int userId)
        {
            var cart = new Cart()
            {
                UserId = userId
            };
            await _unitOfWork.Carts.AddAsync(cart);
            var count = await _unitOfWork.SaveAsync();

            if (count > -1)
            {
                return new Result(ResultStatus.Success, "Başarılı");
            }
            else
            {
                return new Result(ResultStatus.Error, "Hata");
            }
        }
    }
}
