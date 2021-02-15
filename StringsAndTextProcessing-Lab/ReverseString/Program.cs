using System;
using System.Linq;

namespace ReverseString
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            string reverseText = new string(text.Reverse().ToArray());
            Console.WriteLine(reverseText);
        }
    }
}
