using System;
using System.Collections.Generic;
using System.Linq;

namespace UserLogs
{
    class UserLogs
    {
        static void Main(string[] args)
        {
            Dictionary<string, Dictionary<string, int>> site = new Dictionary<string, Dictionary<string, int>>();
            string[] command = Console.ReadLine().Split(' ');
            string name;
            string ip;

            while (command[0] != "end")
            {
                string[] inputIp = command[0].Split('=');
                ip = inputIp[1];
                string[] inputName = command[2].Split('=');
                name = inputName[1];

                if (site.ContainsKey(name) == false)
                {
                    Dictionary<string, int> curr = new Dictionary<string, int>();
                    curr.Add(ip, 1);
                    site.Add(name, curr);
                }
                else
                {
                    if (site[name].ContainsKey(ip) == false)
                    {
                        site[name].Add(ip, 1);
                    }
                    else
                    {
                        site[name][ip]++;
                    }
                }
                command = Console.ReadLine().Split(' ');
            }
            foreach (var users in site.OrderBy(x => x.Key))
            {
                Console.WriteLine($"{users.Key}: ");
                List<string> helper = new List<string>();
                foreach (var ips in users.Value)
                {
                    helper.Add($"{ips.Key} => {ips.Value}");
                }
                Console.WriteLine(string.Join(", ", helper) + ".");
            }
        }
    }
}
