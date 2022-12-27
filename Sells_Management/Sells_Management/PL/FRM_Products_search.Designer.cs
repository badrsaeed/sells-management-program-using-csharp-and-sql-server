namespace Sells_Management.PL
{
    partial class FRM_Products_search
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
            this.label1 = new System.Windows.Forms.Label();
            this.search_txt = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button8 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.EditProduct_btn = new System.Windows.Forms.Button();
            this.DeleteProduvt_btn = new System.Windows.Forms.Button();
            this.AddProduct_btn = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(193, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 28);
            this.label1.TabIndex = 0;
            this.label1.Text = "Search";
            // 
            // search_txt
            // 
            this.search_txt.Location = new System.Drawing.Point(295, 29);
            this.search_txt.Name = "search_txt";
            this.search_txt.Size = new System.Drawing.Size(633, 27);
            this.search_txt.TabIndex = 0;
            this.search_txt.TextChanged += new System.EventHandler(this.search_txt_TextChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Location = new System.Drawing.Point(32, 73);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1022, 359);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Product Results";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 21);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 29;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(1002, 330);
            this.dataGridView1.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button8);
            this.groupBox2.Controls.Add(this.button6);
            this.groupBox2.Controls.Add(this.button7);
            this.groupBox2.Controls.Add(this.button5);
            this.groupBox2.Controls.Add(this.button4);
            this.groupBox2.Controls.Add(this.EditProduct_btn);
            this.groupBox2.Controls.Add(this.DeleteProduvt_btn);
            this.groupBox2.Controls.Add(this.AddProduct_btn);
            this.groupBox2.Location = new System.Drawing.Point(31, 441);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1015, 126);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Valid Operations";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(548, 82);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(96, 29);
            this.button8.TabIndex = 1;
            this.button8.Text = "Exit";
            this.button8.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(819, 36);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(159, 29);
            this.button6.TabIndex = 1;
            this.button6.Text = "Print All Products";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(371, 82);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(159, 29);
            this.button7.TabIndex = 1;
            this.button7.Text = "Save At Excel File";
            this.button7.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(642, 36);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(159, 29);
            this.button5.TabIndex = 1;
            this.button5.Text = "Print The Peoduct";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(495, 36);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(129, 29);
            this.button4.TabIndex = 1;
            this.button4.Text = "Show Image";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // EditProduct_btn
            // 
            this.EditProduct_btn.Location = new System.Drawing.Point(348, 36);
            this.EditProduct_btn.Name = "EditProduct_btn";
            this.EditProduct_btn.Size = new System.Drawing.Size(129, 29);
            this.EditProduct_btn.TabIndex = 1;
            this.EditProduct_btn.Text = "Edit Product";
            this.EditProduct_btn.UseVisualStyleBackColor = true;
            this.EditProduct_btn.Click += new System.EventHandler(this.button3_Click);
            // 
            // DeleteProduvt_btn
            // 
            this.DeleteProduvt_btn.Location = new System.Drawing.Point(201, 36);
            this.DeleteProduvt_btn.Name = "DeleteProduvt_btn";
            this.DeleteProduvt_btn.Size = new System.Drawing.Size(129, 29);
            this.DeleteProduvt_btn.TabIndex = 1;
            this.DeleteProduvt_btn.Text = "Delete Product";
            this.DeleteProduvt_btn.UseVisualStyleBackColor = true;
            this.DeleteProduvt_btn.Click += new System.EventHandler(this.button2_Click);
            // 
            // AddProduct_btn
            // 
            this.AddProduct_btn.Location = new System.Drawing.Point(37, 36);
            this.AddProduct_btn.Name = "AddProduct_btn";
            this.AddProduct_btn.Size = new System.Drawing.Size(146, 29);
            this.AddProduct_btn.TabIndex = 0;
            this.AddProduct_btn.Text = "Add New Product";
            this.AddProduct_btn.UseVisualStyleBackColor = true;
            this.AddProduct_btn.Click += new System.EventHandler(this.button1_Click);
            // 
            // FRM_Products_search
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1084, 592);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.search_txt);
            this.Controls.Add(this.label1);
            this.Name = "FRM_Products_search";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Products Search";
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox search_txt;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button EditProduct_btn;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button DeleteProduvt_btn;
        private System.Windows.Forms.Button AddProduct_btn;
        public System.Windows.Forms.DataGridView dataGridView1;
    }
}