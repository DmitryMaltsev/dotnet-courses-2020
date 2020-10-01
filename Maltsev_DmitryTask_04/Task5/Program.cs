using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Task5
{
    class Program
    {
        static void Main(string[] args)
        {
            string Expression = "<b>Это</b> текст <i>с</i> <font color=”red”>HTML</font> кодами ";
            Console.WriteLine(Expression);
            Console.WriteLine(RegExpression(Expression));
        }
        private static string RegExpression(string Sentence)
        {
            Regex regex = new Regex("<.*?>");
            MatchCollection matches = regex.Matches(Sentence);
            string target = "_";
            string resultSentence = regex.Replace(Sentence, target);
            return resultSentence;

        }
    }
}
