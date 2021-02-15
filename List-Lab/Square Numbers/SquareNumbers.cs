using System;
using System.Collections.Generic;
using System.Linq;

namespace Square_Numbers
{
    class SquareNumbers
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split(" ").Select(int.Parse).ToList();
            List<int> sqareNums = new List<int>();

            foreach (var num in numbers)
            {
                if (Math.Sqrt(num) == (int)Math.Sqrt(num))
                {
                    sqareNums.Add(num);
                }
            }
            sqareNums.Sort((a, b) => b.CompareTo(a));

            Console.WriteLine(string.Join(" ", sqareNums));
        }
    }
}
