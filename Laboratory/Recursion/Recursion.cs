using System;
using System.Collections.Generic;

namespace Recursion
{
    public class Recursion
    {
        //enerate the nth fibonacci number
        public static int Fibonacci(int n)
        {
            if (n == 0) return 0;
            else if (n == 1) return 1;
            else if (n > 1) return Fibonacci(n - 1) + Fibonacci(n - 2);
            else return -1;
        }

        //method to compute all permutations of a string
        public static List<string> getPerms(string str)
        {
            List<string> perms = new List<string>();
            if (str == null) return null;
            else if(str.Length == 0)
            {
                perms.Add("");
                return perms;
            }

            char c = str[0];
            string remainder = str.Substring(1); // remove first char
            List<string> words = getPerms(remainder);

            foreach(var word in words)
            {
                for (int j = 0; j <= word.Length; j++)
                {
                    perms.Add(insertCharAt(word, c, j));
                }
            }

            return perms;

        }

        private static string insertCharAt(string word, object first, int j)
        {
            String start = word.Substring(0, j);
            String end = word.Substring(j);
            return start + first + end;
        }
    }
}
