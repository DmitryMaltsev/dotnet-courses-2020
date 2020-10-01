using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            string Sentence = InputSentence();
            int[] CountSimbolsInWords=CountWordsInSentence(Sentence);
            Console.WriteLine("Среднее количество символов в слове={0}",AverageCountSimbolsInWord(CountSimbolsInWords));
        }

        private static string InputSentence()
        {
            Console.WriteLine("Введите предложение");
            string sentence = Console.ReadLine();
            return sentence;
        }
        private static int[] CountWordsInSentence(string sentence)
        {
            string[] words = sentence.Split(new Char[] {' '});      
            int[] wordsLength = new int[words.Length];
            for (int i = 0; i < words.Length; i++)
            {
                for (int j= 0; j < words[i].Length; j++)
                {
                    if (!Char.IsPunctuation(words[i][j]))
                    {
                        wordsLength[i] += 1;
                    }
                 //   Console.WriteLine(wordsLength[i]);
                }
            }
            return wordsLength;
         }

        private static int AverageCountSimbolsInWord(int[] arrayCountSimbols)
        {
            int averageCountSimbols=0;
            foreach ( var ar in arrayCountSimbols)
            {
                averageCountSimbols += ar;
            }
            averageCountSimbols = averageCountSimbols / arrayCountSimbols.Count();
            return averageCountSimbols;
        }
    }
}
            
        
    

