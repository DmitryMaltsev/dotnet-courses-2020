using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
    abstract class Bonuses
    {
       public abstract int XPosition { get; set; }
       public abstract int YPosition { get; set; }
       public abstract double Bonus { get; set; }      
    }
    class MashRooms : Bonuses, IBonusEvent
    {
        public MashRooms(int xPosition, int yPosition, double bonus)
        {
            XPosition = xPosition;
            YPosition = yPosition;
            Bonus = bonus;
        }
        public override int XPosition { get; set; }
        public override int YPosition { get; set; }
        public override double Bonus { get; set; }

        public bool AddBonusPoints(double countPlayerBonuses, double maxBonusPoints)
        {
            bool createRandombonus = false;
            if (countPlayerBonuses <= maxBonusPoints)
            {
                createRandombonus = true;
            }
            return createRandombonus;
        }
    }
}
