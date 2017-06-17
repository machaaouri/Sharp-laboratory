using System;
using System.Collections.Generic;

namespace Generics
{
    class Program
    {
        static void case_1()
        {
            var buffer = new CircularBuffer<double>(5);
            buffer.Write(1);
            buffer.Write(2);
            buffer.Write(3);
            buffer.Write(4);

            foreach (var item in buffer)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("Buffer Count : {0}", buffer.Count);
        }

        /*
         * Comparing
        */ 
        static void case_2()
        {
            var finantialTypes = new SortedDictionary<string, HashSet<Instrument>>();

            finantialTypes.Add("Bonds", new HashSet<Instrument>());
            finantialTypes["Bonds"].Add(new Instrument { Name = "BO12" });
            finantialTypes["Bonds"].Add(new Instrument { Name = "BO52" });
            finantialTypes["Bonds"].Add(new Instrument { Name = "BO92" });

            finantialTypes.Add("Shares", new HashSet<Instrument>());
            finantialTypes["Shares"].Add(new Instrument { Name = "S012" });
            finantialTypes["Shares"].Add(new Instrument { Name = "S052" });
            finantialTypes["Shares"].Add(new Instrument { Name = "S092" });

            

            foreach(var financialType in finantialTypes)
            {
                Console.WriteLine(financialType.Key);
                foreach(var instrument in financialType.Value)
                {
                    Console.WriteLine("\t" + instrument.Name);
                }
            }
            
        }

        static void Main(string[] args)
        {
           // case_1();
            case_2();
            Console.ReadKey();

        }
    }
}
