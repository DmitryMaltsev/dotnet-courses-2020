using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
    abstract class Bonuses : Screen
    {
        public Bonuses(int _widthScreen, int _heightScreen)
             : base(_widthScreen, _heightScreen)
        { }
        public abstract int CountBonus { get; set; }      
    }
    class MashRooms : Bonuses,IBaseInformation
    {
        public MashRooms(double _xPosition, double _yPosition, int _widthScreen, int _heightScreen,int _countBonus)
             : base(_widthScreen, _heightScreen)
        {
            CountBonus = CountBonus;
            XAxisposition = _xPosition;
            YAxisposition = _yPosition;
        }
        public double XAxisposition { get; set; }
        public double YAxisposition { get; set; }
        public override int CountBonus { get; set; }
    }
    class Berries : Bonuses, IBaseInformation
    {
        public Berries(double _xPosition, double _yPosition, int _widthScreen, int _heightScreen, int _countBonus)
             : base(_widthScreen, _heightScreen)
        {
            CountBonus = CountBonus;
            XAxisposition = _xPosition;
            YAxisposition = _yPosition;
        }
        public double XAxisposition { get; set; }
        public double YAxisposition { get; set; }
        public override int CountBonus { get; set; }
    }
}
