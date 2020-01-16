using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentHouseReception
{
    class Room
    {
        public Room(uint number)
        {
            RoomNumber = number;
        }

        public uint RoomNumber
        {
            get
            {
                return RoomNumber;
            }
            set
            {
                RoomNumber = value;
            }
        }
        // Room room = new Room(123);
    }

}
