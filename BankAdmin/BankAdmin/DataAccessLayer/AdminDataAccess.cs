using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace BankAdmin.DataAccessLayer
{
    class AdminDataAccess
    {
       
            SqlConnection con;
            public AdminDataAccess()
            {
                try
                {
                    con = new SqlConnection(@"Data Source=DESKTOP-VNJQTPT;Initial Catalog=BankAdmin;Integrated Security=True");
                    if (con.State == ConnectionState.Closed)
                    {
                        con.Open();
                    }
                }
                catch (Exception ex)
                {
                    con.Close();
                }
            }
            public bool AdminLogin(int id, string password)
            {
                try
                {
                    string query = string.Format("Select * from LogAdmins where id={0} and password='{1}' ", id, password);
                    SqlCommand cmd = new SqlCommand(query, con);
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    if (dt.Rows.Count > 0)
                    {
                        return true;
                    }
                    return false;
                }
                catch (Exception ex)
                {
                    return false;
                }
            }
        }
    }


