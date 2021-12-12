using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BankAdmin.BusinessLogicLayer;
using BankAdmin.PresentationLayer;

namespace BankAdmin
{
    public partial class AdminHome : Form
    {
        Admin a = new Admin();
        public AdminHome()
        {
            InitializeComponent();
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            if (textBoxID.Text == "" || textBoxPassword.Text == "")
            {
                MessageBox.Show("Invalid Login please check id and password ");
            }
            else
            {
                if (int.Parse(textBoxID.Text) < 100)
                {
                    MessageBox.Show("Invalid ID");
                }
                else if (int.Parse(textBoxID.Text) > 100 && int.Parse(textBoxID.Text) < 1000)
                {
                    if (a.AdminLogin(int.Parse(textBoxID.Text), textBoxPassword.Text))
                    {
                        AdminWindow ah = new AdminWindow();
                        ah.labelId.Text = textBoxID.Text;
                        ah.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Invalid Login please check id and password");
                    }
                }
            }


        }

        private void AdminHome_FormClosing_1(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBoxID.Text = textBoxPassword.Text = "";
        }

        private void textBoxID_KeyPress(object sender, KeyPressEventArgs e)
        {
               int number;
            bool success = Int32.TryParse(e.KeyChar.ToString(),out number);

            if (success)
            {
                textBoxID.Text = textBoxID.Text;
            }
            else
            {
                if(e.KeyChar == (char)Keys.Back)
                {
                    textBoxID.Select(textBoxID.Text.Length, 0);
                }
                else
                {
                    MessageBox.Show("Invalid!");
                    AdminHome h = new AdminHome();
                    h.Show();
                    this.Hide();
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Homepage ch = new Homepage();
            ch.Show();
            this.Hide();
        }
     }
}

