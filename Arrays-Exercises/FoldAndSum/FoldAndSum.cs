using System;
using System.Linq;

namespace FoldAndSum
{
    class FoldAndSum
    {
        static void Main(string[] args)
        {
            int[] arr = Console
                .ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToArray();
            int[] left = arr.Take(arr.Length / 4).Reverse().ToArray();
            int[] middle = arr.Skip(arr.Length / 4).Take((arr.Length / 4) * 2).ToArray();
            int[] right = arr.Skip(left.Length + middle.Length).Take(arr.Length / 4).Reverse().ToArray();
            int[] result = new int[middle.Length];

            for (int i = 0; i < middle.Length / 2; i++)
            {
                result[i] = left[i] + middle[i];
                result[i + middle.Length / 2] = right[i] + middle[i + middle.Length / 2];
            }
            

            Console.WriteLine(string.Join(" ", result));
        }
    }
}
