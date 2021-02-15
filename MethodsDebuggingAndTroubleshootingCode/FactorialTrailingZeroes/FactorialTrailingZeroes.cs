using System;
using System.Numerics;


namespace FactorialTrailingZeroes
{
    class FactorialTrailingZeroes
    {
        static void Main(string[] args)
        {
            BigInteger n = BigInteger.Parse(Console.ReadLine());
            BigInteger fact = GetFactorial(n);
            Console.WriteLine(GetTrailingZeroes(fact));
        }

        static BigInteger GetFactorial(BigInteger n)
        {
            BigInteger fact = 1;

            for (int i = 1; i <= n; i++)
            {
                fact *= i;
            }

            return fact;
        }

        static BigInteger GetTrailingZeroes(BigInteger num)
        {

            BigInteger counter = 0;
            while (num % 10 == 0)
            {
                num = num / 10;
                counter++;
            }
            return counter;
        }

    }
}