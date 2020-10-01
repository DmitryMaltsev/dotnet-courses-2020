using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
    class Program
    {
        static void Main(string[] args)
        {
            MyString ms1 = new MyString("123456789");
            MyString ms2 = new MyString("3456789");
            string ResultString = ms1 - ms2;
            ResultString = ms1 + ms2;
            Console.WriteLine("после сложения строк {0} и {1} получилась строка {2}",ms1.MyWord,ms2.MyWord,ResultString);
            bool IsEqual = (ms1 == ms2);
            if(IsEqual)
            {
                Console.WriteLine("Строка {0} равна строке {1}",ms1.MyWord,ms2.MyWord);
            }
            else
            {
                Console.WriteLine("Строка {0} не равна строке {1}", ms1.MyWord, ms2.MyWord);
            }
            Console.WriteLine("Переопределённый метод ToString() выдает Myword={0}",ms1);


        }
    }
}
