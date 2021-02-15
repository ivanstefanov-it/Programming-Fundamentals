using System;
using System.Collections.Generic;
using System.Linq;

namespace LogsAggregator
{
    class LogsAggregator
    {
        static void Main(string[] args)
        {
            SortedDictionary<string, SortedDictionary<string, int>> logs = new SortedDictionary<string, SortedDictionary<string, int>>();
            int n = int.Parse(Console.ReadLine());
            string[] input;
            string ip;
            string user;
            int duration;
       

            for (int i = 0; i < n; i++)
            {
                input = Console.ReadLine().Split();
                ip = input[0];
                user = input[1];
                duration = int.Parse(input[2]);
                SortedDictionary<string, int> curr = new SortedDictionary<string, int>();

                if (logs.ContainsKey(user) == false)
                {
                    logs.Add(user, curr);
                }
                if (logs[user].ContainsKey(ip) == false)
                {
                    logs[user].Add(ip, duration);
                }
                else
                {
                    logs[user][ip] += duration;
                }
            }
            foreach (var log in logs)
            {
                var totalDurationOfUser = logs[log.Key].Values.Sum();
                var listOfIps = log.Value.Keys.ToList();
                Console.WriteLine($"{log.Key}: {totalDurationOfUser} [{string.Join(", ", listOfIps)}]");
            }
        }
    }
}
