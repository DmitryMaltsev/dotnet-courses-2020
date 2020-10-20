using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
    class Player:Character,IEnemyEvent,IBonusEvent
    {
        public Player(int positionX, int poSitionY, int health, double speed, double damage, double attackSpeed)
        {
            XAxisposition = positionX;
            YAxisposition = poSitionY;
            Speed = speed;
            Health = health;
            Damage = damage;
            Health = health;
            Attackspeed = attackSpeed;
        }
        public  double XAxisposition { get; set; }   
        public double YAxisposition { get; set; }
        public override double Speed{ get; set; }
        public override double Health { get; set; }
        public override double Damage { get; set; }
        public override double Attackspeed { get; set; }
        public double Bonus { get; set; }

        public override void Move() { } 
 
        public double DamageToUnit(double enemyDamage)
        {
            return Health - enemyDamage;
        }

        public bool IsDead()
        {
            bool gameOver = false; 
            if (Health <= 0)
            {
                gameOver = true;
            }
            return gameOver;
        }

        public bool AddBonusPoints(double countBonusPoints, double maxBonusPoints)
        {
            bool winGame = false;
            Bonus += countBonusPoints;
            if(Bonus >= maxBonusPoints)
            {
                winGame = true;
            }
            return winGame;
        }
    }
}
