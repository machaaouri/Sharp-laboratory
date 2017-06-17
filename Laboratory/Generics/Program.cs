using System;

namespace Generics
{
    class Program
    {


        static void Main(string[] args)
        {
            var buffer = new CircularBuffer<double>(5);
            buffer.Write(1);
            buffer.Write(2);
            buffer.Write(3);
            buffer.Write(4);

            foreach(var item in buffer)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("Buffer Count : {0}", buffer.Count);
            Console.ReadKey();

        }
    }
}
