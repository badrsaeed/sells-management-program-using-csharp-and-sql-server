using Sells_Management.BL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;

namespace Sells_Management.PL
{
    public partial class FRM_Products_search : Form
    {
        private static FRM_Products_search frm_psearch;
        Products product = new Products();

        public static FRM_Products_search GetProductInstance {
            get
            {
                if(frm_psearch is null)
                {
                    frm_psearch = new FRM_Products_search();
                    frm_psearch.FormClosed += new FormClosedEventHandler(Frm_psearch_FormClosed);
                }
                return frm_psearch;
            }
        }

        private static void Frm_psearch_FormClosed(object sender, FormClosedEventArgs e)
        {
            frm_psearch= null;
        }

        public FRM_Products_search()
        {
            InitializeComponent();
            if(frm_psearch is null)
                frm_psearch= this;
            this.dataGridView1.DataSource = product.GetAllProducts();
        }

        
        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void search_txt_TextChanged(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt = product.SearchAboutProduct(search_txt.Text);
            this.dataGridView1.DataSource = dt;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FRM_ADD_PRODUCT fRM_ADD_PRODUCT = new FRM_ADD_PRODUCT();
            fRM_ADD_PRODUCT.ShowDialog();

            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do You Want to Delete this Product ?",
                "Delete !", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation)
                == DialogResult.Yes)
            {
                var productID = this.dataGridView1.CurrentRow.Cells[0].Value.ToString();
                product.DeleteProduct(productID);

                MessageBox.Show("Deleted Successfully.", "Delete", MessageBoxButtons.OK, MessageBoxIcon.Information);

                this.dataGridView1.DataSource = product.GetAllProducts();
            }
            else
            {
                MessageBox.Show("Deleted Canceled.", "Delete", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            FRM_ADD_PRODUCT frm_add =  new FRM_ADD_PRODUCT();
            frm_add.product_id.Text = this.dataGridView1.CurrentRow
                .Cells[0].Value.ToString();
            frm_add.prod_discreption.Text = this.dataGridView1.CurrentRow
                .Cells[1].Value.ToString();
            frm_add.price_txt.Text = this.dataGridView1.CurrentRow
                .Cells[2].Value.ToString();
            frm_add.quentitu_txt.Text = this.dataGridView1.CurrentRow
                .Cells[3].Value.ToString();
            frm_add.cmbCategories.Text = this.dataGridView1.CurrentRow
                .Cells[4].Value.ToString();

            frm_add.Text = "Update product";
            frm_add.Ok_btn.Text = "Update";
            frm_add.IsAddOperation = false;
            frm_add.product_id.ReadOnly = true;

            DataTable dtimages = product.GetProductImage(this.dataGridView1.CurrentRow.Cells[0].Value.ToString());
            byte[] image = (byte[])dtimages.Rows[0][0]; 
            var stream = new MemoryStream(image);
            frm_add.picture_box.Image = Image.FromStream(stream); 
            frm_add.ShowDialog();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            FRM_Preview frm_preview = new FRM_Preview();
            DataTable dtimages = product.GetProductImage(this.dataGridView1.CurrentRow.Cells[0].Value.ToString());
            byte[] image = (byte[])dtimages.Rows[0][0];
            var stream = new MemoryStream(image);
            frm_preview.productImageBox.Image = Image.FromStream(stream);
            frm_preview.ShowDialog();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            ExportOptions exportOptions = new ExportOptions();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
