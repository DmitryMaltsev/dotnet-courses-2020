using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    public class User
    {
        private DateTime _birthday;
        private int _age;
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
        public int Age
        {
            get
            {
                return CalculateAge(Birthday);                            
            }         
        }
        public int CalculateAge(DateTime date)
        {
            int age = 0;
            DateTime now = DateTime.Now;
            if (now.Month > date.Month || (now.Month == date.Month && now.Day >= date.Day))
            {
                age = now.Year - date.Year;
            }
            else
            {
                age = now.Year - 1 - date.Year;
            }
            return age;
        }
    }
}

