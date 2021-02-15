using System;
using System.Collections.Generic;
using System.Linq;

namespace SplitByWordCasing
{
    class SplitByWordCasing
    {
        static void Main(string[] args)
        {
            string[] words = Console
                .ReadLine()
                .Split(",;:.!()\"'\\/[] ".ToCharArray(),StringSplitOptions.RemoveEmptyEntries)
               .ToArray();
            List<string> upperCase = new List<string>();
            List<string> lowerCase = new List<string>();
            List<string> mixedCase = new List<string>();

            foreach (var word in words)
            {
                if (IsUpperWord(word))
                {
                    upperCase.Add(word);
                }
                else if (IsLowerWord(word))
                {
                    lowerCase.Add(word);
                }
                else
                {
                    mixedCase.Add(word);
                }
            }
            Console.WriteLine("Lower-case: {0}", string.Join(", ",lowerCase));
            Console.WriteLine("Mixed-case: {0}", string.Join(", ",mixedCase));
            Console.WriteLine("Upper-case: {0}", string.Join(", ",upperCase));
        }
        static bool IsUpperWord(string word)
        {
            foreach (char symbol in word)
            {
                if ('A' > symbol || symbol > 'Z')
                {
                    return false;
                }
            }
            return true;
        }
        static bool IsLowerWord(string word)
        {
            foreach (char symbol in word)
            {
                if ('a' > symbol || symbol > 'z')
                {
                    return false;
                }
            }
            return true;
        }
    }
}
