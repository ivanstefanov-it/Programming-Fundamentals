using System;
using System.Collections.Generic;
using System.Linq;

namespace PopulationCounter
{
    class PopulationCounter
    {
        static void Main(string[] args)
        {
            Dictionary<string, Dictionary<string, long>> countries = new Dictionary<string, Dictionary<string, long>>();
            string[] input = Console.ReadLine().Split('|');
            string country;
            string city;
            long population;

            while (input[0] != "report")
            {
                city = input[0];
                country = input[1];
                population = long.Parse(input[2]);

                if (countries.ContainsKey(country) == false)
                {
                    Dictionary<string, long> help = new Dictionary<string, long>();
                    help.Add(city, population);

                    countries.Add(country, help);
                }
                else
                {
                    if (countries[country].ContainsKey(city) == false)
                    {
                        countries[country].Add(city, population);
                    }
                }
                input = Console.ReadLine().Split('|');
            }
            foreach (var pair in countries.OrderByDescending(x => x.Value.Values.Sum()))
            {
                Console.WriteLine($"{pair.Key} (total population: {pair.Value.Values.Sum()})");
                foreach (var cityPair in pair.Value.OrderByDescending(c => c.Value))
                {
                Console.WriteLine($"=>{cityPair.Key}: {cityPair.Value}");

                }
            }
        }
    }
}
