using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicaretApp.Data.Abstract
{
    public interface IUnitOfWork : IAsyncDisposable
    {
        IProductRepository Products { get; }
        ICategoryRepository Categories { get; }
        IBrandRepository Brands { get; }
        IImageRepository Images { get; }
        ICartRepository Carts { get; }
        ICommentRepository Comments { get; }
        Task<int> SaveAsync();
    }
}
