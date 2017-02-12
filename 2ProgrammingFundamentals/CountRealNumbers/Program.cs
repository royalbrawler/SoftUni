using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CountRealNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = Console.ReadLine()
                .Split(' ')
                .Select(double.Parse); // 8 2.5 2.5 8 2.5

            var result = new SortedDictionary<double, int>();

            foreach (var item in numbers)
            {
                if (!result.ContainsKey(item)) 
                {
                    result[item] = 0;
                }
                result[item]++;
            }

            foreach (var item in result)
            {
                Console.WriteLine($"{item.Key} -> {item.Value}");
            }
        }
    }
}
