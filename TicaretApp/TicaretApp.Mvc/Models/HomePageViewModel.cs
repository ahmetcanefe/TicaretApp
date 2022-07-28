using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TicaretApp.Entity.Dtos;

namespace TicaretApp.Mvc.Models
{
    public class HomePageViewModel
    {
        public CategoryListDto TopCategories { get; set; } 
        public ProductListDto NewProducts { get; set; }
        public ProductListDto TopSellingProducts { get; set; }
    }
}
