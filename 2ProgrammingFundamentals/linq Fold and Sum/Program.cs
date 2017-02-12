using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace linq_Fold_and_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToArray();

            int k = numbers.Length / 4;

            var firstRowLeft = numbers
                .Take(k)
                .Reverse()
                .ToArray();
            var firstRowRight = numbers
                .Reverse()
                .Take(k)
                .ToArray();

            var firstRow = firstRowLeft
                .Concat(firstRowRight)
                .ToArray();
            var secondRow = numbers
                .Skip(k)
                .Take(k * 2)
                .ToArray();

            // var result =
            firstRow
                .Zip(secondRow, (x, y) => x + y)
                .ToList()
                .ForEach(Console.WriteLine); // zip - if they are equal lenghts

            var result2 = firstRow
                .Select((n, index) => n + secondRow[index]);

            // or just use a - for cycle
        }
    }
}
