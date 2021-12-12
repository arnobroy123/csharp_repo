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
    public partial class Cashier : Form
    {
        DataAccess da = new DataAccess();
        public Cashier()
        {
            InitializeComponent();
            dataGridView1.DataSource = da.GetAllNotice();
        }

        public void GridUpdate()
        {

            dataGridView1.DataSource = da.GetAllNotice();
        }

        private void Cashier_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Cashier_Homepage ch = new Cashier_Homepage();
            ch.Show();
            this.Hide();
        }

        private void Cashier_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Deposit d = new Deposit();
            d.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Withdraw w = new Withdraw();
            w.Show();
            this.Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Transfer t = new Transfer();
            t.Show();
            this.Hide();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

    }
}
