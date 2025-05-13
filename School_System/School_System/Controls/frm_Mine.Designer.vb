<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_Mine
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
        Me.components = New System.ComponentModel.Container()
        Me.StatusStrip = New System.Windows.Forms.StatusStrip()
        Me.ToolStripStatusLabel1 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusLabel2 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolTip = New System.Windows.Forms.ToolTip(Me.components)
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.MenuStrip2 = New System.Windows.Forms.MenuStrip()
        Me.حفظالطلابToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.غياباتالطلابToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Time_new = New AnalogClock.AnalogClock()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.النظاموالتهيئةToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.ظبطالنظامToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.المستخدمينToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.صلاحيةالمستخدمينToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator5 = New System.Windows.Forms.ToolStripSeparator()
        Me.النسخالإحتياطيToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator4 = New System.Windows.Forms.ToolStripSeparator()
        Me.خروجToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.بياناتالطلابToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.إظافةطالبToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.الحلقاتToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.الشعبToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.حفظالطلابToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.بياناتالموظفينToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.الغياباتToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.الإختباراتToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.أنشطةالمركزToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.الداعمينToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.تقاريرالنظامToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.خروجToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.StatusStrip.SuspendLayout()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        Me.MenuStrip2.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'StatusStrip
        '
        Me.StatusStrip.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.StatusStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripStatusLabel1, Me.ToolStripStatusLabel2})
        Me.StatusStrip.Location = New System.Drawing.Point(0, 526)
        Me.StatusStrip.Name = "StatusStrip"
        Me.StatusStrip.Padding = New System.Windows.Forms.Padding(1, 0, 14, 0)
        Me.StatusStrip.Size = New System.Drawing.Size(1174, 22)
        Me.StatusStrip.TabIndex = 7
        Me.StatusStrip.Text = "StatusStrip"
        '
        'ToolStripStatusLabel1
        '
        Me.ToolStripStatusLabel1.Name = "ToolStripStatusLabel1"
        Me.ToolStripStatusLabel1.Size = New System.Drawing.Size(86, 17)
        Me.ToolStripStatusLabel1.Text = "المستخدمالحالي"
        '
        'ToolStripStatusLabel2
        '
        Me.ToolStripStatusLabel2.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.ToolStripStatusLabel2.ForeColor = System.Drawing.Color.Red
        Me.ToolStripStatusLabel2.Name = "ToolStripStatusLabel2"
        Me.ToolStripStatusLabel2.Size = New System.Drawing.Size(278, 17)
        Me.ToolStripStatusLabel2.Text = "حقوق النظام محفوضة لدى المبرمج عمرو اليوسفي2023"
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer1.Location = New System.Drawing.Point(0, 68)
        Me.SplitContainer1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.SplitContainer1.Name = "SplitContainer1"
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.MenuStrip2)
        Me.SplitContainer1.Panel1.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.BackgroundImage = Global.School_System.My.Resources.Resources.gggg
        Me.SplitContainer1.Panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.SplitContainer1.Panel2.Controls.Add(Me.Time_new)
        Me.SplitContainer1.Panel2.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.SplitContainer1.Size = New System.Drawing.Size(1174, 458)
        Me.SplitContainer1.SplitterDistance = 159
        Me.SplitContainer1.SplitterWidth = 3
        Me.SplitContainer1.TabIndex = 10
        '
        'MenuStrip2
        '
        Me.MenuStrip2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.MenuStrip2.Font = New System.Drawing.Font("PT Bold Dusky", 12.0!)
        Me.MenuStrip2.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip2.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.حفظالطلابToolStripMenuItem1, Me.غياباتالطلابToolStripMenuItem})
        Me.MenuStrip2.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.VerticalStackWithOverflow
        Me.MenuStrip2.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip2.Name = "MenuStrip2"
        Me.MenuStrip2.Padding = New System.Windows.Forms.Padding(5, 2, 0, 2)
        Me.MenuStrip2.Size = New System.Drawing.Size(159, 458)
        Me.MenuStrip2.TabIndex = 0
        Me.MenuStrip2.Text = "MenuStrip2"
        '
        'حفظالطلابToolStripMenuItem1
        '
        Me.حفظالطلابToolStripMenuItem1.Name = "حفظالطلابToolStripMenuItem1"
        Me.حفظالطلابToolStripMenuItem1.Size = New System.Drawing.Size(153, 33)
        Me.حفظالطلابToolStripMenuItem1.Text = "حفظ الطلاب"
        '
        'غياباتالطلابToolStripMenuItem
        '
        Me.غياباتالطلابToolStripMenuItem.Name = "غياباتالطلابToolStripMenuItem"
        Me.غياباتالطلابToolStripMenuItem.Size = New System.Drawing.Size(153, 33)
        Me.غياباتالطلابToolStripMenuItem.Text = "غيابات الطلاب"
        '
        'Time_new
        '
        Me.Time_new.BackgroundImage = Global.School_System.My.Resources.Resources.gggg
        Me.Time_new.Dock = System.Windows.Forms.DockStyle.Top
        Me.Time_new.DrawHourHand = True
        Me.Time_new.DrawHourHandShadow = True
        Me.Time_new.DrawMinuteHand = True
        Me.Time_new.DrawMinuteHandShadow = True
        Me.Time_new.DrawSecondHand = True
        Me.Time_new.DropShadowColor = System.Drawing.Color.Black
        Me.Time_new.DropShadowOffset = New System.Drawing.Point(0, 0)
        Me.Time_new.FaceColorHigh = System.Drawing.Color.RoyalBlue
        Me.Time_new.FaceColorLow = System.Drawing.Color.SkyBlue
        Me.Time_new.FaceGradientMode = System.Drawing.Drawing2D.LinearGradientMode.BackwardDiagonal
        Me.Time_new.FaceImage = Nothing
        Me.Time_new.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Time_new.HourHandColor = System.Drawing.Color.Gainsboro
        Me.Time_new.HourHandDropShadowColor = System.Drawing.Color.Gray
        Me.Time_new.Location = New System.Drawing.Point(0, 0)
        Me.Time_new.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Time_new.MinuteHandColor = System.Drawing.Color.WhiteSmoke
        Me.Time_new.MinuteHandDropShadowColor = System.Drawing.Color.Gray
        Me.Time_new.MinuteHandTickStyle = AnalogClock.TickStyle.Normal
        Me.Time_new.Name = "Time_new"
        Me.Time_new.NumeralColor = System.Drawing.Color.WhiteSmoke
        Me.Time_new.RimColorHigh = System.Drawing.Color.RoyalBlue
        Me.Time_new.RimColorLow = System.Drawing.Color.SkyBlue
        Me.Time_new.RimGradientMode = System.Drawing.Drawing2D.LinearGradientMode.ForwardDiagonal
        Me.Time_new.SecondHandColor = System.Drawing.Color.Tomato
        Me.Time_new.SecondHandDropShadowColor = System.Drawing.Color.Gray
        Me.Time_new.SecondHandEndCap = System.Drawing.Drawing2D.LineCap.Round
        Me.Time_new.SecondHandTickStyle = AnalogClock.TickStyle.Normal
        Me.Time_new.Size = New System.Drawing.Size(182, 182)
        Me.Time_new.TabIndex = 0
        Me.Time_new.Time = New Date(CType(0, Long))
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 1000
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackgroundImage = Global.School_System.My.Resources.Resources.menus
        Me.MenuStrip1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.MenuStrip1.Font = New System.Drawing.Font("PT Bold Dusky", 14.0!)
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.النظاموالتهيئةToolStripMenuItem, Me.بياناتالطلابToolStripMenuItem, Me.بياناتالموظفينToolStripMenuItem, Me.الغياباتToolStripMenuItem, Me.الإختباراتToolStripMenuItem, Me.أنشطةالمركزToolStripMenuItem, Me.الداعمينToolStripMenuItem, Me.تقاريرالنظامToolStripMenuItem, Me.خروجToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Padding = New System.Windows.Forms.Padding(5, 2, 0, 2)
        Me.MenuStrip1.Size = New System.Drawing.Size(1174, 68)
        Me.MenuStrip1.TabIndex = 9
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'النظاموالتهيئةToolStripMenuItem
        '
        Me.النظاموالتهيئةToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripSeparator1, Me.ظبطالنظامToolStripMenuItem, Me.ToolStripSeparator2, Me.المستخدمينToolStripMenuItem, Me.ToolStripSeparator3, Me.صلاحيةالمستخدمينToolStripMenuItem, Me.ToolStripSeparator5, Me.النسخالإحتياطيToolStripMenuItem, Me.ToolStripSeparator4, Me.خروجToolStripMenuItem1})
        Me.النظاموالتهيئةToolStripMenuItem.Font = New System.Drawing.Font("PT Bold Dusky", 12.0!)
        Me.النظاموالتهيئةToolStripMenuItem.Image = Global.School_System.My.Resources.Resources._1133445
        Me.النظاموالتهيئةToolStripMenuItem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.النظاموالتهيئةToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.النظاموالتهيئةToolStripMenuItem.Name = "النظاموالتهيئةToolStripMenuItem"
        Me.النظاموالتهيئةToolStripMenuItem.Size = New System.Drawing.Size(173, 64)
        Me.النظاموالتهيئةToolStripMenuItem.Text = "النظام والتهيئة"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(219, 6)
        '
        'ظبطالنظامToolStripMenuItem
        '
        Me.ظبطالنظامToolStripMenuItem.Image = Global.School_System.My.Resources.Resources.Technology_32x32
        Me.ظبطالنظامToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.ظبطالنظامToolStripMenuItem.Name = "ظبطالنظامToolStripMenuItem"
        Me.ظبطالنظامToolStripMenuItem.Size = New System.Drawing.Size(222, 38)
        Me.ظبطالنظامToolStripMenuItem.Text = "ظبط النظام"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(219, 6)
        '
        'المستخدمينToolStripMenuItem
        '
        Me.المستخدمينToolStripMenuItem.Image = Global.School_System.My.Resources.Resources.UserGroup_32x32
        Me.المستخدمينToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.المستخدمينToolStripMenuItem.Name = "المستخدمينToolStripMenuItem"
        Me.المستخدمينToolStripMenuItem.Size = New System.Drawing.Size(222, 38)
        Me.المستخدمينToolStripMenuItem.Text = "المستخدمين"
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(219, 6)
        '
        'صلاحيةالمستخدمينToolStripMenuItem
        '
        Me.صلاحيةالمستخدمينToolStripMenuItem.Image = Global.School_System.My.Resources.Resources.Role_32x32
        Me.صلاحيةالمستخدمينToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.صلاحيةالمستخدمينToolStripMenuItem.Name = "صلاحيةالمستخدمينToolStripMenuItem"
        Me.صلاحيةالمستخدمينToolStripMenuItem.Size = New System.Drawing.Size(222, 38)
        Me.صلاحيةالمستخدمينToolStripMenuItem.Text = "صلاحية المستخدمين"
        '
        'ToolStripSeparator5
        '
        Me.ToolStripSeparator5.Name = "ToolStripSeparator5"
        Me.ToolStripSeparator5.Size = New System.Drawing.Size(219, 6)
        '
        'النسخالإحتياطيToolStripMenuItem
        '
        Me.النسخالإحتياطيToolStripMenuItem.Image = Global.School_System.My.Resources.Resources.Copy_32x32
        Me.النسخالإحتياطيToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.النسخالإحتياطيToolStripMenuItem.Name = "النسخالإحتياطيToolStripMenuItem"
        Me.النسخالإحتياطيToolStripMenuItem.Size = New System.Drawing.Size(222, 38)
        Me.النسخالإحتياطيToolStripMenuItem.Text = "النسخ الإحتياطي"
        '
        'ToolStripSeparator4
        '
        Me.ToolStripSeparator4.Name = "ToolStripSeparator4"
        Me.ToolStripSeparator4.Size = New System.Drawing.Size(219, 6)
        '
        'خروجToolStripMenuItem1
        '
        Me.خروجToolStripMenuItem1.Image = Global.School_System.My.Resources.Resources.Delete_32x32
        Me.خروجToolStripMenuItem1.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.خروجToolStripMenuItem1.Name = "خروجToolStripMenuItem1"
        Me.خروجToolStripMenuItem1.Size = New System.Drawing.Size(222, 38)
        Me.خروجToolStripMenuItem1.Text = "خروج"
        '
        'بياناتالطلابToolStripMenuItem
        '
        Me.بياناتالطلابToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.إظافةطالبToolStripMenuItem, Me.الحلقاتToolStripMenuItem, Me.الشعبToolStripMenuItem, Me.حفظالطلابToolStripMenuItem})
        Me.بياناتالطلابToolStripMenuItem.Image = Global.School_System.My.Resources.Resources._1666483601919
        Me.بياناتالطلابToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.بياناتالطلابToolStripMenuItem.Name = "بياناتالطلابToolStripMenuItem"
        Me.بياناتالطلابToolStripMenuItem.Size = New System.Drawing.Size(178, 64)
        Me.بياناتالطلابToolStripMenuItem.Text = "بيانات الطلاب"
        '
        'إظافةطالبToolStripMenuItem
        '
        Me.إظافةطالبToolStripMenuItem.Name = "إظافةطالبToolStripMenuItem"
        Me.إظافةطالبToolStripMenuItem.Size = New System.Drawing.Size(175, 38)
        Me.إظافةطالبToolStripMenuItem.Text = "إظافة طالب"
        '
        'الحلقاتToolStripMenuItem
        '
        Me.الحلقاتToolStripMenuItem.Name = "الحلقاتToolStripMenuItem"
        Me.الحلقاتToolStripMenuItem.Size = New System.Drawing.Size(175, 38)
        Me.الحلقاتToolStripMenuItem.Text = "الحلقات"
        '
        'الشعبToolStripMenuItem
        '
        Me.الشعبToolStripMenuItem.Name = "الشعبToolStripMenuItem"
        Me.الشعبToolStripMenuItem.Size = New System.Drawing.Size(175, 38)
        Me.الشعبToolStripMenuItem.Text = "الشعب"
        '
        'حفظالطلابToolStripMenuItem
        '
        Me.حفظالطلابToolStripMenuItem.Name = "حفظالطلابToolStripMenuItem"
        Me.حفظالطلابToolStripMenuItem.Size = New System.Drawing.Size(175, 38)
        Me.حفظالطلابToolStripMenuItem.Text = "حفظ الطلاب"
        '
        'بياناتالموظفينToolStripMenuItem
        '
        Me.بياناتالموظفينToolStripMenuItem.Image = Global.School_System.My.Resources.Resources._1666483601960
        Me.بياناتالموظفينToolStripMenuItem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.بياناتالموظفينToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.بياناتالموظفينToolStripMenuItem.Name = "بياناتالموظفينToolStripMenuItem"
        Me.بياناتالموظفينToolStripMenuItem.Size = New System.Drawing.Size(197, 64)
        Me.بياناتالموظفينToolStripMenuItem.Text = "بيانات الموظفين"
        '
        'الغياباتToolStripMenuItem
        '
        Me.الغياباتToolStripMenuItem.Image = Global.School_System.My.Resources.Resources.ham_ph_btn_edit
        Me.الغياباتToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.الغياباتToolStripMenuItem.Name = "الغياباتToolStripMenuItem"
        Me.الغياباتToolStripMenuItem.Size = New System.Drawing.Size(148, 64)
        Me.الغياباتToolStripMenuItem.Text = "الغيابات"
        '
        'الإختباراتToolStripMenuItem
        '
        Me.الإختباراتToolStripMenuItem.Image = Global.School_System.My.Resources.Resources.ham_ph_btn_add
        Me.الإختباراتToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.الإختباراتToolStripMenuItem.Name = "الإختباراتToolStripMenuItem"
        Me.الإختباراتToolStripMenuItem.Size = New System.Drawing.Size(162, 64)
        Me.الإختباراتToolStripMenuItem.Text = "الإختبارات"
        '
        'أنشطةالمركزToolStripMenuItem
        '
        Me.أنشطةالمركزToolStripMenuItem.Image = Global.School_System.My.Resources.Resources.Today_32x32
        Me.أنشطةالمركزToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.أنشطةالمركزToolStripMenuItem.Name = "أنشطةالمركزToolStripMenuItem"
        Me.أنشطةالمركزToolStripMenuItem.Size = New System.Drawing.Size(174, 64)
        Me.أنشطةالمركزToolStripMenuItem.Text = "أنشطة المركز"
        '
        'الداعمينToolStripMenuItem
        '
        Me.الداعمينToolStripMenuItem.Image = Global.School_System.My.Resources.Resources.coin
        Me.الداعمينToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.الداعمينToolStripMenuItem.Name = "الداعمينToolStripMenuItem"
        Me.الداعمينToolStripMenuItem.Size = New System.Drawing.Size(153, 64)
        Me.الداعمينToolStripMenuItem.Text = "الداعمين"
        '
        'تقاريرالنظامToolStripMenuItem
        '
        Me.تقاريرالنظامToolStripMenuItem.Image = Global.School_System.My.Resources.Resources.ListBullets_32x32
        Me.تقاريرالنظامToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.تقاريرالنظامToolStripMenuItem.Name = "تقاريرالنظامToolStripMenuItem"
        Me.تقاريرالنظامToolStripMenuItem.Size = New System.Drawing.Size(179, 64)
        Me.تقاريرالنظامToolStripMenuItem.Text = "تقارير النظام"
        '
        'خروجToolStripMenuItem
        '
        Me.خروجToolStripMenuItem.Image = Global.School_System.My.Resources.Resources.Log_Out_icon1
        Me.خروجToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.خروجToolStripMenuItem.Name = "خروجToolStripMenuItem"
        Me.خروجToolStripMenuItem.Size = New System.Drawing.Size(114, 64)
        Me.خروجToolStripMenuItem.Text = "خروج"
        '
        'frm_Mine
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1174, 548)
        Me.Controls.Add(Me.SplitContainer1)
        Me.Controls.Add(Me.StatusStrip)
        Me.Controls.Add(Me.MenuStrip1)
        Me.IsMdiContainer = True
        Me.MainMenuStrip = Me.MenuStrip2
        Me.Name = "frm_Mine"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.RightToLeftLayout = True
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "نظام إدارة مركزالبراء بن مالك لتعليم القران الكريم وعلومه"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.StatusStrip.ResumeLayout(False)
        Me.StatusStrip.PerformLayout()
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel1.PerformLayout()
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        Me.MenuStrip2.ResumeLayout(False)
        Me.MenuStrip2.PerformLayout()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ToolTip As System.Windows.Forms.ToolTip
    Friend WithEvents StatusStrip As System.Windows.Forms.StatusStrip
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents النظاموالتهيئةToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents ظبطالنظامToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator2 As ToolStripSeparator
    Friend WithEvents المستخدمينToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator3 As ToolStripSeparator
    Friend WithEvents صلاحيةالمستخدمينToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator5 As ToolStripSeparator
    Friend WithEvents النسخالإحتياطيToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator4 As ToolStripSeparator
    Friend WithEvents خروجToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents بياناتالطلابToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents إظافةطالبToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents الحلقاتToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents الشعبToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents بياناتالموظفينToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents الغياباتToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents الإختباراتToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents أنشطةالمركزToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents الداعمينToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents تقاريرالنظامToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents خروجToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SplitContainer1 As SplitContainer
    Friend WithEvents Time_new As AnalogClock.AnalogClock
    Friend WithEvents Timer1 As Timer
    Friend WithEvents ToolStripStatusLabel1 As ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabel2 As ToolStripStatusLabel
    Friend WithEvents MenuStrip2 As MenuStrip
    Friend WithEvents حفظالطلابToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents غياباتالطلابToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents حفظالطلابToolStripMenuItem As ToolStripMenuItem
End Class
