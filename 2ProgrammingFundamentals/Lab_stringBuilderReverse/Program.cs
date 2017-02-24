using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_stringBuilderReverse
{
    class Program
    {
        static void Main(string[] args)
        {
            string ww = "asdasdasdasdasd";
            Console.WriteLine(ReverseString(ww));

        }
        public static string ReverseString(string s)
        {
            StringBuilder sb = new StringBuilder();
            for (int i = s.Length - 1; i >= 0; i--)
            {
                sb.Append(s[i]);
            }

            return sb.ToString();
        }
    }
}
