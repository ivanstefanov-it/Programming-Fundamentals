using System;
using System.Linq;

namespace ExtractMiddleElements
{
    class ExtractMiddleElements
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            if (arr.Length == 1)
            {
                Console.WriteLine(string.Join("", arr));
            }
            else if (arr.Length % 2 == 0)
            {
                int[] result = new int[2];
                result[0] = arr[arr.Length / 2 - 1];
                result[1] = arr[arr.Length / 2];
                Console.WriteLine(string.Join(", ", result));
            }
            else if (arr.Length % 2 != 0)
            {
                int[] result = new int[3];
                result[0] = arr[arr.Length / 2 - 1];
                result[1] = arr[arr.Length / 2];
                result[2] = arr[arr.Length / 2 + 1];
                Console.WriteLine(string.Join(", ", result));
            }
        }
    }
}
