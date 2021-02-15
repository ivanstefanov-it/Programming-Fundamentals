using System;

namespace BoatSimulator
{
    class Program
    {
        static void Main(string[] args)
        {
            char firstChar = char.Parse(Console.ReadLine());
            char secondChar = char.Parse(Console.ReadLine());
            int num = int.Parse(Console.ReadLine());
            string lines = "";
            int firstBoatSpeed = 0;
            int secondBoatSpeed = 0;

            for (int i = 1; i <= num; i++)
            {
                lines = Console.ReadLine();
                if (lines == "UPGRADE")
                {
                    firstChar += (char)3;
                    secondChar += (char)3;
                    continue;
                }
                if (i % 2 != 0)
                {
                    firstBoatSpeed += lines.Length;
                }
                else
                {
                    secondBoatSpeed += lines.Length;
                }
                if (i == num || firstBoatSpeed >= 50 || secondBoatSpeed >= 50)
                {
                    if (firstBoatSpeed > secondBoatSpeed)
                    {
                        Console.WriteLine(firstChar);
                        return;
                    }
                    else
                    {
                        Console.WriteLine(secondChar);
                        return;
                    }
                }
            }
            if (firstBoatSpeed > secondBoatSpeed)
            {
                Console.WriteLine(firstChar);
                return;
            }
            else
            {
                Console.WriteLine(secondChar);
                return;
            }


        }
    }
}
