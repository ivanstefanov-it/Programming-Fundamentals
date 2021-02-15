using System;
using System.Linq;

namespace demo
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] names = Console.ReadLine().Split(' ').ToArray();
            int[] quantities = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            double[] prices = Console.ReadLine().Split(' ').Select(double.Parse).ToArray();
            string[] command = Console.ReadLine().Split(' ').ToArray();
            
            double total; 

            while (command[0] != "done")
            {
                int index = Array.IndexOf(names, command[0]);
                
                try
                {
                    total = int.Parse(command[1]) * prices[index];
                    Console.WriteLine($"{names[index]} x {quantities[index]} costs {total:F2}");
                }
                catch (IndexOutOfRangeException)
                {
                    Console.WriteLine($"We do not have enough {names[index]}");
                }
                command = Console.ReadLine().Split(' ').ToArray();
            }
        }
    }
}
