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
            new Student("���������","���������","����������","��������",'�',
                "����",3,10701218,1,new DateTime(2018,8,20),new DateTime (2022,8,20),new Room(222,'�',2)),

            new Student("����������","�����","����������","��������",'�',
                "����",3,10701218,2,new DateTime(2018,8,18),new DateTime (2022,8,22),new Room(227,'�',3)),

            new Student("��������","�������","���������","������",'�',
                "����",3,10701219,1,new DateTime(2019,7,30),new DateTime (2023,8,26),new Room(313,'�',3)),

            new Student("�������","�����","����������","�������",'�',
                "����",3,10701220,1,new DateTime(2020,8,13),new DateTime (2024,9,1),new Room(459,'�',2)),

            new Student("����","������","��������","���",'�',
                "���",3,10701218,1,new DateTime(2018,8,22),new DateTime (2022,8,10),new Room(455,'�',1))
        };

        public int[] rooms = { 222, 227, 313, 459, 455 };
        public int[] floors= {2,2,3,4,4 };
        public char[] blocks = {'�','�','�','�','�' };
        
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
