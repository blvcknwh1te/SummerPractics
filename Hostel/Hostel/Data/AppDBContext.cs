using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Hostel.Data.Models;
using Microsoft.EntityFrameworkCore;

namespace Hostel.Data
{
    public class AppDBContext : DbContext
    {
        public DbSet<Room> Rooms { get; set; }
        public DbSet<Student> Students { get; set; }

        public AppDBContext()
        {
            Database.EnsureCreated();
        }
    }
}
