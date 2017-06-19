using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constraints
{
    /*
     * Covariance 
    */ 
    public interface IReadOnlyRepository<out T> : IDisposable
    {
        T FindById(int id);
        /*
         * I need to do some manipulations with the Dataset, that's why i'm using IQueryable 
        */
        IQueryable<T> FindAll();
    }
}
