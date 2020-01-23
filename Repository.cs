using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EF_Repository_UnitOfWork
{
    public class Repository
    {
        public IUnitOfWork RepoUnitOfWork;
        public Repository(DatabaseFactory db)
        {
            this.RepoUnitOfWork = new UnitOfWork(db);
        }
    }
}
