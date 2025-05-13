using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Prcj_12_10
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {

            if (txtPass.Text == string.Empty) { MessageBox.Show(" لم تقم بإدخال كلمة سر الدخول", "رسالة تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Error); return; }
            if(txtPass.Text=="7796" || txtPass.Text=="2023")
            {
                MainPag frm = new MainPag();
                frm.ShowDialog();
            }
            else { MessageBox.Show("كلمة السر غير صحيحة ","رسالة تنبيه",MessageBoxButtons.OK,MessageBoxIcon.Error); }
        }
    }
}
