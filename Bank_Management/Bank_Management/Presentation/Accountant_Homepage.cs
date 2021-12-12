using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Bank_Management.Data_Access;
using Bank_Management.Business_Logic;

namespace Bank_Management.Presentation
{
    public partial class Accountant_Homepage : Form
    {
        BusinessLogic bl = new BusinessLogic();
        DataAccess da = new DataAccess();
        DataTable dt = new DataTable();

        public Accountant_Homepage()
        {
            InitializeComponent();
        }

        private void Login_Click(object sender, EventArgs e)
        {
            bl.Acc_user = user_txt.Text;
            bl.Acc_pass = pass_txt.Text;
            dt = da.AccLogin(bl);
            if (dt.Rows.Count > 0)
            {
                Accountant a = new Accountant();
                a.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Invalid Username or Password");
            }
        }

        private void Accountant_Homepage_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Homepage h = new Homepage();
            //h.Show();
            this.Hide();
        }
    }
}
