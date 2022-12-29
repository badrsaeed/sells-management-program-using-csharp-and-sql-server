using Sells_Management.BL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace Sells_Management.PL
{
    public partial class FRM_CustomersManagement : Form
    {
        CLS_Customers customers = new CLS_Customers();

        public FRM_CustomersManagement()
        {
            InitializeComponent();
            this.customersList_dgv.DataSource = customers.GetAllCustomers();
        }

        private void addCat_btn_Click(object sender, EventArgs e)
        {
            try
            {
                byte[] image;
                MemoryStream stream = new MemoryStream();
                pictureBox1.Image.Save(stream, pictureBox1.Image.RawFormat);
                image = stream.ToArray();

                customers.AddCustomer(fname_txt.Text, lname_txt.Text, phone_txt.Text, email_txt.Text
                    , image);

                MessageBox.Show("Customer Added Successfully!", "Adding",
                       MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.customersList_dgv.DataSource = customers.GetAllCustomers();

            }
            catch 
            {
                return;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Picture Files | *.jpg; *.PNG; *.GIF; *.BMP; *.SVG ";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Image = Image.FromFile(ofd.FileName);
            }
        }
    }
}
