using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using Bank_Management.Business_Logic;

namespace Bank_Management.Data_Access
{
    class DataAccess
    {

        SqlConnection con = new SqlConnection(@"Data Source=ARNOB234\SQLEXPRESS2019;Initial Catalog=BankManagementSystem;Persist Security Info=True;User ID=Arnob;Password=01740");

        public DataTable GetAllCustomer()
        {
            DataTable dt = new DataTable();
            con.Open();
            string query = string.Format("SELECT * FROM customer");
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            con.Close();
            return dt;
        }

        public DataTable GetCustomer(BusinessLogic bl)
        {
            DataTable dt = new DataTable();
            con.Open();
            string query = string.Format("SELECT * FROM customer WHERE id = '"+bl.Acc_No+"'");
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            con.Close();
            return dt;
        }

        public DataTable AccLogin(BusinessLogic bl)
        {
            DataTable dt = new DataTable();
            con.Open();
            string query = string.Format("SELECT * FROM acclogin WHERE username ='"+bl.Acc_user+"'and password ='"+bl.Acc_pass+"'");
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            con.Close();
            return dt;
        }

        public DataTable CasLogin(BusinessLogic bl)
        {
            DataTable dt = new DataTable();
            con.Open();
            string query = string.Format("SELECT * FROM caslogin WHERE username ='" + bl.Cas_user + "'and password ='" + bl.Cas_pass + "'");
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            con.Close();
            return dt;
        }

        public bool Create(string n, string o, string t, string g, string d, string na, string a, int c, int ni, string e, int b)
        {
            con.Open();
            string query = string.Format("INSERT INTO customer(name,occupation,type,gender,dob,nationality,address,contact,nid,email,balance) VALUES('{0}','{1}','{2}','{3}','{4}','{5}','{6}',{7},{8},'{9}',{10})", n, o, t, g, d, na, a, c, ni, e, b);
            SqlCommand cmd = new SqlCommand(query, con);
            int rows = -1;
            rows = cmd.ExecuteNonQuery();
            if (rows >= 0)
            {
                return true;
            }
            return false;
        }

        public bool Update(int i, string n, string o, string t, string g, string d, string na, string a, int c, int ni, string e, int b)
        {
            con.Open();
            string query = string.Format("UPDATE customer SET name='{0}',occupation='{1}',type='{2}',gender='{3}',dob='{4}',nationality='{5}',address='{6}',contact={7},nid={8},email='{9}',balance={10} WHERE id={11}", n, o, t, g, d, na, a, c, ni, e, b, i);
            SqlCommand cmd = new SqlCommand(query, con);
            int rows = -1;
            rows = cmd.ExecuteNonQuery();
            if (rows >= 0)
            {
                return true;
            }
            return false;
        }

        public bool Delete(int id)
        {
            con.Open();
            string query = string.Format("DELETE FROM customer WHERE id={0} ", id);
            SqlCommand cmd = new SqlCommand(query, con);
            int rows = -1;
            rows = cmd.ExecuteNonQuery();
            if (rows >= 0)
            {
                return true;
            }
            return false;
        }

        public DataTable GetAllNotice()
        {
            DataTable dt = new DataTable();
            con.Open();
            string query = string.Format("SELECT * FROM Notices");
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            con.Close();
            return dt;
        }
        ~DataAccess()
        {
            if (con.State == ConnectionState.Open)
            {
                con.Close();
            }
        }

    }
}
