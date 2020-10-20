using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AllMathMethods
{
    public class MathMethods
    {
        public int Fatcorial(int Number)
        {
            int result = 1;
            for (int i = 1; i <= Number; i++)
            {
                result *= i;
            }
            return result;
        }

        public double Exponential(int Number, int Exponent)
        {
            return Math.Pow(Number, Exponent);
        }
    }
}
