using System;
using System.Collections.Generic;
using System.Linq;

namespace Exc_BasicQueueOperations
{
    class Program
    {
        static void Main(string[] args)
        {
            var conditions = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            var input = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            Queue<int> que = new Queue<int>(input);

            for (int i = 0; i < conditions[1]; i++)
            {
                que.Dequeue();
            }

            if (!que.Any())
            {
                Console.WriteLine(0);
                return;
            }

            if (que.Contains(conditions[2]))
                Console.WriteLine("true");
            else
                Console.WriteLine(que.Min());
        }
    }
}
