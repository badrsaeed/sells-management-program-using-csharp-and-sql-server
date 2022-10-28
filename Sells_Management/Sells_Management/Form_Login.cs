using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Sells_Management.BL;

namespace Sells_Management
{
    public partial class Form_Login : Form
    {

        CLS_Login login = new CLS_Login();
        public Form_Login()
        {
            InitializeComponent();
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
                MessageBox.Show("Login Successfully!");
            else
                MessageBox.Show("Login Faild");
        }
    }
}
