using System;

namespace ExperimentsHERE
{
    class Program
    {
        static void Main(string[] args)
        {
            int magnol = int.Parse(Console.ReadLine());
            double triTona = 0;
            double fourTona = 0;
            double twelveTona = 0;

            for (int i = 0; i < magnol; i++)
            {
                double asd = double.Parse(Console.ReadLine());
                if (asd <= 3)
                {
                    triTona += asd;
                }
                else if (asd > 3 && asd <= 11)
                {
                    fourTona += asd;
                }
                else
                {
                    twelveTona += asd;
                }
            }
            double Tonove = triTona + fourTona + twelveTona;
            double srednaCena = ((triTona * 200) + (fourTona * 175) + (twelveTona * 120)) / Tonove;
            Console.WriteLine("{0:F2}", srednaCena);
            Console.WriteLine("{0:F2}%", triTona / Tonove * 100);
            Console.WriteLine("{0:F2}%", fourTona / Tonove * 100);
            Console.WriteLine("{0:F2}%", twelveTona / Tonove * 100);
        }
    }
}
