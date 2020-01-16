using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentHouseReception
{
    class StudentRegistration
    {
        private Student student;
        private List<Room> rooms;
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
            this.rooms.Add(room);

        }
        // StudentRegistration registration = new StudentRegistration(rfid, student, room);

        private bool IsValidRfidTag(string rfid)
        {
            if (rfid == "")
            {
                return false;
            }
            else return true;
        }
        String OpenDoor(Room room, string rfid)
        {
            if(rooms.Contains(room))
            {
                return "Granted";
            }
            else
            {
                return "Denied";
            }
        }
    }
}
