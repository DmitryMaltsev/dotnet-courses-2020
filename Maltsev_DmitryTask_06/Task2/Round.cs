using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    public class Round
    {
        public int XCenter;
        public int YCenter;
        private double _radius;
        public Round(int xCenter, int yCenter, double radius)
        {
            XCenter = xCenter;
            YCenter = yCenter;
            Radius = radius;
        }
        public double Radius
        {
            get
            {
                return _radius;
            }
            private set
            {
                if (value <= 0)
                {
                    throw new Exception("Радиус должен быть>0");
                }
                _radius = value;
            }
        }
        public virtual double Length
        {
            get
            {
                return 2 * Math.PI * Radius;
            }
        }
        public virtual double Area
        {
            get
            {
                return Math.PI * Math.Pow(Radius, 2);
            }
        }
    }
}