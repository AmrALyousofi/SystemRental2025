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
    public partial class MainPag : Form
    {
        public MainPag()
        {
            InitializeComponent();
        }

        private void MainPag_Load(object sender, EventArgs e)
        {

        }

        private void myButtonCicular1_Click(object sender, EventArgs e)
        {
            Accounts.Acc1 frmAcc1 = new Accounts.Acc1();
            frmAcc1.ShowDialog();
        }

        private void btnAccTotal_Dgv_Click(object sender, EventArgs e)
        {
            Accounts.AccTotal_Dgv frmAcc1 = new Accounts.AccTotal_Dgv();
            frmAcc1.ShowDialog();
        }

        private void btnCurrancyLatters_Click(object sender, EventArgs e)
        {
            Accounts.CurrancyLatters frmAcc1 = new Accounts.CurrancyLatters();
            frmAcc1.ShowDialog();
        }
    }
}
