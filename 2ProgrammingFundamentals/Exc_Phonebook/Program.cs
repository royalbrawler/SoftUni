using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exc_Phonebook
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> phonebook = new Dictionary<string, string>();


            string commnadLine = Console.ReadLine(); // A Nakov 087918971987

            while (!commnadLine.Equals("END"))
            {
                string[] commandArgs = commnadLine.Split();

                string command = commandArgs[0];// first element ? A, S

                if (command.Equals("A"))
                {
                    //add
                    string contact = commandArgs[1];
                    string number = commandArgs[2];

                    //phonebook.Add(contact, number);
                    phonebook[contact] = number;
                }
                else if (command.Equals("S"))
                {
                    //search
                    string contact = commandArgs[1];
                    if (phonebook.ContainsKey(contact))
                    {
                        Console.WriteLine($"{contact} -> {phonebook[contact]}");
                    }
                    else
                    {
                        Console.WriteLine("Contact {0} does not exist.", contact);
                    }
                }
                else if (command.Equals("ListAll")) // Upgraded dictionary exercise
                {
                    // print all
                    foreach (var item in phonebook.OrderBy(x => x.Key)) // order by key - a b c
                    {
                        Console.WriteLine("{0} -> {1}", item.Key, item.Value);
                    }
                }

                commnadLine = Console.ReadLine();
            }
        }
    }
}
