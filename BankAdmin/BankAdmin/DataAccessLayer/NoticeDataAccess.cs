using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace BankAdmin.DataAccessLayer
{
    class NoticeDataAccess
    {

        SqlConnection con;
       public NoticeDataAccess()
       {
           con = new SqlConnection(@"Data Source=DESKTOP-VNJQTPT;Initial Catalog=BankAdmin;Integrated Security=True");
           if (con.State == ConnectionState.Closed)
           {
               con.Open();
           }
       }

       public DataTable GetAllNotice()
       {
           con = new SqlConnection(@"Data Source=DESKTOP-VNJQTPT;Initial Catalog=BankAdmin;Integrated Security=True");
           con.Open();
           string query = string.Format("SELECT * FROM Notices");
           SqlCommand cmd = new SqlCommand(query, con);
           SqlDataAdapter da = new SqlDataAdapter(cmd);
           DataTable dt = new DataTable();
           da.Fill(dt);
           con.Close();
           return dt;
       }

       public bool Insert( string notice)
       {
           con.Open();
           string query = string.Format("INSERT INTO Notices(notice) VALUES('{0}')", notice);
           SqlCommand cmd = new SqlCommand(query, con);
           int rows = -1;
           rows = cmd.ExecuteNonQuery();
           if (rows >= 0)
           {
               return true;
           }
           return false;
       }
    }
}
