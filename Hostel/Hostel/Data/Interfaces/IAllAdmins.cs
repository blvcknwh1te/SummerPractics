using Hostel.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Hostel.Data.Interfaces
{
    interface IAllAdmins
    {
        public IEnumerable<Admin> Admins { get; set; }
    }
}
