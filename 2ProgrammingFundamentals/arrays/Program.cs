using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var k = int.Parse(Console.ReadLine());


            var arr = new BigInteger[n];
            arr[0] = 1;
            for (int i = 1; i < n; i++)
            {
                BigInteger sum = 0;
                for (int prev = i - k; prev <= i - 1; prev++)
                    if (prev >= 0)
                        sum += arr[prev];
                arr[i] = sum;
            }
            for (int i = 0; i < n; i++)
                Console.Write(arr[i] + " ");
        }
    }
}
