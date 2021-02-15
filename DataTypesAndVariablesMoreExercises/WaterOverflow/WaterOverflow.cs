using System;

namespace WaterOverflow
{
    class WaterOverflow
    {
        static void Main(string[] args)
        {
            byte liters = byte.MaxValue;
            byte lines = byte.Parse(Console.ReadLine());
            int capacity = 0;
           

            for (int i = 1; i <= lines; i++)
            {
               int n = int.Parse(Console.ReadLine());
                capacity = capacity + n;

                if (capacity > liters)
                {
                    Console.WriteLine("Insufficient capacity!");
                    capacity -= n;
                }
                
            }
            Console.WriteLine(capacity);
        }
    }
}
