using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Task3
{
    public delegate string[] SortingFunc(string[] lines);
    public delegate void EndsortDelegate(string message);  
    
    class Program
    {
        public static event EndsortDelegate EndSorting;

        static void Main(string[] args)
        {
            EndSorting += MessageEndSorting;
            string[] line = { "Vasian", "Petia", "Misha Vlasov", "Kolia123", "Kolia12", "Kolia" };
            SortingFunc func1 = new SortingFunc(SortingLinesByLengthAndABC);            
            string[] result = func1?.Invoke(line);
            Thread thread1 = new Thread(() => SortingLinesByLengthAndABC(line));
            thread1.Start();
            foreach (var r in result)
            {
                Console.WriteLine(r);
            }
        }

        private static void MessageEndSorting(string message)
        {
            Console.WriteLine(message);
        }

        private static string[] SortingLinesByLengthAndABC(string[] lines)
        {
            string line = "";
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
                    else
                    {
                        if (lines[j + 1].Length == lines[j].Length)
                        {
                            char[] ch1 = lines[j + 1].ToCharArray();
                            char[] ch2 = lines[j].ToCharArray();
                            for (int k = 0; k < ch1.Length; k++)
                            {
                                if (ch1[k] != ch2[k] && ch1[k] < ch2[k])
                                {
                                    line = lines[k];
                                    lines[k] = lines[k + 1];
                                    lines[k + 1] = line;
                                    break;
                                }
                            }
                        }
                    }
                }
            }
            Thread.Sleep(500);
            EndSorting?.Invoke("Thread finished");
            return lines;
        }
    }
}
