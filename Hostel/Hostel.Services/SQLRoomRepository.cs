using Hostel.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hostel.Services
{
    class SQLRoomRepository : IRoomRepository
    {
        private readonly AppDBContext _context;

        public SQLRoomRepository(AppDBContext context)
        {
            _context = context;
        }

        public Room Add(Room newRoom)
        {
            _context.Rooms.Add(newRoom);
            _context.SaveChanges();
            return newRoom;
        }

        public Room Delete(int id)
        {
            var roomToDelete = _context.Rooms.Find(id);

            if(roomToDelete != null)
            {
                _context.Rooms.Remove(roomToDelete);
                _context.SaveChanges();
            }

            return roomToDelete;
        }

        public IEnumerable<Room> GetAllRooms()
        {
            return _context.Rooms;
        }

        public void Fill()
        {

        }
    }
}
