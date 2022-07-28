using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TicaretApp.Mvc.Areas.Admin.Models
{
    public class BrandUpdateViewModel
    {
        [Required]
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }
        public bool IsActive { get; set; }
    }
}
