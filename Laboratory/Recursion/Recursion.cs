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
    }
}
