using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RotateNsum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] inputNums = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int rotateTimes = int.Parse(Console.ReadLine());

            int[] sum = new int[inputNums.Length];

            for (int i = 0; i < rotateTimes; i++)
            {
                var lastNum = inputNums[inputNums.Length - 1];
                for (int k = inputNums.Length - 1; k > 0; k--)
                {
                    inputNums[k] = inputNums[k - 1];
                }

                inputNums[0] = lastNum;

                for (int j = 0; j < inputNums.Length; j++) // 1st rotation it saves them, 2nd rotation it sums the saved
                {
                    sum[j] = sum[j] + inputNums[j];
                }
            }
            Console.WriteLine(string.Join(" ", sum));

        }
    }
}
