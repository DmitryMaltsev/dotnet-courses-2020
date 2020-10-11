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
            double aLength;
            double bLength;
            double cLength;
            try
            {
                aLength = 5;
                bLength = 5;
                cLength = 5;                                   
                Triangle triangle = new Triangle(aLength, bLength, cLength);
                PrintTriangleDates(triangle);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private static void PrintTriangleDates(Triangle triangle)
        {
            Console.WriteLine($"Сторона А={triangle.ALength}");
            Console.WriteLine($"Сторона B={triangle.BLength}");
            Console.WriteLine($"Сторона C={triangle.CLength}");
            Console.WriteLine($"Периметр={triangle.Perimeter}");
            Console.WriteLine($"Площадь равна={triangle.Area,3:f2}");
        }
    }
}
