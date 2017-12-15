Public Class report
    Dim con As New ADODB.Connection
    Dim cmd As New ADODB.Recordset
    Dim cmd2 As New ADODB.Recordset

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        TextBox1.Text = ""
        DataGridView1.Rows.Clear()
        cmd.Open("select * from report where r_date = '" & DateTimePicker1.Text & "'", con, ADODB.CursorTypeEnum.adOpenDynamic, ADODB.LockTypeEnum.adLockOptimistic)
        While Not cmd.EOF
            DataGridView1.Rows.Add(cmd.Fields("r_date").Value, cmd.Fields("r_item").Value, cmd.Fields("r_quantity").Value, cmd.Fields("r_total").Value, cmd.Fields("r_tabno").Value)
            cmd.MoveNext()
        End While
        cmd.Close()
        Dim y, w As New Integer
        w = 0
        For y = 0 To DataGridView1.RowCount - 1
            w = w + DataGridView1.Item("Column4", DataGridView1.Rows.Item(y).Index).Value
        Next y
        TextBox1.Text = w

    End Sub

    Private Sub report_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        TextBox1.Enabled = False
        con.Open("dsn=abc")
    End Sub
    Dim s As String
    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        DataGridView1.Rows.Clear()
        TextBox1.Text = ""
        cmd2.Open("select f_name from food_details", con, ADODB.CursorTypeEnum.adOpenDynamic, ADODB.LockTypeEnum.adLockOptimistic)
        While Not cmd2.EOF
            Dim a As New Integer
            Dim b As New Integer
            a = 0
            b = 0
            s = cmd2.Fields("f_name").Value

            cmd.Open("select * from report where r_item = '" & s & "' and r_date='" & DateTimePicker1.Text & "'", con, ADODB.CursorTypeEnum.adOpenDynamic, ADODB.LockTypeEnum.adLockOptimistic)
            While Not cmd.EOF
                a = a + cmd.Fields("r_quantity").Value
                b = b + cmd.Fields("r_total").Value
                cmd.MoveNext()
            End While
            DataGridView1.Rows.Add(DateTimePicker1.Text, s, a, b)
            cmd.Close()
            cmd2.MoveNext()
        End While
        cmd2.Close()

        Dim y, w As New Integer
        w = 0
        For y = 0 To DataGridView1.RowCount - 1
            w = w + DataGridView1.Item("Column4", DataGridView1.Rows.Item(y).Index).Value
        Next y
        TextBox1.Text = w

    End Sub
    Private Sub report_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        Me.Enabled = False
        main.Enabled = True
    End Sub

    Private Sub DateTimePicker1_PreviewKeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.PreviewKeyDownEventArgs) Handles DateTimePicker1.PreviewKeyDown
        If e.KeyCode = Keys.Enter Then
            DataGridView1.Rows.Clear()
            cmd.Open("select * from report where r_date = '" & DateTimePicker1.Text & "'", con, ADODB.CursorTypeEnum.adOpenDynamic, ADODB.LockTypeEnum.adLockOptimistic)
            While Not cmd.EOF
                DataGridView1.Rows.Add(cmd.Fields("r_date").Value, cmd.Fields("r_item").Value, cmd.Fields("r_quantity").Value, cmd.Fields("r_total").Value, cmd.Fields("r_tabno").Value)

                cmd.MoveNext()
            End While
            cmd.Close()
        End If
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        MsgBox("Are you sure to delete all data from report ?", MsgBoxStyle.YesNo, Nothing)
        If MsgBoxResult.Yes Then
            con.Execute("delete * from report")
            MsgBox("Deleted successfully.")
        End If
    End Sub
End Class