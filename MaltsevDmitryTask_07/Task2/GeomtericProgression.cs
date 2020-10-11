using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    public class GeometricProgerssion : ISeries
    {
        private double _start;
        private double _step;
        private double _currentIndex;
        public GeometricProgerssion(double start, double step)
        {
            _start = start;
            _step = step;
            _currentIndex = 1;
        }

        public double GetCurrent()
        {
            double result = 1;
            for (int i = 0; i < _currentIndex; i++)
            {
                result *= _step;
            }
            return result;

        }
        public bool MoveNext()
        {
            _currentIndex++;
            return true;
        }
        public void Reset()
        {
            _currentIndex = 1;
        }
    }
}
