using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentHouseReception
{
    class Student
    {
        private string firstname;
        private string lastname;
        private string birthday;
        private ulong studentnumber;

        public Student(string firstname, string lastname, string birthday, ulong studentNumber)
        {
            this.firstname = firstname;
            this.lastname = lastname;
            this.birthday = birthday;
            this.studentnumber = studentNumber;
        }

        //public string FirstName
        //{
        //    set
        //    {
        //       // if (IsValidName(value))
        //        //{
        //            FirstName = firstname;
        //        //}
        //    }
        //    get
        //    {
        //        return firstname;
        //    }
        //}

        //public string LastName
        //{
        //    set
        //    {
        //        //if (IsValidName(value))
        //        //{
        //            lastname = value;
        //        //}
        //    }
        //    get
        //    {
        //        return lastname;
        //    }
        //}

        //public string Birthday
        //{
        //    set
        //    {
        //        if (IsValidBirthday(value))
        //        {
        //            birthday = value;
        //        }
        //    }
        //    get
        //    {
        //        return birthday;
        //    }
        //}

        //public ulong StudentNumber
        //{
        //    set
        //    {
        //        if (IsValidStudentNumber(value))
        //        {
        //            studentnumber = value;
        //        }
        //    }
        //    get
        //    {
        //        return studentnumber;
        //    }
        //}
        
        //private bool IsValidName(string name)
        //{
        //    if (name == "")
        //    {
        //        return false;
        //    }
        //    else return true;
        //}

        //private bool IsValidBirthday(string date)
        //{
        //    if (date == "")
        //    {
        //        return false;
        //    }
        //    else return true;
        //}

        //private bool IsValidStudentNumber(ulong number)
        //{
        //    if (number<=0)
        //    {
        //        return false;
        //    }
        //    else return true;
        //}

        // Student student = new Student("Big","Chungus", "01012001", 123456789123);
    }
}
