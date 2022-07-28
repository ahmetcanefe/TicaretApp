using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TicaretApp.Entity.Dtos;

namespace TicaretApp.Mvc.Models
{
    public class ProductDetailSideBarViewModel
    {
        public string Header { get; set; }
        public ProductListDto ProductListDto { get; set; }
    }
}
