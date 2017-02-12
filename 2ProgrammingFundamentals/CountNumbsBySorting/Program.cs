using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CountNumbsBySorting
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> nums = Console.ReadLine().Trim().Split(' ').Select(int.Parse).ToList(); ;
            nums.Sort();
            var pos = 0;
            while (pos < nums.Count)
            {
                int num = nums[pos], count = 1;

                while (pos + count < nums.Count && nums[pos + count] == num)
                {
                    count++;
                }

                pos = pos + count;

                Console.WriteLine($"{num} -> {count}");
            }
        }
    }
}
