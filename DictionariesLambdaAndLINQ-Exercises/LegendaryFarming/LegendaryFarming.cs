using System;
using System.Collections.Generic;
using System.Linq;

namespace LegendaryFarming
{
    class LegendaryFarming
    {
        static void Main(string[] args)
        {
            
            Dictionary<string, int> junk = new Dictionary<string, int>();
            bool shards = false;
            bool fragments = false;
            bool motes = false;
            string resourse;
            int quantity = 0;
            Dictionary<string, int> keyMaterials = new Dictionary<string, int>();
            keyMaterials.Add("shards", 0);
            keyMaterials.Add("fragments", 0);
            keyMaterials.Add("motes", 0);

            while (shards == false && fragments == false && motes == false)
            {
                 string [] input = Console.ReadLine().ToLower().Split();
                for (int i = 0; i < input.Length; i+= 2)
                {
                    resourse = input[i + 1];
                    quantity = int.Parse(input[i]);
                    if (keyMaterials.ContainsKey(resourse))
                    {
                        keyMaterials[resourse] += quantity;
                    }
                    else if (junk.ContainsKey(resourse) == false)
                    {
                        junk.Add(resourse, quantity);
                    }
                    else
                    {
                        junk[resourse] += quantity;
                    }
                    if (keyMaterials["shards"] >= 250)
                    {
                        shards = true;
                        keyMaterials["shards"] -= 250;
                        break;
                    }
                    else if (keyMaterials["fragments"] >= 250)
                    {
                        fragments = true;
                        keyMaterials["fragments"] -= 250;
                        break;
                    }
                    else if (keyMaterials["motes"] >= 250)
                    {
                        motes = true;
                        keyMaterials["motes"] -= 250;
                        break;
                    }
                }
                
            }
            if (shards)
            {
                Console.WriteLine("Shadowmourne obtained!");
            }
            else if (fragments)
            {
                Console.WriteLine("Valanyr obtained!");
            }
            else if (motes)
            {
                Console.WriteLine("Dragonwrath obtained!");
            }

            foreach (var metal in keyMaterials.OrderByDescending(x => x.Value).ThenBy(x => x.Key))
            {
                Console.WriteLine($"{metal.Key}: {metal.Value}");
            }
            foreach (var metal in junk.OrderBy(x => x.Key))
            {
                Console.WriteLine($"{metal.Key}: {metal.Value}");
            }

        }
    }
}
