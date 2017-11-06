using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleDelegate
{



        /*
         * Behinf the scenes the compiler generates a class Mydelegate that inherits from MutliCastDelegates
        */

        class Program
        {
            static void Main(string[] args)
            {
                MyDelegate del1 = new MyDelegate(WorkPerformed1);
                MyDelegate del2 = new MyDelegate(WorkPerformed2);
                MyDelegate del3 = new MyDelegate(WorkPerformed3);

                del1 += del2 + del3;
                del1(8, WorkType.OrganizeMeting);

                Console.Read();
            }

            static void DoWork(MyDelegate del)
            {
                del(10, WorkType.GenerateReports);
            }
            static void WorkPerformed1(int hours, WorkType workType)
            {
                Console.WriteLine("WorkPerformed1 called, hours = " + hours.ToString());
            }

            static void WorkPerformed2(int hours, WorkType workType)
            {
                Console.WriteLine("WorkPerformed2 called, hours = " + hours.ToString());
            }

            static void WorkPerformed3(int hours, WorkType workType)
            {
                Console.WriteLine("WorkPerformed3 called, hours = " + hours.ToString());
            }
        }

        public enum WorkType
        {
            OrganizeMeting,
            PrintPapers,
            GenerateReports
        }
}
