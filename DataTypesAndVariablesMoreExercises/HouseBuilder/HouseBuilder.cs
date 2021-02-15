using System;

namespace HouseBuilder
{
    class Program
    {
        static void Main(string[] args)
        {
            long price1 = long.Parse(Console.ReadLine());
            long price2 = long.Parse(Console.ReadLine());
            long intType = Math.Max(price1, price2);
            long sbyteType = Math.Min(price1, price2);
            long result = (intType * 10) + (sbyteType * 4);

            Console.WriteLine(result);
        }
    }
}
