using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EF_Repository_UnitOfWork
{
    public interface IDatabaseFactory : IDisposable
    {
        DBContext Get();
    }
}
