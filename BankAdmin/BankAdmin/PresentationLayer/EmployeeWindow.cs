using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BankAdmin.PresentationLayer;

namespace BankAdmin
{
    public partial class EmployeeWindow : Form
    {
        public EmployeeWindow()
        {
            InitializeComponent();
        }

        private void AddEmp_btn_Click(object sender, EventArgs e)
        {
            this.Hide();
            AddEmployee ss = new AddEmployee();
            ss.Show();

        }

        private void empdept_btn_Click(object sender, EventArgs e)
        {
            this.Hide();
            DeptWindow ss = new DeptWindow();
            ss.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            AdminWindow ss = new AdminWindow();
            ss.Show();
        }

        private void emplist_btn_Click(object sender, EventArgs e)
        {

            this.Hide();
            EmployeeList ss = new EmployeeList();
            ss.Show();
        }

        private void EmployeeWindow_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            AdminWindow ad = new AdminWindow();
            ad.Show();
        }


    }
}
