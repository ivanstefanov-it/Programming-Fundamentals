using System;
using System.Linq;

namespace ShortWordsSorted
{
    class ShortWordsSorted
    {
        static void Main(string[] args)
        {
            string[] words = Console
                .ReadLine()
                .ToLower()
                .Split(".,:;()[]\"'\\/!? ".ToCharArray(), StringSplitOptions.RemoveEmptyEntries);
            Console.WriteLine(string.Join(", ", words.OrderBy(x => x).Where(x => x.Length < 5).Distinct()));
        }
    }
}
