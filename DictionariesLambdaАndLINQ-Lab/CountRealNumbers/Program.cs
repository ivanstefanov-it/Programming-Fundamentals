using System;
using System.Collections.Generic;
using System.Linq;

namespace CountRealNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] numbers = Console.ReadLine().Split().Select(double.Parse).ToArray();
            SortedDictionary<double, int> count = new SortedDictionary<double, int>();

            foreach (var num in numbers)
            {
                if (count.ContainsKey(num) == false)
                {
                    count[num] = 1;
                }
                else
                {
                    count[num]++;
                }
            }
            foreach (var num in count)
            {
                Console.WriteLine($"{num.Key} -> {num.Value}");
            }
        }
    }
}
