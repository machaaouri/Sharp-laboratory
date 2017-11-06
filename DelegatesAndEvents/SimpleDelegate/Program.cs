using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleDelegate
{

        class Program
        {
            static void Main(string[] args)
            {
                var worker = new Worker();

                worker.WorkPerformed += Worker_WorkPerformed;
                worker.WorkCompleted += delegate(object sender, EventArgs e)
                {
                    Console.WriteLine("Work completed !"); // use an Anonymous Method
                };
                worker.Dowork(9,WorkType.PrintPapers);

                Console.Read();
            }

            //static void Worker_WorkCompleted(object sender, EventArgs e)
            //{
            //    Console.WriteLine("Work completed !");
            //}

            static void Worker_WorkPerformed(object sender, WorkPerformedEventArgs e)
            {
                Console.WriteLine("Hours worked: " + e.Hours + " " + e.WorkType);
            }

        }

        public enum WorkType
        {
            OrganizeMeting,
            PrintPapers,
            GenerateReports
        }
}
