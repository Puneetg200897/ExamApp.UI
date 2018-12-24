using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using System.Data;
using System.Linq.Expressions;
namespace ExamApp.DataAccess
{
    public class RepositoryBase<T> : IRepository<T> where T : class
    {
        private readonly IDbContext _context;
        private IDbSet<T> _entities;

        public RepositoryBase(IDbContext context)
        {
            this._context = context;
            _entities = _context.Set<T>();
        }

        public IEnumerable<T> List()
        {
            return _entities.ToList();
        }
     
        public IQueryable<T> FindBy(Expression<Func<T, bool>> predicate)
        {
            IQueryable<T> query = _context.Set<T>().Where(predicate);
            return query;
        }

        public void Add(T entity)
        {
            _entities.Add(entity);
        }

        public void Delete(Object entity)
        {
            T existing = _entities.Find(entity);
            _entities.Remove(existing);
        }

        public T FindById(int Obj)
        {
           return _entities.Find(Obj);
        }                

        public void Update(T entity)
        {
            _entities.Attach(entity);
            _context.Entry(entity).State = EntityState.Modified;
        }
        
        
    }
}
