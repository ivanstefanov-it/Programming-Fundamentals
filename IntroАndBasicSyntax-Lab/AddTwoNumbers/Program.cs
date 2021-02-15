using System;

namespace AddTwoNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            var firstNumber = int.Parse(Console.ReadLine());
            var secondNumber = int.Parse(Console.ReadLine());
            var result = firstNumber + secondNumber;

            Console.WriteLine($"{firstNumber} + {secondNumber} = {result}");
        }
    }
}
