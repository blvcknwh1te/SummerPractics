using System;

namespace Hostel.Models
{
    public class Student
    {
        public Student()
        {

        }

        public Student(string fullname, string nationality, char gender, string faculty, int course, int group, int orderNumber, DateTime dataIn, DateTime dataOut)
        {
            FullName = fullname;
            Nationality = nationality;
            Gender = gender;
            Faculty = faculty;
            Course = course;
            Group = group;
            OrderNumber = orderNumber;
            DataIn = dataIn;
            DataOut = dataOut;
        }

        public int Id { get; set; }
        public string FullName { get; set; }
        public string Nationality { get; set; }
        public char Gender { get; set; }
        public string PhoneNumber { get; set; }
        public string Faculty { get; set; }
        public int Course { get; set; }
        public int Group { get; set; }
        public int OrderNumber { get; set; }
        public DateTime DataIn { get; set; }
        public DateTime DataOut { get; set; }
        public Room Room { get; set; }
    }
}
