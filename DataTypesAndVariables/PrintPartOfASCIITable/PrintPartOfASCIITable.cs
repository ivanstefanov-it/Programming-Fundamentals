using System;

namespace PrintPartOfASCIITable
{
    class Program
    {
        static void Main(string[] args)
        {
            int startIndex = int.Parse(Console.ReadLine());
            int stopIndex = int.Parse(Console.ReadLine());

            for (char output = (char)startIndex; output <= stopIndex; output++)
            {
                Console.Write(output + " ");
            }
        }
    }
}
