using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace asdaf
{
    class Program
    {
        static void Main(string[] args)
        {
            var nums = Console.ReadLine().Split(' ').Select(double.Parse).ToArray();

            for (int i = 0; i < nums.Length; i++)
            {
                int rounded = (int) Math.Round(nums[i],MidpointRounding.AwayFromZero);
                Console.WriteLine($"{nums[i]} => {rounded}");
            }
        }
    }
}
