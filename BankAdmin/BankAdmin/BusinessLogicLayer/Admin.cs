using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BankAdmin.DataAccessLayer;

namespace BankAdmin.BusinessLogicLayer
{
    class Admin
    {
        AdminDataAccess ad = new AdminDataAccess();
        public bool AdminLogin(int id, string password)
        {
            return ad.AdminLogin(id, password);
        }
    }
}
