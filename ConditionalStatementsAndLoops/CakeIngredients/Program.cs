using System;

namespace CakeIngredients
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            int counter = 0;

            while (input != "Bake!")
            {
                Console.WriteLine($"Adding ingredient {input}.");
                counter++;
                input = Console.ReadLine();
                if (input == "Bake!")
                {
                    Console.WriteLine($"Preparing cake with {counter} ingredients.");
                }
            }
        }
    }
}
