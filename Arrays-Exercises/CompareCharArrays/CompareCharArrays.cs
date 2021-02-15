using System;
using System.Linq;

namespace CompareCharArrays
{
    class CompareCharArrays
    {
        static void Main(string[] args)
        {
            char[] firstArr = Console.ReadLine().Split(' ').Select(char.Parse).ToArray();
            char[] secondArr = Console.ReadLine().Split(' ').Select(char.Parse).ToArray();
            int len = Math.Min(firstArr.Length, secondArr.Length);
            bool isFirst = false;

            for (int i = 0; i < len; i++)
            {
                if (firstArr[i] < secondArr[i])
                {
                    isFirst = true;
                    break;
                }
                else if (firstArr[i] > secondArr[i])
                {
                    isFirst = false;
                    break;
                }
                if (i == len -1)
                {
                    if (firstArr.Length < secondArr.Length)
                    {
                        isFirst = true;
                    }
                }
            }
            if (isFirst)
            {
                Console.WriteLine(string.Join("", firstArr));
                Console.WriteLine(string.Join("", secondArr));
            }
            else
            {
                Console.WriteLine(string.Join("", secondArr));
                Console.WriteLine(string.Join("", firstArr));

            }
        }
    }
}
