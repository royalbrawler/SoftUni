using System;
using System.Collections.Generic;

namespace MatchingBrackets
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine(); // 1 + (2 - (2 + 3) * 4 / (3 + 1)) * 5
            var stackBrackets = new Stack<int>();
            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] == '(')
                {
                    stackBrackets.Push(i);
                }
                if (input[i] == ')')
                {
                    int opened = stackBrackets.Pop();
                    int toClosed = i - opened + 1;
                    Console.WriteLine(input.Substring(opened, toClosed));
                }
            }

        }
    }
}
