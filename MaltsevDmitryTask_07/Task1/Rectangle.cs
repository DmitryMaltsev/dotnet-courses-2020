using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    class Rectangle : Figure
    {
        protected int width;
        protected int height;
        public Rectangle(int _width, int _height)
        {
            Width = _width;
        }
        public int Width
        {
            get
            {
                if (width <= 0)
                {
                    throw new Exception("Ширина прямоугольника должна быть >0");
                }
                return width;
            }
            set
            {
                width = value;
            }
        }
        public int Height
        {
            get
            {
                if (height < 0)
                {
                    throw new Exception("Высота прямоугольника должна быть >0");
                }
                return height;
            }
            set
            {
                height = value;
            }
        }
        public override void Draw()
        {
            Console.WriteLine(this.ToString());
        }
        public override string ToString()
        {
            return string.Format($"Это прямоугольник с шириной={Width}, высотой={Height}");
        }
    }

}
