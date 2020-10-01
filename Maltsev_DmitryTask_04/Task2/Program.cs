using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            string FirstWord = InputWord(1);
            string SecondWord = InputWord(2);         
            Console.WriteLine("Полученное выражение=" + ResultWord(FirstWord, SecondWord));

        }
        private static string InputWord(int Num)
        {
            Console.Write("Введите {0} строку = ",Num);
            string word =Console.ReadLine();
            return word;
        }
        private static string ResultWord(string firstWord, string secondWord)
        {
            StringBuilder sbFirstWord= new StringBuilder(firstWord);
            StringBuilder sbSecondWord= new StringBuilder(secondWord);
            StringBuilder sbThirdWord=new StringBuilder();
            int k = 0;
            for (int i = 0; i < sbFirstWord.Length; i++)
            {
                sbThirdWord.Append(sbFirstWord[i]);
                for (int j = 0; j < sbSecondWord.Length; j++)
                {
                    if(sbSecondWord[j]==sbFirstWord[i])
                    {
                        sbThirdWord.Append(sbFirstWord[i]);                     
                    }               
                }
            }
            return sbThirdWord.ToString();
        }
    }

}
