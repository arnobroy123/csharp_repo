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
using BankAdmin.DataAccessLayer;

namespace BankAdmin
{
    public partial class SalaryWindow : Form
    {
        public AddNewEmp p = new AddNewEmp(); 


        public SalaryWindow()
        {
            InitializeComponent();
            dataGridView1.DataSource = p.GetAllEmp();
        }
        void GridUpdate()
        {
            dataGridView1.DataSource = p.GetAllEmp();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            AdminWindow ss = new AdminWindow();
            ss.Show();
        }

        private void SalaryWindow_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            textBoxID.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            textBoxSal.Text = dataGridView1.Rows[e.RowIndex].Cells[9].Value.ToString();

        }

        private void buttonConfirm_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrWhiteSpace(textBoxID.Text) || string.IsNullOrWhiteSpace(textBoxSal.Text))
            {
                MessageBox.Show("Some Fields are Empty !! Please Fill Up");
            }
            else
            {
                if (p.UpdateSalary(int.Parse(textBoxID.Text),textBoxSal.Text))
                {
                    GridUpdate();
                    MessageBox.Show("Successfully Updated Salary");
                }
                else
                {
                    MessageBox.Show("Error in creating");
                }

                GridUpdate();
            }
        }

        private void textBoxID_KeyPress(object sender, KeyPressEventArgs e)
        {
            int number;
            bool success = Int32.TryParse(e.KeyChar.ToString(), out number);

            if (success)
            {
                MessageBox.Show("Invalid!");
            }
            else
            {
                if (e.KeyChar == (char)Keys.Back)
                {
                    textBoxID.Select(textBoxID.Text.Length, 0);
                }
                else
                {
                    textBoxID.Text = textBoxID.Text;
                }
            }
        }

        private void textBoxSal_KeyPress(object sender, KeyPressEventArgs e)
        {
            int number;
            bool success = Int32.TryParse(e.KeyChar.ToString(), out number);

            if (success)
            {
               textBoxSal.Text = textBoxSal.Text;
            }
            else
            {
                if (e.KeyChar == (char)Keys.Back)
                {
                    textBoxSal.Select(textBoxSal.Text.Length, 0);
                }
                else
                {
                    MessageBox.Show("Invalid!");
                }
            }
        }


        private void btnDelete_Click(object sender, EventArgs e)
        {


            
            foreach(DataGridViewRow item in dataGridView1.Rows)
                if (bool.Parse(item.Cells[0].Value.ToString()))
                {
                    MessageBox.Show("Selected Rows : " + item.Cells[0].RowIndex.ToString());

                }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            AdminWindow ss = new AdminWindow();
            ss.Show();
        }

        
    }
}
