namespace Sells_Management.PL
{
    partial class FRM_Categories
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
            this.CategoriesList_dgv = new System.Windows.Forms.DataGridView();
            this.numbering_lbl = new System.Windows.Forms.Label();
            this.first_btn = new System.Windows.Forms.Button();
            this.previous_btn = new System.Windows.Forms.Button();
            this.last_btn = new System.Windows.Forms.Button();
            this.next_btn = new System.Windows.Forms.Button();
            this.catDesc = new System.Windows.Forms.TextBox();
            this.catID = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.new_btn = new System.Windows.Forms.Button();
            this.ExitCat_btn = new System.Windows.Forms.Button();
            this.DeleteCat_btn = new System.Windows.Forms.Button();
            this.EditCat_btn = new System.Windows.Forms.Button();
            this.addCat_btn = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CategoriesList_dgv)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.CategoriesList_dgv);
            this.groupBox1.Controls.Add(this.numbering_lbl);
            this.groupBox1.Controls.Add(this.first_btn);
            this.groupBox1.Controls.Add(this.previous_btn);
            this.groupBox1.Controls.Add(this.last_btn);
            this.groupBox1.Controls.Add(this.next_btn);
            this.groupBox1.Controls.Add(this.catDesc);
            this.groupBox1.Controls.Add(this.catID);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(967, 256);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Category Datailes";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // CategoriesList_dgv
            // 
            this.CategoriesList_dgv.AllowUserToAddRows = false;
            this.CategoriesList_dgv.AllowUserToDeleteRows = false;
            this.CategoriesList_dgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.CategoriesList_dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.CategoriesList_dgv.Location = new System.Drawing.Point(536, 26);
            this.CategoriesList_dgv.Name = "CategoriesList_dgv";
            this.CategoriesList_dgv.RowHeadersWidth = 51;
            this.CategoriesList_dgv.RowTemplate.Height = 29;
            this.CategoriesList_dgv.Size = new System.Drawing.Size(425, 219);
            this.CategoriesList_dgv.TabIndex = 0;
            // 
            // numbering_lbl
            // 
            this.numbering_lbl.AutoSize = true;
            this.numbering_lbl.Location = new System.Drawing.Point(334, 225);
            this.numbering_lbl.Name = "numbering_lbl";
            this.numbering_lbl.Size = new System.Drawing.Size(47, 20);
            this.numbering_lbl.TabIndex = 4;
            this.numbering_lbl.Text = "15/20";
            // 
            // first_btn
            // 
            this.first_btn.Location = new System.Drawing.Point(203, 220);
            this.first_btn.Name = "first_btn";
            this.first_btn.Size = new System.Drawing.Size(45, 29);
            this.first_btn.TabIndex = 3;
            this.first_btn.Text = "||<<";
            this.first_btn.UseVisualStyleBackColor = true;
            this.first_btn.Click += new System.EventHandler(this.first_btn_Click);
            // 
            // previous_btn
            // 
            this.previous_btn.Location = new System.Drawing.Point(267, 220);
            this.previous_btn.Name = "previous_btn";
            this.previous_btn.Size = new System.Drawing.Size(45, 29);
            this.previous_btn.TabIndex = 3;
            this.previous_btn.Text = "<<";
            this.previous_btn.UseVisualStyleBackColor = true;
            this.previous_btn.Click += new System.EventHandler(this.previous_btn_Click);
            // 
            // last_btn
            // 
            this.last_btn.Location = new System.Drawing.Point(476, 218);
            this.last_btn.Name = "last_btn";
            this.last_btn.Size = new System.Drawing.Size(45, 29);
            this.last_btn.TabIndex = 3;
            this.last_btn.Text = ">>||";
            this.last_btn.UseVisualStyleBackColor = true;
            this.last_btn.Click += new System.EventHandler(this.last_btn_Click);
            // 
            // next_btn
            // 
            this.next_btn.Location = new System.Drawing.Point(413, 219);
            this.next_btn.Name = "next_btn";
            this.next_btn.Size = new System.Drawing.Size(45, 29);
            this.next_btn.TabIndex = 3;
            this.next_btn.Text = ">>";
            this.next_btn.UseVisualStyleBackColor = true;
            this.next_btn.Click += new System.EventHandler(this.next_btn_Click);
            // 
            // catDesc
            // 
            this.catDesc.Location = new System.Drawing.Point(204, 78);
            this.catDesc.Multiline = true;
            this.catDesc.Name = "catDesc";
            this.catDesc.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.catDesc.Size = new System.Drawing.Size(317, 136);
            this.catDesc.TabIndex = 2;
            // 
            // catID
            // 
            this.catID.Location = new System.Drawing.Point(204, 30);
            this.catID.Name = "catID";
            this.catID.ReadOnly = true;
            this.catID.Size = new System.Drawing.Size(204, 27);
            this.catID.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(47, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(145, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Category Discription";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(47, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Category ID";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.new_btn);
            this.groupBox2.Controls.Add(this.ExitCat_btn);
            this.groupBox2.Controls.Add(this.DeleteCat_btn);
            this.groupBox2.Controls.Add(this.EditCat_btn);
            this.groupBox2.Controls.Add(this.addCat_btn);
            this.groupBox2.Location = new System.Drawing.Point(12, 273);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(967, 86);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Valid Operation";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // new_btn
            // 
            this.new_btn.Location = new System.Drawing.Point(47, 32);
            this.new_btn.Name = "new_btn";
            this.new_btn.Size = new System.Drawing.Size(94, 29);
            this.new_btn.TabIndex = 0;
            this.new_btn.Text = "New";
            this.new_btn.UseVisualStyleBackColor = true;
            this.new_btn.Click += new System.EventHandler(this.new_btn_Click);
            // 
            // ExitCat_btn
            // 
            this.ExitCat_btn.Location = new System.Drawing.Point(807, 32);
            this.ExitCat_btn.Name = "ExitCat_btn";
            this.ExitCat_btn.Size = new System.Drawing.Size(94, 29);
            this.ExitCat_btn.TabIndex = 0;
            this.ExitCat_btn.Text = "Exit";
            this.ExitCat_btn.UseVisualStyleBackColor = true;
            this.ExitCat_btn.Click += new System.EventHandler(this.ExitCat_btn_Click);
            // 
            // DeleteCat_btn
            // 
            this.DeleteCat_btn.Location = new System.Drawing.Point(617, 32);
            this.DeleteCat_btn.Name = "DeleteCat_btn";
            this.DeleteCat_btn.Size = new System.Drawing.Size(94, 29);
            this.DeleteCat_btn.TabIndex = 0;
            this.DeleteCat_btn.Text = "Delete";
            this.DeleteCat_btn.UseVisualStyleBackColor = true;
            this.DeleteCat_btn.Click += new System.EventHandler(this.DeleteCat_btn_Click);
            // 
            // EditCat_btn
            // 
            this.EditCat_btn.Location = new System.Drawing.Point(427, 32);
            this.EditCat_btn.Name = "EditCat_btn";
            this.EditCat_btn.Size = new System.Drawing.Size(94, 29);
            this.EditCat_btn.TabIndex = 0;
            this.EditCat_btn.Text = "Edit";
            this.EditCat_btn.UseVisualStyleBackColor = true;
            this.EditCat_btn.Click += new System.EventHandler(this.EditCat_btn_Click);
            // 
            // addCat_btn
            // 
            this.addCat_btn.Location = new System.Drawing.Point(237, 32);
            this.addCat_btn.Name = "addCat_btn";
            this.addCat_btn.Size = new System.Drawing.Size(94, 29);
            this.addCat_btn.TabIndex = 0;
            this.addCat_btn.Text = "Add";
            this.addCat_btn.UseVisualStyleBackColor = true;
            this.addCat_btn.Click += new System.EventHandler(this.addCat_btn_Click);
            // 
            // FRM_Categories
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(994, 365);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FRM_Categories";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Categories Management";
            this.Load += new System.EventHandler(this.FRM_Categories_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CategoriesList_dgv)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label numbering_lbl;
        private System.Windows.Forms.Button first_btn;
        private System.Windows.Forms.Button previous_btn;
        private System.Windows.Forms.Button last_btn;
        private System.Windows.Forms.Button next_btn;
        private System.Windows.Forms.TextBox catDesc;
        private System.Windows.Forms.TextBox catID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button new_btn;
        private System.Windows.Forms.Button ExitCat_btn;
        private System.Windows.Forms.Button DeleteCat_btn;
        private System.Windows.Forms.Button EditCat_btn;
        private System.Windows.Forms.Button addCat_btn;
        private System.Windows.Forms.DataGridView CategoriesList_dgv;
    }
}