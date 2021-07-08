using Hostel.Data.Interfaces;
using Hostel.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Hostel.Data.Repository
{
    public class AdminsRepository : IAllAdmins
    {
        private AppDBContext _appDB;
        public IEnumerable<Admin> Admins { get; set; }

        public AdminsRepository(AppDBContext dBContext)
        {
            _appDB = dBContext;
            Admins = _appDB.Admins;
        }

        public void Save()
        {
            foreach(var el in Admins)
            {
                if (!_appDB.Admins.Contains(el))
                {
                    _appDB.Admins.Add(el);
                }
            }
            _appDB.SaveChanges();
        }
    }
}
