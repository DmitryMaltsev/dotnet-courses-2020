using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
    class Screen
    {
        private int width;
        private int height;
        public Screen(int _widthScreen, int _heightScreen)
        {
            Width = _widthScreen;
            Height = _heightScreen;
        }
        public int Width
        {
            get
            {
                if (width <= 0)
                {
                    throw new Exception("Ширина экрана должна быть >0");
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
                    throw new Exception("Высота экрана должна быть >0");
                }
                return height;
            }
            set
            {
                height = value;
            }
        }
    }
}


