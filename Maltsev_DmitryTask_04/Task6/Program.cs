using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Task6
{
    class Program
    {
        static void Main(string[] args)
        {
           double Num = 25.3;
            string Num2 = "2.53*10^1";
            Console.WriteLine(Num);
            string ResultCommon = string.Format("{0:f}",Num);        
            string ResultExp = string.Format("{0:e}", Num);
            CountFormatOfNumber(ResultExp);
            CountFormatOfNumber(ResultCommon);
            CountFormatOfNumber(Num2);
            CountFormatOfNumber("*");
        }
        private static void CountFormatOfNumber(string Number)
        {
            int numFormat = 0;
            if (Regex.IsMatch(Number, @"\d"))
            {
                numFormat = 1;
            }

            if (Regex.IsMatch(Number, @"\de|\d\*"))
            {
                numFormat = 2;              
            }
       
            switch (numFormat)
            {
                case 1:
                    {
                        Console.WriteLine("Число {0} в обычной аннотации",Number);
                    }
                    break;
                case 2:
                    {
                        Console.WriteLine("Число {0} в научной аннотации", Number);
                    }
                    break;
                default:
                    {
                        Console.WriteLine("{0}-это не число", Number);
                    }
                    break;
            }
        }       
    }
}
