using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace largerstCommonEnd
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(' ');
            string[] input2 = Console.ReadLine().Split();

            int scanLeftToRight = 0;
            int scanRL = ScanRightL(input, input2); // tuka se opleskva
            ScanLeftR(input, input2, out scanLeftToRight); 
            

            if (scanLeftToRight == 0 && scanRL == 0)
                Console.WriteLine(0);
            else if (scanLeftToRight > scanRL)
                Console.WriteLine(scanLeftToRight);
            else
                Console.WriteLine(scanRL);

        }
        private static int ScanRightL(string[] input, string[] input2)
        {
            int count = 0;
            if (input.Length > input2.Length)
            {
                int biggestIndx = input.Length - 1;
                for (int i = input2.Length - 1; i >= 0; i++)
                {
                    if (input[biggestIndx] == input2[i])
                    {
                        count++;
                    }
                    biggestIndx--;
                }
            }
            else
            {
                int biggestIndx = input2.Length - 1;
                for (int i = input.Length - 1; i >= 0; i--)
                {
                    if (input2[biggestIndx] == input[i])
                    {
                        count++;
                    }
                    biggestIndx--;
                }
            }

            return count;
        }


        private static void ScanLeftR(string[] input, string[] input2, out int scanLeftToRight)
        {
            int min = Math.Min(input.Length, input2.Length);
            scanLeftToRight = 0;
            for (int i = 0; i < min; i++)
                if (input[i] == input2[i])
                    scanLeftToRight++;
        }
    }
}
