<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_Feather
    Inherits System.Windows.Forms.Form

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
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.btn_new = New System.Windows.Forms.ToolStripButton()
        Me.btn_save = New System.Windows.Forms.ToolStripButton()
        Me.btn_edite = New System.Windows.Forms.ToolStripButton()
        Me.btn_delete = New System.Windows.Forms.ToolStripButton()
        Me.btn_cancel = New System.Windows.Forms.ToolStripButton()
        Me.btn_search = New System.Windows.Forms.ToolStripButton()
        Me.btn_print = New System.Windows.Forms.ToolStripButton()
        Me.btn_close = New System.Windows.Forms.ToolStripButton()
        Me.btn_laste = New System.Windows.Forms.ToolStripButton()
        Me.btn_nexte = New System.Windows.Forms.ToolStripButton()
        Me.btn_privious = New System.Windows.Forms.ToolStripButton()
        Me.btn_frist = New System.Windows.Forms.ToolStripButton()
        Me.txt_show = New System.Windows.Forms.ToolStripTextBox()
        Me.ToolStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'ToolStrip1
        '
        Me.ToolStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btn_new, Me.btn_save, Me.btn_edite, Me.btn_delete, Me.btn_cancel, Me.btn_search, Me.btn_print, Me.btn_close, Me.btn_laste, Me.btn_nexte, Me.txt_show, Me.btn_privious, Me.btn_frist})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(1206, 67)
        Me.ToolStrip1.TabIndex = 0
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'btn_new
        '
        Me.btn_new.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btn_new.Image = Global.School_System.My.Resources.Resources.addcomop
        Me.btn_new.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.btn_new.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btn_new.Name = "btn_new"
        Me.btn_new.Size = New System.Drawing.Size(52, 64)
        Me.btn_new.Text = "جديد"
        '
        'btn_save
        '
        Me.btn_save.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btn_save.Image = Global.School_System.My.Resources.Resources.ham_ph_btn_save
        Me.btn_save.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.btn_save.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btn_save.Name = "btn_save"
        Me.btn_save.Size = New System.Drawing.Size(64, 64)
        Me.btn_save.Text = "حفظ"
        '
        'btn_edite
        '
        Me.btn_edite.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btn_edite.Image = Global.School_System.My.Resources.Resources.ham_ph_btn_edit
        Me.btn_edite.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.btn_edite.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btn_edite.Name = "btn_edite"
        Me.btn_edite.Size = New System.Drawing.Size(64, 64)
        Me.btn_edite.Text = "تعديل"
        '
        'btn_delete
        '
        Me.btn_delete.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btn_delete.Image = Global.School_System.My.Resources.Resources.ham_ph_btn_del1
        Me.btn_delete.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.btn_delete.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btn_delete.Name = "btn_delete"
        Me.btn_delete.Size = New System.Drawing.Size(64, 64)
        Me.btn_delete.Text = "حذف"
        '
        'btn_cancel
        '
        Me.btn_cancel.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btn_cancel.Image = Global.School_System.My.Resources.Resources.ham_ph_btn_Cancel1
        Me.btn_cancel.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.btn_cancel.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btn_cancel.Name = "btn_cancel"
        Me.btn_cancel.Size = New System.Drawing.Size(64, 64)
        Me.btn_cancel.Text = "تراجع"
        '
        'btn_search
        '
        Me.btn_search.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btn_search.Image = Global.School_System.My.Resources.Resources.Zoom_32x32
        Me.btn_search.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.btn_search.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btn_search.Name = "btn_search"
        Me.btn_search.Size = New System.Drawing.Size(36, 64)
        Me.btn_search.Text = "بحث"
        '
        'btn_print
        '
        Me.btn_print.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btn_print.Image = Global.School_System.My.Resources.Resources.App_printer_icon
        Me.btn_print.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.btn_print.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btn_print.Name = "btn_print"
        Me.btn_print.Size = New System.Drawing.Size(52, 64)
        Me.btn_print.Text = "طباعة"
        '
        'btn_close
        '
        Me.btn_close.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btn_close.Image = Global.School_System.My.Resources.Resources.Log_Out_icon1
        Me.btn_close.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.btn_close.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btn_close.Name = "btn_close"
        Me.btn_close.Size = New System.Drawing.Size(52, 64)
        Me.btn_close.Text = "خروج"
        '
        'btn_laste
        '
        Me.btn_laste.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.btn_laste.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btn_laste.Image = Global.School_System.My.Resources.Resources.Actions_go_first_view_icon
        Me.btn_laste.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btn_laste.Name = "btn_laste"
        Me.btn_laste.Size = New System.Drawing.Size(24, 64)
        Me.btn_laste.Text = "السجل الأخير"
        '
        'btn_nexte
        '
        Me.btn_nexte.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.btn_nexte.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btn_nexte.Image = Global.School_System.My.Resources.Resources.Actions_go_previous_icon
        Me.btn_nexte.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btn_nexte.Name = "btn_nexte"
        Me.btn_nexte.Size = New System.Drawing.Size(24, 64)
        Me.btn_nexte.Text = "السجل التالي"
        '
        'btn_privious
        '
        Me.btn_privious.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.btn_privious.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btn_privious.Image = Global.School_System.My.Resources.Resources.Actions_go_next_icon
        Me.btn_privious.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btn_privious.Name = "btn_privious"
        Me.btn_privious.Size = New System.Drawing.Size(24, 64)
        Me.btn_privious.Text = "السجل السابق"
        '
        'btn_frist
        '
        Me.btn_frist.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.btn_frist.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btn_frist.Image = Global.School_System.My.Resources.Resources.Actions_go_last_view_icon
        Me.btn_frist.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btn_frist.Name = "btn_frist"
        Me.btn_frist.Size = New System.Drawing.Size(24, 64)
        Me.btn_frist.Text = "السجل الول"
        '
        'txt_show
        '
        Me.txt_show.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.txt_show.Name = "txt_show"
        Me.txt_show.ReadOnly = True
        Me.txt_show.Size = New System.Drawing.Size(90, 67)
        Me.txt_show.TextBoxTextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'frm_Feather
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 32.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.School_System.My.Resources.Resources.gggg
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1206, 572)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Font = New System.Drawing.Font("Akhbar MT", 12.0!)
        Me.Margin = New System.Windows.Forms.Padding(6, 7, 6, 7)
        Me.Name = "frm_Feather"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ToolStrip1 As ToolStrip
    Friend WithEvents btn_new As ToolStripButton
    Friend WithEvents btn_save As ToolStripButton
    Friend WithEvents btn_edite As ToolStripButton
    Friend WithEvents btn_delete As ToolStripButton
    Friend WithEvents btn_cancel As ToolStripButton
    Friend WithEvents btn_print As ToolStripButton
    Friend WithEvents btn_close As ToolStripButton
    Friend WithEvents btn_search As ToolStripButton
    Friend WithEvents btn_laste As ToolStripButton
    Friend WithEvents btn_nexte As ToolStripButton
    Friend WithEvents btn_privious As ToolStripButton
    Friend WithEvents btn_frist As ToolStripButton
    Friend WithEvents txt_show As ToolStripTextBox
End Class
