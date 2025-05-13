Imports System.Data.OracleClient
Module Module_Controls

    Public Database As String = "mis"
    Public ConStr As String = String.Format("data source={0};User Id=ammmr;password=7796", Database)
    Public Conn As New OracleConnection(ConStr)

    Sub main()
        Try
            MsgBox(Conn.State)
            If Not Conn.State = ConnectionState.Open Then
                Conn.Open()
            End If
            Dim frm_login As New frm_Login
            frm_login.Show()
            Application.EnableVisualStyles()
            Application.Run()
        Catch ex As Exception
            MsgBox("هناك خطاء في عملية الوصول لقاعدة البيانات /تواصل مع الدعم الفني          
                                                            بالإتصال على الرقم 779617470")
            'MessageBox.Show("هناك خطاء في عملية الوصول لقاعدة البيانات", "محمد", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxDefaultButton.Button2)

        End Try

    End Sub
End Module
