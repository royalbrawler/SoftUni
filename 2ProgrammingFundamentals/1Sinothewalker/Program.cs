using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1Sinothewalker
{
    class Program
    {
        static void Main(string[] args)
        {
            string parse = Console.ReadLine();
            var inputTime = DateTime.ParseExact(parse, "HH:mm:ss", CultureInfo.InvariantCulture);

            ulong steps = ulong.Parse(Console.ReadLine());
            ulong secondsPerStep = ulong.Parse(Console.ReadLine());

            ulong totalSecs = steps * secondsPerStep;

            ulong mins = totalSecs / 60;
            ulong hours = mins / 60;

            ulong secs = totalSecs % 60;
            mins = mins % 60;
            hours = hours % 24;

            inputTime = inputTime
                .AddHours(hours)
                .AddMinutes(mins)
                .AddSeconds(secs);

            Console.WriteLine("Time Arrival: " + inputTime.ToString("HH:mm:ss"));
        }
    }
}
