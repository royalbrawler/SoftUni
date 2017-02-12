using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fibbonacci
{
    class Program
    {
        static void Main(string[] args)
        {
            int f = int.Parse(Console.ReadLine());

            Console.WriteLine(Fib(f));
            Console.WriteLine(Fibonacci(f));
        }
        public static int Fib (int n)
        {
            int a = 0;
            int b = 1;
            // In N steps compute Fibonacci sequence iteratively.
            for (int i = 0; i <= n; i++)
            {
                int temp = a;
                a = b;
                b = temp + b;
            }
            return a;
        }
        public static int Fibonacci(int n)
        {
            int first = 1;
            int sec = 1;
            int fib3 = 1;
            for (int i = 1; i < n; i++)
            {
                fib3 = first + sec;
                first = sec;
                sec = fib3;
            }
            return fib3;
        }
    }
}
