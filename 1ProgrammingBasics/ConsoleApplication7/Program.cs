using System;

namespace SOFTuni
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            var num1 = int.Parse(Console.ReadLine());
            var num2 = int.Parse(Console.ReadLine());
            var num3 = int.Parse(Console.ReadLine());

            int seconds = num1 + num2 + num3;
            int minutes = seconds / 60;
            seconds = seconds % 60;

            if (seconds < 9)
            {
                Console.WriteLine(minutes + ":0" + seconds);
            }
            else
            {
                Console.WriteLine(minutes + ":" + seconds);
            }


        }
    }
}