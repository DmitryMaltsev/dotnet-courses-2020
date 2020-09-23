using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.CursorVisible = false;
            string Star = "*";
            int N;
            int CurrentCount = 1;
            int Yaxis = 1;
            do
            {
                Console.Write("Введите целое неотрицательное число=");
                N = int.Parse(Console.ReadLine());
            }
            while (N <= 0);           
            for (int i = 1; i <= N; i++)
            {
                for (int j = 1; j <= CurrentCount; j++)
                {
                    Console.SetCursorPosition(N-j+1, Yaxis);
                    Console.WriteLine(Star);
                    Star += "**";
                    Yaxis += 1;
                }
              CurrentCount += 1;
              Star = "*";
            }
            Console.SetCursorPosition(0, Yaxis + 1);
            Console.WriteLine("Please insert button to close console");


        }
    }
}
