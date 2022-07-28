using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TicaretApp.Shared.Results.ComplexTypes;

namespace TicaretApp.Shared.Results.Abstract
{
    public interface IResult
    {
        public ResultStatus ResultStatus { get; }
        public string Message { get;  }
        public Exception Exception { get; }
    }
}
