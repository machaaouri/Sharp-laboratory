using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constraints
{
    public interface IRepository<T> : IDisposable
    {
        void Add(T newEntity);
        void Delete(T entity);
        T FindById(int id);
        /*
         * I need to do some manipulations with the Dataset, that's why i'm using IQueryable 
        */
        IQueryable<T> FindAll();
        int Commit();
    }
}
