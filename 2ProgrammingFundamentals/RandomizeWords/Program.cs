using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RandomizeWords
{
    class Program
    {
        static void Main(string[] args)
        {
            var word = Console.ReadLine()
                .Split();

            var random = new Random();

            for (int i = 0; i < word.Length; i++)
            {
                var currentWord = word[i];
                var randomIndex = random.Next(0, word.Length);

                var tempWord = word[randomIndex];
                word[i] = tempWord;
                word[randomIndex] = currentWord;
            }
        }
    }
}
