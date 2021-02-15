using System;

namespace ComparingFloats
{
    class Program
    {
        static void Main(string[] args)
        {
            double firstNumber = double.Parse(Console.ReadLine());
            double secondNumber = double.Parse(Console.ReadLine());
            double bigger = Math.Max(firstNumber, secondNumber);
            double smaller = Math.Min(firstNumber, secondNumber);

            if (bigger - smaller < 0.000001)
            {
                Console.WriteLine("True");
            }
            else
            {
                Console.WriteLine("False");
            }
        }
    }
}
