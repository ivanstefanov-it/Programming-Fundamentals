using System;
using System.Collections.Generic;
using System.Linq;

namespace BombNumbers
{
    class BombNumbers
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split(" ").Select(int.Parse).ToList();
            List<int> command = Console.ReadLine().Split(" ").Select(int.Parse).ToList();
            int bomb = command[0];
            int power = command[1];

            for (int i = 0; i < numbers.Count; i++)
            {
                if (numbers[i] == bomb)
                {
                    if (power <= i)
                    {
                        for (int j = i; j >= i - power; j--)
                        {
                            numbers[j] = 0;
                        }
                    }
                    if (power > i)
                    {
                        for (int j = i; j >= 0; j--)
                        {
                            numbers[j] = 0;
                        }
                    }
                    if (power + i <= numbers.Count - 1)
                    {
                        for (int j = i; j <= power + i ; j++)
                        {
                            numbers[j] = 0;
                        }
                    }
                    if (power + i > numbers.Count - 1)
                    {
                        for (int j = i; j < numbers.Count; j++)
                        {
                            numbers[j] = 0;
                        }
                    }
                }
            }
            Console.WriteLine(numbers.Sum());
        }
    }
}
