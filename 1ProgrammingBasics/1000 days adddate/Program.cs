using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1000_days_adddate
{
    class Program
    {
        static void Main(string[] args)
        {
            String dateInput = Console.ReadLine();
            DateTime userDate = DateTime.ParseExact(dateInput, "dd-MM-yyyy", null);
            Console.WriteLine(userDate.AddDays(999).ToString("dd-MM-yyyy"));
        }
    }
}
