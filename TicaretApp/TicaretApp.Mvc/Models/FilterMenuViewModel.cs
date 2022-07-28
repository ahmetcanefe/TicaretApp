using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TicaretApp.Entity.Concrete;

namespace TicaretApp.Mvc.Models
{
    public class FilterMenuViewModel
    {
        public List<CategoryByCount> CategoriesWithCount { get; set; }
        public IList<Brand> Brands { get; set; }
    }
    public class CategoryByCount
    {
        public Category Category { get; set; }
        public int Count { get; set; }
    }
}
