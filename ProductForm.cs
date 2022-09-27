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
    public partial class ProductForm : Form
    {
        public ProductForm()
        {
            InitializeComponent();
        }

        //Display
        private void poplate()
        {
            SqlConnection con = new SqlConnection(@"Data Source=IN-WIN-PKUMAR\SQLEXPRESS;Initial Catalog=InvoiceProject;Integrated Security=True");
            con.Open();
            string query = "select * from ProductTbl";
            SqlDataAdapter sda = new SqlDataAdapter(query, con);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            ProdDGV.DataSource = ds.Tables[0];
            con.Close();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {

        }
       

        //close
        private void label2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
      
        //display from other form
        private void fillcombo()
        {
            //This Method will bind the Combobox with the Database
            SqlConnection con = new SqlConnection(@"Data Source=IN-WIN-PKUMAR\SQLEXPRESS;Initial Catalog=InvoiceProject;Integrated Security=True");
            con.Open();

            string query = "select CatName from CategoryTbl";
            SqlCommand cmd = new SqlCommand(query,con);
            SqlDataReader rdr;
            rdr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Columns.Add("CatName", typeof(string));
            dt.Load(rdr);
            CatCb.ValueMember = "CatName";
            CatCb.DataSource = dt;
            con.Close();

        }
        private void ProductForm_Load(object sender, EventArgs e)
        {
            fillcombo();
            poplate();
        }

        private void panel1_Paint_1(object sender, PaintEventArgs e)
        {
        }
        private void label10_Click(object sender, EventArgs e)
        {

        }

        //access to other form
        private void button7_Click(object sender, EventArgs e)
        {
            CategoryForm cat = new CategoryForm();
            cat.Show();
            this.Hide();
        }
        //ADD Button
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection con = new SqlConnection(@"Data Source=IN-WIN-PKUMAR\SQLEXPRESS;Initial Catalog=InvoiceProject;Integrated Security=True");
                //step-1

                string query = "insert into ProductTbl values(" + ProdId.Text + ",'"
                                                                + ProdName.Text + "',"
                                                                + ProdQty.Text + ","
                                                                + ProdPrice.Text + ",'"
                                                                + CatCb.SelectedValue.ToString()+ "')";
                //step-2
                SqlCommand cmd = new SqlCommand(query, con);
                con.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Product Added Successfully");
                con.Close();
                poplate();
                ClearDate();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        //select
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // CatIdTb.Text = CatDGV.SelectedRows[0].Cells[0].Value.ToString();
            ProdId.Text = ProdDGV.SelectedRows[0].Cells[0].Value.ToString();
            ProdName.Text = ProdDGV.SelectedRows[0].Cells[1].Value.ToString();
            ProdQty.Text = ProdDGV.SelectedRows[0].Cells[2].Value.ToString();
            ProdPrice.Text = ProdDGV.SelectedRows[0].Cells[3].Value.ToString();
            CatCb.SelectedValue = ProdDGV.SelectedRows[0].Cells[4].Value.ToString();


        }

        //update
        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                if (ProdId.Text == "" || ProdName.Text == "" || ProdQty.Text == "" || ProdPrice.Text =="")
                {
                    MessageBox.Show("Missing Information");
                }
                else
                {
                    SqlConnection con = new SqlConnection(@"Data Source=IN-WIN-PKUMAR\SQLEXPRESS;Initial Catalog=InvoiceProject;Integrated Security=True");
                    string query = "update ProductTbl set ProdName ='"
                                                + ProdName.Text + "',ProdQty="
                                                + ProdQty.Text + ",ProdPrice=" 
                                                + ProdPrice.Text + ",ProdCat='" 
                                                + CatCb.SelectedValue.ToString()+"' where ProdId=" + ProdId.Text + ";";
                    SqlCommand cmd = new SqlCommand(query, con);                    
                    con.Open();                                        
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Product Successfully Updated");
                    con.Close();
                    poplate();
                    ClearDate();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        //Delete Button
        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                if (ProdId.Text == "")
                {
                    MessageBox.Show("Select The Product to Delete");
                }
                else
                {
                    SqlConnection con = new SqlConnection(@"Data Source=IN-WIN-PKUMAR\SQLEXPRESS;Initial Catalog=InvoiceProject;Integrated Security=True");
                    string query = "delete from ProductTbl where ProdId=" + ProdId.Text + "";
                    SqlCommand cmd = new SqlCommand(query, con);
                    con.Open();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Product Deleted Successfully");
                    con.Close();
                    poplate();
                    ClearDate();

                    
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void button6_Click(object sender, EventArgs e)
        {
            SellerForm sf = new SellerForm();
            sf.Show();
            this.Hide();
        }
        private void CatCb_SelectedIndexChanged(object sender, EventArgs e)
        {
        }
        private void button8_Click(object sender, EventArgs e)
        {
        }
        private void ClearDate()
        {
            ProdId.Text = "";
            ProdName.Text = "";
            ProdQty.Text = "";
            ProdPrice.Text = "";
        }
    }
}
