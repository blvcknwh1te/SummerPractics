using Hostel.Data.Interfaces;
using Hostel.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Hostel.Data.Repository
{
    public class RoomsRepository : IAllRooms
    {
        public IEnumerable<Room> Rooms { get; set; }

        public IEnumerable<Room> GetFreeRooms()
        {
            return Rooms.Where(c => c.Students is null);
        }

        public IEnumerable<Room> GetRoomsOnFloor(int floorNum)
        {
            return Rooms.Where(c => c.FloorNumber == floorNum);
        }
    }
}
