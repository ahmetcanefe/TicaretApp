using Microsoft.EntityFrameworkCore;
using TicaretApp.Data.Abstract;
using TicaretApp.Entity.Concrete;
using TicaretApp.Shared.Dta.Concrete.EntityFramework;

namespace TicaretApp.Data.Concrete.EntityFramework.Repositories
{
    public class EfCommentRepository : EfEntityRepositoryBase<Comment>, ICommentRepository
    {
        public EfCommentRepository(DbContext context) : base(context)
        {

        }
    }
}
