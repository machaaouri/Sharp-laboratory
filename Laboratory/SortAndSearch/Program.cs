using System;

namespace SortAndSearch
{
    class Program
    {
        static void Merge()
        {
            int[] A = { 10, 21, 33, 35, 40, 0, 0, 0, 0, 0 };
            int[] B = { 32, 34, 36, 41 };
            SortAndSearch.merge(A, 5, B);
        }

        static void SortStrings()
        {
            string[] words = { "ZEF","ABC", "ABD", "ABE", "ACB", "BCD" };
            SortAndSearch.SortAnagrams(words);
            foreach(var w in words )
            {
                Console.WriteLine(w);
            }
        }
        static void Main(string[] args)
        {
            //Merge();
            SortStrings();
            Console.ReadKey();
        }
    }
}
