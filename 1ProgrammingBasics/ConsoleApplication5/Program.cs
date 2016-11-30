using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication5
{
    class Program
    {
        static void Main(string[] args)
        {
            double x = double.Parse(Console.ReadLine());
            double y = double.Parse(Console.ReadLine());
            double z = double.Parse(Console.ReadLine());
            double rabotnici = double.Parse(Console.ReadLine());

            var obshtoGrozde = x * y;
            var vino = 0.4 * obshtoGrozde / 2.5;

            if (vino >= z)
            {
                Console.WriteLine($"Good harvest this year! Total wine: {Math.Floor(vino)} liters.");

                Console.WriteLine("{0} liters left -> {1} liters per person.",
                    Math.Ceiling(vino - z), Math.Ceiling((vino - z) / rabotnici));
            }
            else
            {
                Console.WriteLine("It will be a tough winter! More {0} liters wine needed.",
                    Math.Floor(z - vino));
            }


        }
    }
}
