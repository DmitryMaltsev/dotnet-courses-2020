using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
    public class MyString
    {
        public string MyWord;
        public MyString(string word)
        {
            MyWord = word;
        }
        public static string operator +(MyString myString1, MyString myString2)
        {
            return myString1.MyWord + myString2.MyWord;
        }

        public static string operator -(MyString myString1, MyString myString2)
        {
            bool compareStrings = myString1.MyWord.Contains(myString2.MyWord);
            string resultString = "";
            if (compareStrings)
            {
                int index = myString1.MyWord.IndexOf(myString2.MyWord, 0);
                resultString = myString1.MyWord.Remove(index, myString2.MyWord.Length);
                Console.WriteLine("После вычитания из строки {0} строки {1} получилась строка {2}", myString1.MyWord, myString2.MyWord, resultString);
            }
            else
            {
                Console.WriteLine("Строка {0} не содержит в себе строку {1}",
                                            myString1.MyWord, myString2.MyWord);
            }
            return resultString;
        }
        public static bool operator ==(MyString myString1, MyString myString2)
        {
            bool equals;
            if (myString1.MyWord == myString2.MyWord)
            {
                equals = true;
            }
            else
            {
                equals = false;
            }
            return equals;
        }
        public static bool operator !=(MyString myString1, MyString myString2)
        {
            bool nonEquals;
            if (myString1.MyWord == myString2.MyWord)
            {
                nonEquals = true;
            }
            else
            {
                nonEquals = false;
            }
            return nonEquals;
        }
        public override string ToString()
        {
            return MyWord;
        }
    }
 }
