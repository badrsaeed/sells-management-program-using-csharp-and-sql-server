namespace Sells_Management.PL
{
    partial class FRM_CustomersManagement
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.numbering_lbl = new System.Windows.Forms.Label();
            this.first_btn = new System.Windows.Forms.Button();
            this.previous_btn = new System.Windows.Forms.Button();
            this.last_btn = new System.Windows.Forms.Button();
            this.next_btn = new System.Windows.Forms.Button();
            this.email_txt = new System.Windows.Forms.TextBox();
            this.phone_txt = new System.Windows.Forms.TextBox();
            this.lname_txt = new System.Windows.Forms.TextBox();
            this.fname_txt = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.new_btn = new System.Windows.Forms.Button();
            this.ExitCat_btn = new System.Windows.Forms.Button();
            this.DeleteCat_btn = new System.Windows.Forms.Button();
            this.EditCat_btn = new System.Windows.Forms.Button();
            this.addCat_btn = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.search_btn = new System.Windows.Forms.Button();
            this.search_txt = new System.Windows.Forms.TextBox();
            this.customersList_dgv = new System.Windows.Forms.DataGridView();
            this.search_lbl = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.customersList_dgv)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.numbering_lbl);
            this.groupBox1.Controls.Add(this.first_btn);
            this.groupBox1.Controls.Add(this.previous_btn);
            this.groupBox1.Controls.Add(this.last_btn);
            this.groupBox1.Controls.Add(this.next_btn);
            this.groupBox1.Controls.Add(this.email_txt);
            this.groupBox1.Controls.Add(this.phone_txt);
            this.groupBox1.Controls.Add(this.lname_txt);
            this.groupBox1.Controls.Add(this.fname_txt);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 30);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(628, 268);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Customer Data";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(365, 31);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(236, 170);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(428, 215);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(118, 29);
            this.button1.TabIndex = 4;
            this.button1.Text = "Browse";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // numbering_lbl
            // 
            this.numbering_lbl.AutoSize = true;
            this.numbering_lbl.Location = new System.Drawing.Point(184, 220);
            this.numbering_lbl.Name = "numbering_lbl";
            this.numbering_lbl.Size = new System.Drawing.Size(47, 20);
            this.numbering_lbl.TabIndex = 9;
            this.numbering_lbl.Text = "15/20";
            // 
            // first_btn
            // 
            this.first_btn.Location = new System.Drawing.Point(82, 216);
            this.first_btn.Name = "first_btn";
            this.first_btn.Size = new System.Drawing.Size(45, 29);
            this.first_btn.TabIndex = 5;
            this.first_btn.Text = "||<<";
            this.first_btn.UseVisualStyleBackColor = true;
            // 
            // previous_btn
            // 
            this.previous_btn.Location = new System.Drawing.Point(133, 215);
            this.previous_btn.Name = "previous_btn";
            this.previous_btn.Size = new System.Drawing.Size(45, 29);
            this.previous_btn.TabIndex = 6;
            this.previous_btn.Text = "<<";
            this.previous_btn.UseVisualStyleBackColor = true;
            // 
            // last_btn
            // 
            this.last_btn.Location = new System.Drawing.Point(288, 215);
            this.last_btn.Name = "last_btn";
            this.last_btn.Size = new System.Drawing.Size(45, 29);
            this.last_btn.TabIndex = 7;
            this.last_btn.Text = ">>||";
            this.last_btn.UseVisualStyleBackColor = true;
            // 
            // next_btn
            // 
            this.next_btn.Location = new System.Drawing.Point(237, 215);
            this.next_btn.Name = "next_btn";
            this.next_btn.Size = new System.Drawing.Size(45, 29);
            this.next_btn.TabIndex = 8;
            this.next_btn.Text = ">>";
            this.next_btn.UseVisualStyleBackColor = true;
            // 
            // email_txt
            // 
            this.email_txt.Location = new System.Drawing.Point(112, 166);
            this.email_txt.Name = "email_txt";
            this.email_txt.Size = new System.Drawing.Size(214, 27);
            this.email_txt.TabIndex = 3;
            // 
            // phone_txt
            // 
            this.phone_txt.Location = new System.Drawing.Point(112, 125);
            this.phone_txt.Name = "phone_txt";
            this.phone_txt.Size = new System.Drawing.Size(214, 27);
            this.phone_txt.TabIndex = 2;
            // 
            // lname_txt
            // 
            this.lname_txt.Location = new System.Drawing.Point(112, 87);
            this.lname_txt.Name = "lname_txt";
            this.lname_txt.Size = new System.Drawing.Size(214, 27);
            this.lname_txt.TabIndex = 1;
            // 
            // fname_txt
            // 
            this.fname_txt.Location = new System.Drawing.Point(112, 49);
            this.fname_txt.Name = "fname_txt";
            this.fname_txt.Size = new System.Drawing.Size(214, 27);
            this.fname_txt.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(17, 169);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 20);
            this.label4.TabIndex = 0;
            this.label4.Text = "Email :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 130);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 20);
            this.label3.TabIndex = 0;
            this.label3.Text = "Phone :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Last Name :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "First Name :";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.new_btn);
            this.groupBox2.Controls.Add(this.ExitCat_btn);
            this.groupBox2.Controls.Add(this.DeleteCat_btn);
            this.groupBox2.Controls.Add(this.EditCat_btn);
            this.groupBox2.Controls.Add(this.addCat_btn);
            this.groupBox2.Location = new System.Drawing.Point(12, 313);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(628, 86);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Valid Operation";
            // 
            // new_btn
            // 
            this.new_btn.Location = new System.Drawing.Point(17, 32);
            this.new_btn.Name = "new_btn";
            this.new_btn.Size = new System.Drawing.Size(94, 29);
            this.new_btn.TabIndex = 0;
            this.new_btn.Text = "New";
            this.new_btn.UseVisualStyleBackColor = true;
            // 
            // ExitCat_btn
            // 
            this.ExitCat_btn.Location = new System.Drawing.Point(507, 32);
            this.ExitCat_btn.Name = "ExitCat_btn";
            this.ExitCat_btn.Size = new System.Drawing.Size(94, 29);
            this.ExitCat_btn.TabIndex = 0;
            this.ExitCat_btn.Text = "Exit";
            this.ExitCat_btn.UseVisualStyleBackColor = true;
            // 
            // DeleteCat_btn
            // 
            this.DeleteCat_btn.Location = new System.Drawing.Point(381, 32);
            this.DeleteCat_btn.Name = "DeleteCat_btn";
            this.DeleteCat_btn.Size = new System.Drawing.Size(94, 29);
            this.DeleteCat_btn.TabIndex = 0;
            this.DeleteCat_btn.Text = "Delete";
            this.DeleteCat_btn.UseVisualStyleBackColor = true;
            // 
            // EditCat_btn
            // 
            this.EditCat_btn.Location = new System.Drawing.Point(261, 32);
            this.EditCat_btn.Name = "EditCat_btn";
            this.EditCat_btn.Size = new System.Drawing.Size(94, 29);
            this.EditCat_btn.TabIndex = 0;
            this.EditCat_btn.Text = "Edit";
            this.EditCat_btn.UseVisualStyleBackColor = true;
            // 
            // addCat_btn
            // 
            this.addCat_btn.Location = new System.Drawing.Point(137, 32);
            this.addCat_btn.Name = "addCat_btn";
            this.addCat_btn.Size = new System.Drawing.Size(94, 29);
            this.addCat_btn.TabIndex = 0;
            this.addCat_btn.Text = "Add";
            this.addCat_btn.UseVisualStyleBackColor = true;
            this.addCat_btn.Click += new System.EventHandler(this.addCat_btn_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.search_btn);
            this.groupBox3.Controls.Add(this.search_txt);
            this.groupBox3.Controls.Add(this.customersList_dgv);
            this.groupBox3.Controls.Add(this.search_lbl);
            this.groupBox3.Location = new System.Drawing.Point(652, 34);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(566, 365);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "All Customers";
            // 
            // search_btn
            // 
            this.search_btn.Location = new System.Drawing.Point(476, 29);
            this.search_btn.Name = "search_btn";
            this.search_btn.Size = new System.Drawing.Size(72, 29);
            this.search_btn.TabIndex = 3;
            this.search_btn.Text = "search";
            this.search_btn.UseVisualStyleBackColor = true;
            // 
            // search_txt
            // 
            this.search_txt.Location = new System.Drawing.Point(85, 29);
            this.search_txt.Name = "search_txt";
            this.search_txt.Size = new System.Drawing.Size(374, 27);
            this.search_txt.TabIndex = 2;
            // 
            // customersList_dgv
            // 
            this.customersList_dgv.AllowUserToAddRows = false;
            this.customersList_dgv.AllowUserToDeleteRows = false;
            this.customersList_dgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.customersList_dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.customersList_dgv.Location = new System.Drawing.Point(11, 71);
            this.customersList_dgv.Name = "customersList_dgv";
            this.customersList_dgv.RowHeadersWidth = 51;
            this.customersList_dgv.RowTemplate.Height = 29;
            this.customersList_dgv.Size = new System.Drawing.Size(549, 288);
            this.customersList_dgv.TabIndex = 1;
            // 
            // search_lbl
            // 
            this.search_lbl.AutoSize = true;
            this.search_lbl.Location = new System.Drawing.Point(16, 32);
            this.search_lbl.Name = "search_lbl";
            this.search_lbl.Size = new System.Drawing.Size(53, 20);
            this.search_lbl.TabIndex = 0;
            this.search_lbl.Text = "Search";
            // 
            // FRM_CustomersManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1241, 411);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FRM_CustomersManagement";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Customers Management";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.customersList_dgv)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox email_txt;
        private System.Windows.Forms.TextBox phone_txt;
        private System.Windows.Forms.TextBox lname_txt;
        private System.Windows.Forms.TextBox fname_txt;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label numbering_lbl;
        private System.Windows.Forms.Button first_btn;
        private System.Windows.Forms.Button previous_btn;
        private System.Windows.Forms.Button last_btn;
        private System.Windows.Forms.Button next_btn;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button new_btn;
        private System.Windows.Forms.Button ExitCat_btn;
        private System.Windows.Forms.Button DeleteCat_btn;
        private System.Windows.Forms.Button EditCat_btn;
        private System.Windows.Forms.Button addCat_btn;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button search_btn;
        private System.Windows.Forms.TextBox search_txt;
        private System.Windows.Forms.Label search_lbl;
        private System.Windows.Forms.Button button1;
        public System.Windows.Forms.DataGridView customersList_dgv;
    }
}