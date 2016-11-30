using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace equal_words
{
    class Program
    {
        static void Main(string[] args)
        {
            string asd = Console.ReadLine();
            string asd1 = Console.ReadLine();
            asd = asd.ToLower();
            asd1 = asd1.ToLower();

            if (asd == asd1)
            {
                Console.WriteLine("yes");
            }
            else
            {
                Console.WriteLine("no");
            }

        }
    }
}
