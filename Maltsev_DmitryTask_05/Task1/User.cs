﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maltsev_DmitryTask_05
{
    public class User
    {
        private string Surnames;
        private string Name;
        private string MiddleName;
        private DateTime Birthday;
        private int age;
        public User(string surnames, string name, string middleName, DateTime birthDay)
        {
            Surnames = surnames;
            Name = name;
            MiddleName = middleName;
            Birthday = birthDay;
        }
        public int Age
        {
            get
            {
             return age = CalculateAge();              
            }      
        }
        private int CalculateAge()
        {
            if (Birthday > DateTime.Now)
            {
                throw new Exception("Дата рождения больше текущей даты. Введите верную дату");
            }
            int ageFromBirth=0;
            DateTime now = DateTime.Now;      
        if (now.Month > Birthday.Month)
        {
           ageFromBirth = now.Year - Birthday.Year;
        }
        else
         if (now.Month == Birthday.Month)
         {
            if (now.Day >= Birthday.Day)
           {
             ageFromBirth = now.Year - Birthday.Year;
           }
         }
          else 
          {
            ageFromBirth = now.Year - 1 - Birthday.Year;
          }                   
            return ageFromBirth;
        }
    }
}