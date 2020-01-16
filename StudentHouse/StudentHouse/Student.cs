using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentHouseReception
{
    class Student
    {
        public Student(string surname, string lastname, string birthday, ulong studentNumber)
        {
            Surname = surname;
            LastName = lastname;
            Birthday = birthday;
            StudentNumber = studentNumber;
        }

        public string Surname
        {
            set
            {
                if (IsValidName(value))
                {
                    Surname = value;
                }
            }
            get
            {
                return Surname;
            }
        }

        public string LastName
        {
            set
            {
                if (IsValidName(value))
                {
                    LastName = value;
                }
            }
            get
            {
                return LastName;
            }
        }

        public string Birthday
        {
            set
            {
                if (IsValidBirthday(value))
                {
                    Birthday = value;
                }
            }
            get
            {
                return Birthday;
            }
        }

        public ulong StudentNumber
        {
            set
            {
                if (IsValidStudentNumber(value))
                {
                    StudentNumber = value;
                }
            }
            get
            {
                return StudentNumber;
            }
        }
        
        private bool IsValidName(string name)
        {
            if (name == "")
            {
                return false;
            }
            else return true;
        }

        private bool IsValidBirthday(string date)
        {
            if (date == "")
            {
                return false;
            }
            else return true;
        }

        private bool IsValidStudentNumber(ulong number)
        {
            if (number<=0)
            {
                return false;
            }
            else return true;
        }

        // Student student = new Student("Big","Chungus", "01012001", 123456789123);
    }
}
