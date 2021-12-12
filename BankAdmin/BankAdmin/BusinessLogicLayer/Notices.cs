using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BankAdmin.DataAccessLayer;

namespace BankAdmin.BusinessLogicLayer
{
     public class Notices
    {
        public int notice_number{ get; set;}
        public string notice { get; set; }

        NoticeDataAccess  da = new NoticeDataAccess();

        Notices n;

        public List<Notices> GetAllNotice()
        {
            var employees = da.GetAllNotice();

            List<Notices> list = new List<Notices>();
            for (int i = 0; i < employees.Rows.Count; i++)
            {
                n = new Notices();
                n.notice_number = int.Parse(employees.Rows[i][0].ToString());
                n.notice = employees.Rows[i][1].ToString();
                list.Add(n);
            }
            return list;
        }

        public bool InsertNotice(string notice)
        {
            return da.Insert(notice);
        }
    }
}
