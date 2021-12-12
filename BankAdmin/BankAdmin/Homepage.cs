using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bank_Management.Presentation
{
    public partial class Homepage : Form
    {
        public Homepage()
        {
            InitializeComponent();
        }

        private void Homepage_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Accountant_Homepage ah = new Accountant_Homepage();
            ah.Show();
            this.Hide();
        }

        private void Homepage_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Cashier_Homepage ch = new Cashier_Homepage();
            ch.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
        }
    }
}
