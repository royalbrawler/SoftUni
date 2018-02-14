using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace decimalToBinary
{
    class Program
    {
        static void Main(string[] args)
        {
            var inputDecimal = int.Parse(Console.ReadLine()); // 1024
            var stack = new Stack<int>();
            if (inputDecimal == 0)
            {
                Console.WriteLine("0");
            }
            while (inputDecimal > 0)
            {
                stack.Push(inputDecimal % 2);
                inputDecimal = inputDecimal / 2;                
            }

            while (stack.Count > 0)
            {
                Console.Write(stack.Pop());
            }

        }
    }
}
