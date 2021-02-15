using System;

namespace ChooseADrink2._0
{
    class Program
    {
        static void Main(string[] args)
        {
            string profession = Console.ReadLine();
            int quantity = int.Parse(Console.ReadLine());
            double price = 1;

            if (profession == "Athlete")
            {
                price = 0.70 * quantity;
                Console.WriteLine($"The {profession} has to pay {price:F2}.");
            }
            else if (profession == "Businessman" || profession == "Businesswoman")
            {
                price = 1.00 * quantity;
                Console.WriteLine($"The {profession} has to pay {price:F2}.");
            }
            else if (profession == "SoftUni Student")
            {
                price = 1.70 * quantity;
                Console.WriteLine($"The {profession} has to pay {price:F2}.");
            }
            else
            {
                price = 1.20 * quantity;
                Console.WriteLine($"The {profession} has to pay {price:F2}.");
            }
        }
    }
}
