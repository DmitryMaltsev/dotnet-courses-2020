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
            try
            {
                X = 1;
                Y = 1;
                Radius = -1;   
                Round round = new Round(X, Y, Radius);
                PrintDates(X, Y, Radius, round.Area, round.Length);
            }

            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private static void PrintDates(int xCenter, int yCenter,double radius, double roundLength, Double area)
        {
            Console.WriteLine("Координата X центра=" + xCenter);
            Console.WriteLine("Координата Y центра=" + yCenter);
            Console.WriteLine("Радиус=" + radius);
            Console.WriteLine("Длина круга={0,3:f2}", roundLength);
            Console.WriteLine("Площадь круга={0,3:f2}", area);
        }
    }
}
