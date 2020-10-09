using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    class Ring : Circle
    {
        protected int outerRadius;
        public Ring(int _xCenter, int _yCenter, int _radius, int _outerRadius)
            : base(_xCenter, _yCenter, _radius)
        {
            OuterRadius = _outerRadius;
        }
        public int OuterRadius
        {
            get
            {
                if (outerRadius <= 0)
                {
                    throw new Exception("Внешний радиус должен быть больше 0");
                }
                return outerRadius;
            }
            set
            {
                outerRadius = value;
            }
        }

        public override void Draw()
        {
            Console.WriteLine(this.ToString());
        }
        public override string ToString()
        {
            return string.Format($"Это кольцо с координатой X={XCenter},координатой Y={YCenter},внутренним радиусом радиусом={Radius}"
                +$", внешним радиусом={OuterRadius}");
        }
    }
}
