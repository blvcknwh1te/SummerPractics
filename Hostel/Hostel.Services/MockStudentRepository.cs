using Hostel.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hostel.Services
{
    class MockStudentRepository : IStudentRepository
    {
        private List<Student> _students;

        public MockStudentRepository()
        {
            _students = new List<Student>()
            {
                new Student()
                {
                    Id = 1,
                    Surname = "Кармальков",
                    FirstName = "Артём",
                    SecondName = "Валерьевич",
                    Sex = 'М',
                    Course = 3
                },
                new Student()
                {
                    Id = 1,
                    Surname = "Ерофеенко",
                    FirstName = "Владислав",
                    SecondName = "Алексеевич",
                    Sex = 'М',
                    Course = 3
                }
            };
        }

        public IEnumerable<Student> GetAllStudents()
        {
            return _students;
        }
    }
}
