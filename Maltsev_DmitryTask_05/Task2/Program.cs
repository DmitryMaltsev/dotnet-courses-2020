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
            Round round = new Round(0,0,5);
            round.RoundLength = 5;
            round.Area = 5;
            Console.WriteLine("длина круга равна {0}",round.RoundLength);
            Console.WriteLine("площадь круга равна {0}", round.Area);
            Console.WriteLine("Координата X центра="+round.XCenter);
            Console.WriteLine("Координата Y центра=" + round.YCenter);
        }
    }
}
