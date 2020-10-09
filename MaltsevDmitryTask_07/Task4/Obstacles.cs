using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
    class Obstacles : Screen
    {
        public Obstacles(int _widthScreen, int _heightScreen)
             : base(_widthScreen, _heightScreen)
        { }
    }
    class Stone : Obstacles, IBaseInformation
    {
        public Stone(double _xPosition, double _yPosition, int _widthScreen, int _heightScreen)
             : base(_widthScreen, _heightScreen)
        {           
            XAxisposition = _xPosition;
            YAxisposition = _yPosition;
        }
        public double XAxisposition { get; set; }
        public double YAxisposition { get; set; }     
    }
    class Tree : Obstacles, IBaseInformation
    {
        public Tree(double _xPosition, double _yPosition, int _widthScreen, int _heightScreen)
             : base(_widthScreen, _heightScreen)
        {
            XAxisposition = _xPosition;
            YAxisposition = _yPosition;
        }
        public double XAxisposition { get; set; }
        public double YAxisposition { get; set; }
    }
}
