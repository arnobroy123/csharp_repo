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

namespace Bank_Management.Presentation
{
    public partial class Customer_List : Form
    {
        DataAccess da = new DataAccess();

        public Customer_List()
        {
            InitializeComponent();
            dataGridView1.DataSource = da.GetAllCustomer();
        }

        public void GridUpdate()
        {
            dataGridView1.DataSource = da.GetAllCustomer();
        }

        private void Customer_List_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Accountant a = new Accountant();
            a.Show();
            this.Hide();
        }

        private void Customer_List_Load(object sender, EventArgs e)
        {

        }
    }
}
