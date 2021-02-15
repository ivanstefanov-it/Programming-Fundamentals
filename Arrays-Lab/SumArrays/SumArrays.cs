using System;
using System.Linq;

namespace SumArrays
{
    class SumArrays
    {
        static void Main(string[] args)
        {
            int[] firstArr = Console
                .ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToArray();

            int[] secondArr = Console
                .ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToArray();

            int maxLen = Math.Max(firstArr.Length, secondArr.Length);

            int[] result = new int[maxLen];

            for (int i = 0; i < maxLen; i++)
            {
                int a = i % firstArr.Length;
                int b = i % secondArr.Length;
                result[i] = firstArr[a] + secondArr[b];
            }
            Console.WriteLine(string.Join(" ", result));
        }
    }
}
