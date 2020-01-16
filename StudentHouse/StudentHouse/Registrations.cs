using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentHouseReception
{
    class Registrations
    {
        private List<StudentRegistration> registrations;
        private List<Room> rooms;
        Registrations()
        {
            rooms = new List<Room>();
            for (uint number = 1; number<=150; number++)
            {
                rooms.Add(new Room(number));
            }
            registrations = new List<StudentRegistration>();
        }
        void Add(string Surname, string LastName, string Birthday, ulong StudentNumber, string rfidTag, uint roomNumber)
        {
            Room room = GetRoom(roomNumber);
            if(room != null)
            {
                Student student = new Student(Surname, LastName, Birthday, StudentNumber);
                //StudentRegistration stureg = new StudentRegistration();
                //registrations.Add(stureg);
            }
        }
        Room GetRoom(uint number)
        {
            foreach(Room room in rooms)
            {
                if (room.RoomNumber == number)
                {
                    return room;
                }
            }
            return null;
        }

        //public bool CanEnterRoom (string rfid, uint roomNumber)
        //{

        //}


    }
}
