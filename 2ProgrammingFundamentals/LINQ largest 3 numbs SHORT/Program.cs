using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ_largest_3_numbs_SHORT
{
    class Program
    {
        static void Main(string[] args)
        {
            var list = new List<int> { 10, 30, 15, 20, 50, 5 };

            list.OrderByDescending(n => n)
                .Take(3)
                .ToList()
                .ForEach(Console.WriteLine);

            // one line solution
            Console.ReadLine().Split(' ')
                .Select(double.Parse)
                .OrderByDescending(n => n)
                .Take(3)
                .ToList()
                .ForEach(Console.WriteLine);

        }
    }
}
