using Sells_Management.BL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Windows.Forms;

namespace Sells_Management.PL
{
    public partial class FRM_ADD_PRODUCT : Form
    {
        Products product = new Products();
        public bool IsAddOperation = true;
        FRM_Products_search fps = FRM_Products_search.GetProductInstance;
        public FRM_ADD_PRODUCT()
        {
            InitializeComponent();
            cmbCategories.DataSource = product.GetAllCategories();
            cmbCategories.DisplayMember = "Description_Cat";
            cmbCategories.ValueMember = "ID_Cat";
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Picture Files | *.jpg; *.PNG; *.GIF; *.BMP; *.SVG ";
            if(ofd.ShowDialog() == DialogResult.OK)
            {
                picture_box.Image = Image.FromFile(ofd.FileName);
            }
        }

        private void Ok_btn_Click(object sender, EventArgs e)
        {
            byte[] byteImage = null;
            MemoryStream stream = new MemoryStream();
            picture_box.Image.Save(stream, picture_box.Image.RawFormat);

            byteImage = stream.ToArray();


            if (IsAddOperation)
            {
                product.AddProduct(product_id.Text, prod_discreption.Text,
                    Convert.ToInt32(quentitu_txt.Text), price_txt.Text,
                    Convert.ToInt32(cmbCategories.SelectedValue), byteImage);

                MessageBox.Show("Product Added Successfully!", "Adding",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);

                product_id.Text = "";
                prod_discreption.Text = "";
                quentitu_txt.Text = "";
                price_txt.Text = "";
                picture_box.Image = default;
                product_id.Focus();
            }

            else
            {
                var response = MessageBox.Show("Do you want update this product by new value ?", "Updating",
                    MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                if(response == DialogResult.OK)
                {
                    product.UpdateProduct(
                    product_id.Text, prod_discreption.Text, Convert.ToInt32(quentitu_txt.Text),
                    price_txt.Text, byteImage, Convert.ToInt32(cmbCategories.SelectedValue));

                    MessageBox.Show("Product Updated Successfully!", "Updating",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);

                    
                }
                else
                {
                    MessageBox.Show("Product updated Cancelled!", "Updating",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            fps.dataGridView1.DataSource = product.GetAllProducts();

        }

        private void cmbCategories_Validated(object sender, EventArgs e)
        {
          
        }

        private void product_id_Validated(object sender, EventArgs e)
        {
            if (IsAddOperation)
            {
                DataTable dt = product.ProductIdChecker(product_id.Text);
                if (dt.Rows.Count > 0)
                {
                    MessageBox.Show("Product ID Already Exist", "Warning !!",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);

                    product_id.Focus();
                    product_id.SelectionStart = 0;
                    product_id.SelectionLength = product_id.TextLength;
                }
            }
        }

        private void cancel_btn_Click(object sender, EventArgs e)
        {
            Close();

        }
    }
}
