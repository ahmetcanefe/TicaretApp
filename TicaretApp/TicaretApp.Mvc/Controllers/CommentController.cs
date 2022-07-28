using Microsoft.AspNetCore.Mvc;
using NToastNotify;
using System.Threading.Tasks;
using TicaretApp.Entity.Dtos;
using TicaretApp.Services.Abstract;
using TicaretApp.Shared.Results.ComplexTypes;

namespace TicaretApp.Mvc.Controllers
{
    public class CommentController : Controller
    {
        private readonly ICommentService _commentService;
        private readonly IToastNotification _toastNotification;
        public CommentController(ICommentService commentService, IToastNotification toastNotification)
        {
            _commentService = commentService;
            _toastNotification = toastNotification;
        }
        public IActionResult Index()
        {
            
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Add(CommentAddDto commentAddDto)
        {
            if (ModelState.IsValid)
            {
                var result = await _commentService.AddAsync(commentAddDto);
                if (result.ResultStatus == ResultStatus.Success)
                {
                    _toastNotification.AddSuccessToastMessage(result.Message, new ToastrOptions
                    {
                        Title = "Başarılı İşlem"
                    });
                    return Redirect(commentAddDto.Url);
                }
                else
                {
                    _toastNotification.AddErrorToastMessage(result.Message, new ToastrOptions
                    {
                        Title = "Başarısız İşlem"
                    });
                    return Redirect(commentAddDto.Url);
                }
            }
            return Redirect(commentAddDto.Url);
        }
    }
}
