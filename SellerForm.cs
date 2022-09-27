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
    public partial class SellerForm : Form
    {
        public SellerForm()
        {
            InitializeComponent();
        }
        //Main Form Display
        private void poplate()
        {
            SqlConnection con = new SqlConnection(@"Data Source=IN-WIN-PKUMAR\SQLEXPRESS;Initial Catalog=InvoiceProject;Integrated Security=True");
            con.Open();
            string query = "select ProdName,ProdQty from ProductTbl";
            SqlDataAdapter sda = new SqlDataAdapter(query, con);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            ProdDGV1.DataSource = ds.Tables[0];
            con.Close();
        }

        //Display On DGV
        private void poplateBills()
        {
            SqlConnection con = new SqlConnection(@"Data Source=IN-WIN-PKUMAR\SQLEXPRESS;Initial Catalog=InvoiceProject;Integrated Security=True");
            con.Open();
            string query = "select * from BillTbl1";
            SqlDataAdapter sda = new SqlDataAdapter(query, con);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            BillsDGV.DataSource = ds.Tables[0];
            con.Close();
        }

        private void CatDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void button6_Click(object sender, EventArgs e)
        {

        }
       
        //Display
        private void SellerForm_Load(object sender, EventArgs e)
        {
            poplate();
            poplateBills();          
        }
        
        //Select in DGV
        private void ProdDGV1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {       
            ProdName.Text = ProdDGV1.SelectedRows[0].Cells[0].Value.ToString();
            ProdPrice.Text = ProdDGV1.SelectedRows[0].Cells[1].Value.ToString();         
        }
        //Date
        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            Datebl.Text = DateTime.Today.Day.ToString() + "/" +
                          DateTime.Today.Month.ToString() + "/" +
                          DateTime.Today.Year.ToString();
        }
        int Grdtotal = 0, n = 0;
        //Add Button
        private void button1_Click(object sender, EventArgs e)
        {
            if (BillID.Text == "")
            {
                MessageBox.Show("Missing Bill Id");
            }
            else
            {
                try
                {
                    SqlConnection con = new SqlConnection(@"Data Source=IN-WIN-PKUMAR\SQLEXPRESS;Initial Catalog=InvoiceProject;Integrated Security=True");
                    con.Open();
                    //step-1
                    string SellerName = txtSelerNameData.Text;
                    string query = "insert into BillTbl1 values(" + BillID.Text + ",'"
                                                                  + SellerName+"','"
                                                                 + Datebl.Text + "',"
                                                                 +Amtlbl.Text + " )";
    
                //step-2
                    SqlCommand cmd = new SqlCommand(query, con);
                    
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Order Added Successfully");
                    con.Close();
                    poplateBills();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void OrderDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if(printPreviewDialog1.ShowDialog() == DialogResult.OK)
            {
                printDocument1.Print();
            }
        }

        //Print method
        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawString("MORESUPERMARKERT", new Font("Century Gothic",25,FontStyle.Bold),Brushes.Red,new Point(230));
            e.Graphics.DrawString("Bill ID:" + BillsDGV.SelectedRows[0].Cells[0].Value.ToString(), new Font("Century Gothic",20, FontStyle.Bold),Brushes.Blue,new Point(100,70));
            e.Graphics.DrawString("Seller Name:" + BillsDGV.SelectedRows[0].Cells[1].Value.ToString(), new Font("Century Gothic",20, FontStyle.Bold),Brushes.Blue,new Point(100,100));
            e.Graphics.DrawString("Date:" + BillsDGV.SelectedRows[0].Cells[2].Value.ToString(), new Font("Century Gothic",20, FontStyle.Bold),Brushes.Blue,new Point(100,130));
            e.Graphics.DrawString("Total Amount:" + BillsDGV.SelectedRows[0].Cells[3].Value.ToString(), new Font("Century Gothic",20, FontStyle.Bold),Brushes.Blue,new Point(100,160));
            e.Graphics.DrawString("CodeSpace", new Font("Century Gothic", 20, FontStyle.Italic), Brushes.Red, new Point(270,230));
        }

        private void button2_Click(object sender, EventArgs e)
        {
            poplate();
        }

        private void CatCb_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void label1_Click(object sender, EventArgs e)
        {
           
        }

        private void button6_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            LoginForm login = new LoginForm();
            login.Show();
        }

        private void label1_Click_1(object sender, EventArgs e)
        {
            ProductForm pf = new ProductForm();
            pf.Show();
            this.Hide();
        }

        private void Datebl_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            
            if (ProdName.Text == "" || ProdQty.Text == "")
            {
                MessageBox.Show("Missing Data");
            }
            else
            {
                int total = Convert.ToInt32(ProdPrice.Text) * Convert.ToInt32(ProdQty.Text);
                DataGridViewRow newRow = new DataGridViewRow();
                newRow.CreateCells(OrderDGV);
                newRow.Cells[0].Value = n + 1;
                newRow.Cells[1].Value = ProdName.Text;
                newRow.Cells[2].Value = ProdPrice.Text;
                newRow.Cells[3].Value = ProdQty.Text;
                newRow.Cells[4].Value = Convert.ToInt32(ProdPrice.Text) * Convert.ToInt32(ProdQty.Text);
              //  newRow.Cells[5].Value = textBox1.Text;
                OrderDGV.Rows.Add(newRow);
                n++;
                Grdtotal = Grdtotal + total;
                Amtlbl.Text = "" + Grdtotal;
            }
        }
    }
}
