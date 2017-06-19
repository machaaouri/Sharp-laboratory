using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constraints
{
    class Program
    {

        static void Init()
        {
            /*
             * For test purpose Tells Entity Framework that it is okay 
             * to drop and recreate the databse evry time this App runs 
            */
            Database.SetInitializer(new DropCreateDatabaseAlways<EmployeeDbContex>());
        }
        static void Main(string[] args)
        {
        }
    }
}
