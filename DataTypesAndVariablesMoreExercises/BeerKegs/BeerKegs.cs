using System;

namespace BeerKegs
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string model = "";
            double radius = 0;
            int height = 0;
            double biggestKeg = 0;
            string currModel = "";

            for (int i = 0; i < n; i++)
            {
                currModel = Console.ReadLine();
                radius = double.Parse(Console.ReadLine());
                height = int.Parse(Console.ReadLine());

                double currBig = Math.PI * Math.Pow(radius, 2) * height;

                if (currBig > biggestKeg)
                {
                    biggestKeg = currBig;
                    model = currModel;
                }
            }
            Console.WriteLine(model);
        }
    }
}
