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
            string surnames;
            string name;
            string middleName;
            DateTime myBirthday;
            try
            {
                surnames = "Мальцев";
                name = "Дмитрий";
                middleName = "Сергеевич";
                myBirthday = new DateTime(2019,9, 9);                         
                User Me = new User(surnames, name, middleName, myBirthday);
                PrintUserDates(Me);
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);              
            }              
        }
       private static void PrintUserDates(User user)
        {
            Console.WriteLine($"ФИО гражданина={user.Surnames} {user.Name} {user.Middlename}");
            Console.WriteLine($"День рождения={user.Birthday.ToString("dd MM yyyy")}");
            Console.WriteLine($"Количество лет={user.CalculateAge()}");
        }
    }  
}  
