using System;
using System.Linq;

namespace CharacterMultiplier
{
    class CharacterMultiplier
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split().ToArray();
            string first = input[0];
            string second = input[1];
            int sum = 0;
            int minLenght = Math.Min(first.Length, second.Length);
            int maxLenght = Math.Max(first.Length, second.Length);

            for (int i = 0; i < minLenght; i++)
            {
                sum += first[i] * second[i];
            }

            for (int i = minLenght; i < maxLenght; i++)
            {
                if (first.Length > second.Length)
                {
                    sum += first[i];
                }
                else
                {
                    sum += second[i];
                }
            }
            Console.WriteLine(sum);
        }
    }
}
