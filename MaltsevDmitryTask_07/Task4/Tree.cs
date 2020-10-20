using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
    class Tree : Obstacles
    {
        public Tree(int xPosition, int yPosition)
           : base(xPosition, yPosition)
        {
            XPosition = xPosition;
            YPosition = yPosition;
        }
        public override int XPosition { get; set; }
        public override int YPosition { get; set; }
    }
}
