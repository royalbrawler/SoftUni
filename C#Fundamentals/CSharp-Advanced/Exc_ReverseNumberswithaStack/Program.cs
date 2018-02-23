using System;
using System.Collections.Generic;
using System.Linq;

namespace Exc_ReverseNumberswithaStack
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .ToList()
                .Select(int.Parse); // 1 2 3 4 5

            Stack<int> stack = new Stack<int>();

            foreach (var item in input)
            {
                stack.Push(item);
            }

            //while (stack.Count > 0)
            //{
            //    Console.Write(stack.Pop());
            //}

            Console.WriteLine(string.Join(" ", stack));
            
        }
    }
}
