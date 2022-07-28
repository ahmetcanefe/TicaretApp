using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TicaretApp.Entity.Dtos;

namespace TicaretApp.Mvc.Models
{
    public class HomeProductViewModel
    {
        public CategoryListDto TopCategories { get; set; }
        public ProductListDto NewProducts { get; set; }
    }
}
