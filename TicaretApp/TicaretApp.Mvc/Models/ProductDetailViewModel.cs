using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TicaretApp.Entity.Concrete;
using TicaretApp.Entity.Dtos;

namespace TicaretApp.Mvc.Models
{
    public class ProductDetailViewModel
    {
        public ProductDto ProductDto { get; set; }
        public ProductDetailSideBarViewModel ProductDetailSideBarViewModel { get; set; }
    }
}
