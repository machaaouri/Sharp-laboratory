using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleDelegate
{
        public delegate int BusinessRulesDelegate(int x, int y);


        class Program
        {
            static void Main(string[] args)
            {
                var data = new ProcessData();
                BusinessRulesDelegate addDel = (x, y) => x + y;
                BusinessRulesDelegate multiplyDel = (x, y) => x * y;
                data.Process(5, 3, multiplyDel);


                Func<int, int, int> funcAddDel = (x, y) => x + y;
                Func<int, int, int> funcMultipDel = (x, y) => x * y;
                data.ProcessFunc(10, 20, funcMultipDel);




                Action<int, int> myAction = (x, y) => Console.WriteLine(x + y);
                data.ProcessAction(4, 2, myAction);



                var worker = new Worker();
                worker.WorkPerformed += Worker_WorkPerformed;

                worker.WorkStarted += (s, e) =>
                {
                    Console.WriteLine("Word started !");
                    Console.WriteLine("Hours " + e.Hours + ", workType: " + e.WorkType);
                };

                worker.WorkCompleted += delegate(object sender, EventArgs e)
                {
                    Console.WriteLine("Work completed !"); // use an Anonymous Method
                };
                worker.Dowork(9,WorkType.PrintPapers);

                Console.Read();
            }

            //private static void Worker_Workstarted(object sender, EventArgs e)
            //{
            //    Console.WriteLine("Work started !");
            //}

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
