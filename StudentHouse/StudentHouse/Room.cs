using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentHouseReception
{
    class Room
    {
        private uint number;

        public Room(uint number)
        {
            this.number = number;
        }

        //public uint RoomNumber
        //{
        //    get
        //    {
        //        return RoomNumber;
        //    }
        //    set
        //    {
        //        if (IsValidRoomNumber(value))
        //        {
        //            RoomNumber = value;
        //        }
        //    }
        //}

        //private bool IsValidRoomNumber(ulong number)
        //{
        //    if (number >= 1 && number <= 150)
        //    {
        //        return false;
        //    }
        //    else return true;
        //}

        // Room room = new Room(123);
    }

}
