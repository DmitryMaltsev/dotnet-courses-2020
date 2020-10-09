using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{  
   class Line : Figure
   {
     protected int width;
     public Line(int _width)
     {
            Width = _width;
     }
     public int Width
     {
       get
       {
          if (width <= 0)
          {
              throw new Exception("Длина прямой должна быть >0");
          }
          return width;
       }
       set
       {
           width = value;
       }
     }

      public override void Draw()
      {
            Console.WriteLine(this.ToString());
      }
      public override string ToString()
      {
            return string.Format($"Это прямая длиной {Width}");
      }
   }   
}
