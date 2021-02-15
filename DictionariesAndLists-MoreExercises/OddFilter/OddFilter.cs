using System;
using System.Collections.Generic;
using System.Linq;

namespace OddFilter
{
    class OddFilter
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine()
                 .Split(' ')
                 .Select(int.Parse)
                 .Where(x => x % 2 == 0)
                 .ToList();
            var averageNum = numbers.Average();
            numbers = numbers.Select(x => x = x > averageNum ? ++x : --x)
                .ToList();
            Console.WriteLine(string.Join(" ", numbers));
        }
    }
}
