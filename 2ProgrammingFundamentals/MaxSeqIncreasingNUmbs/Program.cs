using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaxSeqIncreasingNUmbs
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            //int[] input = new int[] { 1, 1, 2, 2, 2, 3, 4, 5 };

            int start = 0;
            int len = 0;
            int bestLenght = 0;

            for (int pos = 1; pos < input.Length; pos++)
            {
                if (input[pos] - input[pos - 1] >= 1)
                {
                    len++;

                    if (len > bestLenght)
                    {
                        bestLenght = len;
                        start = pos - len;
                    }
                }
                else
                {
                    len = 0;
                }
            }

            for (int i = start; i <= (start + bestLenght); i++)
            {
                Console.Write($"{input[i]} ");
            }

        }
    }
}
