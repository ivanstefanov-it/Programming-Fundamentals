using System;

namespace BackIn30Minutes
{
    class Program
    {
        static void Main(string[] args)
        {
            int hours = int.Parse(Console.ReadLine());
            int minutes = int.Parse(Console.ReadLine());
            int addMinutes = minutes + 30;

            if (addMinutes > 59)
            {
                hours++;
                addMinutes -= 60;
                if (hours > 23)
                {
                    hours = 0;
                }
                Console.WriteLine($"{hours}:{addMinutes:D2}");
            }
            else if (addMinutes < 59)
            {
                minutes -= 60;
                Console.WriteLine($"{hours}:{addMinutes:D2}");
            }
        }
    }
}
