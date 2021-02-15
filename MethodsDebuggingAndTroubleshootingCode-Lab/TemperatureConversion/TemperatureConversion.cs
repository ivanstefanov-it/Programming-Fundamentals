using System;

namespace TemperatureConversion
{
    class TemperatureConversion
    {
        static void Main(string[] args)
        {
            double fahrenheit = double.Parse(Console.ReadLine());
            double celsius = ToCelsius(fahrenheit);
            Console.WriteLine($"{celsius:F2}");
        }
        static double ToCelsius(double degrees)
        {
            return (degrees - 32) * 5 / 9;
        }
    }
}
