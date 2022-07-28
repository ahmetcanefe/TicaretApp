using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TicaretApp.Data.Abstract;
using TicaretApp.Data.Concrete.EntityFramework.Contexts;
using TicaretApp.Data.Concrete.EntityFramework.Repositories;

namespace TicaretApp.Data.Concrete
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly TicaretAppContext _context;
        private EfProductRepository _productRepository;
        private EfCategoryRepository _categoryRepository;
        private EfBrandRepository _brandRepository;
        private EfImageRepository _imageRepository;
        private EfCartRepository _cartRepository;
        private EfCommentRepository _commentRepository;
        
        public UnitOfWork(TicaretAppContext context)
        {
            _context = context;
        }

        public IProductRepository Products => _productRepository ?? new EfProductRepository(_context);

        public ICategoryRepository Categories => _categoryRepository ?? new EfCategoryRepository(_context);
        public IBrandRepository Brands => _brandRepository ?? new EfBrandRepository(_context);
        public IImageRepository Images => _imageRepository ?? new EfImageRepository(_context);
        public ICartRepository Carts => _cartRepository ?? new EfCartRepository(_context);

        public ICommentRepository Comments => _commentRepository ?? new EfCommentRepository(_context);

        public async Task<int> SaveAsync()
        {
            return await _context.SaveChangesAsync();
        }

        public async ValueTask DisposeAsync()
        {
            await _context.DisposeAsync();
        }
    }
}
