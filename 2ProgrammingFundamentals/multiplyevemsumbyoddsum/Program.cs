using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace multiplyevemsumbyoddsum
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(GetMultipleSum(-12345));
            Console.WriteLine(SumEven(-12345));
            Console.WriteLine(SumOdd(12345));
        }

        private static int GetMultipleSum(int shit)
        {
            return Math.Abs(SumOdd(shit) * SumEven(shit));
        }

        private static int SumEven(int passnum)
        {
            int result = 0;
            passnum = Math.Abs(passnum);
            while (passnum > 0)
            {
                if (passnum % 2 == 0)
                {
                    result += passnum % 10;
                }
                passnum = passnum / 10;
            }
            return result;
            //return Sum(passnum, 0);
        }

        private static int SumOdd(int passnum)
        {
            //int result = 0;
            //while (passnum > 0)
            //{
            //    if (passnum % 2 != 0)
            //    {
            //        result += passnum % 10;
            //    }
            //    passnum = passnum / 10;
            //}
            //return result;
            passnum = Math.Abs(passnum);
            return Sum(passnum, 1);
        }
        private static int Sum(int passnum, int ss)
        {
            int result = 0;            
            foreach (var item in passnum.ToString())    
            {
                var digit = item - '0';
                if (digit % 2 == ss)
                {
                    result += digit;
                }
            }
            return result;
        }
    }
}
