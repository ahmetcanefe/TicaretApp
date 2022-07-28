using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TicaretApp.Data.Abstract;
using TicaretApp.Entity.Concrete;
using TicaretApp.Entity.Dtos;
using TicaretApp.Services.Abstract;
using TicaretApp.Shared.Results.Abstract;
using TicaretApp.Shared.Results.ComplexTypes;
using TicaretApp.Shared.Results.Concrete;

namespace TicaretApp.Services.Concrete
{
    public class CommentManager : ICommentService
    {
        private readonly IUnitOfWork _unitOfWork;

        public CommentManager(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task<IResult> AddAsync(CommentAddDto commentAddDto)
        {
            var comment = new Comment()
            {
                Name = commentAddDto.Name,
                Email = commentAddDto.Email,
                Review = commentAddDto.Review,
                Rating = commentAddDto.Rating,
                ProductId = commentAddDto.ProductId
            };
            await _unitOfWork.Comments.AddAsync(comment);
            await _unitOfWork.SaveAsync();
            return new Result(ResultStatus.Success, "Başarılı");
        }

        public async Task<IDataResult<CommentListDto>> GetAllByProductIdAsync(int productId)
        {
            var resultProduct = await _unitOfWork.Products.AnyAsync(predicate: p => p.Id == productId);
            if (resultProduct)
            {
                var comments = await _unitOfWork.Comments.GetAllAsync(predicate: c => c.ProductId == productId);
                if (comments.Count() > -1)
                {
                    return new DataResult<CommentListDto>(ResultStatus.Success, new CommentListDto
                    {
                        Comments = comments
                    });
                }
            }
            return new DataResult<CommentListDto>(ResultStatus.Error, "Hata", null);
        }
    }
}
