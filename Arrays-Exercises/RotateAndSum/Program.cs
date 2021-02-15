using System;
using System.Linq;

namespace RotateAndSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int k = int.Parse(Console.ReadLine());
            int[] sum = new int[arr.Length];

            for (int i = 0; i < k; i++)
            {
                arr = Rotate(arr);
                for (int j = 0; j < sum.Length; j++)
                {
                    sum[j] += arr[j];
                }
            }
            Console.WriteLine(string.Join(" ", sum));
        }
        static int[] Rotate(int[] number)
        {
            int[] rotated = new int[number.Length];
            int last = number[number.Length - 1];
            for (int i = 1; i < rotated.Length; i++)
            {
                rotated[i] = number[i - 1];
            }
            rotated[0] = last;
            return rotated;
        }
    }
}
