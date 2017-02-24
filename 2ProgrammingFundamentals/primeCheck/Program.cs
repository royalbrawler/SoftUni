using System;

namespace primeCheck
{
    class Program
    {
        static void Main(string[] args)
        {
            int MaxCheck = int.Parse(Console.ReadLine());
            for (int NumTOcheck = 0; NumTOcheck <= MaxCheck; NumTOcheck++)
            {
                bool isPrime = true;
                for (int checker = 2; checker <= Math.Sqrt(NumTOcheck); checker++) // actual checker
                {
                    if (NumTOcheck % checker == 0)
                    {
                        isPrime = false;
                        break;
                    }
                }
                Console.WriteLine($"{NumTOcheck} -> {isPrime}");
            }
        }
    }
}
