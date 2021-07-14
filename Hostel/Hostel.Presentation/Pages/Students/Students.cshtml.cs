using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Hostel.Services;
using Hostel.Models;

namespace Hostel.Presentation.Pages.Students
{
    public class StudentsModel : PageModel
    {
        private readonly IStudentRepository _studentsDB;



        public List<Student> tempStudents = new List<Student>()
        {
            new Student("Ерофеенко","Владислав","Алексеевич","Беларусь",'М',
                "ФИТР",3,10701218,1,new DateTime(2018,8,20),new DateTime (2022,8,20),new Room(222,'А',2)),

            new Student("Кармальков","Артем","Витальевич","Беларусь",'М',
                "ФИТР",3,10701218,2,new DateTime(2018,8,18),new DateTime (2022,8,22),new Room(227,'А',3)),

            new Student("Кузнецов","Дмитрий","Сергеевич","Россия",'М',
                "ФИТР",3,10701219,1,new DateTime(2019,7,30),new DateTime (2023,8,26),new Room(313,'Б',3)),

            new Student("Лапушко","Ирина","Валерьевна","Украина",'Ж',
                "ФММП",3,10701220,1,new DateTime(2020,8,13),new DateTime (2024,9,1),new Room(459,'А',2)),

            new Student("Уайт","Уолтер","Хартвелл","США",'М',
                "ИПФ",3,10701218,1,new DateTime(2018,8,22),new DateTime (2022,8,10),new Room(455,'Б',1))
        };

        public int[] rooms = { 222, 227, 313, 459, 455 };
        public int[] floors= {2,2,3,4,4 };
        public char[] blocks = {'А','А','Б','А','Б' };
        
        public StudentsModel(IStudentRepository studentsDB)
        {
            _studentsDB = studentsDB;
        }

        public IEnumerable<Student> Students { get; set; }
        public void OnGet()
        {
            Students = _studentsDB.GetAllStudents();
            if (Students.Count() < 1) CreateMockModel();
        } 

        public void AddStudents(Student student)
        {
            _studentsDB.Add(student);
            
        }

        public void CreateMockModel()
        {
            for (var i = 0; i < 5; i++)
            {

                AddStudents(tempStudents[i]);
            }
        }

    }
}
