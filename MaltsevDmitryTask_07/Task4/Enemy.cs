using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
    abstract class Enemy:Screen
    {          
       public Enemy(int _widthScreen, int _heightScreen)
            :base(_widthScreen,_heightScreen)
        {}
        public abstract double Speed { get; set; }
        public abstract double Damage { get; set; }
        public abstract void Move();
    }
    class Bear : Enemy, IBaseInformation
    {
        public Bear(int _positionX, int _poSitionY, int _health, double _speed, int Height, int Width,double _damage)
            : base(Height, Width)
        {
            XAxisposition = _positionX;
            YAxisposition = _poSitionY;
            Speed = _speed;
            Damage = _damage;
        }
        public double XAxisposition { get; set; }
        public double YAxisposition { get; set; }
        public override double Speed { get; set; }
        public override double Damage { get; set; }
        public override void Move() { }      

    }
    class Wolf : Enemy, IBaseInformation
    {
        public Wolf(int _positionX, int _poSitionY, int _health, double _speed, int Height, int Width, double _damage)
            : base(Height, Width)
        {
            XAxisposition = _positionX;
            YAxisposition = _poSitionY;
            Speed = _speed;
            Damage = _damage;
        }
        public double XAxisposition { get; set; }
        public double YAxisposition { get; set; }
        public override double Speed { get; set; }
        public override double Damage { get; set;}
        public override void Move() { }

    }
}

