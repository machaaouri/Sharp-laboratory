using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constraints
{
    public class SqlRepository<T> : IRepository<T> where T: class  /* DataSet only works with an Object reference */
    {
        /*
         * IoC
        */
        DbContext _ctx;
        DbSet<T> _set;

        public SqlRepository(DbContext ctx)
        {
            _ctx = ctx;
            _set = _ctx.Set<T>();
        }


        public void Add(T newEntity)
        {
            _set.Add(newEntity);
        }

        public void Delete(T entity)
        {
            throw new NotImplementedException();
        }

        public T FindById(int id)
        {
            throw new NotImplementedException();
        }

        public IQueryable<T> FindAll()
        {
            return _set;
        }

        public int Commit()
        {
            return _ctx.SaveChanges(); // Returns the number of records that were affected
        }

        public void Dispose()
        {
            _ctx.Dispose();
        }
    }
}
