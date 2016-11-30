using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace foreach1
{
    class Program
    {
        static void Main(string[] args)
        {
            var nums = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            for (int i = 0; i < nums.Length / 2; i++)
            {
                var old = nums[i];
                nums[i] = nums[nums.Length - i - 1];
                nums[nums.Length - i - 1] = old;
            }
            foreach (var item in nums)
            {
                Console.WriteLine(nums[item]);
            }
        }
    }
}
