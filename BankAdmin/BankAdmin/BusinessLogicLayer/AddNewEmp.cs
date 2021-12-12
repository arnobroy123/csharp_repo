using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BankAdmin.DataAccessLayer;
using System.Data;

namespace BankAdmin.BusinessLogicLayer
{
    public class AddNewEmp
    {
        public int id { get; set; }
        public string name { get; set; }
        public string gender { get; set; }
        public string email { get; set; }
        public string address { get; set; }
        public int contact { get; set; }
        public DateTime JoinningDate { get; set; }
        public string position { get; set; }
        public string password { get; set; }
        public string salary { get; set; }
        public string commition { get; set; }

        
        DataAccess da = new DataAccess();                         
         AddNewEmp p;

          public List<AddNewEmp> GetAllEmp()
        {
        var employees = da.GetAllEmp();
            
            List<AddNewEmp> list = new List<AddNewEmp>();
            for (int i = 0; i < employees.Rows.Count; i++)
            {
                p = new AddNewEmp();
                p.id = int.Parse(employees.Rows[i][0].ToString());
                p.name = employees.Rows[i][1].ToString();
                p.gender = employees.Rows[i][2].ToString();
                p.email = employees.Rows[i][3].ToString();
                p.address = employees.Rows[i][4].ToString();
                p.contact =int.Parse(employees.Rows[i][5].ToString());
                p.JoinningDate = Convert.ToDateTime(employees.Rows[i][6].ToString());
                p.position = employees.Rows[i][7].ToString();
                p.password = employees.Rows[i][8].ToString();
                p.salary = employees.Rows[i][9].ToString();
                p.commition =employees.Rows[i][10].ToString();

                list.Add(p);
            }
            return list;
        }



          public List<AddNewEmp> GetAllEmpMgr()
          {
              var employees = da.GetAllEmpMgr();

              List<AddNewEmp> list = new List<AddNewEmp>();
              for (int i = 0; i < employees.Rows.Count; i++)
              {
                  p = new AddNewEmp();
                  p.id = int.Parse(employees.Rows[i][0].ToString());
                  p.name = employees.Rows[i][1].ToString();
                  p.gender = employees.Rows[i][2].ToString();
                  p.email = employees.Rows[i][3].ToString();
                  p.address = employees.Rows[i][4].ToString();
                  p.contact = int.Parse(employees.Rows[i][5].ToString());
                  p.JoinningDate = Convert.ToDateTime(employees.Rows[i][6].ToString());
                  p.position = employees.Rows[i][7].ToString();
                  p.password = employees.Rows[i][8].ToString();
                  p.salary = employees.Rows[i][9].ToString();
                  p.commition = employees.Rows[i][10].ToString();

                  list.Add(p);
              }
              return list;
          }

          public List<AddNewEmp> GetAllEmpAcc()
          {
              var employees = da.GetAllEmpAcc();

              List<AddNewEmp> list = new List<AddNewEmp>();
              for (int i = 0; i < employees.Rows.Count; i++)
              {
                  p = new AddNewEmp();
                  p.id = int.Parse(employees.Rows[i][0].ToString());
                  p.name = employees.Rows[i][1].ToString();
                  p.gender = employees.Rows[i][2].ToString();
                  p.email = employees.Rows[i][3].ToString();
                  p.address = employees.Rows[i][4].ToString();
                  p.contact = int.Parse(employees.Rows[i][5].ToString());
                  p.JoinningDate = Convert.ToDateTime(employees.Rows[i][6].ToString());
                  p.position = employees.Rows[i][7].ToString();
                  p.password = employees.Rows[i][8].ToString();
                  p.salary = employees.Rows[i][9].ToString();
                  p.commition = employees.Rows[i][10].ToString();

                  list.Add(p);
              }
              return list;
          }

          public List<AddNewEmp> GetAllEmpCash()
          {
              var employees = da.GetAllEmpCash();

              List<AddNewEmp> list = new List<AddNewEmp>();
              for (int i = 0; i < employees.Rows.Count; i++)
              {
                  p = new AddNewEmp();
                  p.id = int.Parse(employees.Rows[i][0].ToString());
                  p.name = employees.Rows[i][1].ToString();
                  p.gender = employees.Rows[i][2].ToString();
                  p.email = employees.Rows[i][3].ToString();
                  p.address = employees.Rows[i][4].ToString();
                  p.contact = int.Parse(employees.Rows[i][5].ToString());
                  p.JoinningDate = Convert.ToDateTime(employees.Rows[i][6].ToString());
                  p.position = employees.Rows[i][7].ToString();
                  p.password = employees.Rows[i][8].ToString();
                  p.salary = employees.Rows[i][9].ToString();
                  p.commition = employees.Rows[i][10].ToString();

                  list.Add(p);
              }
              return list;
          }

          public List<AddNewEmp> GetAllEmpStaff()
          {
              var employees = da.GetAllEmpStaff();

              List<AddNewEmp> list = new List<AddNewEmp>();
              for (int i = 0; i < employees.Rows.Count; i++)
              {
                  p = new AddNewEmp();
                  p.id = int.Parse(employees.Rows[i][0].ToString());
                  p.name = employees.Rows[i][1].ToString();
                  p.gender = employees.Rows[i][2].ToString();
                  p.email = employees.Rows[i][3].ToString();
                  p.address = employees.Rows[i][4].ToString();
                  p.contact = int.Parse(employees.Rows[i][5].ToString());
                  p.JoinningDate = Convert.ToDateTime(employees.Rows[i][6].ToString());
                  p.position = employees.Rows[i][7].ToString();
                  p.password = employees.Rows[i][8].ToString();
                  p.salary = employees.Rows[i][9].ToString();
                  p.commition = employees.Rows[i][10].ToString();

                  list.Add(p);
              }
              return list;
          }
           
        public bool CreateEmp(string name, string gender, string email, string address, int contact, DateTime JoinningDate, string position, string password, string salary,string commition)
        {
            return da.Insert(name, gender, email, address, contact, JoinningDate, position, password, salary,commition);
        }

        /*public bool SearchEmp(int id)
        {
            return da.Search(id);
        }      */
        public bool UpdateEmp(int id,string name,string email,string address, int contact, string position)
        {
            return da.Update(id,name,email, address, contact,position);
        }

        public bool DeleteEmp(int id)
        {
            return da.Delete(id);
        }

        public bool UpdateSalary(int id, string salary)
        {
            return da.UpdateSal(id, salary);
        }

        public bool UpdateCommition(int id, string commition)
        {
            return da.UpdateCom(id, commition);
        }
       
    }

}
