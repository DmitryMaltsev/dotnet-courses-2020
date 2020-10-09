using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    class Emploee:User
    {
        private string position;
        private int workExperience;
        private int MinWorkingAge;
        private int MaxWorkingAge;
        public Emploee(string surnames, string name, string middleName, DateTime birthday,string pos,int workExp,int minWorkingAge,int maxWorkingAge)
            :base (surnames,name,middleName,birthday)
        {
            Position = pos;
            MaxWorkingAge = maxWorkingAge;
            MinWorkingAge = minWorkingAge;
            WorkExperience = workExp;
            Position = pos;
        }
        public string Position
        {
            get
            {
                return position;
            }
            set
            {
                position = value;
            }
        }
        public int WorkExperience
        {
            get
            {
                CheckWorkExperience();
                return workExperience;
            }
            set
            {              
                workExperience = value;
            }                 
        }
        private void CheckWorkExperience()
        {
            if (workExperience < 0)
                throw new Exception("В строку \"Стаж работы\" введено отрицательное число");

            if ((Age - workExperience < MinWorkingAge) || (Age - workExperience > MaxWorkingAge))
            {
                {
                    throw new Exception($"Срок начала работы < {MinWorkingAge} лет или >{MaxWorkingAge}, что противоречит законодательству");
                }
            }         
        }

    }
}
