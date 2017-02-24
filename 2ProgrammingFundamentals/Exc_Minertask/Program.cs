using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exc_Minertask
{
    class Program
    {
        static void Main(string[] args)
        {
            var resources = new Dictionary<string, decimal>();

            var line = Console.ReadLine(); // GOld silver
            while (!line.Equals("stop"))
            {
                var resource = line;
                var quantity = decimal.Parse(Console.ReadLine()); // 100 155

                if (!resources.ContainsKey(resource)) // notice !
                {
                    resources[resource] = 0;
                }

                resources[resource] += quantity;

                line = Console.ReadLine();
            }

            foreach (var item in resources)
            {
                Console.WriteLine($"{item.Key} -> {item.Value}");
            }

        }
    }
}
