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
            int x;
            int y;
            double radius;
            double outerRadius;
            try
            {
                x = 1;
                y = 1;
                radius = 5;
                outerRadius = 6;                             
                Ring ring = new Ring(x, y, radius, outerRadius);
                PrintDates(ring);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private static void PrintDates(Ring ring)
        {
            Console.WriteLine("Координата X центра=" + ring.XCenter);
            Console.WriteLine("Координата Y центра=" + ring.YCenter);
            Console.WriteLine("Внешний радиус=" + ring.Radius);
            Console.WriteLine("Внутренний радиус=" +ring.OuterRadius);
            Console.WriteLine("Длина кольца={0,3:f2}", ring.Length);
            Console.WriteLine("Площадь кольца={0,3:f2}", ring.Area);
        }
    }  
}
