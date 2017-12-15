Public Class login
    Dim con As New ADODB.Connection
    Dim cmd As New ADODB.Recordset

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        cmd.Open("select * from other", con, ADODB.CursorTypeEnum.adOpenDynamic, ADODB.LockTypeEnum.adLockOptimistic)
        TextBox1.Focus()
        If (TextBox1.Text = StrReverse(cmd.Fields("othr").Value)) Then
            main.Show()
            Me.Close()
        Else
            MsgBox("Please enter valid password", MsgBoxStyle.Critical, Nothing)
        End If
        cmd.Close()
    End Sub

    Private Sub login_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        con.Open("dsn=abc")
    End Sub

   End Class