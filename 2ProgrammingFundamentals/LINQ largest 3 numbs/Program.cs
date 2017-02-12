using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ_largest_3_numbs
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] strings = Console.ReadLine().Split(' '); 
            //10 30 15 20 50 5

            List<int> nums = strings
                        .Select(int.Parse)
                        .ToList(); 
            var sortedNums = nums.OrderByDescending(x => x);
            var largest3Nums = sortedNums.Take(3);
            Console.WriteLine(string.Join(" ", largest3Nums));
            //50 30 20

        }
    }
}
