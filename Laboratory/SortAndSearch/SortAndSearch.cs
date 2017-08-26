using System;
using System.Collections.Generic;

namespace SortAndSearch
{
    public class SortAndSearch
    {

        // Given 2 arrays sorted , write method to merge B into A in sorted order.
        public static void merge(int[] A,int M,int[] B)
        {
            int k = M + B.Length - 1;
            int i = M - 1; // last element of A
            int j = B.Length - 1; // last element of B

            while(i>= 0  && j >= 0)
            {
                if(A[i] > B[j])
                {
                    A[k--] = A[i--];
                }
                else
                {
                    A[k--] = B[j--];
                }
            }
            while(j>=0)
            {
                A[k--] = B[j--];
            }
        }

        //sort an array of strings so that all the anagrams are next to each other.
        public class MyComparator : IComparer<String>
        {
            public String SortString(String s)
            {
                char[] c = s.ToCharArray();
                Array.Sort(c);
                return new string(c);
            }
            public int Compare(string x, string y)
            {
                return SortString(x).CompareTo(SortString(y));
            }
        }

        public static void SortAnagrams(string[] s)
        {
            Array.Sort(s, new MyComparator());
        }

        //Given a matrix in which each row and each column is sorted, write a method to find an element in it
        /*
         * |1 |5 |7 |9 |
         * |2 |8 |10|11|
         * |4 |9 |12|15|
         * |10|17|20|25|
         *
        */ 

        static bool findElem(int[][] A, int elem,int rowLen ,int colLen)
        {
            int row = 0;
            int col = colLen - 1;

            while(row < rowLen || col >= 0)
            {
                if(A[row][col] == elem)
                {
                    return true;
                }
                else
                {
                    if (A[row][col] > elem) col--;
                    else row++;
                }
            }

            return false;
        }

    }
}
