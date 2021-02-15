using System;
using System.Collections.Generic;
using System.Linq;

namespace SupermarketDatabase
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] command = Console.ReadLine().Split();
            Dictionary<string, Dictionary<double, double>> products = new Dictionary<string, Dictionary<double, double>>();
            double total = 0;

            while (command[0] != "stocked")
            {
                string name = command[0];
                double price = double.Parse(command[1]);
                double quantity = double.Parse(command[2]);

                if (products.ContainsKey(name) == false)
                {
                    products[name] = new Dictionary<double, double>();
                }
                if (products[name].ContainsKey(price) == false)
                {
                    products[name][price] = 0;
                }

                products[name][price] += quantity;

                command = Console.ReadLine().Split();
            }
            foreach (var product in products)
            {
                string name = product.Key;
                double price = product.Value.Keys.Last();
                double quantity = product.Value.Values.Sum();
                total += (quantity * price);

                Console.WriteLine($"{name}: ${price:f2} * {quantity} = ${quantity * price:f2}");
            }
            Console.WriteLine("------------------------------");
            Console.WriteLine($"Grand Total: ${total:f2}");
        }
    }
}
