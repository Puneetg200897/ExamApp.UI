using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamApp.DataAccess
{
   
    public interface IRepository<T> where T : class
    {
        IEnumerable<T> List();

        IEnumerable<T> List(int id);
        void Add(T entity);
        void Delete(Object entity);
        void Update(T entity);
        T FindById(T Obj);

    }
}
