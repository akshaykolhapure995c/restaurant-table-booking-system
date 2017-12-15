Public Class bill
    Dim con As New ADODB.Connection
    Dim cmd As New ADODB.Recordset

    Private Sub bill_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        con.Open("dsn=abc")
        TextBox2.Enabled = False
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        DataGridView1.Rows.Clear()
        cmd.Open("select * from report where r_bill = '" & TextBox1.Text & "' and r_date='" & DateTimePicker1.Text & "'", con, ADODB.CursorTypeEnum.adOpenDynamic, ADODB.LockTypeEnum.adLockOptimistic)
        If Not cmd.EOF Then
            While Not cmd.EOF
                DataGridView1.Rows.Add(cmd.Fields("r_date").Value, cmd.Fields("r_item").Value, cmd.Fields("r_quantity").Value, cmd.Fields("r_total").Value, cmd.Fields("r_tabno").Value, cmd.Fields("r_bill").Value)
                cmd.MoveNext()
            End While
        Else
            MsgBox("Bill is not present on this date , Try another . ", MsgBoxStyle.Critical, Nothing)
        End If
        cmd.Close()
        Dim y, w As New Integer
        w = 0
        For y = 0 To DataGridView1.RowCount - 1
            w = w + DataGridView1.Item("Column4", DataGridView1.Rows.Item(y).Index).Value
        Next y
        TextBox2.Text = w

    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        
    End Sub

    Private Sub TextBox1_PreviewKeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.PreviewKeyDownEventArgs) Handles TextBox1.PreviewKeyDown
        If e.KeyCode = Keys.Enter Then

            DataGridView1.Rows.Clear()
            cmd.Open("select * from report where r_bill = '" & TextBox1.Text & "' and r_date='" & DateTimePicker1.Text & "'", con, ADODB.CursorTypeEnum.adOpenDynamic, ADODB.LockTypeEnum.adLockOptimistic)
            If Not cmd.EOF Then
                While Not cmd.EOF
                    DataGridView1.Rows.Add(cmd.Fields("r_date").Value, cmd.Fields("r_item").Value, cmd.Fields("r_quantity").Value, cmd.Fields("r_total").Value, cmd.Fields("r_tabno").Value, cmd.Fields("r_bill").Value)
                    cmd.MoveNext()
                End While
            Else
                MsgBox("Bill is not present on this date , Try another . ", MsgBoxStyle.Critical, Nothing)
            End If
            cmd.Close()

        End If
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        DataGridView1.Rows.Clear()
        cmd.Open("select * from report where r_tabno = '" & TextBox1.Text & "' and r_date='" & DateTimePicker1.Text & "'", con, ADODB.CursorTypeEnum.adOpenDynamic, ADODB.LockTypeEnum.adLockOptimistic)
        If Not cmd.EOF Then
            While Not cmd.EOF
                DataGridView1.Rows.Add(cmd.Fields("r_date").Value, cmd.Fields("r_item").Value, cmd.Fields("r_quantity").Value, cmd.Fields("r_total").Value, cmd.Fields("r_tabno").Value, cmd.Fields("r_bill").Value)
                cmd.MoveNext()
            End While
        Else
            MsgBox("Table Number is not present on this date , Try another . ", MsgBoxStyle.Critical, Nothing)
        End If
        cmd.Close()
        Dim y, w As New Integer
        w = 0
        For y = 0 To DataGridView1.RowCount - 1
            w = w + DataGridView1.Item("Column4", DataGridView1.Rows.Item(y).Index).Value
        Next y
        TextBox1.Text = w
    End Sub

End Class