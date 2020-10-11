using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    class Triangle
    {
        private double _a;
        private double _b;
        private double _c;
             
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
                return _a;
            }
            private set
            {
                if (value < 0)
                    throw new Exception("Длина стороны А должна быть >0");
                _a = value;
            }
        }
        public double BLength
        {
            get
            {
                return _b;
            }
            private set
            {
                if (value < 0)
                    throw new Exception("Длина стороны B должна быть >0");
                _b = value;
            }
        }
        public double CLength
        {
            get
            {             
                return _c;
            }
            set
            {
                if (value < 0)
                    throw new Exception("Длина стороны C должна быть >0");
                _c = value;
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
        }
         public double Perimeter
        {
            get
            {
                CompaisonTriangleSides();
                double p = ALength + BLength + CLength;
                return p;
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
