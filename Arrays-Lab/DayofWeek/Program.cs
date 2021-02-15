using System;

namespace DayofWeek
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] daysOfWeek = {
                "Monday",
                "Tuesday",
                "Wednesday",
                "Thursday",
                "Friday",
                "Saturday",
                "Sunday",
            };
            
            int day = int.Parse(Console.ReadLine());

            if (day >= 1 && day < 8)
            {
            Console.WriteLine(daysOfWeek[day - 1]);
            }
            else
            {
                Console.WriteLine("Invalid day");
            }

            
        }
    }
}
