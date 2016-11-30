using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication6
{
    class Program
    {
        static void Main(string[] args)
        {
            var num = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter score: " + num);
            double bonus = 0;

            if (num % 2 == 0)
                bonus += 1;
            if (num % 10 == 5)
                bonus += 2;

            if (num <= 100)
                bonus += 5;
            else if (num > 100 && num <= 1000)
                bonus += (num * 0.2);
            else if (num > 1000)
                bonus += (num * 0.1);
            Console.WriteLine("Bonus score: {0}\nTotal score: {1}" ,bonus, num + bonus);


        }
    }
}
