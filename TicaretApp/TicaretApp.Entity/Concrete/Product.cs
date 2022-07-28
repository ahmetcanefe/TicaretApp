using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TicaretApp.Shared.Entities.Abstract;

namespace TicaretApp.Entity.Concrete
{
    public class Product : EntityBase,IEntity
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public double OldPrice { get; set; }
        public double? Discount { get; set; }
        public double Price => (double)(OldPrice - (OldPrice * Discount / 100));
        public string ImageUrl { get; set; }
        public bool HotDeal { get; set; } = false;
        public int ViewCount { get; set; }
        public int CommentCount { get; set; }
        public int OrderCount { get; set; }
        public int BrandId { get; set; }
        public Brand Brand { get; set; } 
        public ICollection<Image> Images { get; set; }
        public ICollection<ProductCategory> ProductCategories { get; set; }
        public ICollection<ProductDetail> ProductDetails { get; set; }
        public ICollection<Comment> Comments { get; set; }
    }
}
