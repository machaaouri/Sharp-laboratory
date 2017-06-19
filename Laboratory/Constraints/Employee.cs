using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constraints
{
    public class Employee : Person
    {
        public int Id { get; set; }
        public virtual void DoWork()
        {
            Console.Write("Doing real work");
        }
    }
}
