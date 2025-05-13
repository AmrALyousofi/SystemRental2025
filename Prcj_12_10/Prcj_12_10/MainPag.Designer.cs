namespace Prcj_12_10
{
    partial class MainPag
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.myButtonCicular1 = new Prcj_12_10.MyButtonCicular();
            this.btnAccTotal_Dgv = new Prcj_12_10.MyButtonCicular();
            this.btnCurrancyLatters = new Prcj_12_10.MyButtonCicular();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panel1.Controls.Add(this.btnCurrancyLatters);
            this.panel1.Controls.Add(this.btnAccTotal_Dgv);
            this.panel1.Controls.Add(this.myButtonCicular1);
            this.panel1.Font = new System.Drawing.Font("Sakkal Majalla", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(-1, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1061, 514);
            this.panel1.TabIndex = 0;
            // 
            // myButtonCicular1
            // 
            this.myButtonCicular1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.myButtonCicular1.Font = new System.Drawing.Font("Sakkal Majalla", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.myButtonCicular1.Location = new System.Drawing.Point(617, 32);
            this.myButtonCicular1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.myButtonCicular1.Name = "myButtonCicular1";
            this.myButtonCicular1.Size = new System.Drawing.Size(120, 102);
            this.myButtonCicular1.TabIndex = 0;
            this.myButtonCicular1.Text = "1";
            this.myButtonCicular1.UseVisualStyleBackColor = true;
            this.myButtonCicular1.Click += new System.EventHandler(this.myButtonCicular1_Click);
            // 
            // btnAccTotal_Dgv
            // 
            this.btnAccTotal_Dgv.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAccTotal_Dgv.Font = new System.Drawing.Font("Sakkal Majalla", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAccTotal_Dgv.Location = new System.Drawing.Point(442, 32);
            this.btnAccTotal_Dgv.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAccTotal_Dgv.Name = "btnAccTotal_Dgv";
            this.btnAccTotal_Dgv.Size = new System.Drawing.Size(120, 102);
            this.btnAccTotal_Dgv.TabIndex = 1;
            this.btnAccTotal_Dgv.Text = "2";
            this.btnAccTotal_Dgv.UseVisualStyleBackColor = true;
            this.btnAccTotal_Dgv.Click += new System.EventHandler(this.btnAccTotal_Dgv_Click);
            // 
            // btnCurrancyLatters
            // 
            this.btnCurrancyLatters.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCurrancyLatters.Font = new System.Drawing.Font("Sakkal Majalla", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCurrancyLatters.Location = new System.Drawing.Point(290, 32);
            this.btnCurrancyLatters.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCurrancyLatters.Name = "btnCurrancyLatters";
            this.btnCurrancyLatters.Size = new System.Drawing.Size(120, 102);
            this.btnCurrancyLatters.TabIndex = 2;
            this.btnCurrancyLatters.Text = "3";
            this.btnCurrancyLatters.UseVisualStyleBackColor = true;
            this.btnCurrancyLatters.Click += new System.EventHandler(this.btnCurrancyLatters_Click);
            // 
            // MainPag
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.ClientSize = new System.Drawing.Size(1058, 417);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "MainPag";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.WindowsDefaultBounds;
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.MainPag_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private MyButtonCicular myButtonCicular1;
        private MyButtonCicular btnCurrancyLatters;
        private MyButtonCicular btnAccTotal_Dgv;
    }
}

