using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constraints
{
    public interface IRepository<T> : IReadOnlyRepository<T>, IWriteOnlyRepository<T>
    {
        /*
         * IRepository remains invariant ,it will pick up the IDisposable from one of the inherited interfaces
        */
    }
}
