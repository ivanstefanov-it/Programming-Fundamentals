using System;

namespace UnicodeCharacters
{
    class UnicodeCharacters
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();

            foreach (var symbol in text)
            {
                Console.Write("\\u{0:x4}", (int)symbol);
            }
        }
    }
}
