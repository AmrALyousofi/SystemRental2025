Imports System.Data.OracleClient

Public Class frm_students_Add

#Region "Variables"
    Private dt_ As New DataTable
    Private WithEvents cm_ As CurrencyManager


#End Region

#Region "Functions"
    Private Sub lode_date()
        Try
            Dim sql As Object = New String("select * from student t")
            Dim da_ As OracleDataAdapter
            da_ = New OracleDataAdapter(sql, Conn)
            da_.Fill(Me.dt_)
            Me.dgv_stu.DataSource = Me.dt_

            Me.dgv_stu.Columns("STU_NO").Visible = False
            Me.dgv_stu.Columns("ADRESS").Visible = False
            Me.dgv_stu.Columns("PHON").Visible = False
        Catch ex As Exception

        End Try
    End Sub
    Private Sub JoinFields_()
        Try
            Me.txt_stu_no.DataBindings.Add("Text", Me.dt_, "STU_NO")
            Me.txt_name.DataBindings.Add("Text", Me.dt_, "STU_NAME")
            Me.txt_adress.DataBindings.Add("Text", Me.dt_, "ADRESS")
            Me.txt_phone.DataBindings.Add("Text", Me.dt_, "PHON")
            Me.comb_stu_ring.DataBindings.Add("Text", Me.dt_, "RING_ID")
            Me.comb_stu_div.DataBindings.Add("Text", Me.dt_, "DIV_STU_")

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

#End Region
#Region "Events"
    Private Sub frm_students_Add_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            Me.Panel1.Parent = Me
            Me.Panel1.BackColor = Color.Transparent
            If Not Conn.State = ConnectionState.Open Then
                Conn.Open()
            End If
            lode_date()
            JoinFields_()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub Label6_Click(sender As Object, e As EventArgs) Handles Label6.Click

    End Sub

    Private Sub comb_stu_ring_SelectedIndexChanged(sender As Object, e As EventArgs) Handles comb_stu_ring.SelectedIndexChanged

    End Sub

    Private Sub txt_search_TextChanged(sender As Object, e As EventArgs) Handles txt_search.TextChanged
        Try
            Me.dt_.DefaultView.RowFilter = " STU_NAME  like '%" & Me.txt_search.Text.Trim & "%'"
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub txt_stu_no_TextChanged(sender As Object, e As EventArgs) Handles txt_stu_no.TextChanged

    End Sub

    Private Sub btn_Add_Click(sender As Object, e As EventArgs) Handles btn_Add.Click
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
    End Sub
#End Region


End Class