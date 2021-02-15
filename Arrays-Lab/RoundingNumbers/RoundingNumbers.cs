using System;
using System.Linq;

namespace RoundingNumbers
{
    class RoundingNumbers
    {
        static void Main(string[] args)
        {
            double[] numbers = Console.ReadLine().Split(' ').Select(double.Parse).ToArray();

            foreach (var num in numbers)
            {
                double result =  Math.Round(num, MidpointRounding.AwayFromZero);
                Console.WriteLine($"{num} => {result}");
            }
        }
    }
}
