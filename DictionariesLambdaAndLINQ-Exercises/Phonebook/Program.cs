using System;
using System.Collections.Generic;

namespace Phonebook
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> phonebook = new Dictionary<string, string>();
            string[] command = Console.ReadLine().Split();

            while (command[0] != "END")
            {
                if (command[0] == "A")
                {
                    if (phonebook.ContainsKey(command[1]) == false)
                    {
                        phonebook.Add(command[1], command[2]);
                    }
                    else
                    {
                        phonebook[command[1]] = command[2];
                    }
                }
                else if (command[0] == "S")
                {
                    
                        if (phonebook.ContainsKey(command[1]))
                        {
                            Console.WriteLine($"{command[1]} -> {phonebook[command[1]]}");
                        }
                        else
                        {
                            Console.WriteLine($"Contact {command[1]} does not exist.");
                        }
                    
                }
                command = Console.ReadLine().Split();
            }
        }
    }
}
