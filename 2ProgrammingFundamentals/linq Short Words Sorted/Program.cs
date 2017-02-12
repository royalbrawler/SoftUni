using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace linq_Short_Words_Sorted
{
    class Program
    {
        static void Main(string[] args)
        {
            // input: some big text
            Console.WriteLine(string.Join(", ",
                    Console.ReadLine()
                        .ToLower()
                        .Split(new[] { ' ', '.', ',', ':', ';', '(', ')', '[', ']', '"', '\'', '/', '\\', '!', '?' },
                            StringSplitOptions.RemoveEmptyEntries)
                        .Distinct()
                        .Where(w => w.Length < 5)
                        .OrderBy(w => w)
                        .ToList()
                ));

        }
    }
}
