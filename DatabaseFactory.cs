using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EF_Repository_UnitOfWork
{
    public class DatabaseFactory : Disposable, IDatabaseFactory
    {
        private DBContext dataContext;
        public DBContext Get()
        {
            return dataContext ?? (dataContext = new DBContext());
        }
        protected override void DisposeCore()
        {
            if (dataContext != null)
                dataContext.Dispose();
        }
    }
}
