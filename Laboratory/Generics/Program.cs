using System;

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
         * IEQualityComparer
        */ 
        static void case_2()
        {
            var finantialTypes = new InstrumentCollection();

            // use the Oject InstrumentComparer to Compare the instruments

            finantialTypes.Add("Bonds", new Instrument { Name = "BO12" })
                          .Add("Bonds", new Instrument { Name = "BO12" })
                          .Add("Bonds", new Instrument { Name = "BO52" })
                          .Add("Bonds", new Instrument { Name = "BO92" });

            finantialTypes.Add("Shares", new Instrument { Name = "S012" })
                          .Add("Shares", new Instrument { Name = "S012" })
                          .Add("Shares", new Instrument { Name = "S092" });

            

            foreach(var financialType in finantialTypes)
            {
                Console.WriteLine(financialType.Key);
                foreach(var instrument in financialType.Value)
                {
                    Console.WriteLine("\t" + instrument.Name);
                }
            }
            
        }

        /*
         * Sorted Generics and IComparer
         */ 
        static void case_3()
        {
            var finantialTypes = new InstrumentCollectionSorted();

            // use the Oject InstrumentComparer to Compare the instruments

            finantialTypes.Add("Bonds", new Instrument { Name = "BO12" })
                          .Add("Bonds", new Instrument { Name = "BO12" })
                          .Add("Bonds", new Instrument { Name = "BO52" })
                          .Add("Bonds", new Instrument { Name = "BO92" });

            finantialTypes.Add("Shares", new Instrument { Name = "S012" })
                           .Add("Shares", new Instrument { Name = "S012" })
                           .Add("Shares", new Instrument { Name = "S012" })
                           .Add("Shares", new Instrument { Name = "S092" });



            foreach (var financialType in finantialTypes)
            {
                Console.WriteLine(financialType.Key);
                foreach (var instrument in financialType.Value)
                {
                    Console.WriteLine("\t" + instrument.Name);
                }
            }
        }

        static void Main(string[] args)
        {
           // case_1();
            case_2();
            case_3();
            Console.ReadKey();

        }
    }
}
