using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exc_handsOfCards
{
    class HandOfCards
    {
        public static void Main()
        {
            var cardsPower = power();
            var cardsType = type();

            var cards = new Dictionary<string, HashSet<int>>();

            var line = Console.ReadLine();

            while (line != "JOKER")
            {
                var tokens = line.Split(':');
                var name = tokens[0];
                var playerCards = tokens[1].Split(", ".ToCharArray(), StringSplitOptions.RemoveEmptyEntries);

                foreach (var card in playerCards)
                {
                    var cardPower = card.Substring(0, card.Length - 1);
                    var cardType = card.Substring(card.Length - 1);
                    var sum = cardsPower[cardPower] * cardsType[cardType];

                    if (!cards.ContainsKey(name))
                    {
                        cards[name] = new HashSet<int>();
                    }
                    cards[name].Add(sum);
                }
                line = Console.ReadLine();
            }


            foreach (var player in cards)
            {
                var name = player.Key;
                var cardsSum = player.Value.Sum();

                Console.WriteLine($"{name}: {cardsSum}");
            }

        }
        public static Dictionary<string, int> power()
        {
            Dictionary<string, int> power = new Dictionary<string, int>();

            power.Add("2", 2);
            power.Add("3", 3);
            power.Add("4", 4);
            power.Add("5", 5);
            power.Add("6", 6);
            power.Add("7", 7);
            power.Add("8", 8);
            power.Add("9", 9);
            power.Add("10", 10);
            power.Add("J", 11);
            power.Add("Q", 12);
            power.Add("K", 13);
            power.Add("A", 14);

            return power;
        }
        public static Dictionary<string, int> type()
        {
            Dictionary<string, int> type = new Dictionary<string, int>();

            type.Add("S", 4);
            type.Add("H", 3);
            type.Add("D", 2);
            type.Add("C", 1);


            return type;
        }

    }
}