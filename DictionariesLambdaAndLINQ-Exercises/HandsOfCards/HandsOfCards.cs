using System;
using System.Collections.Generic;
using System.Linq;

namespace HandsOfCards
{
    class HandsOfCards
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<string>> players = new Dictionary<string, List<string>>();
            string[] hand = Console.ReadLine().Split(":, ".ToCharArray(), StringSplitOptions.RemoveEmptyEntries);
            List<string> cards = new List<string>();
            string name = "";
            int sum = 0;

            while (hand[0] != "JOKER")
            {
                name = hand[0];
                cards = hand.Skip(1).ToList();
                cards = cards.Distinct().ToList();
                if (players.ContainsKey(name) == false)
                {
                    players.Add(name, cards);
                }
                else
                {
                    players[name].AddRange(cards);
                    players[name] = players[name].Distinct().ToList();
                }
                hand = Console.ReadLine().Split(":, ".ToCharArray(), StringSplitOptions.RemoveEmptyEntries);
            }

            int multiplyer = 0;
            int mainValue = 0;
            foreach (var player in players)
            {
                foreach (var card in player.Value)
                {
                    switch (card[card.Length - 1])
                    {
                        case 'S':
                            multiplyer = 4;
                            break;
                        case 'H':
                            multiplyer = 3;
                            break;
                        case 'D':
                            multiplyer = 2;
                            break;
                        case 'C':
                            multiplyer = 1;
                            break;
                    }
                    char[] curr = card.Reverse().Skip(1).ToArray();
                    switch (curr[0])
                    {
                        case 'J':
                            mainValue = 11;
                            break;
                        case 'Q':
                            mainValue = 12;
                            break;
                        case 'K':
                            mainValue = 13;
                            break;
                        case 'A':
                            mainValue = 14;
                            break;
                        case '1':
                            mainValue = 10;
                            break;
                        case '2':
                            mainValue = 2;
                            break;
                        case '3':
                            mainValue = 3;
                            break;
                        case '4':
                            mainValue = 4;
                            break;
                        case '5':
                            mainValue = 5;
                            break;
                        case '6':
                            mainValue = 6;
                            break;
                        case '7':
                            mainValue = 7;
                            break;
                        case '8':
                            mainValue = 8;
                            break;
                        case '9':
                            mainValue = 9;
                            break;
                    }
                    sum += multiplyer * mainValue;
                }
                Console.WriteLine($"{player.Key}: {sum}");
                sum = 0;
            }
        }
    }
}
