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
    public partial class Acc1 : Form
    {
        public Acc1()
        {
            InitializeComponent();
        }


        private void CalculatinoSalePrice()
        {
            



            for (Int32 i = 0; i <= dgv.Rows.Count - 1; i++)
            {
                double xEnar = Convert.ToDouble(txtEarnRatio.Text);
                dgv[6, i].Value = xEnar + "%";
                if (Convert.ToInt16(Quotation.SelectedIndex) == 0) { xEnar = xEnar * 1; }
                else if (Convert.ToInt16(Quotation.SelectedIndex) == 1) { xEnar = xEnar * -1; }
                if (CkRound.Checked == false)
                {
                    if (Convert.ToInt16(CalcMethod.SelectedIndex) == 0)
                    {
                        dgv[7, i].Value = (((xEnar / 100) * Convert.ToDouble(dgv[4, i].Value)) + Convert.ToDouble(dgv[4, i].Value));
                    }
                    else if (Convert.ToInt16(CalcMethod.SelectedIndex) == 1)
                    {
                        dgv[7, i].Value = (((xEnar / 100) * Convert.ToDouble(dgv[5, i].Value)) + Convert.ToDouble(dgv[5, i].Value));
                    }
                }
                else if (CkRound.Checked == true)
                {
                    int z = Convert.ToInt32(txtfraction.Text.Trim());
                    if (Convert.ToInt16(CalcMethod.SelectedIndex) == 0)
                    {
                        dgv[7, i].Value = Math.Round((((xEnar / 100) * Convert.ToDouble(dgv[4, i].Value)) + Convert.ToDouble(dgv[4, i].Value)), z);
                    }
                    else if (Convert.ToInt16(CalcMethod.SelectedIndex) == 1)
                    {
                        dgv[7, i].Value = Math.Round((((xEnar / 100) * Convert.ToDouble(dgv[5, i].Value)) + Convert.ToDouble(dgv[5, i].Value)), z);
                    }
                }
            }
        }
        private void btnCalculations_Click(object sender, EventArgs e)
        {
            CalculatinoSalePrice();
        }
    }
}
