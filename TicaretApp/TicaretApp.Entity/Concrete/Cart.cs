using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TicaretApp.Shared.Entities.Abstract;

namespace TicaretApp.Entity.Concrete
{
    public class Cart : EntityBase, IEntity
    {
        public int UserId { get; set; }
        public ICollection<CartItem> CartItems { get; set; }
    }
}
