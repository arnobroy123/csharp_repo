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
    public partial class Update_Account : Form
    {
        BusinessLogic bl = new BusinessLogic();
        DataAccess da = new DataAccess();
        DataTable dt = new DataTable();
        Customer_List cl = new Customer_List();

        public Update_Account()
        {
            InitializeComponent();
        }

        private void Update_Account_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Accountant a = new Accountant();
            a.Show();
            this.Hide();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            bl.Acc_No = int.Parse(textBox1.Text);
            dt = da.GetCustomer(bl);
            if (dt.Rows.Count > 0)
            {
                textBox2.Text = dt.Rows[0]["name"].ToString();
                textBox3.Text = dt.Rows[0]["occupation"].ToString();
                comboBox1.Text = dt.Rows[0]["type"].ToString();
                comboBox2.Text = dt.Rows[0]["gender"].ToString();
                dateTimePicker1.Text = dt.Rows[0]["dob"].ToString();
                textBox5.Text = dt.Rows[0]["nationality"].ToString();
                textBox6.Text = dt.Rows[0]["address"].ToString();
                textBox7.Text = dt.Rows[0]["contact"].ToString();
                textBox8.Text = dt.Rows[0]["nid"].ToString();
                textBox10.Text = dt.Rows[0]["email"].ToString();
                textBox12.Text = dt.Rows[0]["balance"].ToString();
            }

            else
            {
                MessageBox.Show("Invalid Account No");
            }
        }
            
        public void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (bl.UpdateCustomer(int.Parse(textBox1.Text), textBox2.Text, textBox3.Text, comboBox1.Text, comboBox2.Text, dateTimePicker1.Text, textBox5.Text, textBox6.Text, int.Parse(textBox7.Text), int.Parse(textBox8.Text), textBox10.Text, int.Parse(textBox12.Text)))
            {
                cl.GridUpdate();
                MessageBox.Show("Successfully Updated");
                textBox2.Text = textBox3.Text = comboBox1.Text = comboBox2.Text = dateTimePicker1.Text = textBox5.Text = textBox6.Text = textBox7.Text = textBox8.Text = textBox10.Text = textBox12.Text = textBox1.Text = string.Empty;
            }
            else
            {
                MessageBox.Show("Invalid Info");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("Are You Sure?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (res.Equals(DialogResult.Yes))
            {
                if (bl.DeleteCustomer(int.Parse(textBox1.Text)))
                {
                    cl.GridUpdate();
                    MessageBox.Show("Successfully Deleted");
                }
                else
                {
                    MessageBox.Show("Can't Delete");
                }

                textBox2.Text = textBox3.Text = comboBox1.Text = comboBox2.Text = dateTimePicker1.Text = textBox5.Text = textBox6.Text = textBox7.Text = textBox8.Text = textBox10.Text = textBox12.Text = textBox1.Text = string.Empty;
            }
            else
            {
                cl.GridUpdate();
                textBox2.Text = textBox3.Text = comboBox1.Text = comboBox2.Text = dateTimePicker1.Text = textBox5.Text = textBox6.Text = textBox7.Text = textBox8.Text = textBox10.Text = textBox12.Text = textBox1.Text = string.Empty;
            }
        }

        private void Update_Account_Load(object sender, EventArgs e)
        {

        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void textBox5_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void textBox7_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void textBox8_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void textBox12_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
