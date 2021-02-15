using System;
using System.Collections.Generic;
using System.Linq;

namespace P03_ImmuneSystem
{
    class P03_ImmuneSystem
    {
        static void Main(string[] args)
        {

            List<string> imuneSystemLog = new List<string>();
            List<string> knownViruses = new List<string>();
            int maxHealth = int.Parse(Console.ReadLine());
            int currentHealth = maxHealth;

            string command = Console.ReadLine();

            while (command != "end" && currentHealth > 0)
            {
                string virusName = command;
                int virusStrenght = command.Sum(x => x);
                virusStrenght /= 3;
                int defeatTimeSeconds = virusStrenght * virusName.Length;
               

                defeatTimeSeconds =
                    knownViruses.Contains(virusName) ?
                    defeatTimeSeconds / 3 :
                    defeatTimeSeconds;
                currentHealth -= defeatTimeSeconds;

                if (currentHealth <= 0)
                {
                    imuneSystemLog.Add($"Virus {virusName}: {virusStrenght} => {defeatTimeSeconds} seconds");
                    continue;
                }

                string defeatTime = CalcDefeatTime(defeatTimeSeconds);

                knownViruses.Add(virusName);

                string result = $"Virus {virusName}: {virusStrenght} => {defeatTimeSeconds} seconds\n";
                result += $"{virusName} defeated in {defeatTime}.\n";
                result += $"Remaining health: {currentHealth}";

                imuneSystemLog.Add(result);
                currentHealth =
                    (int)(currentHealth * 1.2) > maxHealth ?
                    maxHealth :
                    (int)(currentHealth * 1.2);
                command = Console.ReadLine();
            }

            foreach (var entry in imuneSystemLog)
            {
                Console.WriteLine(entry);
            }
            Console.WriteLine(
                currentHealth < 0 ?
                "Immune System Defeated." :
                $"Final Health: {currentHealth}");
        }

        static string CalcDefeatTime(int defeatTimeSeconds)
        {
            string result = (defeatTimeSeconds / 60) + "m ";
            result += (defeatTimeSeconds % 60) + "s";
            return result;
        }
    }
}