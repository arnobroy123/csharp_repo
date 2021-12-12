using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BankAdmin.BusinessLogicLayer;
using BankAdmin.DataAccessLayer;

namespace BankAdmin
{
    public partial class DeptWindow : Form
    {
        public AddNewEmp p = new AddNewEmp();
        public DeptWindow()
        {
            InitializeComponent();
            deptlist_Grid.DataSource = p.GetAllEmpMgr();
        }

        void GridUpdate()
        {
            deptlist_Grid.DataSource = p.GetAllEmpMgr();

        }

        void GridUpdate1()
        {
            deptlist_Grid.DataSource = p.GetAllEmpAcc();

        }

        void GridUpdate2()
        {
            deptlist_Grid.DataSource = p.GetAllEmpCash();

        }

        void GridUpdate3()
        {
            deptlist_Grid.DataSource = p.GetAllEmpStaff();

        }
        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            EmployeeWindow ss = new EmployeeWindow();
            ss.Show();
        }

        private void DeptWindow_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void buttonMngr_Click(object sender, EventArgs e)
        {
            GridUpdate();
        }

        private void buttonAccountent_Click(object sender, EventArgs e)
        {
            GridUpdate1();
        }

        private void buttonCashier_Click(object sender, EventArgs e)
        {
            GridUpdate2();
        }

        private void buttonStaff_Click(object sender, EventArgs e)
        {
            GridUpdate3();
        }

       

       
    }
}
