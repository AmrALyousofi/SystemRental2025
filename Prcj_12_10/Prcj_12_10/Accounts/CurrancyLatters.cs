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
    public partial class CurrancyLatters : Form
    {
        public CurrancyLatters()
        {
            InitializeComponent();
        }

        private void CurrancyLatters_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Label24_Click(object sender, EventArgs e)
        {

        }

        private void L1_Leave(object sender, EventArgs e)
        {
            t2.Text = "2";
        }

        private void L1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                textBox9.Focus();
        }
        public static void ClearControlsOnPanel(Panel panel)
        {
            foreach (TextBox textBox in panel.Controls.OfType<TextBox>())
            {
                textBox.Clear();
                textBox.Enabled = true;            
            }
            
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (btnAdd.Text == "إضافة")
            {
                ClearControlsOnPanel(panel1);
                textBox2.Focus();
                t1.Text = "1";
                this.btnAdd.Text = "حـــــفـــــظ";
            }
            else if (TotalFinal.Text == string.Empty)
                  
                MessageBox.Show("تأكد من إدخال البيانات","تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                else
                    MessageBox.Show("تم حفظ البيانات", "حفظ", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        double totla1 ;
        double totoal2;
        double totoal3 ;

        private void L2_Leave(object sender, EventArgs e)
        {
            t3.Text = "3";
        }

        private void L3_Leave(object sender, EventArgs e)
        {
            //t4.Text = "4";
        }

        private void Q1_TextChanged(object sender, EventArgs e)
        {
            totoal3 = Convert.ToDouble(totla1) * Convert.ToDouble(totoal2);
            L1.Text = totoal3.ToString();
        }

        private void P1_TextChanged(object sender, EventArgs e)
        {
            totoal3 = Convert.ToDouble(totla1) * Convert.ToDouble(totoal2);
            L1.Text = totoal3.ToString();
        }

        private void P2_TextChanged(object sender, EventArgs e)
        {
            totoal3 = Convert.ToDouble(totla1 * totoal2);
            L2.Text = totoal3.ToString();
        }

        private void Q2_TextChanged(object sender, EventArgs e)
        {
            totoal3 = Convert.ToDouble(totla1 * totoal2);
            L2.Text = totoal3.ToString();
        }
    }
    }
