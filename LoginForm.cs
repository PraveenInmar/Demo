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

namespace MoreSuperMarket
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }
       // SqlConnection con = new SqlConnection(@"Data Source=IN-WIN-PKUMAR\SQLEXPRESS;Initial Catalog=InvoiceProject;Integrated Security=True");

        private void label7_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            if(UserNameInput.Text == "" || PasswordInput.Text == "")
            {
                MessageBox.Show("Enter the UserName and Password");
            }
            else
            {
                if(UserNameInput.Text =="Admin" && PasswordInput.Text == "Admin")
                {
                    ProductForm pf = new ProductForm();
                    pf.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Invalid inuput");
                   
                }
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }
    }
}
