using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    class Program
    {

        static void Main(string[] args)
        {
            string Surnames;
            string Name;
            string MiddleName;
            int WorkExperience;
            string Position;
            int MinWorkingAge;
            int MaxWorkingAge;
            try
            {
                Surnames = "Мальцев";
                Name = "Дмитрий";
                MiddleName = "Сергеевич";
                DateTime MyBirthday = new DateTime(1991, 6, 11);
                WorkExperience = 10;
                MinWorkingAge = 18;
                MaxWorkingAge = 70;
                Position = "Начальник начальников";                             
                //User Me = new User(Surnames, Name, MiddleName, MyBirthday);                              
                Emploee emploee = new Emploee(Surnames, Name, MiddleName,
                            MyBirthday,Position, WorkExperience, MinWorkingAge, MaxWorkingAge);
                PrintDates(Surnames, Name, MiddleName, MyBirthday, emploee.Age, emploee.Position, emploee.WorkExperience);               
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

        }
        private static void PrintDates(string surName, string name, string middleName, DateTime birthDay, int age,string position, int workExperience)
        {
            Console.WriteLine($"ФИО гражданина={surName} {name} {middleName}");
            Console.WriteLine($"День рождения={birthDay.ToString("dd MM yyyy")}");
            Console.WriteLine($"Возраст={age}");
            Console.WriteLine($"Должность={position}");
            Console.WriteLine($"Опыт работы={workExperience}");
        }
      
    }
}
