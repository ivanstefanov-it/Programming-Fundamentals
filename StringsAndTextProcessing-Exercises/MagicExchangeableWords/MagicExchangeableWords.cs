using System;
using System.Linq;

namespace MagicExchangeableWords
{
    class MagicExchangeableWords
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split().ToArray();
            string firstWord = input[0];
            string secondWord = input[1];

            int firstNum = firstWord.Distinct().Count();
            int secondNum = secondWord.Distinct().Count();

            if (firstNum == secondNum)
            {
                Console.WriteLine("true");
            }
            else
            {
                Console.WriteLine("false");
            }
        }
    }
}
