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


        //print all valid (e.g., properly opened and closed) combinations of n-pairs of parentheses.
        public static void printPar(int open, int close, string str,int pairs)
        {
            if (open == pairs && close == pairs)
            {
                Console.WriteLine(str); // found one, so print it
            }
            else
            {
                if (open < pairs)
                { // try a left paren, if there are some available
                    
                    printPar(open + 1, close, str + "(", pairs);
                }
                if (close < open)
                { // try a right paren, if there’s a matching left
                    printPar(open, close + 1, str + ")", pairs);
                }
            }
        }

        public static void printPar(int pairs)
        {
            printPar(0, 0, "", pairs);
        }
    }
}
