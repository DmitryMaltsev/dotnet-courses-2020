using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    class Program
    {
        public delegate string[] SortingFunc(string[] lines);

        static void Main(string[] args)
        {
           string[] line = { "Vasian", "Petia", "Misha Vlasov", "Kolia123", "Kolia12","Kolia" };
           SortingFunc func1 = new SortingFunc(SortingLinesByABC);
           string[] resultLine = SortingLinesByLength(func1, line);    
            foreach(var p in resultLine)
            {
                Console.WriteLine(p);
            }
        }

        private static string[] SortingLinesByABC(string[] lines)
        {
            string line = "";
            for (int i = 0; i < lines.Length; i++)
            {
                for (int j = 0; j < lines.Length - 1; j++)
                {

                    if (lines[i].Length == lines[j].Length)
                    {
                        char[] ch1 = lines[i].ToCharArray();
                        char[] ch2 = lines[j + 1].ToCharArray();
                        for (int k = 0; k < ch1.Length; k++)
                        {
                            if (ch1[k] != ch2[k] && ch1[k] > ch2[k])
                            {
                                line = lines[i];
                                lines[i] = lines[j + 1];
                                lines[j + 1] = line;
                                break;
                            }
                        }
                    }
                }
            }
            return lines;
        }

        private static string[] SortingLinesByLength(SortingFunc sortFunc, string[] lines)
        {
            string line = "";
            lines = sortFunc?.Invoke(lines);
            for (int i = 0; i < lines.Length; i++)
            {
                for (int j = 0; j < lines.Length - 1 - i; j++)
                {
                    if (lines[j + 1].Length < lines[j].Length)
                    {
                        line = lines[j];
                        lines[j] = lines[j + 1];
                        lines[j + 1] = line;
                    }
                }
            }
           
            return lines;
        }
    } 
}
