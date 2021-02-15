using System;

namespace GreaterOfTwoValues
{
    class GreaterOfTwoValues
    {
        static void Main(string[] args)
        {
            string type = Console.ReadLine();
            if (type == "int")
            {
                int firstNum = int.Parse(Console.ReadLine());
                int secondNum = int.Parse(Console.ReadLine());
                int max = GetMax(firstNum, secondNum);
                Console.WriteLine(max);
            }
            else if (type == "char")
            {
                char firstSymbol = char.Parse(Console.ReadLine());
                char secondSymbol = char.Parse(Console.ReadLine());
                char max = GetMax(firstSymbol, secondSymbol);
                Console.WriteLine(max);
            }
            else if (type == "string")
            {
                string firstWord = Console.ReadLine();
                string secondWord = Console.ReadLine();
                string max = GetMax(firstWord, secondWord);
                Console.WriteLine(max);
            }
        }
        static int GetMax(int first, int second)
        {
            int max = Math.Max(first, second);
            return max;
        }
        static char GetMax(char first, char second)
        {
            if (first > second)
            {
                return first;
            }
            else
            {
                return second;
            }
        }
        static string GetMax(string first, string second)
        {
            if (first.CompareTo(second) >= 0)
            {
                return first;
            }
            else
            {
                return second;
            }
        }
    }
}
