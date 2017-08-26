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

        static void getLastKLines(int K)
        {
            String[] files = { "ABC", "CDE", "EFG", "GHI", "IJK", "KLM", "MNO", "OPQ", "QRS", "STX", "XBN", "VCX" };
            string[] last = new string[K];

            int l = 0,index;
            foreach(var line in files)
            {
                index = l % K;
                last[index] = line;
                l++;
            }

            int start, count;
            if(l < K)
            {
                start = 0;
                count = l;
            }
            else
            {
                start = l % K;
                count = K;
            }

            for(int i = 0; i < count;i++)
            {
                index = (start + i) % K;
                Console.WriteLine(last[index]);
            }

        }
        static void Main(string[] args)
        {
            //Merge();
            //SortStrings();
            getLastKLines(5);
            Console.ReadKey();
        }
    }
}
