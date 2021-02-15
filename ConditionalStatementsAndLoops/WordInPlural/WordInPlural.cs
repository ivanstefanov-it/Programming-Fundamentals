using System;

namespace WordInPlural
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            if (input.EndsWith("y"))
            {
               input = input.Remove(input.Length - 1);
               input = input.Insert(input.Length, "ies");
               Console.WriteLine(input);
            }
            else if (input.EndsWith("o") || 
                input.EndsWith("ch") || 
                input.EndsWith("s") || 
                input.EndsWith("sh") || 
                input.EndsWith("x") || 
                input.EndsWith("z"))
            {
                input = input.Insert(input.Length, "es");
                Console.WriteLine(input);
            }
            else
            {
                input = input.Insert(input.Length, "s");
                Console.WriteLine(input);
            }
        }
    }
}
