using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringBuilde
{
    class Program
    {
        static void Main(string[] args)
        {
            // STRING MANIPULATIONs
            var time = 50000;
            var result = string.Empty;

            //slow
            Stopwatch swatch = Stopwatch.StartNew();
            for (int i = 0; i < time; i++)
            {
                result = result + i;
            }
            swatch.Stop();
            Console.WriteLine($"'+' - {swatch.Elapsed}");

            result = string.Empty;

            //fast
            swatch = Stopwatch.StartNew();
            for (int i = 0; i < time; i++)
            {
                string.Concat(result, i.ToString());
            }
            swatch.Stop();
            Console.WriteLine($"'Concat' - {swatch.Elapsed}");

            result = string.Empty;

            //fastest NOT ANYMORE
            var sb = new StringBuilder(512); // faster if capacity initiated
            swatch = Stopwatch.StartNew();
            for (int i = 0; i < time; i++)
            {
                sb.Append(i);
            }
            result = sb.ToString();
            swatch.Stop();
            Console.WriteLine($"'StringBuilder' - {swatch.Elapsed}");


        }
    }
}
