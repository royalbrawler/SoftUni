using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleCalc
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine(); // 2 + 5 + 10 - 2 - 1
            var elements = input.Split(' ');
            var stack = new Stack<string>(elements.Reverse());

            while (stack.Count > 1)
            {
                int first = int.Parse(stack.Pop());
                string operat = stack.Pop();
                int second = int.Parse(stack.Pop());

                switch (operat)
                {
                    case "+":
                        stack.Push((first + second).ToString());
                        break;
                    case "-":
                        stack.Push((first - second).ToString());
                        break;
                }
            }
            Console.WriteLine(stack.Pop());

        }
    }
}
