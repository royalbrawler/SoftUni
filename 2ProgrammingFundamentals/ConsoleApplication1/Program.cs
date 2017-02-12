using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {

        static void Main(string[] args)
        {
            int[] numbs = new int[10];
            for (int i = 0; i < numbs.Length; i++)
            {
                numbs[i] += i;
                Console.WriteLine(numbs[i]);
            }
            Console.WriteLine(numbs[10]); // crash

        }
    }
}
