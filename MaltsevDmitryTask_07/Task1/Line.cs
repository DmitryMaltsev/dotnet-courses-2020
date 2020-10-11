using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{  
   class Line : Figure
   {
     private int _width;
     public Line(int width)
     {
            Width = width;
     }
     public int Width
        {
            get
            {
                return _width;
            }
            set
            {
                if (value < 0)
                {
                    throw new Exception("Длина прямой должна быть >0");
                }
                _width = value;
            }
        }

        public override void Draw()
        {
            Console.WriteLine( $"Это прямая длиной {Width}" );
        }
    }   
}
