using Microsoft.EntityFrameworkCore.Query;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using TicaretApp.Shared.Entities.Abstract;

namespace TicaretApp.Shared.Dta.Abstract
{
    public interface IEntityRepository<T> where T:class, IEntity, new ()
    {
        Task<T> GetAsync(Expression<Func<T, bool>> predicate, Func<IQueryable<T>, IIncludableQueryable<T, object>> include = null);
        Task<IList<T>> GetAllAsync(Expression<Func<T, bool>> predicate=null, Func<IQueryable<T>, IIncludableQueryable<T, object>> include = null);
        public IQueryable<T> GetAsQueryable();
        Task<T> AddAsync(T entity);
        Task<T> UpdateAsync(T entity);
        Task DeleteAsync(T entity);
        Task<IList<T>> SearchAsync(IList<Expression<Func<T, bool>>> predicates, params Expression<Func<T, object>>[] includeProperties);
        Task<bool> AnyAsync(Expression<Func<T, bool>> predicate);
        Task<int> CountAsync(Expression<Func<T, bool>> predicate=null);
    }
}
