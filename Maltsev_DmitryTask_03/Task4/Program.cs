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
            int[,] Massive = ArrayInput();
            PrintMassive(Massive);
            Console.WriteLine("Общая сумма четных позиций={0}",EvenSumm(Massive));


        }

        private static int[,] ArrayInput()
        {
            Random random = new Random();
            int[,] massive = new int[3,3];
            for (int i = 0; i < massive.GetLength(0); i++)
            {
                for (int j = 0; j < massive.GetLength(1); j++)
                {
                    massive[i,j] = random.Next(1, 10);
                }            
            }
            return massive;
        }


        private static int EvenSumm(int[,] Ar)
        {
            int Summ=0;
            for (int i = 0; i <Ar.GetLength(0); i++)
            {
                for (int j = 0; j < Ar.GetLength(1); j++)
                {
                   if((i+j)%2==0)
                    {
                        Summ += Ar[i, j];
                     //   Console.WriteLine(Ar[i,j]);
                    }
                }
            }
            return Summ;
        }




  private static void PrintMassive(int[,] PrintArray)
        {
            int summIndex = 0;
            for (int i = 0; i < PrintArray.GetLength(0); i++)
            {
                for (int j = 0; j < PrintArray.GetLength(1); j++)
                {
                    Console.Write(PrintArray[i, j]);
                    if (summIndex < PrintArray.Length - 1)
                        Console.Write(", ");
                    summIndex += 1;
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }
    }
}
