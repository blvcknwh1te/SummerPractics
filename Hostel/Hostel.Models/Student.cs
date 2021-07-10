using System;

namespace Hostel.Models
{
    public class Student
    {
        public int Id { get; set; }
        public string Surname { get; set; }
        public string FirstName { get; set; }
        public string SecondName { get; set; }
        public string Nationality { get; set; }
        public char Sex { get; set; }
        public string Faculty { get; set; }
        public int Course { get; set; }
        public int Group { get; set; }
        public int OrderNumber { get; set; }
        public DateTime DataIn { get; set; }
        public DateTime DataOut { get; set; }
        public Room Room { get; set; }
    }
}
