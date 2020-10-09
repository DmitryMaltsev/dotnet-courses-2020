using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maltsev_DmitryTask_05
{
    class Program
    {
      
        static void Main(string[] args)
        {
            string Surnames;
            string Name;
            string MiddleName;
            try
            {
                Surnames = "Мальцев";
                Name = "Дмитрий";
                MiddleName = "Сергеевич";
                DateTime MyBirthday = new DateTime(2029,5, 6);                         
                User Me = new User(Surnames, Name, MiddleName, MyBirthday);
                PrintDates(Surnames, Name, MiddleName, MyBirthday, Me.Age);
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);              
            }              
        }
       private static void PrintDates(string surName, string name, string middleName, DateTime birthDay,int age)
        {
            Console.WriteLine($"ФИО гражданина={surName} {name} {middleName}");
            Console.WriteLine($"День рождения={birthDay.ToString("dd MM yyyy")}");
            Console.WriteLine($"Возраст={age}");
        }
    }  
}  
