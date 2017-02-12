using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sum_Reversed_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] inputNums = Console.ReadLine().Split(' '); // 123 432 1122

            //one line solution
            Console.WriteLine(Console.ReadLine().Split().Select(x => int.Parse(string.Join("", x.Reverse()))).Sum());
            //one line solution

            int sumedNums = 0;

            for (int i = 0; i < inputNums.Length; i++)
            {
                string currentString = inputNums[i]; // 123

                List<char> reversedString = currentString.Reverse().ToList();
                string reversedNums = string.Join("", reversedString);

                //string reversedString = string.Join("", currentString.Reverse()); // 321
                //Console.WriteLine(reversedString);

                sumedNums += int.Parse(reversedNums);
            }

            Console.WriteLine(sumedNums);

        }
    }
}
