using System;
using System.Collections.Generic;

namespace TrafficJam
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            var input = Console.ReadLine();
            int passedCount = 0;
            var queue = new Queue<string>();
            while (input != "end")
            {
                if (input == "green")
                {
                    var carsThatCanPass = Math.Min(queue.Count, n); // no cars problem fix
                    for (int i = 0; i < carsThatCanPass; i++)
                    {
                        Console.WriteLine($"{queue.Dequeue()} passed!");
                        passedCount++;
                    }
                }
                else
                {
                    queue.Enqueue(input);
                }
                input = Console.ReadLine();
            }
            Console.WriteLine($"{passedCount} cars passed the crossroads.");
        }
    }
}
