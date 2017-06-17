using System;

namespace Generics
{
    class Program
    {


        static void Main(string[] args)
        {
            var buffer = new CircularBuffer<double>(3);
            buffer.Write(1);
            buffer.Write(2);
            buffer.Write(3);
            buffer.Write(4);

            Console.WriteLine("Buffer Count : {0}", buffer.Count);
            Console.ReadKey();

        }
    }
}
