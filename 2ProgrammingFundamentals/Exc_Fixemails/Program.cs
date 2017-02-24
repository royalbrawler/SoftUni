using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exc_Fixemails
{
    class Program
    {
        static void Main(string[] args)
        {
            var emailAdresses = new Dictionary<string, string>();
            var line = Console.ReadLine();

            while (line != "stop")
            {
                var name = line;
                var email = Console.ReadLine();

                
                emailAdresses[name] = email;

                line = Console.ReadLine();
            }

            var fixedEMails = emailAdresses.Where(x => !x.Value.EndsWith("us", StringComparison.OrdinalIgnoreCase) && !x.Value.ToLower().EndsWith("uk"))
                .ToDictionary(p => p.Key, p => p.Value); //tringComparison.OrdinalIgnoreCase == to lower?

            foreach (var item in fixedEMails)
            {
                Console.WriteLine($"{item.Key} -> {item.Value}");
            }
            
        }
    }
}
