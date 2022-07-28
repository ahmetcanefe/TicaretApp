using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TicaretApp.Shared.Entities.Abstract;

namespace TicaretApp.Entity.Concrete
{
    public class ProductDetail : IEntity
    {
        public int Id { get; set; }
        public string Color { get; set; }
        public string Size { get; set; }
        public int stock { get; set; }
        public int ProductId { get; set; }
        public Product Product { get; set; }
    }
}
