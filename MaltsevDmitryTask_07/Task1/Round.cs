using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    class Round : Circle
    {
        public Round(int xCenter, int yCenter, double radius)
            : base(xCenter, yCenter, radius)
        {
            Radius = radius; 
        }
       
        public override void Draw()
        {
            Console.WriteLine($"Это круг с координатой X={XCenter},координатой Y={YCenter}, радиусом={Radius}");
        }
    }
}
