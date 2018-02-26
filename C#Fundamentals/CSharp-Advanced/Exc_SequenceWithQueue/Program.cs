using System;
using System.Collections.Generic;
using System.Linq;

namespace Exc_SequenceWithQueue
{
    class Program
    {
        static void Main(string[] args)
        {
            var num = long.Parse(Console.ReadLine()); // 2

            Queue<long> sTemp = new Queue<long>();
            Queue<long> queSave = new Queue<long>();
            sTemp.Enqueue(num);
            
            while (queSave.Count < 50)
            {
                long temp = sTemp.Peek();
                queSave.Enqueue(sTemp.Dequeue());
                sTemp.Enqueue(temp + 1);
                sTemp.Enqueue(2 * temp + 1);
                sTemp.Enqueue(temp + 2);
            }

            Console.WriteLine(string.Join(" ", queSave));
        }
    }
}

