using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    public class GeometricProgerssion : ISeries
    {
        double start, step;
        int currentIndex;
        public GeometricProgerssion(double _start, double _step)
        {
            start = _start;
            step = _step;
            currentIndex = 1;
        }

        public double GetCurrent()
        {
            double result = 1;
            for (int i = 0; i < currentIndex; i++)
            {
                result *= step;
            }
            return result;
        }
        public bool MoveNext()
        {
            currentIndex++;
            return true;
        }
        public void Reset()
        {
            currentIndex = 1;
        }
    }
}
