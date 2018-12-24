using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using System.Data;
namespace ExamApp.DataAccess
{
    public class RepositoryBase<T> : IRepository<T> where T : class
    {
        private readonly IDbContext _context;
        private IDbSet<T> _entities;

        public RepositoryBase(IDbContext context)
        {
            this._context = context;
        }

        public IEnumerable<T> List()
        {
            return _entities.ToList();
        }
        public IEnumerable<T> List(int Obj)
        {
            return _entities.ToList();
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

        public T FindById(int Id)
        {
           return _entities.Find(Id);
        }                

        public void Update(T entity)
        {
            _entities.Attach(entity);
            _context.Entry(entity).State = EntityState.Modified;
        }
        
        public T FindById(T Obj)
        {
            throw new NotImplementedException();
        }
    }
}
