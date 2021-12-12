using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BankAdmin.PresentationLayer;
using BankAdmin.DataAccessLayer;   
using BankAdmin.BusinessLogicLayer;

namespace BankAdmin
{
    public partial class NoticeWindow : Form
    {
        public Notices n = new Notices();
        public NoticeWindow()
        {
            InitializeComponent();
            dataGridView1.DataSource = n.GetAllNotice();
        }

        void GridUpdate()
        {
            dataGridView1.DataSource = n.GetAllNotice();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            AdminWindow ss = new AdminWindow();
            ss.Show();
        }

        private void NoticeWindow_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(richTextBoxNotice.Text))
            {
                MessageBox.Show("Some Fields are Empty !! Please Fill Up");
            }
            else
            {
                if (n.InsertNotice(richTextBoxNotice.Text))
                {

                    GridUpdate();
                    MessageBox.Show("Successfully Person Created");
                }
                else
                {
                    MessageBox.Show("Error in creating");
                }
                GridUpdate();
                richTextBoxNotice.Text = string.Empty;
            }
            }
        }
    }

