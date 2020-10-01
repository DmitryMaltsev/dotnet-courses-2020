using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maltsev_DmitryTask_05
{
     public class User
    {
        public string Surnames;
        public string Name;
        public string MiddleName;
        public DateTime Birthday;
        public int Age;
        public User(string surnames, string name, string middleName, DateTime birthday, int age)
        {
            Surnames = surnames;
            Name = name;
            MiddleName = middleName;
            Birthday = birthday;
            Age = age;
        }
        public  void UsersDates()
        {
            Console.WriteLine("ФИО пользователя-{0} {1} {2}", Surnames, Name, MiddleName);
            Console.WriteLine("Дата рождения-{0}", Birthday.ToString("dd.MM.yyyy"));
            Console.WriteLine("Возраст-{0}", Age);
        }
    }
}
