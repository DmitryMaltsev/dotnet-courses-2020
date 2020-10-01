using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
    class Program
    {
        static void Main(string[] args)
        {
            Stopwatch stopwatch; 
           
            int N = 100;
            string simb = "*";


            stopwatch = Stopwatch.StartNew();
            StringFunc(N, simb);    
            stopwatch.Stop();
            long StringTick = stopwatch.Elapsed.Ticks; 
            Console.WriteLine("Потрачено тактов на выполнение цикла с переменной String: " + stopwatch.ElapsedTicks);

            stopwatch = Stopwatch.StartNew();
            stringBuilderFunc(N, simb);
            stopwatch.Stop();          
            Console.WriteLine("Потрачено тактов на выполнение цикла с переменной StringBuilder: " + stopwatch.ElapsedTicks);


        }

        private static void StringFunc(int num,string simbol)
        {
            string simbolresult="";
            for (int i = 0; i < num; i++)
            {
                simbolresult += simbol;
            }
        }

       private static void stringBuilderFunc(int num,string simbol)
       {
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < num; i++)
            {
                sb.Append("*");
            }
       }

        
    }
}
