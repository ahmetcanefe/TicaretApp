using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TicaretApp.Entity.Dtos;
using TicaretApp.Shared.Results.Abstract;

namespace TicaretApp.Services.Abstract
{
    public interface ICommentService
    {
        Task<IDataResult<CommentListDto>> GetAllByProductIdAsync(int productId);
        Task<IResult> AddAsync(CommentAddDto commentAddDto);
    }
}
