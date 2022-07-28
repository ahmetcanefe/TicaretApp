using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TicaretApp.Shared.Results.ComplexTypes;

namespace TicaretApp.Shared.Entities.Abstract
{
    public abstract class DtoGetBase
    {
        public ResultStatus ResultStatus { get; set; }
        public string Message { get; set; }
       
    }
}
