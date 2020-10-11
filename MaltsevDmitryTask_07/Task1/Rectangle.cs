using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    class Rectangle : Figure
    {
        private int _width;
        private int _height;
        public Rectangle(int width, int height)
        {
            Width = width;
            Height = height;
        }
        public int Width
        {
            get
            {
                return _width;
            }
            set
            {
                if (value <= 0)
                {
                    throw new Exception("Ширина прямоугольника должна быть >0");
                }
                _width = value;
            }
        }
        public int Height
        {
            get
            {
                return _height;
            }
            set
            {
                if (value < 0)
                {
                    throw new Exception("Высота прямоугольника должна быть >0");
                }
                _height = value;
            }
        }
        public override void Draw()
        {
            Console.WriteLine($"Это прямоугольник с шириной={Width}, высотой={Height}");
        }
    }
}
