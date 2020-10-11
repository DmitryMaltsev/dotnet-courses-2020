using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    class Circle : Figure
    {
        protected int YCenter;
        protected int XCenter;
        private double _radius;
        public Circle(int xCenter, int yCenter, double radius)
        {
            XCenter = xCenter;
            YCenter = yCenter;
            Radius = radius;
        }
        public double Radius
        {
            get
            {
                return _radius;
            }
            set
            {
                if (value <= 0)
                {
                    throw new Exception("Радиус должен быть>0");
                }
                _radius = value;
            }
        }
        public override void Draw()
        {
            Console.WriteLine($"Это Окружность с координатой X={XCenter},координатой Y={YCenter}, радиусом={Radius}");
        }
    }
}
