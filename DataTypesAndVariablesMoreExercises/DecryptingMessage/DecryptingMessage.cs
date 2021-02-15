using System;

namespace DecryptingMessage
{
    class DecryptingMessage
    {
        static void Main(string[] args)
        {
            int key = int.Parse(Console.ReadLine());
            int lines = int.Parse(Console.ReadLine());
            string text = "";
            string output = "";

            for (int i = 1; i <= lines; i++)
            {
                text = Console.ReadLine();
                output += ((char)(char.Parse(text) + key)).ToString();
            }
            Console.WriteLine(output);
        }
    }
}
