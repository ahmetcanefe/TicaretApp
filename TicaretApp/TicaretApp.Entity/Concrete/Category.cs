using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TicaretApp.Shared.Entities.Abstract;

namespace TicaretApp.Entity.Concrete
{
    public class Category : EntityBase,IEntity
    {
        public string Name { get; set; }
        public string ImageUrl { get; set; }
        public bool IsFeatured { get; set; } = false;
        public ICollection<ProductCategory> ProductCategories { get; set; }
    }
}
