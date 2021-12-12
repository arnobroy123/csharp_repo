using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;


namespace BankAdmin.DataAccessLayer
{
    public class DataAccess
    {
       SqlConnection con;
       public DataAccess()
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

       public bool Insert(string name, string gender, string email, string address, int contact, DateTime JoinningDate, string position, string password, string salary,string commition)
       {
           con.Open();
           string query = string.Format("INSERT INTO EmpReg(name,gender,email,address,contact,JoinningDate,position,password,Salary,Commition) VALUES('{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}','{8}',{9})", name, gender, email, address, contact, JoinningDate, position, password, salary, commition);
           SqlCommand cmd = new SqlCommand(query, con);
           int rows = -1;
           rows = cmd.ExecuteNonQuery();
           if (rows >= 0)
           {
               return true;
           }
           return false;
       }


       /*public bool Search(int id)
       {
           con.Open();
           string query = string.Format("SELECT * FROM EmpReg WHERE id={0}",id);
           SqlCommand cmd = new SqlCommand(query, con);
           SqlDataAdapter da = new SqlDataAdapter(cmd);
           int rows = -1;
           rows = cmd.ExecuteNonQuery();
           if (rows >= 0)
           {
               return true;
           }
           return false;
       } */
       public bool Update(int id, string name, string email, string address, int contact, string position)
       {
           con.Open();
           string query = string.Format("UPDATE EmpReg SET name='{0}', email='{1}',address='{2}',contact={3},position='{4}' WHERE id={5} ", name, email, address, contact, position, id);
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
           string query = string.Format("DELETE FROM EmpReg WHERE id={0} ", id);
           SqlCommand cmd = new SqlCommand(query, con);
           int rows = -1;
           rows = cmd.ExecuteNonQuery();
           if (rows >= 0)
           {
               return true;
           }
           return false;
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

       public bool UpdateCom(int id, string commition)
       {
           con.Open();
           string query = string.Format("UPDATE EmpReg SET Commition='{0}' WHERE id={1} ", commition, id);
           SqlCommand cmd = new SqlCommand(query, con);
           int rows = -1;
           rows = cmd.ExecuteNonQuery();
           if (rows >= 0)
           {
               return true;
           }
           return false;
       }

       public DataTable GetAllEmpMgr()
       {
           con = new SqlConnection(@"Data Source=DESKTOP-VNJQTPT;Initial Catalog=BankAdmin;Integrated Security=True");
           con.Open();
           string query = string.Format("SELECT * FROM EmpReg where position ='Manager'");
           SqlCommand cmd = new SqlCommand(query, con);
           SqlDataAdapter da = new SqlDataAdapter(cmd);
           DataTable dt = new DataTable();
           da.Fill(dt);
           con.Close();
           return dt;
       }

       public DataTable GetAllEmpAcc()
       {
           con = new SqlConnection(@"Data Source=DESKTOP-VNJQTPT;Initial Catalog=BankAdmin;Integrated Security=True");
           con.Open();
           string query = string.Format("SELECT * FROM EmpReg where position ='Accountent'");
           SqlCommand cmd = new SqlCommand(query, con);
           SqlDataAdapter da = new SqlDataAdapter(cmd);
           DataTable dt = new DataTable();
           da.Fill(dt);
           con.Close();
           return dt;
       }

       public DataTable GetAllEmpCash()
       {
           con = new SqlConnection(@"Data Source=DESKTOP-VNJQTPT;Initial Catalog=BankAdmin;Integrated Security=True");
           con.Open();
           string query = string.Format("SELECT * FROM EmpReg where position ='Cashier'");
           SqlCommand cmd = new SqlCommand(query, con);
           SqlDataAdapter da = new SqlDataAdapter(cmd);
           DataTable dt = new DataTable();
           da.Fill(dt);
           con.Close();
           return dt;
       }


       public DataTable GetAllEmpStaff()
       {
           con = new SqlConnection(@"Data Source=DESKTOP-VNJQTPT;Initial Catalog=BankAdmin;Integrated Security=True");
           con.Open();
           string query = string.Format("SELECT * FROM EmpReg where position ='Staff'");
           SqlCommand cmd = new SqlCommand(query, con);
           SqlDataAdapter da = new SqlDataAdapter(cmd);
           DataTable dt = new DataTable();
           da.Fill(dt);
           con.Close();
           return dt;
       }

       public DataTable GetAllCust()
       {
           con = new SqlConnection(@"Data Source=DESKTOP-VNJQTPT;Initial Catalog=BankAdmin;Integrated Security=True");
           con.Open();
           string query = string.Format("SELECT * FROM customer");
           SqlCommand cmd = new SqlCommand(query, con);
           SqlDataAdapter da = new SqlDataAdapter(cmd);
           DataTable dt = new DataTable();
           da.Fill(dt);
           con.Close();
           return dt;
       }



        }
    }

