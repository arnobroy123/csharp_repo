using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace BankAdmin.DataAccessLayer
{
    class SalaryDataAccess
    {
        SqlConnection con;
        public SalaryDataAccess()
        {
            con = new SqlConnection(@"Data Source=DESKTOP-VNJQTPT;Initial Catalog=BankAdmin;Integrated Security=True");
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
        }


            public DataTable GetAllEmp()
       {
           con = new SqlConnection(@"Data Source=DESKTOP-VNJQTPT;Initial Catalog=BankAdmin;Integrated Security=True");
           con.Open();
           string query = string.Format("SELECT * FROM EmpReg");
           SqlCommand cmd = new SqlCommand(query, con);
           SqlDataAdapter da = new SqlDataAdapter(cmd);
           DataTable dt = new DataTable();
           da.Fill(dt);
           con.Close();
           return dt;
       }


            public bool UpdateSal(int id, string salary)
            {
                con.Open();
                string query = string.Format("UPDATE EmpReg SET Salary='{0}' WHERE id={1} ", salary, id);
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
