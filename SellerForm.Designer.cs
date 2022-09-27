
namespace MoreSuperMarket
{
    partial class SellerForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SellerForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.txtSelerNameData = new System.Windows.Forms.TextBox();
            this.SellerNamebl = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.OrderDGV = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Amtlbl = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button5 = new System.Windows.Forms.Button();
            this.ProdDGV1 = new System.Windows.Forms.DataGridView();
            this.Datebl = new System.Windows.Forms.Label();
            this.SellingForm = new System.Windows.Forms.Label();
            this.BillsDGV = new System.Windows.Forms.DataGridView();
            this.button3 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.ProdQty = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.ProdPrice = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.ProdName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.BillID = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.OrderDGV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ProdDGV1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BillsDGV)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Coral;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txtSelerNameData);
            this.panel1.Controls.Add(this.SellerNamebl);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.OrderDGV);
            this.panel1.Controls.Add(this.Amtlbl);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.button5);
            this.panel1.Controls.Add(this.ProdDGV1);
            this.panel1.Controls.Add(this.Datebl);
            this.panel1.Controls.Add(this.SellingForm);
            this.panel1.Controls.Add(this.BillsDGV);
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.ProdQty);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.ProdPrice);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.ProdName);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.BillID);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Location = new System.Drawing.Point(5, -118);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1467, 1178);
            this.panel1.TabIndex = 3;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Coral;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(31, 866);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 29);
            this.label1.TabIndex = 34;
            this.label1.Text = "Product";
            this.label1.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // txtSelerNameData
            // 
            this.txtSelerNameData.Location = new System.Drawing.Point(248, 128);
            this.txtSelerNameData.Name = "txtSelerNameData";
            this.txtSelerNameData.Size = new System.Drawing.Size(211, 26);
            this.txtSelerNameData.TabIndex = 33;
            // 
            // SellerNamebl
            // 
            this.SellerNamebl.AutoSize = true;
            this.SellerNamebl.BackColor = System.Drawing.Color.Coral;
            this.SellerNamebl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SellerNamebl.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.SellerNamebl.Location = new System.Drawing.Point(31, 128);
            this.SellerNamebl.Name = "SellerNamebl";
            this.SellerNamebl.Size = new System.Drawing.Size(201, 29);
            this.SellerNamebl.TabIndex = 32;
            this.SellerNamebl.Text = "Customer Name";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Coral;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label8.Location = new System.Drawing.Point(742, 458);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(249, 46);
            this.label8.TabIndex = 31;
            this.label8.Text = "SELLS LIST";
            // 
            // OrderDGV
            // 
            this.OrderDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.OrderDGV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.PName,
            this.Price,
            this.Quantity,
            this.Total});
            this.OrderDGV.Location = new System.Drawing.Point(388, 177);
            this.OrderDGV.Name = "OrderDGV";
            this.OrderDGV.RowHeadersWidth = 62;
            this.OrderDGV.RowTemplate.Height = 28;
            this.OrderDGV.Size = new System.Drawing.Size(992, 204);
            this.OrderDGV.TabIndex = 30;
            this.OrderDGV.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.OrderDGV_CellContentClick);
            // 
            // Id
            // 
            this.Id.HeaderText = "ProdId";
            this.Id.MinimumWidth = 8;
            this.Id.Name = "Id";
            this.Id.Width = 150;
            // 
            // PName
            // 
            this.PName.HeaderText = "ProdName";
            this.PName.MinimumWidth = 8;
            this.PName.Name = "PName";
            this.PName.Width = 150;
            // 
            // Price
            // 
            this.Price.HeaderText = "Price";
            this.Price.MinimumWidth = 8;
            this.Price.Name = "Price";
            this.Price.Width = 150;
            // 
            // Quantity
            // 
            this.Quantity.HeaderText = "Quantity";
            this.Quantity.MinimumWidth = 8;
            this.Quantity.Name = "Quantity";
            this.Quantity.Width = 150;
            // 
            // Total
            // 
            this.Total.HeaderText = "Total";
            this.Total.MinimumWidth = 8;
            this.Total.Name = "Total";
            this.Total.Width = 150;
            // 
            // Amtlbl
            // 
            this.Amtlbl.AutoSize = true;
            this.Amtlbl.BackColor = System.Drawing.Color.Coral;
            this.Amtlbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Amtlbl.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Amtlbl.Location = new System.Drawing.Point(814, 390);
            this.Amtlbl.Name = "Amtlbl";
            this.Amtlbl.Size = new System.Drawing.Size(56, 32);
            this.Amtlbl.TabIndex = 29;
            this.Amtlbl.Text = "RS";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Coral;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(645, 390);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(163, 32);
            this.label2.TabIndex = 28;
            this.label2.Text = "Amount Rs";
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(171, 337);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(211, 44);
            this.button5.TabIndex = 27;
            this.button5.Text = "Add Product";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // ProdDGV1
            // 
            this.ProdDGV1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ProdDGV1.Location = new System.Drawing.Point(36, 512);
            this.ProdDGV1.Name = "ProdDGV1";
            this.ProdDGV1.RowHeadersWidth = 62;
            this.ProdDGV1.RowTemplate.Height = 28;
            this.ProdDGV1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.ProdDGV1.Size = new System.Drawing.Size(393, 316);
            this.ProdDGV1.TabIndex = 23;
            this.ProdDGV1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ProdDGV1_CellContentClick);
            // 
            // Datebl
            // 
            this.Datebl.AutoSize = true;
            this.Datebl.BackColor = System.Drawing.Color.Coral;
            this.Datebl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Datebl.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Datebl.Location = new System.Drawing.Point(1192, 117);
            this.Datebl.Name = "Datebl";
            this.Datebl.Size = new System.Drawing.Size(67, 29);
            this.Datebl.TabIndex = 22;
            this.Datebl.Text = "Date";
            this.Datebl.Click += new System.EventHandler(this.Datebl_Click);
            // 
            // SellingForm
            // 
            this.SellingForm.AutoSize = true;
            this.SellingForm.BackColor = System.Drawing.Color.Coral;
            this.SellingForm.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SellingForm.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.SellingForm.Location = new System.Drawing.Point(742, 128);
            this.SellingForm.Name = "SellingForm";
            this.SellingForm.Size = new System.Drawing.Size(195, 46);
            this.SellingForm.TabIndex = 18;
            this.SellingForm.Text = "SELLING";
            // 
            // BillsDGV
            // 
            this.BillsDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.BillsDGV.Location = new System.Drawing.Point(453, 507);
            this.BillsDGV.Name = "BillsDGV";
            this.BillsDGV.RowHeadersWidth = 62;
            this.BillsDGV.RowTemplate.Height = 28;
            this.BillsDGV.Size = new System.Drawing.Size(927, 260);
            this.BillsDGV.TabIndex = 14;
            this.BillsDGV.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.CatDGV_CellContentClick);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(1029, 794);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(116, 34);
            this.button3.TabIndex = 12;
            this.button3.Text = "PRINT";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(1115, 394);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(111, 33);
            this.button1.TabIndex = 11;
            this.button1.Text = "ADD";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ProdQty
            // 
            this.ProdQty.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProdQty.Location = new System.Drawing.Point(171, 285);
            this.ProdQty.Name = "ProdQty";
            this.ProdQty.Size = new System.Drawing.Size(211, 30);
            this.ProdQty.TabIndex = 8;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Coral;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label6.Location = new System.Drawing.Point(21, 286);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(108, 29);
            this.label6.TabIndex = 7;
            this.label6.Text = "Quantity";
            // 
            // ProdPrice
            // 
            this.ProdPrice.Enabled = false;
            this.ProdPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProdPrice.Location = new System.Drawing.Point(171, 249);
            this.ProdPrice.Name = "ProdPrice";
            this.ProdPrice.Size = new System.Drawing.Size(211, 30);
            this.ProdPrice.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Coral;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label5.Location = new System.Drawing.Point(21, 252);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 29);
            this.label5.TabIndex = 5;
            this.label5.Text = "Price";
            // 
            // ProdName
            // 
            this.ProdName.Enabled = false;
            this.ProdName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProdName.Location = new System.Drawing.Point(171, 213);
            this.ProdName.Name = "ProdName";
            this.ProdName.Size = new System.Drawing.Size(211, 30);
            this.ProdName.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Coral;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label4.Location = new System.Drawing.Point(19, 214);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(138, 29);
            this.label4.TabIndex = 3;
            this.label4.Text = "ProdName";
            // 
            // BillID
            // 
            this.BillID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BillID.Location = new System.Drawing.Point(171, 177);
            this.BillID.Name = "BillID";
            this.BillID.Size = new System.Drawing.Size(211, 30);
            this.BillID.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Coral;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Location = new System.Drawing.Point(21, 177);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 29);
            this.label3.TabIndex = 1;
            this.label3.Text = "BILLID";
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Document = this.printDocument1;
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // SellerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1476, 771);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "SellerForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SellerForm";
            this.Load += new System.EventHandler(this.SellerForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.OrderDGV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ProdDGV1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BillsDGV)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView BillsDGV;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox ProdQty;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox ProdPrice;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox ProdName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox BillID;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label SellingForm;
        private System.Windows.Forms.Label Datebl;
        private System.Windows.Forms.DataGridView ProdDGV1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridView OrderDGV;
        private System.Windows.Forms.Label Amtlbl;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn PName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Price;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn Total;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.Label SellerNamebl;
        private System.Windows.Forms.TextBox txtSelerNameData;
        private System.Windows.Forms.Label label1;
    }
}