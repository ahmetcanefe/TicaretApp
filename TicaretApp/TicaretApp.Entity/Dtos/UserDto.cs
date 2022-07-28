using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TicaretApp.Entity.Concrete;
using TicaretApp.Shared.Entities.Abstract;

namespace TicaretApp.Entity.Dtos
{
    public class UserDto:DtoGetBase
    {
        public User User { get; set; }
    }
}
