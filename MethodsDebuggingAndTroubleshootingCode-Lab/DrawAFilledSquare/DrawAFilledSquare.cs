using System;

namespace DrawAFilledSquare
{
    class DrawAFilledSquare
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            PrintHead(n);
            PrintBody(n);
            PrintBody(n);
            PrintHead(n);
        }
        static void PrintHead(int num)
        {
            Console.WriteLine(new string('-', 2 * num));
        }
        static void PrintBody(int num)
        {
            Console.Write("-");
            for (int i = 1; i < num; i++)
            {
                Console.Write("\\/");
            }
            Console.WriteLine("-");
        }
    }
}
