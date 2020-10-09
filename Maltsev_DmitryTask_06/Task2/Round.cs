using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    public class Round
    {
        private int YCenter;
        private int XCenter;
        private double roundLength;
        private double area;
        private double radius;
        public Round(int xCenter, int yCenter, double R)
        {
            XCenter = xCenter;
            YCenter = yCenter;
            Radius = R;
        }
        public double Radius
        {
            get
            {
                if (Radius <= 0)
                {
                    throw new Exception("Радиус должен быть>0");
                }
                return Radius;
            }
            set
            {
                radius = value;
            }
        }
        public double Length
        {
            get
            {            
                roundLength = 2 * Math.PI * Radius;
                return roundLength;
            }
        }
        public double Area
        {
            get
            {
                area = Math.PI * Math.Pow(Radius, 2);
                return area;
            }
        }
    }
}