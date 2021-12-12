using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Threading.Tasks;
using System.Windows.Forms;
using BankAdmin.BusinessLogicLayer;
using BankAdmin.DataAccessLayer;
using System.Configuration;
using System.Text.RegularExpressions;

namespace BankAdmin
{
    public partial class AddEmployee : Form
    {
        public AddNewEmp p = new AddNewEmp();    
        string gender;

        public AddEmployee()
        {
            InitializeComponent();
            dataGridView1.DataSource = p.GetAllEmp();
        }

        void GridUpdate()
        {
            dataGridView1.DataSource = p.GetAllEmp();

        }
         

        private void addback_btn_Click(object sender, EventArgs e)
        {
            this.Hide();
            EmployeeWindow ss = new EmployeeWindow();
            ss.Show();
        }

        public static bool IsValidEmail(string email)
        {
            const string pattern = @"^(?!\.)(""([^""\r\\]|\\[""\r\\])*""|" + @"([-a-z0-9!#$%&'*+/=?^_`{|}~]|(?<!\.)\.)*)(?<!\.)" + @"@[a-z0-9][\w\.-]*[a-z0-9]\.[a-z][a-z\.]*[a-z]$";

            var regex = new Regex(pattern, RegexOptions.IgnoreCase);

            return regex.IsMatch(email);
        }


        private void btnConfirm_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrWhiteSpace(textBoxCULName.Text) || string.IsNullOrWhiteSpace(textBoxEmail.Text) || string.IsNullOrWhiteSpace(textBoxAddress.Text)
                || string.IsNullOrWhiteSpace(textBoxPassword.Text) || string.IsNullOrWhiteSpace(textBox1.Text) || string.IsNullOrWhiteSpace(textBoxSalary.Text))
            {
                MessageBox.Show("Some Fields are Empty !! Please Fill Up");
            }
            else
            {

                if (textBoxPassword.Text.Length < 4)
                {
                    MessageBox.Show("Password Must Have Four Latters or Digits..!");
                }
                else
                {
                    if (textBoxPassword.Text == textBox1.Text)
                    {
                        if (IsValidEmail(textBoxEmail.Text))
                        {

                            if (radioButton1.Checked==true)
                            {
                                gender = "Female";
                            }
                            else
                            {
                                gender = "Male";
                            }


                            if (p.CreateEmp(textBoxCULName.Text, gender, textBoxEmail.Text, textBoxAddress.Text, int.Parse(textBoxCuContact.Text), dateTimePicker1.Value, comboBox2.Text, textBoxPassword.Text,textBoxSalary.Text,textBoxCommition.Text))
                            {
                                GridUpdate();
                                MessageBox.Show("Successfully Person Created");
                            }
                            else
                            {
                                MessageBox.Show("Error in creating");
                            }


                            GridUpdate();
                            textBoxCULName.Text = textBoxEmail.Text = textBoxAddress.Text = textBoxCuContact.Text  = comboBox2.Text = textBoxPassword.Text = string.Empty;
                        }

                        else
                        {
                            MessageBox.Show("Invalid Email..!");
                        }

                    }
                    else
                    {
                        MessageBox.Show("Password doesn't match..!");
                    }
                }
            }
        }

        private void AddEmployee_FormClosing_1(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void textBoxCULName_KeyPress(object sender, KeyPressEventArgs e)
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
                    textBoxCULName.Select(textBoxCULName.Text.Length, 0);
                }
                else
                {
                    textBoxCULName.Text = textBoxCULName.Text;
                }
            }

        }

        private void textBoxCuContact_KeyPress(object sender, KeyPressEventArgs e)
        {
            int number;
            bool success = Int32.TryParse(e.KeyChar.ToString(), out number);

            if (success)
            {
                textBoxCuContact.Text = textBoxCuContact.Text;
            }
            else
            {
                if (e.KeyChar == (char)Keys.Back)
                {
                    textBoxCuContact.Select(textBoxCuContact.Text.Length, 0);
                }
                else
                {
                    MessageBox.Show("Invalid!");
                }
            }
        }

        private void textBoxSalary_KeyPress(object sender, KeyPressEventArgs e)
        {

            int number;
            bool success = Int32.TryParse(e.KeyChar.ToString(), out number);

            if (success)
            {
                textBoxSalary.Text = textBoxSalary.Text;
            }
            else
            {
                if (e.KeyChar == (char)Keys.Back)
                {
                    textBoxSalary.Select(textBoxSalary.Text.Length, 0);
                }
                else
                {
                    MessageBox.Show("Invalid!");
                }
            }
        }


        private void searchBtn_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrWhiteSpace(textBox7.Text))
            {
                MessageBox.Show(" ID Field  Empty !! Please Fill Up");
            }
            else
            {
                SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-VNJQTPT;Initial Catalog=BankAdmin;Integrated Security=True");
                con.Open();
                string query = string.Format("SELECT * FROM EmpReg WHERE id={0}", int.Parse(textBox7.Text));
                SqlCommand cmd = new SqlCommand(query, con);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();

                da.Fill(dt);
                dataGridView1.DataSource = dt;

                textBoxEmail.Text = dt.Rows[0][3].ToString();
                textBoxAddress.Text = dt.Rows[0][4].ToString();
                textBoxCuContact.Text = dt.Rows[0][5].ToString();
                comboBox2.Text = dt.Rows[0][7].ToString();
                textBoxPassword.Text = dt.Rows[0][8].ToString();
                textBox7.Text = string.Empty;
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void textBoxAddress_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

       }
        
 }
