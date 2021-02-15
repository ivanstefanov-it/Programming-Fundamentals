using System;

namespace ExchangeVariableValues
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int oldB = b;

            Console.WriteLine("Before:");
            Console.WriteLine("a = " + a);
            Console.WriteLine("b = " + b);

            b = a; 
             int c = oldB; 

            Console.WriteLine("After:");
            Console.WriteLine("a = " + c);
            Console.WriteLine("b = " + b);

            
        }
    }
}
