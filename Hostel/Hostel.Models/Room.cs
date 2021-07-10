using System;
using System.Collections.Generic;

namespace Hostel.Models
{
    public class Room
    {
        public int Id { get; set; }
        public int Number { get; set; }
        public int Floor { get; set; }
        public char Unit { get; set; }
        public int MaxStudents { get; set; }
        public List<Student> Students { get; set; }
    }
}
