using System;

namespace CalculateTriangleArea
{
    class CalculateTriangleArea
    {
        static void Main(string[] args)
        {
            double width = double.Parse(Console.ReadLine());
            double height = double.Parse(Console.ReadLine());
            double area = TriangleArea(width, height);
            Console.WriteLine(area);
        }
        static double TriangleArea(double num1, double num2)
        {
            return (num1 * num2) / 2;
        }
    }
}
