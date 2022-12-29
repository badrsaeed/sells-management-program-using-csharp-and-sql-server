using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Sells_Management.PL
{
    public partial class FRM_Categories : Form
    {
        SqlConnection sqlConnection = new SqlConnection(@"Server=.\SQL2019; DataBase=Product_DB; Integrated Security=true");
        SqlDataAdapter sqlda;
        DataTable dt = new DataTable();
        BindingManagerBase bmb;
        SqlCommandBuilder sqlcmdb;

        public FRM_Categories()
        {
            InitializeComponent();
            addCat_btn.Enabled = false;

            sqlda = new SqlDataAdapter("select id_Cat as ID, Description_CAT as Category from categories", sqlConnection);
            sqlda.Fill(dt);

            this.CategoriesList_dgv.DataSource = dt;

            this.catID.DataBindings.Add("text", dt, "ID"); 
            this.catDesc.DataBindings.Add("text", dt, "Category");

            bmb = this.BindingContext[dt];
            numbering_lbl.Text = (bmb.Position + 1) + " / " + bmb.Count;
        }

        private void FRM_Categories_Load(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void next_btn_Click(object sender, EventArgs e)
        {
            bmb.Position += 1;
            numbering_lbl.Text = (bmb.Position + 1) + " / " + bmb.Count;
        }

        private void previous_btn_Click(object sender, EventArgs e)
        {
            bmb.Position -= 1;
            numbering_lbl.Text = (bmb.Position + 1) + " / " + bmb.Count;
        }

        private void first_btn_Click(object sender, EventArgs e)
        {
            bmb.Position = 0;
            numbering_lbl.Text = (bmb.Position + 1) + " / " + bmb.Count;
        }

        private void last_btn_Click(object sender, EventArgs e)
        {
            bmb.Position = bmb.Count;
            numbering_lbl.Text = (bmb.Position + 1) + " / " + bmb.Count;
        }

        private void ExitCat_btn_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void new_btn_Click(object sender, EventArgs e)
        {
            bmb.AddNew();
            int newId = Convert.ToInt16(dt.Rows[dt.Rows.Count - 1][0]) + 1;
            this.catID.Text = newId.ToString();
            catDesc.Focus();
            new_btn.Enabled = false;
            addCat_btn.Enabled = true;  
        }

        private void addCat_btn_Click(object sender, EventArgs e)
        {
            bmb.EndCurrentEdit();
            sqlcmdb = new SqlCommandBuilder(sqlda);
            sqlda.Update(dt);

            MessageBox.Show("Added Successfully!", "Add", MessageBoxButtons.OK,
                MessageBoxIcon.Information);

            numbering_lbl.Text = (bmb.Position + 1) + " / " + bmb.Count;
            new_btn.Enabled = true;
            addCat_btn.Enabled = false;
        }

        private void EditCat_btn_Click(object sender, EventArgs e)
        {
            bmb.EndCurrentEdit();
            sqlcmdb = new SqlCommandBuilder(sqlda);
            sqlda.Update(dt);

            MessageBox.Show("Edited Successfully!", "Edit", MessageBoxButtons.OK,
                MessageBoxIcon.Information);

            numbering_lbl.Text = (bmb.Position + 1) + " / " + bmb.Count;
        }

        private void DeleteCat_btn_Click(object sender, EventArgs e)
        {
            bmb.RemoveAt(bmb.Position);
            bmb.EndCurrentEdit();
            sqlcmdb = new SqlCommandBuilder(sqlda);
            sqlda.Update(dt);

            MessageBox.Show("Deleted Successfully!", "Delete", MessageBoxButtons.OK,
                MessageBoxIcon.Information);

            numbering_lbl.Text = (bmb.Position + 1) + " / " + bmb.Count;
        }
    }
}
