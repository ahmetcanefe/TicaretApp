using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TicaretApp.Entity.Dtos;
using TicaretApp.Shared.Results.Abstract;

namespace TicaretApp.Services.Abstract
{
    public interface ICartService
    {
        Task<IDataResult<CartDto>> GetCartByUserId(int? userId);
        Task<IResult> InitializeCart(int userId);
        Task<IResult> AddToCartAsync(int userId, int productId, int quantity);
        Task<IResult> DeleteFromCart(int userId, int productId);
    }
}
