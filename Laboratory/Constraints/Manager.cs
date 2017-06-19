using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constraints
{
    class Manager : Employee
    {
        public override void DoWork()
        {
            Console.WriteLine("create a meeting");
        }
    }
}
