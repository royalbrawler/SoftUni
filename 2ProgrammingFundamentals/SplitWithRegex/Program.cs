using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace SplitWithRegex
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = "1   2 3      4";
            string pattern = @"\s+";

            string[] results = Regex.Split(text, pattern);
            Console.WriteLine(string.Join(", ", results)); // 1, 2, 3, 4


        }
    }
}
