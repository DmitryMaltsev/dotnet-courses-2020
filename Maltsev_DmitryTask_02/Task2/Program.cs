using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.CursorVisible = false;
            string Star = "*";
            int Line = 1;
            int N;
            do
            {
                Console.Write("Введите целое неотрицательное число=");
                N = int.Parse(Console.ReadLine());
            }
            while (N <= 0);

            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < Line; j++)
                {
                    Console.Write(Star);
                }
              Line += 1;
              Console.WriteLine();
            }

            Console.WriteLine("Please insert button to close console");
        }
    }
}
