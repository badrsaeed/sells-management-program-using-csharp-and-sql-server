using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Sells_Management.PL
{
    public partial class main_form : Form
    {
        private static main_form frmMain;
        public static main_form getMAinForm 
        {
            get
            {
                if(frmMain == null)
                {
                    frmMain = new main_form();
                    frmMain.FormClosed += new FormClosedEventHandler(CloseMainFormObject);
                }
                return frmMain;
            }
        }

        public main_form()
        {
            InitializeComponent();
            if (frmMain == null)
                frmMain = this; 
            this.المستخدمونToolStripMenuItem.Enabled = false;
            this.العملاءToolStripMenuItem.Enabled = false;
            this.المنتجاتToolStripMenuItem.Enabled = false;
            this.انشاءنسخةاحتياطيةToolStripMenuItem.Enabled = false;
            this.استعادةنسخةمحفوظةToolStripMenuItem.Enabled = false;
        }

        public static void CloseMainFormObject(Object sender, FormClosedEventArgs e)
        {
            frmMain = null;
        }

        private void المنتجاتToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void تسجيلالدخولToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_Login frmL = new Form_Login();
            frmL.ShowDialog();
        }

        private void ادارةالعملاءToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void اضافةمنتجToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FRM_ADD_PRODUCT fRM_ADD_PRODUCT= new FRM_ADD_PRODUCT();
            fRM_ADD_PRODUCT.ShowDialog(); 
        }

        private void إدارةالمنتجاتToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FRM_Products_search fRM_Products_Search = new FRM_Products_search();
            fRM_Products_Search.ShowDialog();
        }
    }
}
