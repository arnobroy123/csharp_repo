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
    public partial class CommitionWindow : Form
    {
        public AddNewEmp p = new AddNewEmp();

        public CommitionWindow()
        {
            InitializeComponent();
            dataGridView1.DataSource = p.GetAllEmp();
        }

        void GridUpdate()
        {
            dataGridView1.DataSource = p.GetAllEmp();

        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            AdminWindow ss = new AdminWindow();
            ss.Show();
        }
  

        private void CommitionWindow_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBoxID.Text) || string.IsNullOrWhiteSpace(textBoxCommition.Text))
            {
                MessageBox.Show("Some Fields are Empty !! Please Fill Up");
            }
            else
            {
                if (p.UpdateCommition(int.Parse(textBoxID.Text),textBoxCommition.Text) )
                {
                    GridUpdate();
                    MessageBox.Show("Successfully Updated Commition");
                }
                else
                {
                    MessageBox.Show("Error in creating");
                }

                GridUpdate();
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            textBoxID.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            textBoxCommition.Text = dataGridView1.Rows[e.RowIndex].Cells[10].Value.ToString();
        }

        private void textBoxCommition_KeyPress(object sender, KeyPressEventArgs e)
        {

            int number;
            bool success = Int32.TryParse(e.KeyChar.ToString(), out number);

            if (success)
            {
                textBoxCommition.Text = textBoxCommition.Text;
            }
            else
            {
                if (e.KeyChar == (char)Keys.Back)
                {
                    textBoxCommition.Select(textBoxCommition.Text.Length, 0);
                }
                else
                {
                    MessageBox.Show("Invalid!");
                }
            }
        }

       
    }
}
