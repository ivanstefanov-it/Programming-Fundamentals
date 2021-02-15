using System;

namespace CubeProperties
{
    class CubeProperties
    {
        static void Main(string[] args)
        {
            double side = double.Parse(Console.ReadLine());
            string parameter = Console.ReadLine();
            if (parameter == "face")
            {
                double result = FaceDiagonals(side);
                Console.WriteLine($"{result:F2}");
            }
            else if (parameter == "space")
            {
                double result = SpaceDiagonals(side);
                Console.WriteLine($"{result:F2}");
            }
            else if (parameter == "volume")
            {
                double result = Volume(side);
                Console.WriteLine($"{result:F2}");
            }
            else if (parameter == "area")
            {
                double result = SurfaceArea(side);
                Console.WriteLine($"{result:F2}");
            }
        }
        static double FaceDiagonals(double num)
        {
            double faceDiagonal = Math.Sqrt(2 *(num * num));
            return faceDiagonal;
        }
        static double SpaceDiagonals(double num)
        {
            double spaceDiagonals = Math.Sqrt(3 * (num * num));
            return spaceDiagonals;
        }
        static double Volume(double num)
        {
            double volume = Math.Pow(num, 3);
            return volume;
        }
        static double SurfaceArea(double num)
        {
            double surfaceArea = num * num * 6;
            return surfaceArea;
        }
    }
}
