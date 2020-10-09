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
            int X;
            int Y;
            double Radius;
            double OuterRadius;
            try
            {
                X = 1;
                Y = 1;
                Radius = 5;
                OuterRadius = 8;                             
                Ring ring = new Ring(X, Y, Radius, OuterRadius);
                PrintDates(X, Y, Radius, OuterRadius, ring.RingArea, ring.RingLength);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        private static void PrintDates(int xCenter, int yCenter, double radius, double outerRadius, Double ringArea,Double ringLength)
        {
            Console.WriteLine("Координата X центра=" + xCenter);
            Console.WriteLine("Координата Y центра=" + yCenter);
            Console.WriteLine("Внешний радиус=" + radius);
            Console.WriteLine("Внутренний радиус=" + outerRadius);
            Console.WriteLine("Длина кольца={0,3:f2}", ringLength);
            Console.WriteLine("Площадь кольца={0,3:f2}", ringArea);

        }
    }  
}
