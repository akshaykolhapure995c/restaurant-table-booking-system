Public Class sales
    Dim con As New ADODB.Connection
    Dim cmd As New ADODB.Recordset
    Dim cmd2 As New ADODB.Recordset
    Dim cmd3 As New ADODB.Recordset
    Dim i As Integer
    Dim temp As Boolean
    Dim rate, amount, x As Integer
    Private Sub sales_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        temp = False
        i = 1
        con.Open("dsn=abc")
        cmd.Open("select * from food_details", con, ADODB.CursorTypeEnum.adOpenDynamic, ADODB.LockTypeEnum.adLockOptimistic)
        cmd2.Open("select * from waiter_details", con, ADODB.CursorTypeEnum.adOpenDynamic, ADODB.LockTypeEnum.adLockOptimistic)
        While Not cmd.EOF

            ComboBox2.Items.Add(cmd.Fields("f_name").Value)
            cmd.MoveNext()
        End While
        While Not cmd2.EOF

            ComboBox1.Items.Add(cmd2.Fields("name").Value)
            cmd2.MoveNext()
        End While
        cmd2.Close()
        cmd.Close()

    End Sub
    Private Sub Button15_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button15.Click
        ' i = 0
        ' Dim j As Integer
        If temp = True Then
            ' For j = 0 To DataGridView1.RowCount
            ' DataGridView1.Rows.RemoveAt(j)
            ' Next j

            cmd.Open("select * from sales", con, ADODB.CursorTypeEnum.adOpenDynamic, ADODB.LockTypeEnum.adLockOptimistic)
            While Not cmd.EOF
                DataGridView1.Rows.Add(Val(i), cmd.Fields("f_item").Value, cmd.Fields("f_charges").Value, cmd.Fields("f_quantity").Value, cmd.Fields("f_total").Value, "E", "X")
                ComboBox1.Text = cmd.Fields("f_waiter").Value
                cmd.MoveNext()
                i = i + 1
            End While
            cmd.Close()
        End If
        Label4.Text = Button15.Text
        TextBox3.Text = Val(TextBox3.Text) + 1

    End Sub

    Private Sub Button14_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button14.Click
        cmd.Open("select * from sales_gt2", con, ADODB.CursorTypeEnum.adOpenDynamic, ADODB.LockTypeEnum.adLockOptimistic)
        ' If temp = True Then
        ' DataGridView1.Rows.Add(cmd.Fields("f_item").Value, cmd.Fields("f_charges").Value, cmd.Fields("f_quantity").Value, cmd.Fields("f_total").Value)
        'ComboBox1.Text = cmd.Fields("f_waiter").Value
        'cmd.Close()
        'End If
        cmd.Close()


        Label4.Text = Button14.Text
        TextBox3.Text = Val(TextBox3.Text) + 1
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Label4.Text = Button4.Text
        TextBox3.Text = Val(TextBox3.Text) + 1
    End Sub

    Private Sub Button13_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button13.Click
        Label4.Text = Button13.Text
        TextBox3.Text = Val(TextBox3.Text) + 1
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        Label4.Text = Button5.Text
        TextBox3.Text = Val(TextBox3.Text) + 1
    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        Label4.Text = Button6.Text
        TextBox3.Text = Val(TextBox3.Text) + 1
    End Sub

    Private Sub Button7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button7.Click
        Label4.Text = Button7.Text
        TextBox3.Text = Val(TextBox3.Text) + 1
    End Sub

    Private Sub Button8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button8.Click
        Label4.Text = Button8.Text
        TextBox3.Text = Val(TextBox3.Text) + 1
    End Sub

    Private Sub Button19_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button19.Click
        Label4.Text = Button19.Text
        TextBox3.Text = Val(TextBox3.Text) + 1
    End Sub

    Private Sub Button18_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button18.Click
        Label4.Text = Button18.Text
        TextBox3.Text = Val(TextBox3.Text) + 1
    End Sub

    Private Sub Button16_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button16.Click
        Label4.Text = Button16.Text
        TextBox3.Text = Val(TextBox3.Text) + 1
    End Sub

    Private Sub Button17_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button17.Click
        Label4.Text = Button17.Text
        TextBox3.Text = Val(TextBox3.Text) + 1
    End Sub

    Private Sub Button9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button9.Click
        Label4.Text = Button9.Text
        TextBox3.Text = Val(TextBox3.Text) + 1
    End Sub

    Private Sub Button10_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button10.Click
        Label4.Text = Button10.Text
        TextBox3.Text = Val(TextBox3.Text) + 1
    End Sub

    Private Sub Button11_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button11.Click
        Label4.Text = Button11.Text
        TextBox3.Text = Val(TextBox3.Text) + 1
    End Sub

    Private Sub Button12_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button12.Click
        Label4.Text = Button12.Text
        TextBox3.Text = Val(TextBox3.Text) + 1
    End Sub

    Private Sub Button27_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button27.Click
        Label4.Text = Button27.Text
        TextBox3.Text = Val(TextBox3.Text) + 1
    End Sub

    Private Sub Button26_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button26.Click
        Label4.Text = Button26.Text
        TextBox3.Text = Val(TextBox3.Text) + 1
    End Sub

    Private Sub Button24_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button24.Click
        Label4.Text = Button24.Text
        TextBox3.Text = Val(TextBox3.Text) + 1
    End Sub

    Private Sub Button25_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button25.Click
        Label4.Text = Button25.Text
        TextBox3.Text = Val(TextBox3.Text) + 1
    End Sub

    Private Sub Button20_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button20.Click
        Label4.Text = Button20.Text
        TextBox3.Text = Val(TextBox3.Text) + 1
    End Sub

    Private Sub Button21_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button21.Click
        Label4.Text = Button21.Text
        TextBox3.Text = Val(TextBox3.Text) + 1
    End Sub

    Private Sub Button22_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button22.Click
        Label4.Text = Button22.Text
        TextBox3.Text = Val(TextBox3.Text) + 1
    End Sub

    Private Sub Button23_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button23.Click
        Label4.Text = Button23.Text
        TextBox3.Text = Val(TextBox3.Text) + 1
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        'cmd.Close()
        temp = True

        Dim v, w As New Integer
        w = 0
        For v = 0 To DataGridView1.RowCount - 1
            'v = DataGridView1.RowCount
            w = w + DataGridView1.Item("Column5", DataGridView1.Rows.Item(v).Index).Value
        Next v
        TextBox1.Text = w

        cmd.Open("select * from sales", con, ADODB.CursorTypeEnum.adOpenDynamic, ADODB.LockTypeEnum.adLockOptimistic)
        For v = 0 To DataGridView1.RowCount - 1
            cmd.AddNew()
            cmd.Fields("f_item").Value = DataGridView1.Item("Column2", DataGridView1.Rows.Item(v).Index).Value
            cmd.Fields("f_charges").Value = DataGridView1.Item("Column3", DataGridView1.Rows.Item(v).Index).Value
            cmd.Fields("f_quantity").Value = DataGridView1.Item("Column4", DataGridView1.Rows.Item(v).Index).Value
            cmd.Fields("f_total").Value = DataGridView1.Item("Column5", DataGridView1.Rows.Item(v).Index).Value
            cmd.Fields("f_waiter").Value = ComboBox1.Text
        Next v
        cmd.Update()
        Button15.Text = ("GTable 1") + TextBox1.Text
        cmd.Close()
       



        If (Label4.Text = Button15.Text) Then
            Button15.Text = Button15.Text + TextBox1.Text
        End If
        If (Label4.Text = Button14.Text) Then
            Button14.Text = Button14.Text + TextBox1.Text
        End If
        If (Label4.Text = Button4.Text) Then
            Button4.Text = Button4.Text + TextBox1.Text
        End If
        If (Label4.Text = Button13.Text) Then
            Button13.Text = Button13.Text + TextBox1.Text
        End If
        If (Label4.Text = Button5.Text) Then
            Button5.Text = Button5.Text + TextBox1.Text
        End If
        If (Label4.Text = Button6.Text) Then
            Button6.Text = Button6.Text + TextBox1.Text
        End If
        If (Label4.Text = Button7.Text) Then
            Button7.Text = Button7.Text + TextBox1.Text
        End If
        If (Label4.Text = Button8.Text) Then
            Button8.Text = Button8.Text + TextBox1.Text
        End If
        If (Label4.Text = Button19.Text) Then
            Button19.Text = Button19.Text + TextBox1.Text
        End If
        If (Label4.Text = Button18.Text) Then
            Button18.Text = Button18.Text + TextBox1.Text
        End If
        If (Label4.Text = Button16.Text) Then
            Button16.Text = Button16.Text + TextBox1.Text
        End If
        If (Label4.Text = Button9.Text) Then
            Button9.Text = Button9.Text + TextBox1.Text
        End If
        If (Label4.Text = Button10.Text) Then
            Button10.Text = Button10.Text + TextBox1.Text
        End If
        If (Label4.Text = Button11.Text) Then
            Button11.Text = Button11.Text + TextBox1.Text
        End If
        If (Label4.Text = Button12.Text) Then
            Button12.Text = Button12.Text + TextBox1.Text
        End If
        If (Label4.Text = Button27.Text) Then
            Button27.Text = Button27.Text + TextBox1.Text
        End If
        If (Label4.Text = Button26.Text) Then
            Button26.Text = Button26.Text + TextBox1.Text
        End If
        If (Label4.Text = Button24.Text) Then
            Button24.Text = Button24.Text + TextBox1.Text
        End If
        If (Label4.Text = Button25.Text) Then
            Button25.Text = Button25.Text + TextBox1.Text
        End If
        If (Label4.Text = Button20.Text) Then
            Button20.Text = Button20.Text + TextBox1.Text
        End If
        If (Label4.Text = Button21.Text) Then
            Button21.Text = Button21.Text + TextBox1.Text
        End If
        If (Label4.Text = Button22.Text) Then
            Button22.Text = Button22.Text + TextBox1.Text
        End If
        If (Label4.Text = Button23.Text) Then
            Button23.Text = Button23.Text + TextBox1.Text
        End If
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Button15.BackColor = Color.AliceBlue
        'If (ComboBox2.SelectedItem = "") Then
        'MsgBox("Choose Item")
        'Else
        x = InputBox("Enter Quantity")
        'Dim iname As String
        'iname = ComboBox2.SelectedItem
        'MsgBox(iname)
        cmd3.Open("select f_rate from food_details where f_name='" & ComboBox2.Text & "'", con, ADODB.CursorTypeEnum.adOpenDynamic, ADODB.LockTypeEnum.adLockOptimistic)
        rate = cmd3.Fields("f_rate").Value
        ' MsgBox(rate)
        amount = rate * x
        DataGridView1.Rows.Add(Val(i), ComboBox2.Text, rate, x, amount, "E", "X")
        ComboBox2.SelectedText = ""
        i = i + 1
        'End If
        cmd3.Close()

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Button15.BackColor = Color.Gainsboro
    End Sub

    Private Sub DataGridView1_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        If (DataGridView1.Item("Column7", DataGridView1.CurrentRow.Index).Selected) Then
            DataGridView1.Rows.Remove(DataGridView1.CurrentRow)
        End If
        If (DataGridView1.Item("Column6", DataGridView1.CurrentRow.Index).Selected) Then
            Dim a As Byte = InputBox("Enter Changed Quantity")
            amount = rate * a
            DataGridView1.Rows.Remove(DataGridView1.CurrentRow)
            DataGridView1.Rows.Add(Val(i - 1), ComboBox2.Text, rate, a, amount, "E", "X")
        End If
    End Sub
End Class