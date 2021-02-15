using System;
using System.Linq;

namespace ReverseArrayOfIntegers
{
    class Program
    {
        static void Main(string[] args)
        {
            int len = int.Parse(Console.ReadLine());
            int[] firstArr = new int[len];

            for (int i = 0; i < firstArr.Length; i++)
            {
                firstArr[i] = int.Parse(Console.ReadLine());
            }
            int[] secondArr = firstArr.Reverse().ToArray();

            Console.WriteLine(string.Join(" ", secondArr));
        }
    }
}
