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
            try
            {
                x = 1;
                y = 1;
                radius = -1;   
                Round round = new Round(x, y, radius);
                PrintRoundDates(round);
            }

            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private static void PrintRoundDates(Round round)
        {
            Console.WriteLine("Координата X центра=" + round.XCenter);
            Console.WriteLine("Координата Y центра=" + round.YCenter);
            Console.WriteLine("Радиус=" + round.Radius);
            Console.WriteLine("Длина круга={0,3:f2}", round.Length);
            Console.WriteLine("Площадь круга={0,3:f2}", round.Area);
        }
    }
}
