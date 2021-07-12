using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Hostel.Models;

namespace Hostel.Services
{
    interface IRoomRepository
    {
        public IEnumerable<Room> GetAllRooms();

        public Room Add(Room newRoom);
        public Room Delete(int id);
    }
}
