using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exc_DragonArmy
{
    class Program
    {
        static void Main()
        {
            var dragonsArmy = new Dictionary<string, SortedDictionary<string, List<decimal>>>();
            var defaultStats = DefaultStats();

            var n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                //Initialize all needed variables
                var token = Console.ReadLine().Split(); // Here we read the input
                var type = token[0]; // This is the KEY int the dragonsArmy dictionary

                var dragonsName = token[1]; // Dragons Name
                var damage = token[2] != "null" ? decimal.Parse(token[2]) : 45;
                var health = token[3] != "null" ? decimal.Parse(token[3]) : 250;
                var armor = token[4] != "null" ? decimal.Parse(token[4]) : 10;
                //End of iniilizing

                //filling the main dictionary
                if (!dragonsArmy.ContainsKey(type))
                {
                    dragonsArmy[type] = new SortedDictionary<string, List<decimal>>();
                }

                dragonsArmy[type][dragonsName] = new List<decimal> { damage, health, armor };

                //end of filling the main dictionary
            }


            foreach (var type in dragonsArmy)
            {
                var typeName = type.Key;
                var dragonsByType = type.Value;

                var averageDamage = dragonsByType.Values.Average(a => a[0]);
                var averageHealth = dragonsByType.Values.Average(a => a[1]);
                var averageArmor = dragonsByType.Values.Average(a => a[2]);
                Console.WriteLine($"{typeName}::({averageDamage:f2}/{averageHealth:f2}/{averageArmor:f2})");

                foreach (var dragon in dragonsByType)
                {
                    var name = dragon.Key;
                    var damage = dragon.Value[0];
                    var health = dragon.Value[1];
                    var armor = dragon.Value[2];
                    Console.WriteLine($"-{name} -> damage: {damage}, health: {health}, armor: {armor}");
                }
            }

        }
        public static List<int> DefaultStats()
        {
            var defaultStats = new List<int>();

            defaultStats.Add(45);
            defaultStats.Add(250);
            defaultStats.Add(10);

            return defaultStats;
        }
    }
}
