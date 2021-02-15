using System;
using System.Collections.Generic;
using System.Linq;

namespace MinMaxSumAverage
{
    class MinMaxSumAverage
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int input = 0;
            List<int> nums = new List<int>();

            for (int i = 0; i < n; i++)
            {
                input = int.Parse(Console.ReadLine());
                nums.Add(input);
            }
            Console.WriteLine($"Sum = {nums.Sum()}");
            Console.WriteLine($"Min = {nums.Min()}");
            Console.WriteLine($"Max = {nums.Max()}");
            Console.WriteLine($"Average = {nums.Average()}");
        }
    }
}
