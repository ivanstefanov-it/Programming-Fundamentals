using System;
using System.Collections.Generic;

namespace AMinerTask
{
    class AMinerTask
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> mine = new Dictionary<string, int>();
            string command = Console.ReadLine();
            string resource = "";
            int quantity = 0;

            while (command != "stop")
            {
                resource = command;
                quantity = int.Parse(Console.ReadLine());
                if (mine.ContainsKey(resource) == false)
                {
                    mine[resource] = quantity;
                }
                else
                {
                    mine[resource] += quantity;
                }
                command = Console.ReadLine();
            }
            foreach (var metal in mine)
            {
                Console.WriteLine($"{metal.Key} -> {metal.Value}");
            }
        }
    }
}
