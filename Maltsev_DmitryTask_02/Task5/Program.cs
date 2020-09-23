using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.CursorVisible = false;
            int Summ = 0;
            for (int i = 1; i < 1000; i++)
            {
                if((i%3==0)||(i%5==0))
                {
                    Summ += i;
                }
            }
            Console.WriteLine("Сумма чисел, которые деляется на 3 или на 5 и меньше 1000="+Summ);
            Console.WriteLine("Please insert button to close console");
        }
    }
}
