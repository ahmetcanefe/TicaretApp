using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TicaretApp.Shared.Entities.Abstract;

namespace TicaretApp.Entity.Concrete
{
    public class Brand : EntityBase, IEntity
    {
        public string Name { get; set; }
        public ICollection<Product> Products { get; set; }
    }
}
