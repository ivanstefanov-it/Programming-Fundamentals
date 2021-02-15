using System;

namespace CircleArea_Precision12_
{
    class Program
    {
        static void Main(string[] args)
        {
            double radius = double.Parse(Console.ReadLine());
            double area = Math.PI * radius * radius;

            Console.WriteLine($"{area:F12}");

        }
    }
}
