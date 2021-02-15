using System;

namespace OddNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int input = int.Parse(Console.ReadLine());

            while (true)
            {
                if (input % 2 != 0)
                {
                    Console.WriteLine($"The number is: {Math.Abs(input)}");
                    break;
                }
                Console.WriteLine("Please write an odd number.");

                input = int.Parse(Console.ReadLine());
            }
        }
    }
}
