using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamApp.DataAccess
{
   public class UnitOfWork
    {
        private IDbContext _dbContext;
        public UnitOfWork(IDbContext dbContext)
        {
            this._dbContext = dbContext;
        }

        public void SaveChanges()
        {
            _dbContext.SaveChangesAsync();
        }
    }
}
