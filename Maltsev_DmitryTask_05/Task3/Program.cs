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
            Triangle triangle = new Triangle(5, 5, 5);
            Console.WriteLine("Площадь треугольника = {0}",triangle.TriangleArea().ToString());
            Console.WriteLine("Площадь треугольника = {0}", triangle.TrianglePerimetr().ToString());
        }
    }
}
