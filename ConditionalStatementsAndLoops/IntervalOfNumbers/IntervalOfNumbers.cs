using System;

namespace IntervalOfNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstNumber = int.Parse(Console.ReadLine());
            int secondNumber = int.Parse(Console.ReadLine());

            int start = Math.Min(firstNumber, secondNumber);
            int stop = Math.Max(firstNumber, secondNumber);

            for (int i = start; i <= stop; i++)
            {
                Console.WriteLine(i);
            }
        }
    }
}
