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
        double radius;
        public Circle(int _xCenter, int _yCenter, double _radius)
        {
            XCenter = _xCenter;
            YCenter = _yCenter;
            Radius = _radius;
        }
        public double Radius
        {
            get
            {
                if (radius <= 0)
                {
                    throw new Exception("Радиус должен быть>0");
                }
                return radius;
            }
            set
            {
                radius = value;
            }
        }
        public override void Draw()
        {
            Console.WriteLine(this.ToString());
        }
        public override string ToString()
        {
            return string.Format($"Это Окружность с координатой X={XCenter},координатой Y={YCenter}, радиусом={Radius}");
        }
    }
}
