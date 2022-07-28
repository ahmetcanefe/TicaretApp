using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TicaretApp.Data.Abstract;
using TicaretApp.Entity.Concrete;
using TicaretApp.Shared.Dta.Concrete.EntityFramework;

namespace TicaretApp.Data.Concrete.EntityFramework.Repositories
{
    public class EfBrandRepository : EfEntityRepositoryBase<Brand>,IBrandRepository
    {
        public EfBrandRepository(DbContext context) : base(context)
        {

        }
    }
}
