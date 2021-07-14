using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Hostel.Models;

namespace Hostel.Services
{
    public interface IStudentRepository
    {
        public IEnumerable<Student> GetAllStudents();

        public Student Add(Student newStudent);
        public Student Delete(int id);
    }
}
