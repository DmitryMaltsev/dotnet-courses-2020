using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maltsev_DmitryTask_04
{
    class Program
    {
        static void Main(string[] args)
        {
            string Sentence = "This sentence has 5 words";
            int startposition = Sentence.IndexOf(" ") + 1;
            string word2 = Sentence.Substring(startposition, Sentence.IndexOf(" ", startposition)-startposition);
            Console.WriteLine(Sentence.IndexOf(" ", startposition));
            Console.WriteLine(word2);
        }
    }
}
