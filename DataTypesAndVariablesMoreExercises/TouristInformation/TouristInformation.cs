using System;

namespace TouristInformation
{
    class TouristInformation
    {
        static void Main(string[] args)
        {
            string unit = Console.ReadLine();
            double value = double.Parse(Console.ReadLine());

            if (unit == "miles")
            {
                double result = value * 1.6;
                Console.WriteLine($"{value} miles = {result:F2} kilometers");
            }
            else if (unit == "inches")
            {
                double result = value * 2.54;
                Console.WriteLine($"{value} inches = {result:F2} centimeters");
            }
            else if (unit == "feet")
            {
                double result = value * 30;
                Console.WriteLine($"{value} feet = {result:F2} centimeters");
            }
            else if (unit == "yards")
            {
                double result = value * 0.91;
                Console.WriteLine($"{value} yards = {result:F2} meters");
            }
            else if (unit == "gallons")
            {
                double result = value * 3.8;
                Console.WriteLine($"{value} gallons = {result:F2} liters");
            }
        }
    }
}
