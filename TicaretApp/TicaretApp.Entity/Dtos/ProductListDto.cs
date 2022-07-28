using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TicaretApp.Entity.Concrete;
using TicaretApp.Shared.Entities.Abstract;

namespace TicaretApp.Entity.Dtos
{
    public class ProductListDto : DtoGetBase
    {
        public IList<Product> Products { get; set; }
        public int? CategoryId { get; set; }
        public int[] CategoryIds { get; set; }
        public int[] BrandIds { get; set; }
        public int? priceMin { get; set; }
        public int? priceMax { get; set; } 
        public int? orderBy { get; set; }
        public int CurrentPage { get; set; } = 1;
        public int PageSize { get; set; } = 20;
        public int TotalCount { get; set; }
        public int TotalPages => (int)Math.Ceiling(decimal.Divide(TotalCount, PageSize));
        public bool ShowPrevious => CurrentPage > 1;
        public bool ShowNext => CurrentPage < TotalPages;
    }
}
