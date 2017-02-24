using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace regex11
{
    class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"\d{4}-\d{2}-\d{2}";
            Regex regex = new Regex(pattern);

            string text = "Today is 2016-11-10. yet another day 2018-20-20";

            bool daesItMatch = regex.IsMatch(text); // does it have it
            Match getMatch = regex.Match(text); // get the data - only first match
            MatchCollection matches = regex.Matches(text); // get all the matches

            Console.WriteLine(daesItMatch);
            Console.WriteLine(getMatch);
            Console.WriteLine(matches[1] + "\n");

            foreach (var item in matches)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("---------------- nakov example -- with Groups[]");

            string text2 = "Nakov: 123";
            string pattern2 = @"([A-Z][a-z]+): (\d+)";
            Regex regex2 = new Regex(pattern2);
            Match match = regex2.Match(text2);

            Console.WriteLine(match.Groups.Count); // 3
            Console.WriteLine("Matched text: \"{0}\"", match.Groups[0]); // group[0] is all regex groups
            Console.WriteLine("Name: {0}", match.Groups[1]); // Nakov
            Console.WriteLine("Number: {0}", match.Groups[2]); // 123

        }
    }
}
