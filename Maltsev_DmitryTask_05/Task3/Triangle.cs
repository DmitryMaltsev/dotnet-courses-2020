using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    class Triangle
    {
        public double ALength;
        public double BLength;
        public double CLength;
  
        public Triangle(int aLength, int bLenth, int cLength)
        {
            ALength = aLength;
            BLength = bLenth;
            CLength = cLength;
        }
        public  double TriangleArea()
        {
            double p = (ALength + BLength + CLength) / 2;
            double area = Math.Sqrt(p * (p - ALength) * (p - BLength) * (p - CLength));
            return area;          
        }
         public double TrianglePerimetr()
        {
            double P = ALength + BLength + CLength;
            return P;
        }
        

        
    }
   
}
