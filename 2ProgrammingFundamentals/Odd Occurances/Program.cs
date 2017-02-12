using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Odd_Occurances
{
    class Program
    {
        static void Main(string[] args)
        {
            var words = Console.ReadLine() 
                .ToLower()
                .Split(' '); //words: Java C# PHP PHP JAVA C java

            var wordCount = new Dictionary<string, int>(); // <key, value>

            foreach (var item in words)
            {
                if (!wordCount.ContainsKey(item)) // if the dict doesnt have a similar key
                {
                    wordCount[item] = 0;
                }
                wordCount[item]++; // seen the word "java" how many times++
            }

            var listResult = new List<string>();

            foreach (var word in wordCount)
            {
                if (word.Value % 2 == 0)
                {
                    listResult.Add(word.Key);
                }
            }
            Console.WriteLine(string.Join(" ,", listResult));      
        }
    }
}
