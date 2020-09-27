using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.CursorVisible = false;
            int[] Array = ArrayInput();        
            int[] ArrayMax = SortMax(Array);
            int[] ArrayMin = SortMin(Array);          
            int maxVal = MaxValue(Array);
            int minVal = MinValue(Array);
               Console.Write("Сгенерирован Массив=");
               PrintMassive(Array);
               Console.WriteLine("Максимальное значение в массиве="+maxVal);
               Console.WriteLine("Минимальное значение в массиве=" +minVal);
               Console.Write("Отсортированные массив по возрастанию=");
               PrintMassive(ArrayMax);
               Console.Write("Отсортированные массив по убыванию=");
               PrintMassive(ArrayMin);
        }

        private static int[] ArrayInput()
        {
            Random random = new Random();
            int[] massive = new int[10];
            for (int i = 0; i < massive.Length; i++)
            {
                massive[i] = random.Next(1, 100);
            }
            return massive;
        }
        private static int MaxValue(int[] Massive)
        {        
            int maxval=Massive[0];
            for (int i = 0; i < Massive.Length; i++)
            {
                if (Massive[i] > maxval)
                    maxval = Massive[i];            
            }
            return maxval;
        }
        private static int MinValue(int[] Massive)
        {
            int minval = Massive[0];
            for (int i = 0; i < Massive.Length; i++)
            {
                if (Massive[i] < minval)
                    minval = Massive[i];              
            }
            return minval;
        }
        private static int[] SortMax(int[] Massive)
        {
            int bufferValue;
            int[] sortedMassive=new int[Massive.Length];
            for (int i = 0; i <Massive.Length; i++)
            {
                sortedMassive[i] = Massive[i];
            }

            for (int i = 0; i < sortedMassive.Length; i++)
            {
                for (int j=0;j<sortedMassive.Length;j++)
                if(sortedMassive[i]<sortedMassive[j])
                {

                    bufferValue = sortedMassive[i];
                    sortedMassive[i] = sortedMassive[j];
                    sortedMassive[j] = bufferValue;
                }
            }
            return sortedMassive;
        }
        private static int[] SortMin(int[] Massive)
        {
            int bufferValue;
            int[] sortedMassive = new int[Massive.Length];
            for (int i = 0; i < Massive.Length; i++)
            {
                sortedMassive[i] = Massive[i];
            }

            for (int i = 0; i < sortedMassive.Length; i++)
            {
                for (int j = 0; j < sortedMassive.Length; j++)
                    if (sortedMassive[i] > sortedMassive[j])
                    {

                        bufferValue = sortedMassive[i];
                        sortedMassive[i] = sortedMassive[j];
                        sortedMassive[j] = bufferValue;
                    }
            }
            return sortedMassive;
        }
        private static void PrintMassive(int[] PrintArray)
        {
            for (int i = 0; i < PrintArray.Length; i++)
            {
                Console.Write(PrintArray[i]);
                if(i<PrintArray.Length-1)
                    Console.Write(", ");
            }
            Console.WriteLine();
        }
    }
}
