﻿using System;

namespace IntegerToHexAndBinary
{
    class Program
    {
        static void Main(string[] args)
        {
            int input = int.Parse(Console.ReadLine());
            string hex = Convert.ToString(input, 16).ToUpper();
            string binary = Convert.ToString(input, 2);

            Console.WriteLine(hex);
            Console.WriteLine(binary);
        }
    }
}
