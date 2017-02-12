using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace maxSeqEqualElementsLISTS
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] inputNumbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            List<int> longestSubseq = new List<int>();
            List<int> currentSubseq = new List<int>();

            currentSubseq.Add(inputNumbers[0]);

            for (int i = 1; i < inputNumbers.Length; i++)
            {
                if (inputNumbers[i] == currentSubseq[0])
                {
                    currentSubseq.Add(inputNumbers[i]);
                }
                else
                {
                    if (currentSubseq.Count > longestSubseq.Count)
                    {
                        longestSubseq.Clear(); // clears the list (make a brand new one*?)
                        for (int j = 0; j < currentSubseq.Count; j++) //longestSubseq.AddRange(currentSubseq); SHORTER
                        {
                            longestSubseq.Add(currentSubseq[j]);
                        }
                    }

                    currentSubseq.Clear();
                    currentSubseq.Add(inputNumbers[i]);
                }
            }

            if (currentSubseq.Count > longestSubseq.Count)
            {
                longestSubseq.Clear(); // clears the list (make a brand new one*?)
                longestSubseq.AddRange(currentSubseq);
            }

            Console.WriteLine(string.Join(" ", longestSubseq));

        }
    }
}
