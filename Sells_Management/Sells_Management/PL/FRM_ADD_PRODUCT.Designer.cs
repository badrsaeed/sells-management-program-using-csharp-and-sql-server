namespace Sells_Management.PL
{
    partial class FRM_ADD_PRODUCT
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FRM_ADD_PRODUCT));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.picture_btn = new System.Windows.Forms.Button();
            this.cancel_btn = new System.Windows.Forms.Button();
            this.Ok_btn = new System.Windows.Forms.Button();
            this.picture_box = new System.Windows.Forms.PictureBox();
            this.price_txt = new System.Windows.Forms.TextBox();
            this.quentitu_txt = new System.Windows.Forms.TextBox();
            this.prod_discreption = new System.Windows.Forms.TextBox();
            this.product_id = new System.Windows.Forms.TextBox();
            this.cmbCategories = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picture_box)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.picture_btn);
            this.groupBox1.Controls.Add(this.cancel_btn);
            this.groupBox1.Controls.Add(this.Ok_btn);
            this.groupBox1.Controls.Add(this.picture_box);
            this.groupBox1.Controls.Add(this.price_txt);
            this.groupBox1.Controls.Add(this.quentitu_txt);
            this.groupBox1.Controls.Add(this.prod_discreption);
            this.groupBox1.Controls.Add(this.product_id);
            this.groupBox1.Controls.Add(this.cmbCategories);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(4, 24);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(467, 588);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Product Details";
            // 
            // picture_btn
            // 
            this.picture_btn.Location = new System.Drawing.Point(177, 487);
            this.picture_btn.Name = "picture_btn";
            this.picture_btn.Size = new System.Drawing.Size(167, 29);
            this.picture_btn.TabIndex = 4;
            this.picture_btn.Text = "Browse Picture";
            this.picture_btn.UseVisualStyleBackColor = true;
            this.picture_btn.Click += new System.EventHandler(this.button3_Click);
            // 
            // cancel_btn
            // 
            this.cancel_btn.Location = new System.Drawing.Point(239, 546);
            this.cancel_btn.Name = "cancel_btn";
            this.cancel_btn.Size = new System.Drawing.Size(94, 29);
            this.cancel_btn.TabIndex = 5;
            this.cancel_btn.Text = "Cancel";
            this.cancel_btn.UseVisualStyleBackColor = true;
            this.cancel_btn.Click += new System.EventHandler(this.cancel_btn_Click);
            // 
            // Ok_btn
            // 
            this.Ok_btn.Location = new System.Drawing.Point(358, 546);
            this.Ok_btn.Name = "Ok_btn";
            this.Ok_btn.Size = new System.Drawing.Size(94, 29);
            this.Ok_btn.TabIndex = 6;
            this.Ok_btn.Text = "ADD";
            this.Ok_btn.UseVisualStyleBackColor = true;
            this.Ok_btn.Click += new System.EventHandler(this.Ok_btn_Click);
            // 
            // picture_box
            // 
            this.picture_box.Image = ((System.Drawing.Image)(resources.GetObject("picture_box.Image")));
            this.picture_box.Location = new System.Drawing.Point(167, 356);
            this.picture_box.Name = "picture_box";
            this.picture_box.Size = new System.Drawing.Size(212, 114);
            this.picture_box.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picture_box.TabIndex = 6;
            this.picture_box.TabStop = false;
            // 
            // price_txt
            // 
            this.price_txt.Location = new System.Drawing.Point(167, 299);
            this.price_txt.Name = "price_txt";
            this.price_txt.Size = new System.Drawing.Size(231, 27);
            this.price_txt.TabIndex = 3;
            // 
            // quentitu_txt
            // 
            this.quentitu_txt.Location = new System.Drawing.Point(167, 247);
            this.quentitu_txt.Name = "quentitu_txt";
            this.quentitu_txt.Size = new System.Drawing.Size(231, 27);
            this.quentitu_txt.TabIndex = 2;
            // 
            // prod_discreption
            // 
            this.prod_discreption.Location = new System.Drawing.Point(167, 147);
            this.prod_discreption.Multiline = true;
            this.prod_discreption.Name = "prod_discreption";
            this.prod_discreption.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.prod_discreption.Size = new System.Drawing.Size(231, 78);
            this.prod_discreption.TabIndex = 1;
            // 
            // product_id
            // 
            this.product_id.Location = new System.Drawing.Point(167, 92);
            this.product_id.Name = "product_id";
            this.product_id.Size = new System.Drawing.Size(231, 27);
            this.product_id.TabIndex = 0;
            this.product_id.Validated += new System.EventHandler(this.product_id_Validated);
            // 
            // cmbCategories
            // 
            this.cmbCategories.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCategories.FormattingEnabled = true;
            this.cmbCategories.Location = new System.Drawing.Point(167, 45);
            this.cmbCategories.Name = "cmbCategories";
            this.cmbCategories.Size = new System.Drawing.Size(231, 28);
            this.cmbCategories.TabIndex = 1;
            this.cmbCategories.Validated += new System.EventHandler(this.cmbCategories_Validated);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(21, 369);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(106, 20);
            this.label6.TabIndex = 0;
            this.label6.Text = "Product Image";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(19, 302);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 20);
            this.label5.TabIndex = 0;
            this.label5.Text = "Price";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(19, 247);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 20);
            this.label4.TabIndex = 0;
            this.label4.Text = "Quentity";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 150);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(140, 20);
            this.label3.TabIndex = 0;
            this.label3.Text = "Product Description";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Product ID";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Category";
            // 
            // FRM_ADD_PRODUCT
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(483, 624);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.Name = "FRM_ADD_PRODUCT";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add New Product";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picture_box)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button picture_btn;
        private System.Windows.Forms.Button cancel_btn;
        public System.Windows.Forms.ComboBox cmbCategories;
        public System.Windows.Forms.PictureBox picture_box;
        public System.Windows.Forms.TextBox price_txt;
        public System.Windows.Forms.TextBox quentitu_txt;
        public System.Windows.Forms.TextBox prod_discreption;
        public System.Windows.Forms.TextBox product_id;
        public System.Windows.Forms.Button Ok_btn;
    }
}