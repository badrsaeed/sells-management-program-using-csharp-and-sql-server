namespace Sells_Management.PL
{
    partial class FRM_Preview
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
            this.productImageBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.productImageBox)).BeginInit();
            this.SuspendLayout();
            // 
            // productImageBox
            // 
            this.productImageBox.Location = new System.Drawing.Point(20, 12);
            this.productImageBox.Name = "productImageBox";
            this.productImageBox.Size = new System.Drawing.Size(761, 427);
            this.productImageBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.productImageBox.TabIndex = 0;
            this.productImageBox.TabStop = false;
            // 
            // FRM_Preview
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.productImageBox);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FRM_Preview";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Product Image";
            ((System.ComponentModel.ISupportInitialize)(this.productImageBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.PictureBox productImageBox;
    }
}