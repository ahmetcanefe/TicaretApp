using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TicaretApp.Entity.Dtos;
using TicaretApp.Shared.Results.Abstract;

namespace TicaretApp.Services.Abstract
{
    public interface IImageService
    {
        Task<IDataResult<ImageListDto>> GetAllByProductId(int productId);
    }
}
