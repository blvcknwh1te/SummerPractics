using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Hostel.Data.Models
{
    public class Student
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string SecondName { get; set; }
        public string Surname { get; set; }
        public string Nationality { get; set; }
        public char Gender { get; set; }
        public string Faculty { get; set; }
        public int Course { get; set; }
        public string Group { get; set; }
        public int OrderNumber { get; set; }
        public DateTime DateIn { get; set; }
        public DateTime DateOut { get; set; }
    }
}
