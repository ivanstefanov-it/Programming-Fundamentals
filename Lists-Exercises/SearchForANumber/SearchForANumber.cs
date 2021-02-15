using System;
using System.Collections.Generic;
using System.Linq;

namespace SearchForANumber
{
    class SearchForANumber
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split(" ").Select(int.Parse).ToList();
            int[] arrForManipulation = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
            List<int> result = new List<int>();

            for (int i = 0; i < arrForManipulation[0]; i++)
            {
                result.Add(numbers[i]);
            }
            for (int i = 0; i < arrForManipulation[1]; i++)
            {
                result.RemoveAt(0);
            }
            if (result.Contains(arrForManipulation[2]))
            {
                Console.WriteLine("YES!");
            }
            else
            {
                Console.WriteLine("NO!");
            }
        }
    }
}
