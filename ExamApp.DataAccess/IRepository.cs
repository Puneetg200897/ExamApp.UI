using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace ExamApp.DataAccess{
   
    public interface IRepository<T> where T : class
    {
        IEnumerable<T> List();

        IQueryable<T> FindBy(Expression<Func<T, bool>> predicate);
        void Add(T entity);

        void Update(T entity);
        void Delete(Object entity);
        void Delete(T entity);

        T FindById(object Obj);

    }
}
