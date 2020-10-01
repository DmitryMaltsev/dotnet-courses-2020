using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Task7
{
    class Program
    {
        static void Main(string[] args)
        {
            string Sentence = "В 7:59 я встал, позавтракал и к 00:00 пошел на работу.";
            Console.WriteLine("Время было указано {0} раз",CountTimeInSentence(Sentence));

        }
        static int CountTimeInSentence(string sentence)
        {
            Regex regex =new Regex ("([0-9]{1}|[(0-23)]{2}):[0-59]{2}");
            MatchCollection Matches = regex.Matches(sentence);
            int countMatches = Matches.Count;
            return countMatches;          
        }
    }
}
