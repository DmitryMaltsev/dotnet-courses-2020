using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
    class Bear : Character, IEnemyEvent
    {
        public Bear(int positionX, int poSitionY, int health, double speed, double damage, double attackSpeed)
        {
            XAxisposition = positionX;
            YAxisposition = poSitionY;
            Speed = speed;
            Damage = damage;
            Health = health;
        }
        public double XAxisposition { get; set; }
        public double YAxisposition { get; set; }
        public override double Speed { get; set; }
        public override double Damage { get; set; }
        public override double Health { get; set; }
        public override double Attackspeed { get; set; }
        public bool Dead { get; set; }

        public override void Move() { }

        public double DamageToUnit(double playerDamage)
        {
            return Health - playerDamage;
        }

        public bool IsDead()
        {
            if (Health <= 0)
            {
                Dead = true;
            }
            return Dead;
        }
    }
}
