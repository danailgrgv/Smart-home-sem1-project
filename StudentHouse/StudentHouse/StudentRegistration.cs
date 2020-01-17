using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentHouseReception
{
    class StudentRegistration
    {
        private readonly Student student;
        private readonly Room room = null;
        public string RfidTag
        {
            set
            {
                if(IsValidRfidTag(value))
                {
                    RfidTag = value;
                }
            }
            get
            {
                return RfidTag;
            }
        }

        public StudentRegistration(string rfid, Student student, Room room)
        {
            RfidTag = rfid;
            this.student = student;
            this.room = room;

        }

        private bool IsValidRfidTag(string rfid)
        {
            if (rfid == "")
            {
                return false;
            }
            else return true;
        }
    }
    // StudentRegistration registration = new StudentRegistration(rfid, student, room);
}
