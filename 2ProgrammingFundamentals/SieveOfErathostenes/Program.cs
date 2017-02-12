using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SieveOfErathostenes
{
    class Program
    {
        static void Main(string[] args)
        {
            int inpuit = int.Parse(Console.ReadLine());
            // FAST and SLOW - primes checker

            Fast(inpuit);
            //Slow(inpuit);
        }

        static void Fast(int n)
        {
            bool[] primes = new bool[n + 1];

            for (int i = 0; i <= n; i++)
            {
                primes[i] = true;
            }
            primes[0] = primes[1] = false;

            for (int p = 2; p <= n; p++)
            {
                if (primes[p] == true)
                {
                    Console.WriteLine(p);

                    for (int j = 2; j <= n; j++)
                    {
                        if (j * p <= n && j * p >= 0) //bc it cant fit in int
                        {
                            primes[j * p] = false;
                        }
                    }
                }
            }
        }

        static void Slow(int n)
        {
            for (int i = 2; i < n; i++)
            {
                if (isPrime(i))
                {
                    Console.WriteLine(i);
                }
            }
        }

        static bool isPrime(int num)
        {
            for (int i = 2; i < num; i++)
            {
                if (num % i == 0)
                {
                    return false;
                }
            }
            return true;
        }
    }
}
