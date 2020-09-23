using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.CursorVisible = false;
            string Star = "*";
            int N;     
            do
            {
                Console.Write("Введите целое неотрицательное число=");
                N = int.Parse(Console.ReadLine());
            }
            while (N <= 0);
            //Console.SetCursorPosition(0, N);
            for (int i = 1; i <= N; i++)
            {              
                Console.SetCursorPosition(N + 1 - i,i);
                Console.WriteLine(Star);
                 Star += "**";
           
            }
            Console.SetCursorPosition(0, N + 1);
            Console.WriteLine("Please insert button to close console");           
        }
    }
}
