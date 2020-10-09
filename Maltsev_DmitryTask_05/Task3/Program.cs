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
            double ALength;
            double BLength;
            double CLength;
            try
            {
                ALength = 15;
                BLength = -5;
                CLength = 5;                                   
                Triangle triangle = new Triangle(ALength, BLength, CLength);
                PrintTriangleData(ALength, BLength, CLength, triangle.Area, triangle.Perimeter);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

      

        private static void PrintTriangleData(double aLength, double bLength, double cLength,double area,double perimeter)
        {
            Console.WriteLine($"Сторона А={aLength}");
            Console.WriteLine($"Сторона B={bLength}");
            Console.WriteLine($"Сторона C={cLength}");
            Console.WriteLine($"Периметр={perimeter}");
            Console.WriteLine($"Площадь равна={area,3:f2}");
        }
    }
}
