using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    public class Ring:Round
    {
        private double outerRadius;
       public Ring(int xCenter, int yCenter, double R,double OuterR)
            :base(xCenter,yCenter,R)
        {
            OuterRadius = OuterR;
        }
        public double OuterRadius
        {
            get
            {
                if (outerRadius <= 0)
                {
                    throw new Exception("Внешний радиус должен быть>0");
                }
                if (outerRadius <= Radius)
                {
                    throw new Exception("Внешний радиус должен быть больше внутреннего");
                }
                return outerRadius;
            }
            set
            {
                outerRadius = value;                     
            }         
        }
        public  double RingArea
        {
            get
            {             
             return Math.PI * Math.Pow(OuterRadius, 2)-Area;
            }    
        }
        public double RingLength
        {
            get
            {
              return Length + 2 * Math.PI*OuterRadius;
            }
        }     

    }
    }