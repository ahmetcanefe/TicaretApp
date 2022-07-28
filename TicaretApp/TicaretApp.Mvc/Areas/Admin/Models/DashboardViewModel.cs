using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TicaretApp.Entity.Dtos;

namespace TicaretApp.Mvc.Areas.Admin.Models
{
    public class DashboardViewModel
    {
        public ProductListDto ProductListDto { get; set; }
        public int ProductsCount { get; set; }
        public int CategoriesCount { get; set; }
        public int BrandsCount { get; set; }
        public int UsersCount { get; set; }

    }
}
