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
    public partial class CategoryForm : Form
    {
        public CategoryForm()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(@"Data Source=IN-WIN-PKUMAR\SQLEXPRESS;Initial Catalog=InvoiceProject;Integrated Security=True");
        //ADD Method
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                //step-1
                con.Open();
                string query = "insert into CategoryTbl values(" + CatIdTb.Text + ",'" + CatNameTb.Text + "','" + CatDescTb.Text + "')";
                //step-2
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Category Added Successfully");
                con.Close();
                poplate();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        //Display 
        private void poplate()
        {
            con.Open();
            string query = "select * from CategoryTbl";
            SqlDataAdapter sda = new SqlDataAdapter(query, con);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            CatDGV.DataSource = ds.Tables[0];
            con.Close();
        }
        private void CategoryForm_Load(object sender, EventArgs e)
        {
            poplate();
        }

        //select
        private void CatDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            CatIdTb.Text = CatDGV.SelectedRows[0].Cells[0].Value.ToString();
            CatNameTb.Text = CatDGV.SelectedRows[0].Cells[1].Value.ToString();
            CatDescTb.Text = CatDGV.SelectedRows[0].Cells[2].Value.ToString();
        }

       //Delete
        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                if (CatIdTb.Text == "") 
                {
                    MessageBox.Show("Select The Category to Delete");
                }
                else
                {
                    con.Open();
                    string query = "delete from CategoryTbl where Catd=" + CatIdTb.Text + "";
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Category Deleted Successfully");
                    con.Close();
                    poplate();
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        //Update
        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                if (CatIdTb.Text == "" || CatNameTb.Text == "" || CatDescTb.Text == "")
                {
                    MessageBox.Show("Missing Information");
                }
                else
                {
                    con.Open();
                    string query = "update CategoryTbl set CatName ='"
                                                + CatNameTb.Text + "',CatDesc='"
                                                + CatDescTb.Text + "' where Catd=" + CatIdTb.Text + ";";
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Category Successfully Updated");
                    con.Close();
                    poplate();
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        //Close
        private void label9_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        //go to next form
        private void button7_Click(object sender, EventArgs e)
        {
            ProductForm pord = new ProductForm();
            pord.Show();
            this.Hide();
        }
    }
}
