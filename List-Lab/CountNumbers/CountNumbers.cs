using System;
using System.Collections.Generic;
using System.Linq;

namespace CountNumbers
{
    class CountNumbers
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split(" ").Select(int.Parse).ToList();
            numbers.Sort();

            int previousElement = numbers[0];
            int counter = 1;
            for (int i = 1; i < numbers.Count; i++)
            {
                if (previousElement == numbers[i])
                {
                    counter++;
                }

                else
                {
                    Console.WriteLine("{0} -> {1}", previousElement, counter);
                    previousElement = numbers[i];
                    counter = 1;
                }
            }
            Console.WriteLine("{0} -> {1}", previousElement, counter);
        }
    }
}
