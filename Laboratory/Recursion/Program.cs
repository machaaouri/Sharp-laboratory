using System;

namespace Recursion
{
    class Program
    {
        static int Fibo()
        {
            return Recursion.Fibonacci(25);
        }
        static void Main(string[] args)
        {
            Console.WriteLine(Fibo());
            Console.ReadKey();
        }
    }
}
