using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Prcj_12_10.Accounts
{
    public partial class AccTotal_Dgv : Form
    {
        public AccTotal_Dgv()
        {
            InitializeComponent();
            dgv.AllowUserToAddRows = true;
        }
        private void GetTotalCalc()
        {
            double Total = 0;
 
            foreach (DataGridViewRow row in dgv.Rows)
            {
                row.Cells[5].Value = Math.Round(Convert.ToDouble(row.Cells[4].Value) * Convert.ToDouble(row.Cells[3].Value), 3);
                Total += Convert.ToDouble(row.Cells[5].Value);
            }
            TotalAll.Text = Total.ToString();
            NumberOfItems.Text = dgv.Rows.Count.ToString();         
        }

        private void button1_Click(object sender, EventArgs e)
        {
            GetTotalCalc();
        }

        private void dgv_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            GetTotalCalc();
        }
    }
}
