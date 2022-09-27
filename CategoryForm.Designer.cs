
namespace MoreSuperMarket
{
    partial class CategoryForm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.CatDGV = new System.Windows.Forms.DataGridView();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.CatDescTb = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.CatNameTb = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.CatIdTb = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button8 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CatDGV)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Coral;
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.CatDGV);
            this.panel1.Controls.Add(this.button4);
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.CatDescTb);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.CatNameTb);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.CatIdTb);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(138, -120);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1377, 1178);
            this.panel1.TabIndex = 3;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Coral;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label9.Location = new System.Drawing.Point(1335, 119);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(39, 37);
            this.label9.TabIndex = 18;
            this.label9.Text = "X";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Coral;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label8.Location = new System.Drawing.Point(549, 145);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(391, 37);
            this.label8.TabIndex = 17;
            this.label8.Text = "MANAGE CATEGORIES";
            // 
            // CatDGV
            // 
            this.CatDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.CatDGV.Location = new System.Drawing.Point(605, 292);
            this.CatDGV.Name = "CatDGV";
            this.CatDGV.RowHeadersWidth = 62;
            this.CatDGV.RowTemplate.Height = 28;
            this.CatDGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.CatDGV.Size = new System.Drawing.Size(757, 667);
            this.CatDGV.TabIndex = 14;
            this.CatDGV.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.CatDGV_CellContentClick);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(331, 645);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(134, 63);
            this.button4.TabIndex = 13;
            this.button4.Text = "DELETE";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(189, 645);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(136, 63);
            this.button3.TabIndex = 12;
            this.button3.Text = "EDIT";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(52, 645);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(131, 63);
            this.button1.TabIndex = 11;
            this.button1.Text = "ADD";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // CatDescTb
            // 
            this.CatDescTb.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CatDescTb.Location = new System.Drawing.Point(290, 520);
            this.CatDescTb.Name = "CatDescTb";
            this.CatDescTb.Size = new System.Drawing.Size(223, 30);
            this.CatDescTb.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Coral;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label5.Location = new System.Drawing.Point(40, 514);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(244, 37);
            this.label5.TabIndex = 5;
            this.label5.Text = "DESCRIPTION";
            // 
            // CatNameTb
            // 
            this.CatNameTb.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CatNameTb.Location = new System.Drawing.Point(290, 423);
            this.CatNameTb.Name = "CatNameTb";
            this.CatNameTb.Size = new System.Drawing.Size(223, 30);
            this.CatNameTb.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Coral;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label4.Location = new System.Drawing.Point(40, 417);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(114, 37);
            this.label4.TabIndex = 3;
            this.label4.Text = "NAME";
            // 
            // CatIdTb
            // 
            this.CatIdTb.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.CatIdTb.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CatIdTb.Location = new System.Drawing.Point(290, 323);
            this.CatIdTb.Name = "CatIdTb";
            this.CatIdTb.Size = new System.Drawing.Size(223, 30);
            this.CatIdTb.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Coral;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Location = new System.Drawing.Point(40, 323);
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
            this.label1.Location = new System.Drawing.Point(527, 83);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(445, 46);
            this.label1.TabIndex = 0;
            this.label1.Text = "MANAGE PRODUCTS";
            // 
            // button8
            // 
            this.button8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button8.ForeColor = System.Drawing.Color.Coral;
            this.button8.Location = new System.Drawing.Point(12, 352);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(98, 50);
            this.button8.TabIndex = 8;
            this.button8.Text = "Selling";
            this.button8.UseVisualStyleBackColor = true;
            // 
            // button7
            // 
            this.button7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button7.ForeColor = System.Drawing.Color.Coral;
            this.button7.Location = new System.Drawing.Point(12, 282);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(120, 50);
            this.button7.TabIndex = 7;
            this.button7.Text = "Products";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button6
            // 
            this.button6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.ForeColor = System.Drawing.Color.Coral;
            this.button6.Location = new System.Drawing.Point(12, 203);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(98, 50);
            this.button6.TabIndex = 6;
            this.button6.Text = "Sellers";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // CategoryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1527, 938);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "CategoryForm";
            this.Text = "CategoryForm";
            this.Load += new System.EventHandler(this.CategoryForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CatDGV)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView CatDGV;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox CatDescTb;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox CatNameTb;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox CatIdTb;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button6;
    }
}