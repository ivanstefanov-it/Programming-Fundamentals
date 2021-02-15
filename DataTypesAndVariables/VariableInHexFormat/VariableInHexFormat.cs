using System;

namespace VariableInHexFormat
{
    class Program
    {
        static void Main(string[] args)
        {
            string hex = Console.ReadLine();
            int result = Convert.ToInt32(hex, 16);
            Console.WriteLine(result);
        }
    }
}
