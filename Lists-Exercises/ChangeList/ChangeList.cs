using System;
using System.Collections.Generic;
using System.Linq;

namespace ChangeList
{
    class ChangeList
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split(" ").Select(int.Parse).ToList();
            string[] command = Console.ReadLine().Split(" ").ToArray();

            while (command[0] != "Odd" && command[0] != "Even")
            {
                if (command[0] == "Delete")
                {
                    numbers.RemoveAll(n => n == int.Parse(command[1]));
                    command = Console.ReadLine().Split().ToArray();
                }
                else if (command[0] == "Insert")
                {
                    numbers.Insert(int.Parse(command[2]), int.Parse(command[1]));
                    command = Console.ReadLine().Split().ToArray();
                }

            }
            if (command[0] == "Odd")
            {
                numbers.RemoveAll(n => n % 2 == 0);
            }
            else if (command[0] == "Even")
            {
                numbers.RemoveAll(n => n % 2 == 1);
            }
            Console.WriteLine(string.Join(" ", numbers));
        }
    }
}
