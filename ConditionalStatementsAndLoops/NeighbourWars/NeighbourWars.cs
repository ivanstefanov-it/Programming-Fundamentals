using System;

namespace NeighbourWars
{
    class Program
    {
        static void Main(string[] args)
        {
            int peshosDamage = int.Parse(Console.ReadLine());
            int goshosDamage = int.Parse(Console.ReadLine());
            int peshosHealt = 100;
            int goshosHealt = 100;
            string peshosAttack = "Roundhouse kick";
            string goshosAttack = "Thunderous fist";
            int rounds = 0;
            
            while (peshosHealt > 0 && goshosHealt > 0)
            {
                rounds++;

                if (rounds % 2 != 0)
                {
                    goshosHealt = goshosHealt - peshosDamage;
                    if (goshosHealt > 0)
                    {
                        Console.WriteLine($"Pesho used {peshosAttack} and reduced " +
                       $"Gosho to {goshosHealt} health.");
                    }
                }
                else
                {
                    peshosHealt = peshosHealt - goshosDamage;
                    if (peshosHealt > 0)
                    {
                        Console.WriteLine($"Gosho used {goshosAttack} and reduced " +
                       $"Pesho to {peshosHealt} health.");
                    }
                }
                if (rounds % 3 == 0 && peshosHealt > 0 && goshosHealt > 0)
                {
                    goshosHealt += 10;
                    peshosHealt += 10;
                }
            }
            if (goshosHealt <= 0)
            {
                Console.WriteLine($"Pesho won in {rounds}th round.");
            }
            else
            {
                Console.WriteLine($"Gosho won in {rounds}th round.");

            }

        }
    }
}
