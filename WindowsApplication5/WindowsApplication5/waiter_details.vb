Public Class waiter_details

    Dim con As New ADODB.Connection
    Dim cmd As New ADODB.Recordset
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If IsNumeric(TextBox1.Text) And TextBox1.Text = "" And TextBox2.Text = "" And TextBox3.Text = "" And TextBox4.Text = "" Then
            MsgBox("Invalid input . ", MsgBoxStyle.Critical, Nothing)
            TextBox1.Focus()
        Else
            cmd.Open("select * from waiter_details", con, ADODB.CursorTypeEnum.adOpenDynamic, ADODB.LockTypeEnum.adLockOptimistic)
            cmd.AddNew()
            cmd.Fields("name").Value = TextBox1.Text
            cmd.Fields("contact").Value = TextBox3.Text
            cmd.Fields("dob").Value = TextBox2.Text
            cmd.Fields("address").Value = TextBox4.Text
            MsgBox("added")
            cmd.Update()
            TextBox1.Text = ""
            TextBox2.Text = ""
            TextBox3.Text = ""
            TextBox4.Text = ""
            cmd.Close()
        End If
    End Sub

    Private Sub waiter_details_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        con.Open("dsn=abc")

    End Sub
End Class