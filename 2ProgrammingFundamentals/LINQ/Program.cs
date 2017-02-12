using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ
{
    class Program
    {
        static void Main(string[] args)
        {
            var nums = new List<int> { 1, 2, 3, 4, 5, 6 };

            var result = nums
                .Where(n => n % 2 == 0)
                .ToList();
            foreach (var item in result)
            {
                Console.WriteLine(item);
            }

            var c = nums
                .Count(n => n > 5 && n < 7); // counts how many items are there in n > 5 && n < 7
            Console.WriteLine(c);

            // there are more...
        }
    }
}
