using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    public delegate void Came(Person p, DateTime date);
    public delegate void Leave(Person p);

    public class Person
    {
        public Person(string name)
        {
            Name = name;
        }
        public string Name { get; set; }
        public event Came OnCame;
        public event Leave OnLeave;

        public void GoToWork()
        {
            OnCame?.Invoke(this, DateTime.Now);
        }

        public void GoHome()
        {
            OnLeave?.Invoke(this);
        }

        public void SayHello(string otherPerson, DateTime time)
        {
            string timeOfDay = "";
            if (time.Hour > 5 && time.Hour < 12)
            {
                timeOfDay = "Доброе утро";
            }
            if (time.Hour >= 12 && time.Hour < 17)
            {
                timeOfDay = "Добрый день";
            }
            if (time.Hour >= 17)
            {
                timeOfDay = "Добрый вечер";
            }
            Console.WriteLine($"{timeOfDay} {otherPerson}! Сказал {Name}.");
        }

        public void SayGoodBye(string otherPerson)
        {
            Console.WriteLine($"Хорошего дня {otherPerson}!  Сказал {Name}.");
        }
    }
}
