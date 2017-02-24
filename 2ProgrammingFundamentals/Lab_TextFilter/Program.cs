using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_TextFilter
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] banWords = Console.ReadLine()
             .Split(new char[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries);

            string text = Console.ReadLine();

            foreach (var item in banWords)
            {
                if (text.Contains(item)) // you can remove the if*
                {
                    text = text.Replace(item, new string('*', item.Length));
                }
            }

            Console.WriteLine(text);
        }
    }
}
