using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace isPrime
{
    class Program
    {
        static void Main(string[] args)
        {
            long candidate = long.Parse(Console.ReadLine());
            bool isPrime = isPrimee(candidate);


            Console.WriteLine(isPrime);

        }
        public static bool isPrimee(long candidate)
        {
            if (candidate == 0 || candidate == 1)
            {
                return false;
            }

            bool isPrime = true;

            for (long i = 2; i <= Math.Sqrt(candidate); i++) // math sqrt for time optimize
            {
                if (candidate % 1 == 0 && candidate % i == 0)
                {
                    isPrime = false;
                    break;
                }
            }
            return isPrime;
        }
    }
}
