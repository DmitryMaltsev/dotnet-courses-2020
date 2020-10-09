using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    class List:ISeries,IIndexable
    {
        private double[] series;
        private int currentIndex;
        public List(double[] _series)
        {
            series = _series;
            currentIndex = 0;
        }
        public double this[int index]
        {
            get
            {
                return series[index];
            }
        }           
        public double GetCurrent()
        {
            return series[currentIndex];
        }
        public bool MoveNext()
        {
            currentIndex = currentIndex < series.Length - 1 ? currentIndex + 1 : 0;
            return true;
        }
        public void Reset()
        {
            currentIndex = 0;
        } 
    }
}
