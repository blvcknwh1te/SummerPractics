using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Hostel.Data.Models;

namespace Hostel.Data.Interfaces
{
    interface IAllStudents
    {
        IEnumerable<Student> Students { get; set; }
    }
}
