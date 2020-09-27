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
            int[,,] Array = CreateMassive();
           
            PrintMassive(Array);
        }

        private static int[,,] CreateMassive()
        {
            Random random = new Random();
            int[,,] Massive; Massive = new int [3,3,3];
            for (int i = 0; i < Massive.GetLength(0); i++)
            {             
                for (int j = 0; j < Massive.GetLength(1); j++)
                {
                    for (int k = 0; k < Massive.GetLength(2); k++)
                    {
                        Massive[i, j, k] = random.Next(-100,100);
                        if (Massive[i, j, k]>0)
                        {
                            Massive[i, j, k] = 0;
                        }
                    }
                }
            }
            return Massive;
        }

        private static void PrintMassive(int[,,] Ar)
        {
            int Index=0;
            Random random = new Random();
            Console.WriteLine("Вывод массива:");
            for (int i = 0; i < Ar.GetLength(0); i++)
            {
                for (int j = 0; j < Ar.GetLength(1); j++)
                {
                    for (int k = 0; k < Ar.GetLength(2); k++)
                    {
                        Console.Write(Ar[i, j, k]);
                        if (Index < Ar.Length-1)
                        {
                            Index += 1;
                            Console.Write(", ");
                        }
                    }
                }
            }
            Console.WriteLine();
        }
    }
}
