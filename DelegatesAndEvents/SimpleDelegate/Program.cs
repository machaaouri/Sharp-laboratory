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

                worker.WorkPerformed += worker_workPerformed;
                worker.WorkCompleted += woker_workCompleted;
                worker.Dowork(9,WorkType.PrintPapers);

                Console.Read();
            }

            static void woker_workCompleted(object sender, EventArgs e)
            {
                Console.WriteLine("Work completed !");
            }

            static void worker_workPerformed(object sender, WorkPerformedEventArgs e)
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
