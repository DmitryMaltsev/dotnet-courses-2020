﻿using System;
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
            string surnames = "Мальцев";
            string name = "Дмитрий";
            string middleName = "Сергеевич";
            int age = 29;
            DateTime myBirthday = new DateTime(1991,8,20);      
            User Me = new User(surnames, name, middleName, myBirthday, age);
            Me.UsersDates();       
        }
    }
}
