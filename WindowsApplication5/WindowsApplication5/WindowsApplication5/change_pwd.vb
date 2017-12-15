Public Class change_pwd
    Dim con As New ADODB.Connection
    Dim cmd As New ADODB.Recordset
    Dim cmd2 As New ADODB.Recordset
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        TextBox1.Text = ""
        cmd.Open("select * from  other", con, ADODB.CursorTypeEnum.adOpenDynamic, ADODB.LockTypeEnum.adLockOptimistic)
        If Not TextBox2.Text = TextBox3.Text Then
            MsgBox("Password mismatch.")
        End If
        If TextBox2.Text = TextBox3.Text Then
            cmd.Fields("othr").Value = StrReverse(TextBox3.Text)
            MsgBox("Password changed successfully.")
            Me.Close()
        End If
        cmd.Update()
        cmd.Close()
        TextBox1.Text = ""
        TextBox2.Text = ""
        TextBox3.Text = ""
    End Sub

    Private Sub change_pwd_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        con.Open("dsn=abc")
    End Sub

    Private Sub TextBox3_PreviewKeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.PreviewKeyDownEventArgs) Handles TextBox3.PreviewKeyDown
        If e.KeyCode = Keys.Enter Then
            TextBox1.Text = ""
            cmd.Open("select * from  other", con, ADODB.CursorTypeEnum.adOpenDynamic, ADODB.LockTypeEnum.adLockOptimistic)
            If Not TextBox2.Text = TextBox3.Text Then
                MsgBox("Password mismatch.")
                cmd.Close()
            End If
            If TextBox2.Text = TextBox3.Text Then
                cmd.Fields("othr").Value = StrReverse(TextBox3.Text)
                MsgBox("Password changed successfully.")
                Me.Close()
            End If
            cmd.Update()
            cmd.Close()
            TextBox1.Text = ""
            TextBox2.Text = ""
            TextBox3.Text = ""
        End If
    End Sub
    Private Sub TextBox2_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles TextBox2.GotFocus
        cmd2.Open("select * from  other", con, ADODB.CursorTypeEnum.adOpenDynamic, ADODB.LockTypeEnum.adLockOptimistic)
        If Not cmd2.Fields("othr").Value = StrReverse(TextBox1.Text) Then
            MsgBox("Please enter valid password.")
        End If
        cmd2.Close()
    End Sub

    Private Sub change_pwd_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        Me.Enabled = False
        main.Enabled = True
    End Sub

End Class