using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = "Here You can, 12 you find activities to practise yours reading skills. Reading will help" +
                " you to improve your Improve 12 understanding of the language you and build your vocabulary.";

            List<Word> words = CheckOnWords(text);
            foreach(Word word in words)
            {
                Console.WriteLine($"Слово {word.ThisWord} Повторяется {word.Count} раз");
            }
        }

        static List<Word> CheckOnWords(string text)
        {
            Regex reg = new Regex(@"[A-Za-z0-9]+");
            MatchCollection matches = reg.Matches(text);
            int[] countCoincidence = new int[matches.Count];
            for (int i = 0; i < matches.Count; i++)
            {
                for (int j = 0; j < matches.Count; j++)
                {
                    if (i != j)
                    {
                        if (Regex.IsMatch(matches[i].Value, matches[j].Value, RegexOptions.IgnoreCase)
                            && matches[i].Value.Count()==matches[j].Value.Count())
                        {
                            countCoincidence[i] += 1;
                        }
                    }
                } 
            }
            List<Word> words = ConvertToList(matches, countCoincidence);
            return words;
        }

        private static List<Word> ConvertToList(MatchCollection matches, int[] count)
        {
            Word w;
            List<Word> words = new List<Word>();
            for (int i = 0; i < matches.Count; i++)
            {
                if (words.Count == 0)
                {
                    w = new Word(matches[i].Value, count[i]);
                    words.Add(w);
                    i += 1;
                }
                if(count[i]==0)
                {
                    w = new Word(matches[i].Value, count[i]);
                    words.Add(w);
                }
                else
                {
                    for (int j = 0; j < words.Count; j++)
                    {                   
                        if(Regex.IsMatch(matches[i].Value, words[j].ThisWord, RegexOptions.IgnoreCase)
                            && matches[i].Value.Count()==words[j].ThisWord.Count())
                        {
                            break;
                        }
                        else
                    if (j == words.Count - 1)
                        {
                            w = new Word(matches[i].Value, count[i]);
                            words.Add(w);
                            break;
                        }
                    }                      
                }
            }
            return words;
        }
    }
}
