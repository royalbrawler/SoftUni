using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaxSeqOfEqualElements
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            //int[] input = new int[] { 1, 1, 2, 2, 2, 3, 4, 5 };
            
            int lenght = 1;
            int numb = 0;
            int bestLenght = 1;

            for (int pos = 1; pos < input.Length ; pos++)
            {
                if (input[pos] == input[pos - 1])
                {
                    lenght++;
                    if (lenght > bestLenght)
                    {
                        bestLenght = lenght;
                        numb = input[pos];
                    }
                }
                else
                {
                    lenght = 1;
                }
            }

            for (int i = 0; i < bestLenght; i++)
            {
                Console.Write(numb + " ");
            }
        }
    }
}
