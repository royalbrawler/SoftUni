using System;
using System.Collections.Generic;
using System.Linq;

namespace Exc_TruckTour
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            var que = new Queue<int[]>();

            for (int i = 0; i < n; i++)
            {
                var pump = Console.ReadLine().Split().Select(int.Parse).ToArray();
                que.Enqueue(pump);
            }

            for (int startPump = 0; startPump < n - 1; startPump++)
            {
                int fuel = 0;
                bool canPass = true;

                for (int pumpsPassed = 0; pumpsPassed < n; pumpsPassed++)
                {
                    var currentPump = que.Dequeue();
                    int pumpFuel = currentPump[0];
                    int distance2next = currentPump[1];
                    que.Enqueue(currentPump);

                    fuel += pumpFuel - distance2next;
                    if (fuel < 0)
                    {
                        startPump += pumpsPassed;
                        canPass = false;
                        break;
                    }
                }
                if (canPass)
                {
                    Console.WriteLine(startPump);
                    Environment.Exit(0);
                }
            }
        }
    }
}