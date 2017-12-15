Public Class login
    Dim con As New ADODB.Connection
    Dim cmd As New ADODB.Recordset

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        cmd.Open("select othr from other where user_id='" & TextBox2.Text & "'", con, ADODB.CursorTypeEnum.adOpenDynamic, ADODB.LockTypeEnum.adLockOptimistic)
        If TextBox2.Text = "Admin" Then
            If (TextBox1.Text = StrReverse(cmd.Fields("othr").Value)) Then
                main.Show()
                sales.Label9.Text = Me.TextBox2.Text + " is Logged in. "
                Me.Close()
            Else
                MsgBox("Please enter valid password or user id.", MsgBoxStyle.Critical, Nothing)
            End If
            cmd.Close()
        Else
            If (TextBox1.Text = StrReverse(cmd.Fields("othr").Value)) Then
                sales.Show()
                sales.Label9.Text = Me.TextBox2.Text + " is Logged in. "
                Me.Close()
            Else
                MsgBox("Please enter valid password or user id.", MsgBoxStyle.Critical, Nothing)
            End If
            cmd.Close()
        End If
    End Sub

    Private Sub login_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        con.Open("dsn=abc")
    End Sub

    Private Sub TextBox1_PreviewKeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.PreviewKeyDownEventArgs) Handles TextBox1.PreviewKeyDown
        If e.KeyCode = Keys.Enter Then
            cmd.Open("select othr from other where user_id='" & TextBox2.Text & "'", con, ADODB.CursorTypeEnum.adOpenDynamic, ADODB.LockTypeEnum.adLockOptimistic)
            If TextBox2.Text = "Admin" Then
                If (TextBox1.Text = StrReverse(cmd.Fields("othr").Value)) Then
                    main.Show()
                    sales.Label9.Text = Me.TextBox2.Text + " is Logged in. "
                    Me.Close()
                    cmd.Close()
                Else
                    MsgBox("Please enter valid password or user id.", MsgBoxStyle.Critical, Nothing)
                    cmd.Close()
                End If
            Else
                If (TextBox1.Text = StrReverse(cmd.Fields("othr").Value)) Then
                    sales.Show()
                    sales.Label9.Text = Me.TextBox2.Text + " is Logged in. "
                    Me.Close()
                    cmd.Close()
                Else
                    MsgBox("Please enter valid password or user id.", MsgBoxStyle.Critical, Nothing)
                    cmd.Close()
                End If
            End If
        End If
    End Sub
End Class