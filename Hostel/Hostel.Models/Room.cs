using System;
using System.Collections.Generic;

namespace Hostel.Models
{
    public class Room
    {
        public Room(int number, char unit, int maxStudents)
        {
            Number = number;
            Unit = unit;
            MaxStudents = maxStudents;
        }
        public Room(int number, char unit, int maxStudents,List<Student> students)
        {
            Number = number;
            Unit = unit;
            MaxStudents = maxStudents;
            Students = students;
        }

        public int Id { get; set; }
        public int Number { get; set; }
        public int Floor {
            get
            {
                //Номер этажа = первая цифра комнаты
                return Convert.ToInt32(Number.ToString().Substring(0, 1));
            }
            set 
            {
            }
        }
        public char Unit { get; set; }
        public int MaxStudents { get; set; }
        public List<Student> Students { get; set; }
    }
}
