using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Hostel.Data.Models;

namespace Hostel.Data.Interfaces
{
    public interface IAllRooms
    {
        IEnumerable<Room> Rooms { get; set; }
        public IEnumerable<Room> GetRoomsOnFloor(int floorNum);
        public IEnumerable<Room> GetFreeRooms();
    }
}
