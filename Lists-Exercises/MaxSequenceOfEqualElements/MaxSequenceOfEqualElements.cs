using System;
using System.Collections.Generic;
using System.Linq;

namespace MaxSequenceOfEqualElements
{
    class MaxSequenceOfEqualElements
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split(" ").Select(int.Parse).ToList();
            List<int> resultList = new List<int>();
            List<int> finalList = new List<int>();
            resultList.Add(numbers[0]);

            int len = 1;
            int bestLen = 1;

            for (int i = 0; i < numbers.Count - 1; i++)
            {
                if (numbers[i] == numbers[i + 1])
                {
                    len++;
                    resultList.Add(numbers[i + 1]);
                    
                }
                else
                {
                    len = 1;
                    resultList.Clear();
                    resultList.Add(numbers[i + 1]);
                }
                if (len > bestLen)
                {
                    finalList.Clear();
                    bestLen = len;
                    finalList.AddRange(resultList);
                }

            }
            if (bestLen == 1)
            {
                Console.WriteLine(numbers[0]);
                return;
            }
            Console.WriteLine(string.Join(" ", finalList));
        }
    }
}
