<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_students_Add
    Inherits frm_Feather

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.dgv_stu = New System.Windows.Forms.DataGridView()
        Me.STU_NO = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.STU_NAME = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DIV_STU_ = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RING_ID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.btn_Add = New System.Windows.Forms.Button()
        Me.comb_stu_div = New System.Windows.Forms.ComboBox()
        Me.comb_stu_ring = New System.Windows.Forms.ComboBox()
        Me.txt_phone = New System.Windows.Forms.TextBox()
        Me.txt_adress = New System.Windows.Forms.TextBox()
        Me.txt_name = New System.Windows.Forms.TextBox()
        Me.txt_stu_no = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txt_search = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        CType(Me.dgv_stu, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.dgv_stu)
        Me.Panel1.Controls.Add(Me.GroupBox1)
        Me.Panel1.Controls.Add(Me.txt_search)
        Me.Panel1.Controls.Add(Me.Label7)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Font = New System.Drawing.Font("Times New Roman", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel1.Location = New System.Drawing.Point(0, 67)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1213, 359)
        Me.Panel1.TabIndex = 1
        '
        'dgv_stu
        '
        Me.dgv_stu.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dgv_stu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_stu.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.STU_NO, Me.STU_NAME, Me.DIV_STU_, Me.RING_ID})
        Me.dgv_stu.Cursor = System.Windows.Forms.Cursors.Hand
        Me.dgv_stu.Location = New System.Drawing.Point(3, 47)
        Me.dgv_stu.Name = "dgv_stu"
        Me.dgv_stu.RowTemplate.Height = 26
        Me.dgv_stu.Size = New System.Drawing.Size(654, 306)
        Me.dgv_stu.TabIndex = 1
        '
        'STU_NO
        '
        Me.STU_NO.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.STU_NO.DataPropertyName = "STU_NO"
        Me.STU_NO.FillWeight = 90.57971!
        Me.STU_NO.HeaderText = "رقم الطالب"
        Me.STU_NO.Name = "STU_NO"
        '
        'STU_NAME
        '
        Me.STU_NAME.DataPropertyName = "STU_NAME"
        Me.STU_NAME.FillWeight = 94.41695!
        Me.STU_NAME.HeaderText = "اسم الطالب"
        Me.STU_NAME.Name = "STU_NAME"
        Me.STU_NAME.Width = 280
        '
        'DIV_STU_
        '
        Me.DIV_STU_.DataPropertyName = "DIV_STU_"
        Me.DIV_STU_.FillWeight = 109.3661!
        Me.DIV_STU_.HeaderText = "الشعبة"
        Me.DIV_STU_.Name = "DIV_STU_"
        Me.DIV_STU_.Width = 90
        '
        'RING_ID
        '
        Me.RING_ID.DataPropertyName = "RING_ID"
        Me.RING_ID.FillWeight = 105.6372!
        Me.RING_ID.HeaderText = "الحلقة"
        Me.RING_ID.Name = "RING_ID"
        Me.RING_ID.Width = 132
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Button1)
        Me.GroupBox1.Controls.Add(Me.btn_Add)
        Me.GroupBox1.Controls.Add(Me.comb_stu_div)
        Me.GroupBox1.Controls.Add(Me.comb_stu_ring)
        Me.GroupBox1.Controls.Add(Me.txt_phone)
        Me.GroupBox1.Controls.Add(Me.txt_adress)
        Me.GroupBox1.Controls.Add(Me.txt_name)
        Me.GroupBox1.Controls.Add(Me.txt_stu_no)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(672, 15)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(528, 338)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "بيانات الطالب"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(235, 279)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(172, 34)
        Me.Button1.TabIndex = 3
        Me.Button1.Text = "جديد"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'btn_Add
        '
        Me.btn_Add.Location = New System.Drawing.Point(48, 279)
        Me.btn_Add.Name = "btn_Add"
        Me.btn_Add.Size = New System.Drawing.Size(172, 34)
        Me.btn_Add.TabIndex = 3
        Me.btn_Add.Text = "إظافة"
        Me.btn_Add.UseVisualStyleBackColor = True
        '
        'comb_stu_div
        '
        Me.comb_stu_div.FormattingEnabled = True
        Me.comb_stu_div.Location = New System.Drawing.Point(110, 238)
        Me.comb_stu_div.Name = "comb_stu_div"
        Me.comb_stu_div.Size = New System.Drawing.Size(297, 34)
        Me.comb_stu_div.TabIndex = 2
        '
        'comb_stu_ring
        '
        Me.comb_stu_ring.FormattingEnabled = True
        Me.comb_stu_ring.Location = New System.Drawing.Point(110, 199)
        Me.comb_stu_ring.Name = "comb_stu_ring"
        Me.comb_stu_ring.Size = New System.Drawing.Size(297, 34)
        Me.comb_stu_ring.TabIndex = 2
        '
        'txt_phone
        '
        Me.txt_phone.Location = New System.Drawing.Point(62, 160)
        Me.txt_phone.Name = "txt_phone"
        Me.txt_phone.Size = New System.Drawing.Size(345, 34)
        Me.txt_phone.TabIndex = 1
        '
        'txt_adress
        '
        Me.txt_adress.Location = New System.Drawing.Point(9, 121)
        Me.txt_adress.Name = "txt_adress"
        Me.txt_adress.Size = New System.Drawing.Size(398, 34)
        Me.txt_adress.TabIndex = 1
        '
        'txt_name
        '
        Me.txt_name.Location = New System.Drawing.Point(21, 81)
        Me.txt_name.Name = "txt_name"
        Me.txt_name.Size = New System.Drawing.Size(386, 34)
        Me.txt_name.TabIndex = 1
        '
        'txt_stu_no
        '
        Me.txt_stu_no.Location = New System.Drawing.Point(197, 42)
        Me.txt_stu_no.Name = "txt_stu_no"
        Me.txt_stu_no.Size = New System.Drawing.Size(210, 34)
        Me.txt_stu_no.TabIndex = 1
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(456, 238)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(59, 27)
        Me.Label6.TabIndex = 0
        Me.Label6.Text = "الشعبة"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(440, 202)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(87, 27)
        Me.Label5.TabIndex = 0
        Me.Label5.Text = "اسم الحلقة"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(443, 160)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(62, 27)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "الهاتف"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(440, 121)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(65, 27)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "العنوان"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(428, 84)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(96, 27)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "اسم الطالب"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(428, 43)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(96, 27)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "رقم الطالب"
        '
        'txt_search
        '
        Me.txt_search.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txt_search.Font = New System.Drawing.Font("Times New Roman", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_search.Location = New System.Drawing.Point(98, 4)
        Me.txt_search.Name = "txt_search"
        Me.txt_search.Size = New System.Drawing.Size(386, 34)
        Me.txt_search.TabIndex = 1
        Me.txt_search.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Times New Roman", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(490, 12)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(48, 26)
        Me.Label7.TabIndex = 0
        Me.Label7.Text = "بحث"
        '
        'frm_students_Add
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 32.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1213, 426)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "frm_students_Add"
        Me.Text = "إظافة طالب"
        Me.Controls.SetChildIndex(Me.Panel1, 0)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.dgv_stu, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents comb_stu_div As ComboBox
    Friend WithEvents comb_stu_ring As ComboBox
    Friend WithEvents txt_phone As TextBox
    Friend WithEvents txt_adress As TextBox
    Friend WithEvents txt_name As TextBox
    Friend WithEvents txt_stu_no As TextBox
    Friend WithEvents dgv_stu As DataGridView
    Friend WithEvents txt_search As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents STU_NO As DataGridViewTextBoxColumn
    Friend WithEvents STU_NAME As DataGridViewTextBoxColumn
    Friend WithEvents DIV_STU_ As DataGridViewTextBoxColumn
    Friend WithEvents RING_ID As DataGridViewTextBoxColumn
    Friend WithEvents btn_Add As Button
    Friend WithEvents Button1 As Button
End Class
