using System;
using System.Collections.Generic;
using System.Linq;

namespace SortTimes
{
    class SortTimes
    {
        static void Main(string[] args)
        {
            List<string> dates = Console.ReadLine().Split().OrderBy(x => x).ToList();
            Console.WriteLine(string.Join(", ", dates));
        }
    }
}
