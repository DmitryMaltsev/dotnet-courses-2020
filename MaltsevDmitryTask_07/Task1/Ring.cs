using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    class Ring : Circle
    {
        private double _outerRadius;
        public Ring(int xCenter, int yCenter, double radius, double outerRadius)
            : base(xCenter, yCenter, radius)
        {
            OuterRadius = outerRadius;
        }
        public double OuterRadius
        {
            get
            {
               
                return _outerRadius;
            }
            set
            {
                if (value <= 0)
                {
                    throw new Exception("Внешний радиус должен быть больше 0");
                }
                _outerRadius = value;
            }
        }

        public override void Draw()
        {
            Console.WriteLine($"Это кольцо с координатой X={XCenter},координатой Y={YCenter},внутренним радиусом радиусом={Radius}"
                + $", внешним радиусом={OuterRadius}");
        }
    }
}
