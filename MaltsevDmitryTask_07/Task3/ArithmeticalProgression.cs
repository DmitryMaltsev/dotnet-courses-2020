using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    public class ArithmeticalProgression: ISeries,IIndexable
    {
        private double _start;
        private double _step;
        private double _currentIndex;

        public ArithmeticalProgression(double start, double step)
        {
            _start = start;
            _step = step;
            _currentIndex = 1;
        }
        public double this[int index]
        {
            get
            {
               return _start + _step * index;
            }
        }

        public double GetCurrent()
        {
            return _start + _step * _currentIndex;
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
