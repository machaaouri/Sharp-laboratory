using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegatesAndEvents
{

    //OneWay delegate
    public delegate void MyDelegate(int hours, WorkType workType);

    /*
     * Behinf the scenes the compiler generates a class Mydelegate that inherits from MutliCastDelegates
    */

    class Program
    {
        static void Main(string[] args)
        {
            MyDelegate del1 = new MyDelegate(WorkPerformed1);
            MyDelegate del2 = new MyDelegate(WorkPerformed2);

            DoWork(del2);

            Console.Read();
        }

        static void DoWork(MyDelegate del)
        {
            del(10, WorkType.GenerateReports);
        }
        static void WorkPerformed1(int hours,WorkType workType)
        {
            Console.WriteLine("WorkPerformed1 called, hours = " + hours.ToString());
        }

        static void WorkPerformed2(int hours, WorkType workType)
        {
            Console.WriteLine("WorkPerformed2 called, hours = " + hours.ToString());
        }
    }

    public enum WorkType
    {
        OrganizeMeting,
        PrintPapers,
        GenerateReports
    }
}
