using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TicaretApp.Data.Abstract;
using TicaretApp.Entity.Dtos;
using TicaretApp.Services.Abstract;
using TicaretApp.Shared.Results.Abstract;
using TicaretApp.Shared.Results.ComplexTypes;
using TicaretApp.Shared.Results.Concrete;

namespace TicaretApp.Services.Concrete
{
    public class ImageManager : IImageService
    {
        public readonly IUnitOfWork _unitOfWork;
        public ImageManager(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        public async Task<IDataResult<ImageListDto>> GetAllByProductId(int productId)
        {
            var images = await _unitOfWork.Images.GetAllAsync(predicate: i => i.ProductId == productId, include: null);
            if (images.Count() > -1)
            {
                return new DataResult<ImageListDto>(ResultStatus.Success, new ImageListDto
                {
                    Images = images
                });
            }
            else
            {
                return new DataResult<ImageListDto>(ResultStatus.Error, "Hata", null);
            }
        }
    }
}
