using System;

namespace RectangleArea
{
    class Program
    {
        static void Main(string[] args)
        {
            var sideA = double.Parse(Console.ReadLine());
            var sideB = double.Parse(Console.ReadLine());
            var result = sideA * sideB;
            Console.WriteLine($"{result:F2}");

        }
    }
}
