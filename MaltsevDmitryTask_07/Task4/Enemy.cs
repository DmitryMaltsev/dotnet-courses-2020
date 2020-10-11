using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
    abstract class Enemy
    {          
        public abstract double Speed { get; set; }
        public abstract double Damage { get; set; }
        public abstract double Health { get; set; }
        public abstract double Attackspeed { get; set; }
        public abstract bool Dead { get; set; }

        public abstract void Move();
    }
}

