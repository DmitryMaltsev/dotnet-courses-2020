using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maltsev_DmitryTask_05
{
    public class User
    {
        private DateTime _birthday;
        public User(string surnames, string name, string middleName, DateTime birthDay)
        {
            Surnames = surnames;
            Name = name;
            Middlename = middleName;
            Birthday = birthDay;
        }
        public string Name { get; private set; }
        public string Surnames { get; private set; }
        public string Middlename { get; private set; }
        public DateTime Birthday
        {
            get
            {
                return _birthday;
            }
            private set
            {
                DateTime now = DateTime.Now;
                if (value > now)
                {
                    throw new Exception("Дата рождения больше текущей даты. Введите верную дату");
                }
                else
                    _birthday = value;
            }
        }

        public int CalculateAge()
        {       
            int ageFromBirth = 0;
            DateTime now = DateTime.Now;
            if (now.Month > Birthday.Month || (now.Month == Birthday.Month && now.Day >= Birthday.Day))
            {
                ageFromBirth = now.Year - Birthday.Year;
            }            
            else
            {
                ageFromBirth = now.Year - 1 - Birthday.Year;
            }
            return ageFromBirth;
        }
    }     
} 

