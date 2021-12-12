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
    public partial class Accountant : Form
    {

        DataAccess da = new DataAccess();
        public Accountant()
        {
            InitializeComponent();
            dataGridView2.DataSource = da.GetAllNotice();
        }

        public void GridUpdate()
        {
            dataGridView2.DataSource = da.GetAllNotice();
        }
        private void Accountant_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void Accountant_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Create_Account ca = new Create_Account();
            ca.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Accountant_Homepage ah = new Accountant_Homepage();
            ah.Show();
            this.Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Update_Account ua = new Update_Account();
            ua.Show();
            this.Hide();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Customer_List cl = new Customer_List();
            cl.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }
    }
}
