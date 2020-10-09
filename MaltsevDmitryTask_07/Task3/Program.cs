using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    class Program
    {
        static void Main(string[] args)
        {
          ArithmeticalProgression progression = new ArithmeticalProgression(2, 2);
            Console.WriteLine("Progression:");
            PrintSeries(progression);
            List list=new List(new double[] {1,5,8,11,12,6,8});           
            Console.WriteLine("List:");
            PrintSeries(list);
            Console.WriteLine("Progression by index:");
            PrintElementByIndex(progression, 4);
            Console.WriteLine("List by index");
            PrintElementByIndex(list, 5);
        }
        private static void PrintSeries(ISeries series)
        {
            series.Reset();
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(series.GetCurrent());
                series.MoveNext();
            }       
        }
        private static void PrintElementByIndex(IIndexable indexable, int index)
        {           
            Console.WriteLine(indexable[index].ToString());
        }
    }
    public interface ISeries
    {
        double GetCurrent();
        bool MoveNext();
        void Reset();
    }
    public interface IIndexable
    {
        double this[int index] { get; }
    }
}
