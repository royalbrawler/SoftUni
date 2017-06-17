using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace exam
{
    class Program
    {
        static string r = string.Empty;
        static string w = string.Empty;

        static void Main(string[] args)
        {

            //foreach (var item in fortunes)
            //{
            //    File.AppendAllText("output.txt", item + Environment.NewLine);
            //}
            var authorlist = new List<string>();
            var filteredAuthorList = authorlist.Distinct();
            var quotelist = new List<string>();
            var filteredquoteList = quotelist.Distinct().Where(q => q.Length > 50);

            for (int i = 1; i < 1207; i++)
            {
                GetQuote(i);
                if (w == "")
                    quotelist.Add(r);

                //if (!r.Equals(""))
                //{

                //    //File.AppendAllText("output.txt", $"quotes.add(new Quotes(\"{r}\", \"{w}\"));" + Environment.NewLine);
                //    //File.AppendAllText("output.txt", $"{r} === {w}" + Environment.NewLine);
                //}
            }
            int counter = 0;
            string google = "http://google.com/search?q=";
            foreach (var item in filteredquoteList)
            {
                Console.WriteLine(filteredquoteList.Count());
                counter++;
                Console.WriteLine(item);
                Console.WriteLine(counter);
                var asd = Console.ReadLine();
                if (asd == "asd")
                {
                    System.Diagnostics.Process.Start(google + item);
                    Console.ReadLine();
                }
                else
                {
                    Console.Clear();
                    continue;
                }
                Console.Clear();
            }
            //File.WriteAllLines("authorList.txt", filteredAuthorList);

        }
        public void GetQuote(int i)
        {

        }
    }
}

