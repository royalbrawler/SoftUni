using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace replaceWithRegex
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = "Nakov: 123, Branson: 456";
            string pattern = @"\d{3}";
            string replacement = "999";

            Regex regex = new Regex(pattern);
            string result = regex.Replace(text, replacement);

            Console.WriteLine(result);
            // Nakov: 999, Branson: 999

        }
    }
}
