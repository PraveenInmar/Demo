
namespace MoreSuperMarket
{
    partial class ProductForm
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
            this.button2 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.ProdPrice = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.ProdQty = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.ProdName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.ProdId = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.ProdDGV = new System.Windows.Forms.DataGridView();
            this.CatCb = new System.Windows.Forms.ComboBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ProdDGV)).BeginInit();
            this.SuspendLayout();
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(2029, 27);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 43);
            this.button2.TabIndex = 1;
            this.button2.Text = "X";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Coral;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.ProdDGV);
            this.panel1.Controls.Add(this.button4);
            this.panel1.Controls.Add(this.button6);
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.CatCb);
            this.panel1.Controls.Add(this.ProdPrice);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.ProdQty);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.ProdName);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.ProdId);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(12, 111);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1338, 1135);
            this.panel1.TabIndex = 2;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint_1);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Coral;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(1296, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 37);
            this.label2.TabIndex = 1;
            this.label2.Text = "X";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(298, 589);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(134, 63);
            this.button4.TabIndex = 13;
            this.button4.Text = "DELETE";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.LightSalmon;
            this.button6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.button6.Location = new System.Drawing.Point(874, 29);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(98, 50);
            this.button6.TabIndex = 3;
            this.button6.Text = "Sellers";
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(156, 589);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(136, 63);
            this.button3.TabIndex = 12;
            this.button3.Text = "EDIT";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(19, 589);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(131, 63);
            this.button1.TabIndex = 11;
            this.button1.Text = "ADD";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ProdPrice
            // 
            this.ProdPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProdPrice.Location = new System.Drawing.Point(218, 363);
            this.ProdPrice.Name = "ProdPrice";
            this.ProdPrice.Size = new System.Drawing.Size(223, 30);
            this.ProdPrice.TabIndex = 8;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Coral;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label6.Location = new System.Drawing.Point(12, 356);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(117, 37);
            this.label6.TabIndex = 7;
            this.label6.Text = "PRICE";
            // 
            // ProdQty
            // 
            this.ProdQty.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProdQty.Location = new System.Drawing.Point(218, 272);
            this.ProdQty.Name = "ProdQty";
            this.ProdQty.Size = new System.Drawing.Size(223, 30);
            this.ProdQty.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Coral;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label5.Location = new System.Drawing.Point(3, 265);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(189, 37);
            this.label5.TabIndex = 5;
            this.label5.Text = "QUANTITY";
            // 
            // ProdName
            // 
            this.ProdName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProdName.Location = new System.Drawing.Point(218, 168);
            this.ProdName.Name = "ProdName";
            this.ProdName.Size = new System.Drawing.Size(223, 30);
            this.ProdName.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Coral;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label4.Location = new System.Drawing.Point(3, 168);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(114, 37);
            this.label4.TabIndex = 3;
            this.label4.Text = "NAME";
            // 
            // ProdId
            // 
            this.ProdId.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProdId.Location = new System.Drawing.Point(218, 74);
            this.ProdId.Name = "ProdId";
            this.ProdId.Size = new System.Drawing.Size(223, 30);
            this.ProdId.TabIndex = 2;
            this.ProdId.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Coral;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Location = new System.Drawing.Point(3, 74);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 37);
            this.label3.TabIndex = 1;
            this.label3.Text = "ID";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Coral;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(398, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(445, 46);
            this.label1.TabIndex = 0;
            this.label1.Text = "MANAGE PRODUCTS";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // ProdDGV
            // 
            this.ProdDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ProdDGV.Location = new System.Drawing.Point(469, 74);
            this.ProdDGV.Name = "ProdDGV";
            this.ProdDGV.RowHeadersWidth = 62;
            this.ProdDGV.RowTemplate.Height = 28;
            this.ProdDGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.ProdDGV.Size = new System.Drawing.Size(834, 578);
            this.ProdDGV.TabIndex = 14;
            this.ProdDGV.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // CatCb
            // 
            this.CatCb.FormattingEnabled = true;
            this.CatCb.Location = new System.Drawing.Point(559, 272);
            this.CatCb.Name = "CatCb";
            this.CatCb.Size = new System.Drawing.Size(223, 28);
            this.CatCb.TabIndex = 10;
            this.CatCb.Text = "Select Category";
            this.CatCb.SelectedIndexChanged += new System.EventHandler(this.CatCb_SelectedIndexChanged);
            // 
            // ProductForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1358, 782);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "ProductForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ProductForm";
            this.Load += new System.EventHandler(this.ProductForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ProdDGV)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox ProdId;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox ProdPrice;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox ProdQty;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox ProdName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.DataGridView ProdDGV;
        private System.Windows.Forms.ComboBox CatCb;
    }
}