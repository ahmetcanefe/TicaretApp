using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TicaretApp.Entity.Concrete;
using TicaretApp.Shared.Dta.Abstract;

namespace TicaretApp.Data.Abstract
{
    public interface IProductRepository : IEntityRepository<Product>
    {
    }
}
