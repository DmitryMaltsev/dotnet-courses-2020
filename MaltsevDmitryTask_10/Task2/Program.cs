using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            Person jason = new Person("Jason");
            Person jim = new Person("Jim");
            Person dima = new Person("Dima");
            Person ivan = new Person("Ivan");
            List<Person> persons = new List<Person>()
            {
                jason,
                jim,
                dima,
                ivan
            };
            Office office = new Office(persons);
            jason.GoToWork();
            jim.GoToWork();
            dima.GoToWork();
            ivan.GoToWork();
            jason.GoHome();
            jim.GoHome();
            dima.GoHome();
            ivan.GoHome();
            jason.GoHome();
        }
    }

   


   
}
