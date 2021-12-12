using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Bank_Management.Data_Access;

namespace Bank_Management.Business_Logic
{
    class BusinessLogic
    {
        public string Acc_user { set; get; }
        public string Acc_pass { set; get; }

        public string Cas_user { set; get; }
        public string Cas_pass { set; get; }

        public int Acc_No { set; get; }

        DataAccess da = new DataAccess();

        public bool CreateCustomer(string n, string o, string t, string g, string dob, string na, string a, int c, int ni, string e, int b)
        {
            return da.Create(n, o, t, g, dob, na, a, c, ni, e, b);
        }

        public bool UpdateCustomer(int i, string n, string o, string t, string g, string d, string na, string a, int c, int ni, string e, int b)
        {
            return da.Update(i, n, o, t, g, d, na, a, c, ni, e, b);
        }

        public bool DeleteCustomer(int id)
        {
            return da.Delete(id);
        }
    }
}
