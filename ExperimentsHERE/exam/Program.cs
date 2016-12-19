using System;

namespace exam
{
    class Program
    {
        static void Main(string[] args)
        {
            int player1 = int.Parse(Console.ReadLine());
            int player2 = int.Parse(Console.ReadLine());
            int battles = int.Parse(Console.ReadLine());
            int asd = battles;
            for (int i = 1; i <= player1; i++)
            {
                for (int z = 1; z <= player2; z++)
                {
                    Console.Write($"({i} <-> {z}) ");
                    asd--;
                    if (asd <= 0)
                    {
                        break;
                    }
                }                
                if (asd <= 0)
                {
                    break;
                }
            }
        }
    }
}
