using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Hostel.Data.Models
{
    public class Room
    {
        public int Id { get; set; }
        public int RoomNumber { get; set; }
        public int FloorNumber { get; set; }
        public char Unit { get; set; }
        public int MaxNumberOfStudents { get; set; }
        public List<Student> Students { get; set; }
    }
}
