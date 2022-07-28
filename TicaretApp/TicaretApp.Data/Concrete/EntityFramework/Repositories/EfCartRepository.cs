﻿using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TicaretApp.Data.Abstract;
using TicaretApp.Entity.Concrete;
using TicaretApp.Shared.Dta.Abstract;
using TicaretApp.Shared.Dta.Concrete.EntityFramework;

namespace TicaretApp.Data.Concrete.EntityFramework.Repositories
{
    public class EfCartRepository : EfEntityRepositoryBase<Cart>, ICartRepository
    {
        public EfCartRepository(DbContext context) : base(context)
        {

        }
    }
}
