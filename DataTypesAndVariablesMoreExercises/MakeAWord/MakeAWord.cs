using System;

namespace MakeAWord
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string symbol = "";
            string word = "";

            for (int i = 0; i < n; i++)
            {
                symbol = Console.ReadLine();
                word += symbol;
            }
            Console.WriteLine($"The word is: {word}");
        }
    }
}
