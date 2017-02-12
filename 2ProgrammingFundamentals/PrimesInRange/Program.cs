using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimesInRange
{
    class Program
    {
        static void Main(string[] args)
        {
            var startNum = int.Parse(Console.ReadLine());
            var endNum = int.Parse(Console.ReadLine());

            var asd = FindPrimesInRange(startNum, endNum);

            Console.WriteLine(string.Join(", ", asd));
        }
        static List<int> FindPrimesInRange(int startNum, int end)
        {
            var primes = new List<int>();

            for (int i = startNum; i <= end; i++)
            {
                if (isPrimee(i))
                {
                    primes.Add(i);
                }
            }
            return primes;
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
