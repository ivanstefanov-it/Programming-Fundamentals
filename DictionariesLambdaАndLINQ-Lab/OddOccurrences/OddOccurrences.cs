using System;
using System.Collections.Generic;

namespace OddOccurrences
{
    class OddOccurrences
    {
        static void Main(string[] args)
        {
            string[] words = Console.ReadLine().ToLower().Split(' ');

            Dictionary<string, int> count = new Dictionary<string, int>();

            foreach (var word in words)
            {
                if (count.ContainsKey(word) == false)
                {
                    count[word] = 1;
                }
                else
                {
                    count[word]++;
                }
            }
            List<string> result = new List<string>();

            foreach (var pair in count)
            {
                if (pair.Value % 2 != 0)
                {
                    result.Add(pair.Key);
                }
            }
            Console.WriteLine(string.Join(", ", result));
        }
    }
}
