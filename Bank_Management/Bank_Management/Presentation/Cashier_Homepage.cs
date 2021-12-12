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
    public partial class Cashier_Homepage : Form
    {
        BusinessLogic bl = new BusinessLogic();
        DataAccess da = new DataAccess();
        DataTable dt = new DataTable();

        public Cashier_Homepage()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Homepage h = new Homepage();
            //h.Show();
            this.Hide();
        }

        private void Cashier_Homepage_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void Login_Click(object sender, EventArgs e)
        {
            bl.Cas_user = user.Text;
            bl.Cas_pass = textBox2.Text;
            dt = da.CasLogin(bl);
            if (dt.Rows.Count > 0)
            {
                Cashier c = new Cashier();
                c.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Invalid Username or Password");
            }
        }

        private void Cashier_Homepage_Load(object sender, EventArgs e)
        {

        }
    }
}
