using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AllMathMethods;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            MathMethods Math = new MathMethods();
            Console.WriteLine(Math.Fatcorial(5));
            Console.WriteLine(Math.Exponential(5,2));
        }
    }
}
