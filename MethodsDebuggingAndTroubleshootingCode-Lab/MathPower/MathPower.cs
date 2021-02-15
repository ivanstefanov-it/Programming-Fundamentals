using System;

namespace MathPower
{
    class MathPower
    {
        static void Main(string[] args)
        {
            double number = double.Parse(Console.ReadLine());
            double power = double.Parse(Console.ReadLine());
            double powered = GetPower(number, power);
            Console.WriteLine(powered);
        }
        static double GetPower(double num, double pow)
        {
            double result = Math.Pow(num, pow);
            return result;
        }
    }
}
