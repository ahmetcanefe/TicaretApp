using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TicaretApp.Shared.Entities.Abstract;

namespace TicaretApp.Entity.Concrete
{
    public class Comment : EntityBase, IEntity
    {
        //public override bool IsActive { get; set; } = false;
        public string Name { get; set; }
        public string Email { get; set; }
        public string Review { get; set; }
        public int Rating { get; set; }
        public int ProductId { get; set; }
        public Product Product { get; set; }
    }
}
