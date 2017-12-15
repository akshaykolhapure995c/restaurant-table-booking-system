Public Class bill1
    Dim con As New ADODB.Connection
    Dim cmd As New ADODB.Recordset
    Dim cmd2 As New ADODB.Recordset
    Private Sub DataGridView1_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        If (DataGridView1.Item("Column2", DataGridView1.CurrentRow.Index).Selected) Then
            showbill.Enabled = True
            showbill.Show()
            cmd.Open("select * from report where r_bill = '" & Me.DataGridView1.Item("Column1", Me.DataGridView1.CurrentRow.Index).Value & "' and r_date='" & DateTimePicker1.Text & "'", con, ADODB.CursorTypeEnum.adOpenDynamic, ADODB.LockTypeEnum.adLockOptimistic)
            Dim i As Integer
            i = 1
            If Not cmd.EOF Then
                While Not cmd.EOF
                    showbill.Label4.Text = cmd.Fields("r_tabno").Value
                    showbill.Label2.Text = cmd.Fields("r_bill").Value
                    showbill.DataGridView1.Rows.Add(i, cmd.Fields("r_item").Value, cmd.Fields("r_quantity").Value, cmd.Fields("r_total").Value)
                    cmd.MoveNext()
                    i = i + 1

                End While
            Else
                MsgBox("Bill is not present on this date , Try another . ", MsgBoxStyle.Critical, Nothing)
            End If
            cmd.Close()
        End If
    End Sub

    Private Sub bill1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        con.Open("dsn=abc")
        DateTimePicker1.Format=DateTimePickerFormat.Short 
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        DataGridView1.Rows.Clear()
        If DateTimePicker1.Text = Date.Today Then
            cmd.Open("select bill from bill_number where std='" & DateTimePicker1.Text & "'", con, ADODB.CursorTypeEnum.adOpenDynamic, ADODB.LockTypeEnum.adLockOptimistic)
            Dim b As Integer
            b = cmd.Fields("bill").Value
            For i = 1 To b
                cmd2.Open("select r_total from report where r_date='" & DateTimePicker1.Text & "' and r_bill='" & i & "'", con, ADODB.CursorTypeEnum.adOpenDynamic, ADODB.LockTypeEnum.adLockOptimistic)
                Dim w As New Integer
                w = 0
                cmd.MoveFirst()
                If Not cmd2.EOF Then
                    While Not cmd2.EOF
                        w = w + cmd2.Fields("r_total").Value
                        cmd2.MoveNext()
                    End While
                End If
                cmd2.Close()
                DataGridView1.Rows.Add(i, w)
            Next i
            cmd.Close()
        Else

            cmd.Open("select bill from bill_no where std='" & DateTimePicker1.Text & "'", con, ADODB.CursorTypeEnum.adOpenDynamic, ADODB.LockTypeEnum.adLockOptimistic)

            DataGridView1.Rows.Clear()
            Dim a As Integer
            a = cmd.Fields("bill").Value
            For i = 1 To a
                cmd2.Open("select r_total from report where r_date='" & DateTimePicker1.Text & "' and r_bill='" & i & "'", con, ADODB.CursorTypeEnum.adOpenDynamic, ADODB.LockTypeEnum.adLockOptimistic)
                Dim w As New Integer
                w = 0
                'cmd2.MoveFirst()
                If Not cmd2.EOF Then
                    While Not cmd2.EOF
                        w = w + cmd2.Fields("r_total").Value
                        cmd2.MoveNext()
                    End While
                End If

                cmd2.Close()
                DataGridView1.Rows.Add(i, w)
            Next i
            cmd.Close()
        End If
    End Sub
End Class