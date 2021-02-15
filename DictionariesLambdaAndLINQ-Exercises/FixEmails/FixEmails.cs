using System;
using System.Collections.Generic;
using System.Linq;

namespace FixEmails
{
    class FixEmails
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> mailbook = new Dictionary<string, string>();
            string command = Console.ReadLine();
            string name = "";
            string mail = "";

            while (command != "stop")
            {
                name = command;
                mail = Console.ReadLine();

                if (mailbook.ContainsKey(name) == false)
                {
                    mailbook.Add(name, mail);
                }
                command = Console.ReadLine();
            }
            foreach (var pair in mailbook.Where(x => !x.Value.EndsWith("us") && !x.Value.EndsWith("uk")))
            {
                Console.WriteLine($"{pair.Key} -> {pair.Value}");
            }
        }
    }
}
