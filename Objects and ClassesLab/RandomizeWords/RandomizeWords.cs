using System;

namespace RandomizeWords
{
    class RandomizeWords
    {
        static void Main(string[] args)
        {
            string[] words = Console.ReadLine().Split();
            Random rnd = new Random();

            for (int i = 0; i < words.Length; i++)
            {
                int firstWord = rnd.Next(0, words.Length);
                int secondWord = rnd.Next(0, words.Length);

                string changer = words[firstWord];
                words[firstWord] = words[secondWord];
                words[secondWord] = changer;
            }

            Console.WriteLine(string.Join("\n", words));
        }
    }
}
