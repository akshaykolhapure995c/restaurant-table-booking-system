Public Class food_details
    Dim con As New ADODB.Connection
    Dim cmd As New ADODB.Recordset
    'Dim cmd2 As New ADODB.Recordset
    Private Sub food_details_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        con.Open("dsn=abc")
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        TextBox1.Focus()
        cmd.Open("select * from waiter_details where f_name = '" & TextBox1.Text & "', con, ADODB.CursorTypeEnum.adOpenDynamic, ADODB.LockTypeEnum.adLockOptimistic")
        If Not cmd.EOF Then
            MsgBox("not")
        End If
        'cmd2.Open("select * from waiter_details", con, ADODB.CursorTypeEnum.adOpenDynamic, ADODB.LockTypeEnum.adLockOptimistic)

        cmd.AddNew()
        cmd.Fields("f_name").Value = TextBox1.Text
        cmd.Fields("f_rate").Value = TextBox2.Text
        MsgBox("added")
        cmd.Update()
        TextBox1.Text = ""
        TextBox2.Text = ""
        cmd.Close()
    End Sub
End Class