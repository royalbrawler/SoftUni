using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ_oprerations
{
    class Program
    {
        static void Main(string[] args)
        {
            var list = new List<int> { 1, 2, 3, 4, -1, -5, 0, 50 };
            Console.WriteLine("Sum = {0}", list.Sum());
            Console.WriteLine("Min = {0}", list.Min());
            Console.WriteLine("Max = {0}", list.Max());
            Console.WriteLine("Average = {0}", list.Average());

        }
    }
}
