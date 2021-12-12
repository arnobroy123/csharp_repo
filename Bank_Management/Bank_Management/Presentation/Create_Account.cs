using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Bank_Management.Business_Logic;
using System.Text.RegularExpressions;

namespace Bank_Management.Presentation
{
    public partial class Create_Account : Form
    {
        BusinessLogic bl = new BusinessLogic();
        Customer_List cl = new Customer_List();

        public Create_Account()
        {
            InitializeComponent();
        }

        private void Create_Account_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Accountant a = new Accountant();
            a.Show();
            this.Hide();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox2.Text == "" || textBox3.Text == "" || comboBox2.Text == "" || comboBox1.Text == "" || dateTimePicker1.Text == "" || textBox5.Text == "" || textBox6.Text == "" || textBox7.Text == "" || textBox8.Text == "" || textBox10.Text == "" || textBox12.Text == "")
               {
                    MessageBox.Show("Incomplete Info");
               }  

             else
             {
                 bl.CreateCustomer(textBox2.Text, textBox3.Text, comboBox2.Text, comboBox1.Text, dateTimePicker1.Text, textBox5.Text, textBox6.Text, int.Parse(textBox7.Text), int.Parse(textBox8.Text), textBox10.Text, int.Parse(textBox12.Text));
                 cl.GridUpdate();
                 MessageBox.Show("Created Successfully");
                 textBox2.Text = textBox3.Text = comboBox2.Text = comboBox1.Text = dateTimePicker1.Text = textBox5.Text = textBox6.Text = textBox7.Text = textBox8.Text = textBox10.Text = textBox12.Text = string.Empty;
             }
        }

        private void label2_Click(object sender, EventArgs e)
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

        private void textBox6_KeyPress(object sender, KeyPressEventArgs e)
        {
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

        private void textBox10_Leave(object sender, EventArgs e)
        {
            string pattern = "^([0-9a-zA-Z]([-\\.\\w]*[0-9a-zA-Z])*@([0-9a-zA-Z][-\\w]*[0-9a-zA-Z]\\.)+[a-zA-Z]{2,9})$";
            if (Regex.IsMatch(textBox10.Text, pattern))
            {
                errorProvider1.Clear();
            }
            else
            {
                errorProvider1.SetError(this.textBox10,"Enter Valid Email");
                return;
            }
        }
    }
}
