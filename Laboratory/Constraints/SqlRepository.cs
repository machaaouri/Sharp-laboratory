using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constraints
{
    /* DataSet only works with an Object reference
     * if you want to use value types (int , double...) 
     * use struct but the compiler will not be happy.. becuase of DBset 
    */
    public class SqlRepository<T> : IRepository<T> where T : class,IEntity  
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
            // before adding an Entity to database we want it to pass some validation rules
            if (newEntity.IsValid())
            {
                _set.Add(newEntity);
            }
        }

        public void Delete(T entity)
        {
            _set.Remove(entity);
        }

        public T FindById(int id)
        {
            return _set.Find(id);
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
