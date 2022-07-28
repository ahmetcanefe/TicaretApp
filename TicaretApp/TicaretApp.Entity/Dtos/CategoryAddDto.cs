using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicaretApp.Entity.Dtos
{
    public class CategoryAddDto
    {
        [Required]
        public string Name { get; set; }
        public bool IsActive { get; set; }
    }
}
