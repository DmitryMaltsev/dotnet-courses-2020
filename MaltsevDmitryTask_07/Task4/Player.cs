using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
    class Player:Screen,IBaseInformation
    {

        public Player(int _positionX, int _poSitionY, int _health,double _speed,int Height, int Width)
            :base(Height,Width)
        {
            XAxisposition = _positionX;
            YAxisposition = _poSitionY;
            Speed = _speed;
            Health = _health;
        }
        public  double XAxisposition { get; set; }   
        public double YAxisposition { get; set; }
        public double Speed{ get; set; }
        public double Health { get; set; }
        public double Bonus { get; set; }
        public  void Changeposition() { }
        public double CountHealth() {
            return Health;
        }
        public double CountBonus()
        {
            return Bonus;
        }
        public bool IsPlayerDead()
        {
         bool isDead=false;
         return isDead;
        }
        public bool IsPlayerWin()
        {
            bool Win = false;
            return Win;
        }
    }
}
