using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    class Round : Circle
    {
        public Round(int _xCenter, int _yCenter, int _radius)
            : base(_xCenter, _yCenter, _radius)
        {
            Radius = _radius; 
        }
       
        public override void Draw()
        {
            Console.WriteLine(this.ToString());
        }
        public override string ToString()
        {
            return string.Format($"Это круг с координатой X={XCenter},координатой Y={YCenter}, радиусом={Radius}");
        }
    }
}
