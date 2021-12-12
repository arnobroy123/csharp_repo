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
    public partial class Transfer : Form
    {
        BusinessLogic bl = new BusinessLogic();
        DataAccess da = new DataAccess();
        DataTable dt = new DataTable();
        Customer_List cl = new Customer_List();

        public Transfer()
        {
            InitializeComponent();
        }

        private void Transfer_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Cashier c = new Cashier();
            c.Show();
            this.Hide();
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

            textBox5.Text = textBox6.Text = textBox8.Text = string.Empty;
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            int mytransferamount = int.Parse(textBox5.Text);
            int mycurrentbalance = int.Parse(textBox3.Text);

            if (mytransferamount > mycurrentbalance)
            {
                MessageBox.Show("Not Enough Balance");
            }

            else
            {
                int currentbalance = mycurrentbalance - mytransferamount;
                SqlConnection con = new SqlConnection(@"Data Source=SHANJANA;Initial Catalog=bank_management;Integrated Security=True");
                con.Open();
                string query = string.Format("UPDATE customer SET balance={0} WHERE id={1}", currentbalance, int.Parse(textBox1.Text));
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.ExecuteNonQuery();

                con = new SqlConnection(@"Data Source=SHANJANA;Initial Catalog=bank_management;Integrated Security=True");
                con.Open();
                query = string.Format("SELECT * FROM customer WHERE id={0}", int.Parse(textBox6.Text));
                cmd = new SqlCommand(query, con);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();

                da.Fill(dt);

                int AmounttoTranfer = 0;
                string amm = "";

                if (dt.Rows.Count > 0)
                {
                    
                    amm = dt.Rows[0]["balance"].ToString();
                    AmounttoTranfer = int.Parse(amm);
                    AmounttoTranfer += mytransferamount;
                }
                else
                {
                    MessageBox.Show("Invalid Account No");
                }

                con = new SqlConnection(@"Data Source=SHANJANA;Initial Catalog=bank_management;Integrated Security=True");
                con.Open();
                query = string.Format("UPDATE customer SET balance={0} WHERE id={1}", AmounttoTranfer, int.Parse(textBox6.Text));
                cmd = new SqlCommand(query, con);
                cmd.ExecuteNonQuery();

                MessageBox.Show("Transfer Successfully");
                cl.GridUpdate();

                textBox8.Text = currentbalance.ToString();
            }
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
