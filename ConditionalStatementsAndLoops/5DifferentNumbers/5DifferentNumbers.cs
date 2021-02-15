using System;

namespace _5DifferentNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstNumber = int.Parse(Console.ReadLine());
            int secondNumber = int.Parse(Console.ReadLine());

            int start = Math.Min(firstNumber, secondNumber);
            int stop = Math.Max(firstNumber, secondNumber);

            if (stop - start < 4)
            {
                Console.WriteLine("No");
                return;
            }

            for (int a = start; a <= stop - 4; a++)
            {
                for (int b = start + 1; b <= stop - 3; b++)
                {
                    for (int c = start + 2; c <= stop - 2; c++)
                    {
                        for (int d = start + 3; d <= stop - 1; d++)
                        {
                            for (int e = start + 4; e <= stop; e++)
                            {
                                if (a < b && b < c && c < d && d < e)
                                {
                                    Console.WriteLine($"{a} {b} {c} {d} {e}");
                                }
                            }
                        }
                    }
                }
            }
        }
    }
}
