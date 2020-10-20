using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{  
    class Program
    {
        static void Main(string[] args)
        {
            Numb numb = new Numb();
            foreach(var n in numb)
            {
                Console.WriteLine(n);
            }

            
        }
    }
    class Numb:IEnumerable
    {
        int[] numbs = { 2, 4, 6, 8, 9, 8, 7, 6 };
        public IEnumerator GetEnumerator()
        {
            return new NumbNumerator(numbs);
        }
    }
  
    class NumbNumerator : IEnumerator
    {
        int[] numbs;
        int position = -1;
        public NumbNumerator(int[] numb)
        {
            numbs = numb;
        }
        public object Current
        {
            get
            {
                if (position == -1||position>=numbs.Length)
                {
                    throw new Exception("qwe");
                }
                return numbs[position];
            }
        }

        public bool MoveNext()
        {
            if (position < numbs.Length-1)
            {
                position += 1;
                return true;
            }
            else
                return false;
        }

        public void Reset()
        {
            position = -1;
        }
    }
}
