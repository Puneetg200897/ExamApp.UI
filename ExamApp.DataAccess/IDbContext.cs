using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;

namespace ExamApp.DataAccess
{
    public interface IDbContext : IDisposable
    {
        DbSet Set(Type entityType);
        IDbSet<T> Set<T>() where T : class;
        Task<int> SaveChangesAsync();
        DbEntityEntry<T> Entry<T>(T entity) where T : class;
        new void Dispose();
    }
}
