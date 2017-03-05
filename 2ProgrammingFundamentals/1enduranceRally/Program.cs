using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1enduranceRally
{
    class Program
    {
        static void Main(string[] args)
        {
            var drivers = Console.ReadLine()
                .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).ToArray();

            var trackZones = Console.ReadLine()
                .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(double.Parse).ToArray();

            var checkpoints = Console.ReadLine()
                .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

            
            foreach (var driver in drivers)
            {
                var fuel = (double) driver.ToCharArray().First();

                for (int i = 0; i < trackZones.Length; i++)
                {
                    if (checkpoints.Contains(i))
                    {
                        fuel += trackZones[i];
                    }
                    else
                    {
                        fuel -= trackZones[i];
                    }
                    if (fuel <= 0)
                    {
                        Console.WriteLine(driver + " - reached " + i.ToString());
                        break;
                    }
                }
                if (fuel > 0)
                    Console.WriteLine(driver + " - fuel left " + fuel.ToString("0.00"));
            }
        }
    }
}
