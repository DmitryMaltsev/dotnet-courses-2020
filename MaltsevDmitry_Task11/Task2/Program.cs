using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    class Program
    {

        static void Main(string[] args)
        {
            string surnames;
            string name;
            string middleName;
            DateTime startWorking;
            DateTime myBirthday;
            string position;
            try
            {
                surnames = "Мальцев";
                name = "Дмитрий";
                middleName = "Сергеевич";
                myBirthday = new DateTime(1991, 6, 11);
                startWorking = new DateTime(2015, 6, 11);
                position = "Начальник начальников";
                Emploee emploee = new Emploee(surnames, name, middleName,
                    myBirthday, position, startWorking);
                Emploee emploee2=new Emploee(surnames, name, middleName,
                    myBirthday, position, startWorking);

                PrintEmploeeDates(emploee);
                emploee.Equals(emploee2);
                
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

        }

        private static void PrintEmploeeDates(Emploee user)
        {
            Console.WriteLine($"ФИО гражданина={user.Surnames} {user.Name} {user.Middlename}");
            Console.WriteLine($"День рождения={user.Birthday.ToString("dd MM yyyy")}");
            Console.WriteLine($"Количество лет={user.Age}");
            Console.WriteLine($"дата начала работы={user.StartWorking.ToString("dd MM yyyy")}");
            Console.WriteLine($"Стаж работы={user.WorkExperience}");
        }
    }
}
