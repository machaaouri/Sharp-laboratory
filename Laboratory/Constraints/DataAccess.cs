using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace Constraints
{
    
    public class EmployeeDbContex : DbContext
    {
        //Describe the type of object that i want to store in database
        public DbSet<Employee> Employees { get; set; }
    }
}
