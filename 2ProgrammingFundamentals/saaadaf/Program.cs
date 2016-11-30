using System;
using System.Linq;

namespace saaadaf
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            var count = 0;
            for (int left = 0; left < nums.Length; left++)
            {
                for (int right = left+1; right < nums.Length; right++)
                {
                    var sum = nums[left] + nums[right];
                    if (nums.Contains(sum))
                    {
                        Console.WriteLine("{0} + {1} == {2}", nums[left], nums[right], sum);
                        count++;
                    }
                }

            }
            if (count == 0)
                Console.WriteLine("No");
        }
    }
}
