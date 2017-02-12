using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReverseNumbs
{
    class Program
    {
        static void Main(string[] args)
        {
            //double a = double.Parse(Console.ReadLine());

            Console.WriteLine(ReverseNumbs(12.3));
            Console.WriteLine(ReverseNumbs222(12.3));
        }

        public static double ReverseNumbs(double bb)
        {
            string asd = bb.ToString();
            string ss = string.Join("", asd.Reverse());
            return double.Parse(ss);
        }
        public static double ReverseNumbs222(double bb)
        {
            string ss = bb.ToString();
            string reversedString = string.Empty;

            for (int i = ss.Length - 1; i >= 0; i--)
            {
                reversedString += ss[i];
            }
            var s = double.Parse(reversedString);
            return s;
        }
    }
}
