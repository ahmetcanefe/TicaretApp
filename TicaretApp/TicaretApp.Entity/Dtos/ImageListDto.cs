using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TicaretApp.Entity.Concrete;

namespace TicaretApp.Entity.Dtos
{
    public class ImageListDto
    {
        public IList<Image> Images { get; set; }
    }
}
