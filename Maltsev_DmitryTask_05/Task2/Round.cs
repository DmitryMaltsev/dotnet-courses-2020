using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    public class Round
    {
        public int YCenter;
        public int XCenter;
        public int Radius;
        private double roundLength;
        private double area;
        public Round(int xCenter, int yCenter, int radius)
        {
            XCenter = xCenter;
            YCenter = yCenter;
            Radius = radius;
        }
        public double RoundLength
        {
            get
            {
                return roundLength;
            }
            set
            {
                roundLength =2*Math.PI*value ;
            }
        }
        public double Area
        {
            get
            {
                return area;
            }
            set
            {
                area = Math.PI * Math.Pow(value, 2);
            }
        } 
    }
}
