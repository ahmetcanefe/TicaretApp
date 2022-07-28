using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TicaretApp.Shared.Entities.Abstract;

namespace TicaretApp.Entity.Concrete
{
    public class CartItem : EntityBase, IEntity
    {
        public int ProductId { get; set; }
        public Product Product { get; set; }
        public int Quantity { get; set; }
        public int CartId { get; set; }
        public Cart Cart { get; set; }
        
    }
}
