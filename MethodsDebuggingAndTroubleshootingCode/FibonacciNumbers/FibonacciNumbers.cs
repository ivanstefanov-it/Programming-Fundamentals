using System;

namespace FibonacciNumbers
{
    class FibonacciNumbers
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            if (n == 0)
            {
                Console.WriteLine(1);
            }
            else
            {
                Console.WriteLine(Fibonacci(n));
            }


        }
        private static int Fibonacci(int n)
        {
            int f1 = 0;
            int f2 = 1;
            int fNext = 0;
            for (int i = 1; i <= n; i++)
            {
                fNext = f1 + f2;
                f1 = f2;
                f2 = fNext;
            }
            return fNext;
        }
    }
    
}
