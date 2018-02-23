using System;
using System.Collections.Generic;
using System.Linq;

namespace Exc_MaximumElement
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack<int> stack = new Stack<int>();
            Stack<int> maxStack = new Stack<int>();

            maxStack.Push(int.MinValue);

            int commandsCount = int.Parse(Console.ReadLine());

            for (int i = 0; i < commandsCount; i++)
            {
                var command = Console.ReadLine().Split().Select(int.Parse).ToArray();

                switch (command[0])
                {
                    case 1:
                        var element = command[1];
                        stack.Push(element);
                        if (element >= maxStack.Peek())
                        {
                            maxStack.Push(element);
                        }
                        break;
                    case 2:
                        var popped = stack.Pop();
                        if (maxStack.Peek() == popped)
                        {
                            maxStack.Pop();
                        }
                        break;
                    case 3:
                        Console.WriteLine(maxStack.Peek());
                        break;
                }
            }


        }
    }
}
