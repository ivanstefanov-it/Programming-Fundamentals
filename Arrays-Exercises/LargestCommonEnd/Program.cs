using System;
using System.Linq;

namespace LargestCommonEnd
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] firstArr = Console.ReadLine().Split(' ').ToArray();
            string[] secondArr = Console.ReadLine().Split(' ').ToArray();
            int counter = 0;
            int len = Math.Min(firstArr.Length, secondArr.Length);

            for (int i = 0; i < len; i++)
            {
                if (firstArr[i] == secondArr[i])
                {
                    counter++;
                }
                
            }
            if (counter == 0)
            {
                Array.Reverse(firstArr);
                Array.Reverse(secondArr);
                for (int i = 0; i < len; i++)
                {
                    if (firstArr[i] == secondArr[i])
                    {
                        counter++;
                    }
                }
            }
            Console.WriteLine(counter);
        }
    }
}
