using System;
using System.Linq;

namespace FoldAndSum
{
    class FoldAndSum
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int k = numbers.Length / 4;

            int[] leftRow = numbers.Take(k).Reverse().ToArray();
            int[] rightRow = numbers.Reverse().Take(k).ToArray();
            int[] row1 = leftRow.Concat(rightRow).ToArray();
            int[] row2 = numbers.Skip(k).Take(k * 2).ToArray();
            int[] sum = row1.Select((x, index) => x + row2[index]).ToArray();

            Console.WriteLine(string.Join(" ", sum));
        }
    }
}
