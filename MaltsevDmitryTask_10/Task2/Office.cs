using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    public delegate void SayHello(string otherPerson, DateTime time);
    public delegate void SayGoodBye(string oterPerson);

    public class Office
    {
        private SayHello greetAll;
        private SayGoodBye goodbyeAll;

        public Office(List<Person> persons)
        {
            foreach (var p in persons)
            {
                p.OnCame += OnCameHandler;
                p.OnLeave += OnLeaveHanler;
            }
        }

        private void OnCameHandler(Person p, DateTime time)
        {
            Console.WriteLine($"Person {p.Name} came to work");
            greetAll?.Invoke(p.Name, DateTime.Now);

            greetAll += p.SayHello;
            goodbyeAll += p.SayGoodBye;
        }
        private void OnLeaveHanler(Person p)
        {
            Console.WriteLine($"Person {p.Name} go at home");
            greetAll -= p.SayHello;
            goodbyeAll -= p.SayGoodBye;
            goodbyeAll?.Invoke(p.Name);
        }
    }
}
