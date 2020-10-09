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
            string String1 = "1234567890808080";
            string String2= "1234567890808080";
           
            char[] MyChar1 = String1.ToCharArray();
            char[] MyChar2 = String2.ToCharArray();
            MyString ms1 = new MyString(MyChar1);
            MyString ms2 = new MyString(MyChar2);

            if (ms1 == null)
            {
            ms1 = new MyString(MyChar2);             
            }
            char[] ResultChar = ms1 + ms2;
             Console.WriteLine("после сложения строк {0} и {1} получилась строка {2}",
                                    String1,String2,CharArrayToString(ResultChar));
       
            ResultChar = ms1 - ms2;
            Console.WriteLine("после вычитания из строки {0} строки {1} получилась строка {2}",
                                    String1, String2, CharArrayToString(ResultChar));      
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
        private static string CharArrayToString(char[] CharArray)
        {
            string resultString = "";
            for (int i=0;i<CharArray.Length;i++)
            {
                resultString += CharArray[i];
            }
            return resultString;
        }
    }
}
