using System;
using System.Collections.Generic;
using System.Linq;

namespace ArrayManipulator
{
    class ArrayManipulator
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            List<string> command = Console.ReadLine().Split(' ').ToList();
            
            while (command[0] != "print")
            {
                if (command[0] == "add")
                {
                    int index = int.Parse(command[1]);
                    int element = int.Parse(command[2]);
                    numbers.Insert(index, element);
                }
                else if (command[0] == "addMany")
                {
                    int index = int.Parse(command[1]);
                    numbers.InsertRange(index, command.Skip(2).Select(int.Parse));
                }
                else if (command[0] == "contains")
                {
                    int element = int.Parse(command[1]);
                    if (numbers.Contains(element))
                    {
                        Console.WriteLine(numbers.IndexOf(element));
                    }
                    else
                    {
                        Console.WriteLine(-1);
                    }
                }
                else if (command[0] == "remove")
                {
                    int index = int.Parse(command[1]);
                    numbers.RemoveAt(index);
                }
                else if (command[0] == "shift")
                {
                    int position = int.Parse(command[1]) % numbers.Count;
                    List<int> help = numbers.Skip(position).ToList();
                    for (int i = 0; i < position; i++)
                    {
                        help.Add(numbers[i]);
                    }
                    numbers = help;
                }
                else if (command[0] == "sumPairs")
                {
                    int loops = numbers.Count / 2;
                    for (int i = 0; i < loops; i++)
                    {
                        numbers[i] += numbers[i + 1];
                        numbers.RemoveAt(i + 1);
                    }
                }
                command = Console.ReadLine().Split(' ').ToList();
            }
            Console.WriteLine("[" + string.Join(", ", numbers) + "]");
        }
    }
}
