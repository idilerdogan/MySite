using System.Linq.Expressions;
using MySite.Entities.Entities.Abstract;

namespace MySite.DataAccess.GenericRepos.Abstract
{
    public interface IRepository<T> where T : BaseEntity
    {
        public int Create(T entity);
        public int Update(T entity);
        public int Delete(T entity);

        public T? GetById(int id);
        public T? Get(Expression<Func<T, bool>> predicate);
        public List<T>? GetAll(Expression<Func<T, bool>> predicate = null);

        public IQueryable<T>? GetAllInclude(Expression<Func<T, bool>> predicate = null
            , params Expression<Func<T, object>>[] include);


    }
}
