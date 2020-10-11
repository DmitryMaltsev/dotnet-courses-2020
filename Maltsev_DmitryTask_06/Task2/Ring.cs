using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    public class Ring : Round
    {
        private double _outerRadius;
        public Ring(int xCenter, int yCenter, double R, double OuterR)
             : base(xCenter, yCenter, R)
        {
            OuterRadius = OuterR;
        }
        public double OuterRadius
        {
            get
            {
                return _outerRadius;
            }
            private set
            {
                if (value <= 0)
                {
                    throw new Exception("Внешний радиус должен быть>0");
                }
                if (value <= Radius)
                {
                    throw new Exception("Внешний радиус должен быть больше внутреннего");
                }
                _outerRadius = value;
            }
        }
        public override double Area
        {
            get
            {
                return Math.PI*(Math.Pow(OuterRadius, 2) - Math.Pow(Radius, 2));
            }
        }
        public override double Length
        {
            get
            {
                return  2 * Math.PI * (OuterRadius+Radius);
            }
        }
    }
}
    