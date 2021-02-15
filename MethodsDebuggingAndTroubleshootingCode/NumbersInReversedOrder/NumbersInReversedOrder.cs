using System;
using System.Linq;

namespace NumbersInReversedOrder
{
    class NumbersInReversedOrder
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            ReversedNumber(input);
        }

        private static void ReversedNumber(string input)
        {
            Console.WriteLine(string.Join("", input.Reverse()));
        }
    }
}
