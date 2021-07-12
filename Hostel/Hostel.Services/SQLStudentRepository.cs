using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Hostel.Models;

namespace Hostel.Services
{
    public class SQLStudentRepository : IStudentRepository
    {
        private readonly AppDBContext _context;

        public SQLStudentRepository(AppDBContext context)
        {
            _context = context;
        }

        public Student Add(Student newStudent)
        {
            _context.Students.Add(newStudent);
            _context.SaveChanges();
            return newStudent;
        }

        public Student Delete(int id)
        {
            var studentToDelete = _context.Students.Find(id);

            if(studentToDelete != null)
            {
                _context.Students.Remove(studentToDelete);
                _context.SaveChanges();
            }

            return studentToDelete;
        }

        public IEnumerable<Student> GetAllStudents()
        {
            return _context.Students;
        }
    }
}
