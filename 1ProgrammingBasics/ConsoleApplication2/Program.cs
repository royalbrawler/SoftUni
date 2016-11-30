using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication2
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Globalization.CultureInfo provider = System.Globalization.CultureInfo.InvariantCulture;
            String format = "dd/MM/yyyy";
            DateTime date = DateTime.ParseExact(Console.ReadLine(), format, provider);
            Console.WriteLine(date);
        }
    }
}
