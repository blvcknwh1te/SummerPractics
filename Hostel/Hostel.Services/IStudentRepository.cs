﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Hostel.Models;

namespace Hostel.Services
{
    interface IStudentRepository
    {
        IEnumerable<Student> GetAllStudents();
    }
}
