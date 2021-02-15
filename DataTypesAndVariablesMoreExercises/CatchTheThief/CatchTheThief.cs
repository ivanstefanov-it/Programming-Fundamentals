using System;

namespace CatchTheThief
{
    class CatchTheThief
    {
        static void Main(string[] args)
        {
            string type = Console.ReadLine();
            byte n = byte.Parse(Console.ReadLine());
            decimal biggestId = 0;

            if (type == "sbyte")
            {
                biggestId = sbyte.MaxValue;
            }
            if (type == "int")
            {
                biggestId = int.MaxValue;
            }
            if (type == "long")
            {
                biggestId = long.MaxValue;
            }
            long currentNumber = long.Parse(Console.ReadLine());
            long cloesestNumber = currentNumber;
            for (int index = 1; index < n; index++)
            {
                currentNumber = long.Parse(Console.ReadLine());

                if (Math.Abs(biggestId - currentNumber) < Math.Abs(biggestId - cloesestNumber))
                {
                    cloesestNumber = currentNumber;
                }
            }
            Console.WriteLine(cloesestNumber);
        }
    }
}
