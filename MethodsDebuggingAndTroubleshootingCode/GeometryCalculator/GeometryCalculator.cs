using System;

namespace GeometryCalculator
{
    class GeometryCalculator
    {
        static void Main(string[] args)
        {
            string figure = Console.ReadLine();
            if (figure == "triangle")
            {
                double side = double.Parse(Console.ReadLine());
                double height = double.Parse(Console.ReadLine());
                double result = TriangleArea(side, height);
                Console.WriteLine($"{result:F2}");
            }
            else if (figure == "square")
            {
                double side = double.Parse(Console.ReadLine());
                double result = SquareArea(side);
                Console.WriteLine($"{result:F2}");
            }
            else if (figure == "rectangle")
            {
                double width = double.Parse(Console.ReadLine());
                double height = double.Parse(Console.ReadLine());
                double result = RectangleArea(width, height);
                Console.WriteLine($"{result:F2}");
            }
            else if (figure == "circle")
            {
                double radius = double.Parse(Console.ReadLine());
                double result = CircleArea(radius);
                Console.WriteLine($"{result:F2}");
            }

        }
        static double TriangleArea(double side, double height)
        {
            double area = (side * height) / 2;
            return area;
        }
        static double SquareArea(double side)
        {
            double area = side * side;
            return area;
        }
        static double RectangleArea(double width, double height)
        {
            double area = width * height;
            return area;
        }
        static double CircleArea(double radius)
        {
            double area = Math.PI * Math.Pow(radius, 2);
            return area;
        }
    }
}
