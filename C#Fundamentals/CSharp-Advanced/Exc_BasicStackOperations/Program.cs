using System;
using System.Collections.Generic;
using System.Linq;

namespace Exc_BasicStackOperations
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack<int> stack = new Stack<int>();

            var argz = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            Console.ReadLine()
                .Split(new char[] { ' ' })
                .ToList()
                .ForEach(num => stack.Push(int.Parse(num)));

            for (int i = 0; i < argz[1]; i++)
            {
                stack.Pop();
            }

            if (!stack.Any())
            {
                Console.WriteLine("0");
            }
            else
            {
                if (stack.Contains(argz[2]))
                    Console.WriteLine("true");
                else
                    Console.WriteLine(stack.Min());
            }


        }
    }
}
