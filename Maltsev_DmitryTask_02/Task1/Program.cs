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
            int Width;
            int Height;
            do
            {
                Console.Write("Введите ширину прямоугольника (неотрицательное число)=");
                Width = int.Parse(Console.ReadLine());
                if (Width <= 0)
                    Console.WriteLine("Вы ввели отрицательное число или ноль");
            }
            while (Width <= 0);
            do
            {
                Console.Write("Введите высоту прямоугольника (неотрицательное число)=");
                Height = int.Parse(Console.ReadLine());
                if (Width <= 0)
                    Console.WriteLine("Вы ввели отрицательное число или ноль");
            }
            while (Height <= 0);
            int S = Height * Width;
            Console.WriteLine("Площадь прямоугольника=" + S);
            Console.WriteLine("Please insert button to close console");
        }

    }
}
