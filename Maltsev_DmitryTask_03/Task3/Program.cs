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
            int[] Array = ArrayInput();
            int SummIndex = IndexSumm(Array);
            PrintMassive(Array);
            Console.WriteLine("Сумма всех неотрицательных чисел в массиве={0}", SummIndex);

        }
        private static int[] ArrayInput()
        {
            Random random = new Random();
            int[] massive = new int[10];
            for (int i = 0; i < massive.Length; i++)
            {
                massive[i] = random.Next(-100, 100);
            }
            return massive;
        }
        private static int IndexSumm(int[] Ar)
        {
            int Summ = 0;
            for (int i = 0; i < Ar.Length; i++)
            {
                if (Ar[i] > 0)
                {
                    Summ += Ar[i];
                }
            }
            return Summ;
        }
        private static void PrintMassive(int[] PrintArray)
        {
            for (int i = 0; i < PrintArray.Length; i++)
            {
                Console.Write(PrintArray[i]);
                if (i < PrintArray.Length - 1)
                    Console.Write(", ");
            }
            Console.WriteLine();
        }
    }
}
