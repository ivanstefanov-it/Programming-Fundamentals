using System;

namespace WeatherForecast
{
    class WeatherForecast
    {
        static void Main(string[] args)
        {
            try
            {
                long input = long.Parse(Console.ReadLine());

                if (input <= sbyte.MaxValue && input >= sbyte.MinValue)
                {
                    Console.WriteLine("Sunny");
                }
                else if (input <= int.MaxValue && input >= int.MinValue)
                {
                    Console.WriteLine("Cloudy");
                }
                else if (input <= long.MaxValue && input >= long.MinValue)
                {
                    Console.WriteLine("Windy");
                }
            }
            catch (Exception)
            {
                Console.WriteLine("Rainy");
            }
        }
    }
}
