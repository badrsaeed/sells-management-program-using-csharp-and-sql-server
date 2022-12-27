using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Sells_Management.BL;
using Sells_Management.PL;

namespace Sells_Management
{
    public partial class Form_Login : Form
    {

        CLS_Login login = new CLS_Login();
        public Form_Login()
        {
            InitializeComponent();
            txtID.Focus();
        }

        private void Form_Login_Load(object sender, EventArgs e)
        {
           
        }

        

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            DataTable dt = login.Login(txtID.Text, txtPWD.Text);
            if (dt.Rows.Count > 0)
            {
                main_form.getMAinForm.المنتجاتToolStripMenuItem.Enabled = true;
                main_form.getMAinForm.المستخدمونToolStripMenuItem.Enabled = true;
                main_form.getMAinForm.العملاءToolStripMenuItem.Enabled = true;
                main_form.getMAinForm.استعادةنسخةمحفوظةToolStripMenuItem.Enabled = true;
                main_form.getMAinForm.انشاءنسخةاحتياطيةToolStripMenuItem.Enabled = true;

                this.Close();
            }
            else
                MessageBox.Show("Login Faild");
        }
    }
}
