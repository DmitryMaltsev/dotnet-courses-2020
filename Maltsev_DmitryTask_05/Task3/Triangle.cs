using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    class Triangle
    {
        private double A;
        private double B;
        private double C;
             
        public Triangle(double a, double b, double c)
        {
            ALength = a;
            BLength = b;
            CLength = c;
        }
        public double ALength
        {
            get
            {
                if (A < 0)
                    throw new Exception("Длина стороны А должна быть >0");
                return A;
            }
            set
            {
               
                A = value;
            }
        }
        public double BLength
        {
            get
            {
                if (B < 0)
                    throw new Exception("Длина стороны B должна быть >0");
                return B;
            }
            set
            {
               
                B = value;
            }
        }
        public double CLength
        {
            get
            {
                if (C < 0)
                    throw new Exception("Длина стороны C должна быть >0");
                return C;
            }
            set
            {
               
                C = value;
            }
        }

        public double Area
        {
            get
            {
                CompaisonTriangleSides();
               double p = (ALength + BLength + CLength) / 2;
               double area = Math.Sqrt(p * (p - ALength) * (p - BLength) * (p - CLength));
               return area;
            }
            set
            {            
            }
        }
         public double Perimeter
        {
            get
            {
                CompaisonTriangleSides();
                double P = ALength + BLength + CLength;
                return P;
            }
            set
            {              
            }
        }

        private void CompaisonTriangleSides()
        {          
            if (!((ALength + BLength > CLength) && (ALength + BLength > CLength)
                   && (BLength + CLength > ALength)))
            {
                throw new Exception("2 стороны должны быть больше одной. Условие существования треугольника не выполняется");
            }
        }
    }
   
}
