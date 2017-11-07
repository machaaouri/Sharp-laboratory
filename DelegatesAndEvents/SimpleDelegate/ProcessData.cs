using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleDelegate
{
    public class ProcessData
    {
        public void Process(int x, int y, BusinessRulesDelegate del)
        {
            var result = del(x, y);
            Console.WriteLine(result);
        }
    }
}
