using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_Count_substring_occurrences
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine().ToLower();  // ababa caba
            string pattern = Console.ReadLine().ToLower(); // aba
            int counter = 0;

            int index = text.IndexOf(pattern); 

            while (index != -1)
            {
                counter++;
                index = text.IndexOf(pattern, index + 1);
            }
            Console.WriteLine(counter); //3

        }
    }
}
