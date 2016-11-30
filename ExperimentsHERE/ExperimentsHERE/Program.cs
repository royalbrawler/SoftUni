using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExperimentsHERE
{
    class Program
    {
        static void Main(string[] args)
        {
            int hour = int.Parse(Console.ReadLine());
            int minutes = int.Parse(Console.ReadLine());
            minutes += 15;

            if (minutes >= 60)
            {
                hour++;
                minutes -= 60;
            }
            if (hour >= 24)
            {
                hour -= 24;
            }

            if (minutes < 10)
                Console.WriteLine(hour + ":0" + minutes);
            else
                Console.WriteLine(hour + ":" + minutes);
        }
    }
}
