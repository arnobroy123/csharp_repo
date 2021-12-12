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
using System.Data.SqlClient;

namespace BankAdmin
{
    public partial class CustomerInfoWindow : Form
    {
        DataAccess da = new DataAccess();
        public CustomerInfoWindow()
        {
            InitializeComponent();
            dataGridView1.DataSource = da.GetAllCust();
        }
        public void GridUpdate()
        {
            dataGridView1.DataSource = da.GetAllCust();
        }


        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            AdminWindow ss = new AdminWindow();
            ss.Show();
        }

        private void CustomerInfoWindow_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrWhiteSpace(textBox2.Text))
            {
                MessageBox.Show(" ID Field  Empty !! Please Fill Up");
            }
            else
            {
                SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-VNJQTPT;Initial Catalog=BankAdmin;Integrated Security=True");
                con.Open();
                string query = string.Format("SELECT * FROM customer WHERE id={0}", int.Parse(textBox2.Text));
                SqlCommand cmd = new SqlCommand(query, con);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();

                da.Fill(dt);
                dataGridView1.DataSource = dt;

                
                textBox2.Text = string.Empty;
            }
        }
    }
}
