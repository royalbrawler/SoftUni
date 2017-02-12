using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CountNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> nums = Console.ReadLine().Trim().Split(' ').Select(int.Parse).ToList();
            var counts = new int[nums.Max() + 1];   // for  1 2 5 9 = counts[9+1]
            foreach (var num in nums)
            {
                counts[num]++;
            }

            for (int i = 0; i < counts.Length; i++) // print
                if (counts[i] > 0)
                    Console.WriteLine($"{i} -> {counts[i]}");
            

        }
    }
}
