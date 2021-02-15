using System;
using System.Collections.Generic;
using System.Linq;

namespace AppendLists
{
    class AppendLists
    {
        static void Main(string[] args)
        {
            List<string> numbersAsText = Console.ReadLine().Split("|").Reverse().ToList();

            foreach (var word in numbersAsText)
            {
               string[] textArr = word.Split(new char[] {' '}, StringSplitOptions.RemoveEmptyEntries);
                Console.Write(string.Join(" ", textArr) + " ");
            }
            Console.WriteLine();
        }
    }
}
