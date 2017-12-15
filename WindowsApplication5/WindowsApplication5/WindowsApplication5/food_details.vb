Public Class food_details
    Dim con As New ADODB.Connection
    Dim cmd As New ADODB.Recordset
    'Dim cmd2 As New ADODB.Recordset
    Private Sub food_details_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Label4.Visible = False
        con.Open("dsn=abc")
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        TextBox1.Focus()
        cmd.Open("select * from food_details ", con, ADODB.CursorTypeEnum.adOpenDynamic, ADODB.LockTypeEnum.adLockOptimistic)
        '  where f_srn = '" & TextBox1.Text & "
        'While Not cmd.EOF
        'If cmd.Fields("f_srn").Value = TextBox1.Text Then
        'MsgBox("Already exist.")
        'End If
        'cmd.MoveNext()
        'End While
        cmd.AddNew()
        cmd.Fields("f_srn").Value = TextBox1.Text
        cmd.Fields("f_name").Value = TextBox3.Text
        cmd.Fields("f_rate").Value = TextBox2.Text
        MsgBox("Added successfully.")
        cmd.Update()
        TextBox1.Text = ""
        TextBox2.Text = ""
        cmd.Close()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Label4.Visible = True
        cmd.Open("select * from food_details where f_srn= '" & TextBox1.Text & "'", con, ADODB.CursorTypeEnum.adOpenDynamic, ADODB.LockTypeEnum.adLockOptimistic)
        TextBox1.Text = cmd.Fields("f_srn").Value
        TextBox3.Text = cmd.Fields("f_name").Value
        TextBox2.Text = cmd.Fields("f_rate").Value
        cmd.Close()
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        cmd.Open("select * from food_details where f_srn= '" & TextBox1.Text & "'", con, ADODB.CursorTypeEnum.adOpenDynamic, ADODB.LockTypeEnum.adLockOptimistic)
        cmd.Fields("f_rate").Value = TextBox2.Text
        MsgBox("Edited successfully.")
        TextBox1.Text = ""
        TextBox2.Text = ""
        TextBox3.Text = ""
        Label4.Visible = False
        cmd.Update()
        cmd.Close()
    End Sub
    Private Sub food_details_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        Me.Enabled = False
        main.Enabled = True
    End Sub
End Class