﻿using System;

namespace DebitCardNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            var firstNumber = int.Parse(Console.ReadLine());
            var secondNumber = int.Parse(Console.ReadLine());
            var thirdNumber = int.Parse(Console.ReadLine());
            var fourthNumber = int.Parse(Console.ReadLine());

            Console.WriteLine($"{firstNumber:D4} {secondNumber:D4} {thirdNumber:D4} {fourthNumber:D4}");
        }
    }
}
