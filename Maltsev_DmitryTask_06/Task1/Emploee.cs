using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    class Emploee:User
    {

        private DateTime _startWorking;
        public Emploee(string surnames, string name, string middleName, DateTime birthday, string pos, DateTime startWorking)
            : base(surnames, name, middleName, birthday)
        {
            Position = pos;
            StartWorking = startWorking;
        }
        public string Position { get; set; }
        public DateTime StartWorking
        {
            get
            {
                return _startWorking;             
            }
            private set
            {
                DateTime now = DateTime.Now;
                if (value > now)
                {
                    throw new Exception("Дата трудоустройства больше текущей даты. Введите верную дату");
                }
                if(value<Birthday)
                {
                    throw new Exception("Дата трудоустройства раньше вашей даты рождения. Введите верную дату");
                }
                _startWorking = value;
            }           
        }
        public int WorkExperience
        {
            get
            {
              return  CalculateAge(StartWorking);
            }
        }
    }
}
