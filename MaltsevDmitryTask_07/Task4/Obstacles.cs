using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
    abstract class Obstacles
    {
        public Obstacles(int xPosition, int yPosition)           
        {
            XPosition = xPosition;
            YPosition = yPosition;
        }
        public abstract int XPosition { get; set; }
        public abstract int YPosition { get; set; }
    }
}
