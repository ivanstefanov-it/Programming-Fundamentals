﻿using System;

namespace IndexОfLetters
{
    class IndexОfLetters
    {
        static void Main(string[] args)
        {
            string word = Console.ReadLine();
            char[] arr = new char[26];
            for (int i = 0; i < 26; i++)
            {
                arr[i] = (char)(97 + i);
            }
            for (int i = 0; i < word.Length; i++)
            {
                Console.WriteLine(word[i] + " -> " + Array.IndexOf(arr, word[i]));
            }
        }
    }
}
