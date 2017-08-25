using System;
using System.Collections.Generic;

namespace Recursion
{
    class Program
    {
        static int Fibo()
        {
            return Recursion.Fibonacci(25);
        }

        static void Permutations()
        {
            List<string> perms = Recursion.getPerms("ABC");
            Console.WriteLine("{0} permutations",perms.Count);
            foreach(var word in perms)
            {
                Console.WriteLine(word);
            }
        }

        static void printParen()
        {
            Recursion.printPar(3);
        }
        static void Main(string[] args)
        {
            //Console.WriteLine(Fibo());
            //Permutations();
            printParen();
            Console.ReadKey();

        }
    }
}
