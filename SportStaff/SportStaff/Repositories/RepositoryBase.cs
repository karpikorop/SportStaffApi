using SportStaff.Data;
using System.Linq.Expressions;
using Microsoft.EntityFrameworkCore;

namespace SportStaff.Repositories
{
    public abstract class RepositoryBase<T> : IRepositoryBase<T> where T : class
    {
        public DataContext DataContext { get; set; }
        public RepositoryBase(DataContext dataContext) { DataContext = dataContext; }

        public void Create(T entity)
        {
            DataContext.Set<T>().Add(entity);
            DataContext.SaveChanges();
        }
        public void Update(T entity)
        {
            DataContext.Set<T>().Update(entity);
            DataContext.SaveChanges();
        }
        public void Delete(T entity)
        {
            DataContext.Set<T>().Remove(entity);
            DataContext.SaveChanges();
        }
        public IQueryable<T> Get(Expression<Func<T, bool>> expression)
        {
            return DataContext.Set<T>().Where(expression).AsNoTracking();
        }
        public IQueryable<T> GetAll()
        {
            return DataContext.Set<T>().AsNoTracking();
        }
    }
}
