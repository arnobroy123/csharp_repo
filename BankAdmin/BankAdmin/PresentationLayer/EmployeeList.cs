using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BankAdmin.DataAccessLayer;
using BankAdmin.BusinessLogicLayer;
using System.Data.SqlClient;
using System.Text.RegularExpressions;
using System.Configuration;

namespace BankAdmin.PresentationLayer
{
    public partial class EmployeeList : Form
    {
        public AddNewEmp p = new AddNewEmp(); 
        public EmployeeList()
        {
            InitializeComponent();
            dataGridView1.DataSource = p.GetAllEmp();
        }

        void GridUpdate()
        {
            dataGridView1.DataSource = p.GetAllEmp();

        }



        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            textBoxID1.Text = textBoxID.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            textBoxCULName.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            textBox6.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
            textBox2.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
            textBoxCuContact.Text = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();
            comboBox2.Text = dataGridView1.Rows[e.RowIndex].Cells[7].Value.ToString();
        }

        public static bool IsValidEmail(string email)
        {
            const string pattern = @"^(?!\.)(""([^""\r\\]|\\[""\r\\])*""|" + @"([-a-z0-9!#$%&'*+/=?^_`{|}~]|(?<!\.)\.)*)(?<!\.)" + @"@[a-z0-9][\w\.-]*[a-z0-9]\.[a-z][a-z\.]*[a-z]$";

            var regex = new Regex(pattern, RegexOptions.IgnoreCase);

            return regex.IsMatch(email);
        }


        private void button1_Click(object sender, EventArgs e)
        {


            if (string.IsNullOrWhiteSpace(textBoxID.Text) || string.IsNullOrWhiteSpace(textBoxCULName.Text) || string.IsNullOrWhiteSpace(textBox6.Text) || string.IsNullOrWhiteSpace(textBox2.Text)
                || string.IsNullOrWhiteSpace(textBoxCuContact.Text) || string.IsNullOrWhiteSpace(comboBox2.Text))
            {
                MessageBox.Show("Some Fields are Empty !! Please Fill Up");
            }
            else
            {
                if (IsValidEmail(textBox6.Text))
                {

                    if (p.UpdateEmp(int.Parse(textBoxID.Text), textBoxCULName.Text, textBox6.Text, textBox2.Text, int.Parse(textBoxCuContact.Text), comboBox2.Text))
                    {
                        GridUpdate();
                        MessageBox.Show("Successfully Updated Employee");
                    }
                    else
                    {
                        MessageBox.Show("Error in creating");
                    }

                    GridUpdate();
                }

                else
                {
                    MessageBox.Show("Invalid Email..!");
                }

            }

        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBoxID1.Text))
            {
                MessageBox.Show(" ID Field  Empty !! Please Fill Up");
            }
            else
            {

                p.id = int.Parse(textBoxID1.Text);
                if (p.DeleteEmp(p.id))
                {
                    GridUpdate();
                    MessageBox.Show("Successfully Person deleted");
                }
                else
                {
                    MessageBox.Show("Error in deleting");
                }
            }
        }

        private void searchBtn_Click(object sender, EventArgs e)
        {
            /*p.id = int.Parse(textBox3.Text);
            p.name = textBox1.Text;
            p.email = textBox6.Text;
            p.address = textBox2.Text;
            //p.contact = int.Parse(textBox5.Text);
            p.position = comboBox2.Text;

            if (p.SearchEmp(p.id))
            {
                GridUpdate();
                MessageBox.Show("Successfully Searched Employee");
            }
            else
            {
                MessageBox.Show("Error in creating");
            }

            GridUpdate();*/
            if (string.IsNullOrWhiteSpace(textBoxID2.Text))
            {
                MessageBox.Show(" ID Field  Empty !! Please Fill Up");
            }
            else
            {

                SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-VNJQTPT;Initial Catalog=BankAdmin;Integrated Security=True");
                con.Open();
                string query = string.Format("SELECT * FROM EmpReg WHERE id={0}", int.Parse(textBoxID2.Text));
                SqlCommand cmd = new SqlCommand(query, con);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();

                da.Fill(dt);
                dataGridView1.DataSource = dt;

                textBoxID1.Text = dt.Rows[0][0].ToString();
                textBoxCULName.Text = dt.Rows[0][1].ToString();
                textBox6.Text = dt.Rows[0][3].ToString();
                textBox2.Text = dt.Rows[0][4].ToString();
                textBoxCuContact.Text = dt.Rows[0][5].ToString();
                comboBox2.Text = dt.Rows[0][7].ToString();
                textBoxID.Text = string.Empty;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            EmployeeWindow ss = new EmployeeWindow();
            ss.Show();
        }

        private void EmployeeList_FormClosing_1(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
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
                    EmployeeList h = new EmployeeList();
                    h.Show();
                    this.Hide();
                }
            }
        }

        private void textBoxID1_KeyPress(object sender, KeyPressEventArgs e)
        {
            int number;
            bool success = Int32.TryParse(e.KeyChar.ToString(), out number);

            if (success)
            {
                textBoxID1.Text = textBoxID1.Text;
            }
            else
            {
                if (e.KeyChar == (char)Keys.Back)
                {
                    textBoxID1.Select(textBoxID1.Text.Length, 0);
                }
                else
                {
                    MessageBox.Show("Invalid!");
                    EmployeeList h = new EmployeeList();
                    h.Show();
                    this.Hide();
                }
            }
        }

        private void textBoxID2_KeyPress(object sender, KeyPressEventArgs e)
        {
            int number;
            bool success = Int32.TryParse(e.KeyChar.ToString(), out number);

            if (success)
            {
                textBoxID2.Text = textBoxID2.Text;
            }
            else
            {
                if (e.KeyChar == (char)Keys.Back)
                {
                    textBoxID2.Select(textBoxID2.Text.Length, 0);
                }
                else
                {
                    MessageBox.Show("Invalid!");
                    EmployeeList h = new EmployeeList();
                    h.Show();
                    this.Hide();
                }
            }
        }

     }
  }