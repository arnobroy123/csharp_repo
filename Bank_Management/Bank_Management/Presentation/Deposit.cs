using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using Bank_Management.Business_Logic;
using Bank_Management.Data_Access;

namespace Bank_Management.Presentation
{
    public partial class Deposit : Form
    {
        BusinessLogic bl = new BusinessLogic();
        DataAccess da = new DataAccess();
        DataTable dt = new DataTable();
        Customer_List cl = new Customer_List();

        public Deposit()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Cashier c = new Cashier();
            c.Show();
            this.Hide();
        }

        private void Deposit_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            bl.Acc_No = int.Parse(textBox1.Text);
            dt = da.GetCustomer(bl);

                if (dt.Rows.Count > 0)
                {
                    textBox2.Text = dt.Rows[0]["name"].ToString();
                    textBox3.Text = dt.Rows[0]["balance"].ToString();
                }
                else
                {
                    MessageBox.Show("Invalid Account No");
                }

                textBox4.Text = textBox5.Text = string.Empty;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=SHANJANA;Initial Catalog=bank_management;Integrated Security=True");
            con.Open();
            int amount = int.Parse(textBox3.Text);
            int amount2 = int.Parse(textBox4.Text);

            amount += amount2;

            textBox5.Text = amount.ToString();
            cl.GridUpdate();
            string query = string.Format("UPDATE customer SET balance={0} WHERE id={1}", int.Parse(textBox5.Text), int.Parse(textBox1.Text));
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Deposit Successfully");
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
