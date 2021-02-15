using System;

namespace GameOfNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int m = int.Parse(Console.ReadLine());
            int magic = int.Parse(Console.ReadLine());
            int currentBiggerNumber = 0;
            int counter = 0;

            int max = Math.Max(n, m);
            int min = Math.Min(n, m);


            for (int i = max; i >= min; i--)
            {
                for (int j = max; j >= min; j--)
                {
                    if (i + j == magic)
                    {
                        currentBiggerNumber = i + j;
                        Console.WriteLine($"Number found! {i} + {j} = {currentBiggerNumber}");
                        return;
                    }
                    else
                    {
                        counter++;
                    }
                }
            }
            Console.WriteLine($"{counter} combinations - neither equals {magic}");
            
        }
    }
}
