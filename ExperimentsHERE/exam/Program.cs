using System;

namespace exam
{
    class Program
    {
        static void Main(string[] args)
        {
            double skumria = double.Parse(Console.ReadLine());
            double caca = double.Parse(Console.ReadLine());
            double palamud = double.Parse(Console.ReadLine());
            double safrid = double.Parse(Console.ReadLine());
            double midi = double.Parse(Console.ReadLine());

            double Cenapalamud = skumria * 1.60;
            palamud *= Cenapalamud;
            double CenaSafrid = caca * 1.80;
            safrid *= CenaSafrid;
            midi = midi * 7.50;
            double cena = palamud + safrid + midi;

            Console.WriteLine(Math.Round(cena, 2));
        }
    }
}
