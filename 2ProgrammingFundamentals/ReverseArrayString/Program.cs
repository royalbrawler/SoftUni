using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReverseArrayString
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] arr = Console.ReadLine().Split(' ');
            // 1 2 3 4
            for (int i = 0; i < arr.Length / 2; i++) // loop to half of the string! (/2)
            {
                string temp = arr[i];
                arr[i] = arr[arr.Length - 1 - i];
                arr[arr.Length - 1 - i] = temp;
            }
            // 4 3 2 1
            string hardWay = string.Join(" ", arr);

            // easy way - INTS
            int[] items = { 1, 2, 3, 4 };
            var reversedEZway = items.Reverse();

            Console.WriteLine(hardWay);
            Console.WriteLine(string.Join("", reversedEZway));

        }
    }
}
