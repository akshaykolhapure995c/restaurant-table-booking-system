Imports System.IO
Imports System.Drawing.Printing
Imports System.Drawing.Point

Imports System.Runtime.InteropServices


Public Class sales
    Dim con As New ADODB.Connection
    Dim cmd As New ADODB.Recordset
    Dim cmd2 As New ADODB.Recordset
    Dim cmd3 As New ADODB.Recordset
    Dim cmd4 As New ADODB.Recordset
    Dim cmd5 As New ADODB.Recordset
    Dim dr As New System.Windows.Forms.DataGridViewRow
    Dim cmd6 As New ADODB.Recordset
    Dim i As New Integer
    Dim g As Integer = 0
    Public bill, vi As New Integer
    Dim temp As Boolean
    Dim rate, amount As Integer

    Private Sub sales_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        Me.Enabled = False
        main.Enabled = True
    End Sub
    Private Sub sales_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        TextBox1.Enabled = False
        Column1.SortMode = DataGridViewColumnSortMode.NotSortable
        TextBox3.Enabled = False
        temp = False
        i = 1
        con.Open("dsn=abc")
        cmd.Open("select * from uptdate", con, ADODB.CursorTypeEnum.adOpenDynamic, ADODB.LockTypeEnum.adLockOptimistic)
        If Not cmd.EOF Or Not cmd.BOF Then
            While Not cmd.EOF
                DataGridView2.Rows.Add(cmd.Fields("bill").Value, cmd.Fields("table").Value, cmd.Fields("waiter").Value, cmd.Fields("amt").Value, "Update")
                cmd.MoveNext()
            End While
        End If
        cmd.Close()

        cmd.Open("select * from bill_number", con, ADODB.CursorTypeEnum.adOpenDynamic, ADODB.LockTypeEnum.adLockOptimistic)
        TextBox3.Text = cmd.Fields("bill").Value
        Label6.Text = cmd.Fields("std").Value
        cmd.Close()

        cmd.Open("select * from sales", con, ADODB.CursorTypeEnum.adOpenDynamic, ADODB.LockTypeEnum.adLockOptimistic)
        If Not cmd.EOF Or Not cmd.BOF Then
            Button15.BackColor = Color.DimGray
            Dim h1 As Integer = 0
            While Not cmd.EOF
                h1 = h1 + cmd.Fields("f_total").Value
                cmd.MoveNext()
            End While
            Button15.Text = "1 " + h1.ToString
            temp = True
        End If
        cmd.Close()

        cmd.Open("select * from sales_gt2", con, ADODB.CursorTypeEnum.adOpenDynamic, ADODB.LockTypeEnum.adLockOptimistic)
        If Not cmd.EOF Or Not cmd.BOF Then
            Button14.BackColor = Color.DimGray
            Dim h1 As String = 0
            While Not cmd.EOF
                h1 = h1 + cmd.Fields("f_total").Value
                cmd.MoveNext()
            End While
            Button14.Text = "2  " + h1
            temp = True
        End If
        cmd.Close()

        cmd.Open("select * from sales_gt3", con, ADODB.CursorTypeEnum.adOpenDynamic, ADODB.LockTypeEnum.adLockOptimistic)
        If Not cmd.EOF Or Not cmd.BOF Then
            Button4.BackColor = Color.DimGray
            Dim h1 As String = 0
            While Not cmd.EOF
                h1 = h1 + cmd.Fields("f_total").Value
                cmd.MoveNext()
            End While
            Button4.Text = "3  " + h1
            temp = True
        End If
        cmd.Close()

        cmd.Open("select * from sales_gt4", con, ADODB.CursorTypeEnum.adOpenDynamic, ADODB.LockTypeEnum.adLockOptimistic)
        If Not cmd.EOF Or Not cmd.BOF Then
            Button13.BackColor = Color.DimGray
            Dim h1 As String = 0
            While Not cmd.EOF
                h1 = h1 + cmd.Fields("f_total").Value
                cmd.MoveNext()
            End While
            Button13.Text = "4  " + h1
            temp = True
        End If
        cmd.Close()

        cmd.Open("select * from sales_gt5", con, ADODB.CursorTypeEnum.adOpenDynamic, ADODB.LockTypeEnum.adLockOptimistic)
        If Not cmd.EOF Or Not cmd.BOF Then
            Button5.BackColor = Color.DimGray
            Dim h1 As String = 0
            While Not cmd.EOF
                h1 = h1 + cmd.Fields("f_total").Value
                cmd.MoveNext()
            End While
            Button5.Text = "5  " + h1
            temp = True
        End If
        cmd.Close()

        cmd.Open("select * from sales_gt6", con, ADODB.CursorTypeEnum.adOpenDynamic, ADODB.LockTypeEnum.adLockOptimistic)
        If Not cmd.EOF Or Not cmd.BOF Then
            Button6.BackColor = Color.DimGray
            Dim h1 As String = 0
            While Not cmd.EOF
                h1 = h1 + cmd.Fields("f_total").Value
                cmd.MoveNext()
            End While
            Button6.Text = "6  " + h1
            temp = True
        End If
        cmd.Close()

        cmd.Open("select * from sales_gt7", con, ADODB.CursorTypeEnum.adOpenDynamic, ADODB.LockTypeEnum.adLockOptimistic)
        If Not cmd.EOF Or Not cmd.BOF Then
            Button7.BackColor = Color.DimGray
            Dim h1 As String = 0
            While Not cmd.EOF
                h1 = h1 + cmd.Fields("f_total").Value
                cmd.MoveNext()
            End While
            Button7.Text = "7  " + h1
            temp = True
        End If
        cmd.Close()

        cmd.Open("select * from sales_gt8", con, ADODB.CursorTypeEnum.adOpenDynamic, ADODB.LockTypeEnum.adLockOptimistic)
        If Not cmd.EOF Or Not cmd.BOF Then
            Button8.BackColor = Color.DimGray
            Dim h1 As String = 0
            While Not cmd.EOF
                h1 = h1 + cmd.Fields("f_total").Value
                cmd.MoveNext()
            End While
            Button8.Text = "8  " + h1
            temp = True
        End If
        cmd.Close()

        cmd.Open("select * from sales_p6", con, ADODB.CursorTypeEnum.adOpenDynamic, ADODB.LockTypeEnum.adLockOptimistic)
        If Not cmd.EOF Or Not cmd.BOF Then
            Button21.BackColor = Color.DimGray
            Dim h1 As String = 0
            While Not cmd.EOF
                h1 = h1 + cmd.Fields("f_total").Value
                cmd.MoveNext()
            End While
            Button21.Text = "9  " + h1
            temp = True
        End If
        cmd.Close()

        cmd.Open("select * from sales_p5", con, ADODB.CursorTypeEnum.adOpenDynamic, ADODB.LockTypeEnum.adLockOptimistic)
        If Not cmd.EOF Or Not cmd.BOF Then
            Button20.BackColor = Color.DimGray
            Dim h1 As String = 0
            While Not cmd.EOF
                h1 = h1 + cmd.Fields("f_total").Value
                cmd.MoveNext()
            End While
            Button20.Text = "10  " + h1
            temp = True
        End If
        cmd.Close()

        cmd.Open("select * from sales_gt11", con, ADODB.CursorTypeEnum.adOpenDynamic, ADODB.LockTypeEnum.adLockOptimistic)
        If Not cmd.EOF Or Not cmd.BOF Then
            Button2.BackColor = Color.DimGray
            Dim h1 As String = 0
            While Not cmd.EOF
                h1 = h1 + cmd.Fields("f_total").Value
                cmd.MoveNext()
            End While
            Button2.Text = "11  " + h1
            temp = True
        End If
        cmd.Close()


        cmd.Open("select * from sales_gt12", con, ADODB.CursorTypeEnum.adOpenDynamic, ADODB.LockTypeEnum.adLockOptimistic)
        If Not cmd.EOF Or Not cmd.BOF Then
            Button32.BackColor = Color.DimGray
            Dim h1 As String = 0
            While Not cmd.EOF
                h1 = h1 + cmd.Fields("f_total").Value
                cmd.MoveNext()
            End While
            Button32.Text = "12  " + h1
            temp = True
        End If
        cmd.Close()


        cmd.Open("select * from sales_gt13", con, ADODB.CursorTypeEnum.adOpenDynamic, ADODB.LockTypeEnum.adLockOptimistic)
        If Not cmd.EOF Or Not cmd.BOF Then
            Button33.BackColor = Color.DimGray
            Dim h1 As String = 0
            While Not cmd.EOF
                h1 = h1 + cmd.Fields("f_total").Value
                cmd.MoveNext()
            End While
            Button33.Text = "13  " + h1
            temp = True
        End If
        cmd.Close()


        cmd.Open("select * from sales_gt14", con, ADODB.CursorTypeEnum.adOpenDynamic, ADODB.LockTypeEnum.adLockOptimistic)
        If Not cmd.EOF Or Not cmd.BOF Then
            Button34.BackColor = Color.DimGray
            Dim h1 As String = 0
            While Not cmd.EOF
                h1 = h1 + cmd.Fields("f_total").Value
                cmd.MoveNext()
            End While
            Button34.Text = "14  " + h1
            temp = True
        End If
        cmd.Close()


        cmd.Open("select * from sales_gt15", con, ADODB.CursorTypeEnum.adOpenDynamic, ADODB.LockTypeEnum.adLockOptimistic)
        If Not cmd.EOF Or Not cmd.BOF Then
            Button35.BackColor = Color.DimGray
            Dim h1 As String = 0
            While Not cmd.EOF
                h1 = h1 + cmd.Fields("f_total").Value
                cmd.MoveNext()
            End While
            Button35.Text = "15  " + h1
            temp = True
        End If
        cmd.Close()


        cmd.Open("select * from sales_ff1", con, ADODB.CursorTypeEnum.adOpenDynamic, ADODB.LockTypeEnum.adLockOptimistic)
        If Not cmd.EOF Or Not cmd.BOF Then
            Button19.BackColor = Color.DimGray
            Dim h1 As String = 0
            While Not cmd.EOF
                h1 = h1 + cmd.Fields("f_total").Value
                cmd.MoveNext()
            End While
            Button19.Text = "16  " + h1
            temp = True
        End If
        cmd.Close()


        cmd.Open("select * from sales_ff2", con, ADODB.CursorTypeEnum.adOpenDynamic, ADODB.LockTypeEnum.adLockOptimistic)
        If Not cmd.EOF Or Not cmd.BOF Then
            Button18.BackColor = Color.DimGray
            Dim h1 As String = 0
            While Not cmd.EOF
                h1 = h1 + cmd.Fields("f_total").Value
                cmd.MoveNext()
            End While
            Button18.Text = "17  " + h1
            temp = True
        End If
        cmd.Close()

        cmd.Open("select * from sales_ff3", con, ADODB.CursorTypeEnum.adOpenDynamic, ADODB.LockTypeEnum.adLockOptimistic)
        If Not cmd.EOF Or Not cmd.BOF Then
            Button16.BackColor = Color.DimGray
            Dim h1 As String = 0
            While Not cmd.EOF
                h1 = h1 + cmd.Fields("f_total").Value
                cmd.MoveNext()
            End While
            Button16.Text = "18  " + h1
            temp = True
        End If
        cmd.Close()

        cmd.Open("select * from sales_ff4", con, ADODB.CursorTypeEnum.adOpenDynamic, ADODB.LockTypeEnum.adLockOptimistic)
        If Not cmd.EOF Or Not cmd.BOF Then
            Button17.BackColor = Color.DimGray
            Dim h1 As String = 0
            While Not cmd.EOF
                h1 = h1 + cmd.Fields("f_total").Value
                cmd.MoveNext()
            End While
            Button17.Text = "19  " + h1
            temp = True
        End If
        cmd.Close()


        cmd.Open("select * from sales_ff5", con, ADODB.CursorTypeEnum.adOpenDynamic, ADODB.LockTypeEnum.adLockOptimistic)
        If Not cmd.EOF Or Not cmd.BOF Then
            Button9.BackColor = Color.DimGray
            Dim h1 As String = 0
            While Not cmd.EOF
                h1 = h1 + cmd.Fields("f_total").Value
                cmd.MoveNext()
            End While
            Button9.Text = "20  " + h1
            temp = True
        End If
        cmd.Close()

        cmd.Open("select * from sales_ff6", con, ADODB.CursorTypeEnum.adOpenDynamic, ADODB.LockTypeEnum.adLockOptimistic)
        If Not cmd.EOF Or Not cmd.BOF Then
            Button10.BackColor = Color.DimGray
            Dim h1 As String = 0
            While Not cmd.EOF
                h1 = h1 + cmd.Fields("f_total").Value
                cmd.MoveNext()
            End While
            Button10.Text = "21  " + h1
            temp = True
        End If
        cmd.Close()


        cmd.Open("select * from sales_ff7", con, ADODB.CursorTypeEnum.adOpenDynamic, ADODB.LockTypeEnum.adLockOptimistic)
        If Not cmd.EOF Or Not cmd.BOF Then
            Button11.BackColor = Color.DimGray
            Dim h1 As String = 0
            While Not cmd.EOF
                h1 = h1 + cmd.Fields("f_total").Value
                cmd.MoveNext()
            End While
            Button11.Text = "22  " + h1
            temp = True
        End If
        cmd.Close()

        cmd.Open("select * from sales_ff8", con, ADODB.CursorTypeEnum.adOpenDynamic, ADODB.LockTypeEnum.adLockOptimistic)
        If Not cmd.EOF Or Not cmd.BOF Then
            Button12.BackColor = Color.DimGray
            Dim h1 As String = 0
            While Not cmd.EOF
                h1 = h1 + cmd.Fields("f_total").Value
                cmd.MoveNext()
            End While
            Button12.Text = "23  " + h1
            temp = True
        End If
        cmd.Close()

        cmd.Open("select * from sales_p8", con, ADODB.CursorTypeEnum.adOpenDynamic, ADODB.LockTypeEnum.adLockOptimistic)
        If Not cmd.EOF Or Not cmd.BOF Then
            Button23.BackColor = Color.DimGray
            Dim h1 As String = 0
            While Not cmd.EOF
                h1 = h1 + cmd.Fields("f_total").Value
                cmd.MoveNext()
            End While
            Button23.Text = "24  " + h1
            temp = True
        End If
        cmd.Close()


        cmd.Open("select * from sales_p7", con, ADODB.CursorTypeEnum.adOpenDynamic, ADODB.LockTypeEnum.adLockOptimistic)
        If Not cmd.EOF Or Not cmd.BOF Then
            Button22.BackColor = Color.DimGray
            Dim h1 As String = 0
            While Not cmd.EOF
                h1 = h1 + cmd.Fields("f_total").Value
                cmd.MoveNext()
            End While
            Button22.Text = "25  " + h1
            temp = True
        End If
        cmd.Close()

        cmd.Open("select * from sales_ff11", con, ADODB.CursorTypeEnum.adOpenDynamic, ADODB.LockTypeEnum.adLockOptimistic)
        If Not cmd.EOF Or Not cmd.BOF Then
            Button36.BackColor = Color.DimGray
            Dim h1 As String = 0
            While Not cmd.EOF
                h1 = h1 + cmd.Fields("f_total").Value
                cmd.MoveNext()
            End While
            Button36.Text = "26  " + h1
            temp = True
        End If
        cmd.Close()

        cmd.Open("select * from sales_ff12", con, ADODB.CursorTypeEnum.adOpenDynamic, ADODB.LockTypeEnum.adLockOptimistic)
        If Not cmd.EOF Or Not cmd.BOF Then
            Button37.BackColor = Color.DimGray
            Dim h1 As String = 0
            While Not cmd.EOF
                h1 = h1 + cmd.Fields("f_total").Value
                cmd.MoveNext()
            End While
            Button37.Text = "27  " + h1
            temp = True
        End If
        cmd.Close()

        cmd.Open("select * from sales_ff13", con, ADODB.CursorTypeEnum.adOpenDynamic, ADODB.LockTypeEnum.adLockOptimistic)
        If Not cmd.EOF Or Not cmd.BOF Then
            Button38.BackColor = Color.DimGray
            Dim h1 As String = 0
            While Not cmd.EOF
                h1 = h1 + cmd.Fields("f_total").Value
                cmd.MoveNext()
            End While
            Button38.Text = "28  " + h1
            temp = True
        End If
        cmd.Close()

        cmd.Open("select * from sales_ff14", con, ADODB.CursorTypeEnum.adOpenDynamic, ADODB.LockTypeEnum.adLockOptimistic)
        If Not cmd.EOF Or Not cmd.BOF Then
            Button39.BackColor = Color.DimGray
            Dim h1 As String = 0
            While Not cmd.EOF
                h1 = h1 + cmd.Fields("f_total").Value
                cmd.MoveNext()
            End While
            Button39.Text = "29  " + h1
            temp = True
        End If
        cmd.Close()

        cmd.Open("select * from sales_ff15", con, ADODB.CursorTypeEnum.adOpenDynamic, ADODB.LockTypeEnum.adLockOptimistic)
        If Not cmd.EOF Or Not cmd.BOF Then
            Button40.BackColor = Color.DimGray
            Dim h1 As String = 0
            While Not cmd.EOF
                h1 = h1 + cmd.Fields("f_total").Value
                cmd.MoveNext()
            End While
            Button40.Text = "30  " + h1
            temp = True
        End If
        cmd.Close()






        cmd.Open("select * from waiter_details", con, ADODB.CursorTypeEnum.adOpenDynamic, ADODB.LockTypeEnum.adLockOptimistic)
        While Not cmd.EOF
            ComboBox1.Items.Add(cmd.Fields("name").Value)
            cmd.MoveNext()
        End While
        cmd.Close()

        cmd.Open("select * from food_details", con, ADODB.CursorTypeEnum.adOpenDynamic, ADODB.LockTypeEnum.adLockOptimistic)
        While Not cmd.EOF
            ComboBox2.Items.Add(cmd.Fields("f_name").Value)
            cmd.MoveNext()
        End While
        cmd.Close()
        Button1.Enabled = False
    End Sub
    Private Sub Button15_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button15.Click
        g = 0
        If Not Button15.BackColor = Color.DimGray Then
            con.Execute("delete * from sales")
            ComboBox1.Enabled = True
            ComboBox1.Focus()
            ComboBox1.Text = ""
            ' Label13.Text = TimeOfDay
        Else

            ComboBox1.Enabled = False
            TextBox2.Focus()
        End If
        TextBox1.Text = ""
        TextBox2.Text = ""
        ComboBox2.Text = ""
        i = 1
        If temp = True Then
            DataGridView1.Rows.Clear()
            cmd.Open("select * from sales", con, ADODB.CursorTypeEnum.adOpenDynamic, ADODB.LockTypeEnum.adLockOptimistic)
            While Not cmd.EOF
                DataGridView1.Rows.Add(Val(i), cmd.Fields("f_item").Value, cmd.Fields("f_charges").Value, cmd.Fields("f_quantity").Value, cmd.Fields("f_total").Value, "E", "X")
                ComboBox1.Text = cmd.Fields("f_waiter").Value
                i = i + 1
                cmd.MoveNext()
            End While
            cmd.Close()
        End If
        Label4.Text = "1"
    End Sub
    Private Sub Button14_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button14.Click
        g = 0
        If Not Button14.BackColor = Color.DimGray Then
            con.Execute("delete * from sales_gt2")
            ComboBox1.Enabled = True
            ComboBox1.Focus()
            ComboBox1.Text = ""
            ' Label13.Text = TimeOfDay
        Else

            ComboBox1.Enabled = False
            TextBox2.Focus()
        End If
        TextBox1.Text = ""
        TextBox2.Text = ""
        ComboBox2.Text = ""
        i = 1
        If temp = True Then
            DataGridView1.Rows.Clear()
            cmd.Open("select * from sales_gt2", con, ADODB.CursorTypeEnum.adOpenDynamic, ADODB.LockTypeEnum.adLockOptimistic)
            While Not cmd.EOF
                DataGridView1.Rows.Add(Val(i), cmd.Fields("f_item").Value, cmd.Fields("f_charges").Value, cmd.Fields("f_quantity").Value, cmd.Fields("f_total").Value, "E", "X")
                ComboBox1.Text = cmd.Fields("f_waiter").Value
                i = i + 1
                cmd.MoveNext()
            End While
            cmd.Close()
        End If
        Label4.Text = "2"

    End Sub
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If DataGridView1.RowCount = 0 Then
            MsgBox("No Item")
            Button1.Enabled = False
        Else
            Dim dt As New DataTable
            With dt
                .Columns.Add("Bill")
                .Columns.Add("Waiter")
                .Columns.Add("Table")
                .Columns.Add("Items")
                .Columns.Add("Qty")
            End With
            For v = DataGridView1.RowCount - g To DataGridView1.RowCount - 1
                dt.Rows.Add(Me.TextBox3.Text, Me.ComboBox1.Text, Me.Label4.Text, DataGridView1.Rows(v).Cells(1).Value, DataGridView1.Rows(v).Cells(3).Value)
            Next v

            If Label4.Text = "1" Then
                temp = True
                Dim v, w As New Integer
                w = 0

                For v = 0 To DataGridView1.RowCount - 1
                    w = w + DataGridView1.Item("Column5", DataGridView1.Rows.Item(v).Index).Value
                Next v

                TextBox1.Text = w
                cmd.Open("select * from sales", con, ADODB.CursorTypeEnum.adOpenDynamic, ADODB.LockTypeEnum.adLockOptimistic)
                con.Execute("delete * from sales")
                For v = 0 To DataGridView1.RowCount - 1
                    cmd.AddNew()
                    cmd.Fields("f_item").Value = DataGridView1.Item("Column2", DataGridView1.Rows.Item(v).Index).Value
                    cmd.Fields("f_charges").Value = DataGridView1.Item("Column3", DataGridView1.Rows.Item(v).Index).Value
                    cmd.Fields("f_quantity").Value = DataGridView1.Item("Column4", DataGridView1.Rows.Item(v).Index).Value
                    cmd.Fields("f_total").Value = DataGridView1.Item("Column5", DataGridView1.Rows.Item(v).Index).Value
                    cmd.Fields("f_waiter").Value = ComboBox1.Text
                    cmd.MoveNext()
                Next v
                cmd.Close()
                Button15.Text = ("1  ") + TextBox1.Text

            End If
            If Label4.Text = "15" Then
                temp = True
                Dim v, w As New Integer
                w = 0
                For v = 0 To DataGridView1.RowCount - 1
                    w = w + DataGridView1.Item("Column5", DataGridView1.Rows.Item(v).Index).Value
                Next v
                TextBox1.Text = w

                cmd.Open("select * from sales_gt15", con, ADODB.CursorTypeEnum.adOpenDynamic, ADODB.LockTypeEnum.adLockOptimistic)
                con.Execute("delete * from sales_gt15")
                For v = 0 To DataGridView1.RowCount - 1
                    cmd.AddNew()
                    cmd.Fields("f_item").Value = DataGridView1.Item("Column2", DataGridView1.Rows.Item(v).Index).Value
                    cmd.Fields("f_charges").Value = DataGridView1.Item("Column3", DataGridView1.Rows.Item(v).Index).Value
                    cmd.Fields("f_quantity").Value = DataGridView1.Item("Column4", DataGridView1.Rows.Item(v).Index).Value
                    cmd.Fields("f_total").Value = DataGridView1.Item("Column5", DataGridView1.Rows.Item(v).Index).Value
                    cmd.Fields("f_waiter").Value = ComboBox1.Text
                    cmd.MoveNext()
                Next v
                Button35.Text = ("15  ") + TextBox1.Text
                cmd.Close()
            End If
            If Label4.Text = "14" Then
                temp = True
                Dim v, w As New Integer
                w = 0
                For v = 0 To DataGridView1.RowCount - 1
                    w = w + DataGridView1.Item("Column5", DataGridView1.Rows.Item(v).Index).Value
                Next v
                TextBox1.Text = w

                cmd.Open("select * from sales_gt14", con, ADODB.CursorTypeEnum.adOpenDynamic, ADODB.LockTypeEnum.adLockOptimistic)
                con.Execute("delete * from sales_gt14")
                For v = 0 To DataGridView1.RowCount - 1
                    cmd.AddNew()
                    cmd.Fields("f_item").Value = DataGridView1.Item("Column2", DataGridView1.Rows.Item(v).Index).Value
                    cmd.Fields("f_charges").Value = DataGridView1.Item("Column3", DataGridView1.Rows.Item(v).Index).Value
                    cmd.Fields("f_quantity").Value = DataGridView1.Item("Column4", DataGridView1.Rows.Item(v).Index).Value
                    cmd.Fields("f_total").Value = DataGridView1.Item("Column5", DataGridView1.Rows.Item(v).Index).Value
                    cmd.Fields("f_waiter").Value = ComboBox1.Text
                    cmd.MoveNext()
                Next v
                Button34.Text = ("14  ") + TextBox1.Text
                cmd.Close()
            End If
            If Label4.Text = "13" Then
                temp = True
                Dim v, w As New Integer
                w = 0
                For v = 0 To DataGridView1.RowCount - 1
                    w = w + DataGridView1.Item("Column5", DataGridView1.Rows.Item(v).Index).Value
                Next v
                TextBox1.Text = w

                cmd.Open("select * from sales_gt13", con, ADODB.CursorTypeEnum.adOpenDynamic, ADODB.LockTypeEnum.adLockOptimistic)
                con.Execute("delete * from sales_gt13")
                For v = 0 To DataGridView1.RowCount - 1
                    cmd.AddNew()
                    cmd.Fields("f_item").Value = DataGridView1.Item("Column2", DataGridView1.Rows.Item(v).Index).Value
                    cmd.Fields("f_charges").Value = DataGridView1.Item("Column3", DataGridView1.Rows.Item(v).Index).Value
                    cmd.Fields("f_quantity").Value = DataGridView1.Item("Column4", DataGridView1.Rows.Item(v).Index).Value
                    cmd.Fields("f_total").Value = DataGridView1.Item("Column5", DataGridView1.Rows.Item(v).Index).Value
                    cmd.Fields("f_waiter").Value = ComboBox1.Text
                    cmd.MoveNext()
                Next v
                Button33.Text = ("13  ") + TextBox1.Text
                cmd.Close()
            End If
            If Label4.Text = "12" Then
                temp = True
                Dim v, w As New Integer
                w = 0
                For v = 0 To DataGridView1.RowCount - 1
                    w = w + DataGridView1.Item("Column5", DataGridView1.Rows.Item(v).Index).Value
                Next v
                TextBox1.Text = w

                cmd.Open("select * from sales_gt12", con, ADODB.CursorTypeEnum.adOpenDynamic, ADODB.LockTypeEnum.adLockOptimistic)
                con.Execute("delete * from sales_gt12")
                For v = 0 To DataGridView1.RowCount - 1
                    cmd.AddNew()
                    cmd.Fields("f_item").Value = DataGridView1.Item("Column2", DataGridView1.Rows.Item(v).Index).Value
                    cmd.Fields("f_charges").Value = DataGridView1.Item("Column3", DataGridView1.Rows.Item(v).Index).Value
                    cmd.Fields("f_quantity").Value = DataGridView1.Item("Column4", DataGridView1.Rows.Item(v).Index).Value
                    cmd.Fields("f_total").Value = DataGridView1.Item("Column5", DataGridView1.Rows.Item(v).Index).Value
                    cmd.Fields("f_waiter").Value = ComboBox1.Text
                    cmd.MoveNext()
                Next v
                Button32.Text = ("12  ") + TextBox1.Text
                cmd.Close()
            End If
            If Label4.Text = "11" Then
                temp = True
                Dim v, w As New Integer
                w = 0
                For v = 0 To DataGridView1.RowCount - 1
                    w = w + DataGridView1.Item("Column5", DataGridView1.Rows.Item(v).Index).Value
                Next v
                TextBox1.Text = w

                cmd.Open("select * from sales_gt11", con, ADODB.CursorTypeEnum.adOpenDynamic, ADODB.LockTypeEnum.adLockOptimistic)
                con.Execute("delete * from sales_gt11")
                For v = 0 To DataGridView1.RowCount - 1
                    cmd.AddNew()
                    cmd.Fields("f_item").Value = DataGridView1.Item("Column2", DataGridView1.Rows.Item(v).Index).Value
                    cmd.Fields("f_charges").Value = DataGridView1.Item("Column3", DataGridView1.Rows.Item(v).Index).Value
                    cmd.Fields("f_quantity").Value = DataGridView1.Item("Column4", DataGridView1.Rows.Item(v).Index).Value
                    cmd.Fields("f_total").Value = DataGridView1.Item("Column5", DataGridView1.Rows.Item(v).Index).Value
                    cmd.Fields("f_waiter").Value = ComboBox1.Text
                    cmd.MoveNext()
                Next v
                Button2.Text = ("11  ") + TextBox1.Text
                cmd.Close()
            End If
            If Label4.Text = "2" Then
                temp = True
                Dim v, w As New Integer
                w = 0
                For v = 0 To DataGridView1.RowCount - 1
                    w = w + DataGridView1.Item("Column5", DataGridView1.Rows.Item(v).Index).Value
                Next v
                TextBox1.Text = w

                cmd.Open("select * from sales_gt2", con, ADODB.CursorTypeEnum.adOpenDynamic, ADODB.LockTypeEnum.adLockOptimistic)
                con.Execute("delete * from sales_gt2")
                For v = 0 To DataGridView1.RowCount - 1
                    cmd.AddNew()
                    cmd.Fields("f_item").Value = DataGridView1.Item("Column2", DataGridView1.Rows.Item(v).Index).Value
                    cmd.Fields("f_charges").Value = DataGridView1.Item("Column3", DataGridView1.Rows.Item(v).Index).Value
                    cmd.Fields("f_quantity").Value = DataGridView1.Item("Column4", DataGridView1.Rows.Item(v).Index).Value
                    cmd.Fields("f_total").Value = DataGridView1.Item("Column5", DataGridView1.Rows.Item(v).Index).Value
                    cmd.Fields("f_waiter").Value = ComboBox1.Text
                    cmd.MoveNext()
                Next v
                Button14.Text = ("2  ") + TextBox1.Text
                cmd.Close()
            End If
            If Label4.Text = "3" Then
                temp = True
                Dim v, w As New Integer
                w = 0
                For v = 0 To DataGridView1.RowCount - 1
                    w = w + DataGridView1.Item("Column5", DataGridView1.Rows.Item(v).Index).Value
                Next v
                TextBox1.Text = w
                cmd.Open("select * from sales_gt3", con, ADODB.CursorTypeEnum.adOpenDynamic, ADODB.LockTypeEnum.adLockOptimistic)
                con.Execute("delete * from sales_gt3")
                For v = 0 To DataGridView1.RowCount - 1
                    cmd.AddNew()
                    cmd.Fields("f_item").Value = DataGridView1.Item("Column2", DataGridView1.Rows.Item(v).Index).Value
                    cmd.Fields("f_charges").Value = DataGridView1.Item("Column3", DataGridView1.Rows.Item(v).Index).Value
                    cmd.Fields("f_quantity").Value = DataGridView1.Item("Column4", DataGridView1.Rows.Item(v).Index).Value
                    cmd.Fields("f_total").Value = DataGridView1.Item("Column5", DataGridView1.Rows.Item(v).Index).Value
                    cmd.Fields("f_waiter").Value = ComboBox1.Text
                    cmd.MoveNext()
                Next v

                Button4.Text = ("3  ") + TextBox1.Text
                cmd.Close()
            End If
            If Label4.Text = "4" Then
                temp = True
                Dim v, w As New Integer
                w = 0
                For v = 0 To DataGridView1.RowCount - 1

                    w = w + DataGridView1.Item("Column5", DataGridView1.Rows.Item(v).Index).Value
                Next v
                TextBox1.Text = w
                cmd.Open("select * from sales_gt4", con, ADODB.CursorTypeEnum.adOpenDynamic, ADODB.LockTypeEnum.adLockOptimistic)
                con.Execute("delete * from sales_gt4")
                For v = 0 To DataGridView1.RowCount - 1
                    cmd.AddNew()
                    cmd.Fields("f_item").Value = DataGridView1.Item("Column2", DataGridView1.Rows.Item(v).Index).Value
                    cmd.Fields("f_charges").Value = DataGridView1.Item("Column3", DataGridView1.Rows.Item(v).Index).Value
                    cmd.Fields("f_quantity").Value = DataGridView1.Item("Column4", DataGridView1.Rows.Item(v).Index).Value
                    cmd.Fields("f_total").Value = DataGridView1.Item("Column5", DataGridView1.Rows.Item(v).Index).Value
                    cmd.Fields("f_waiter").Value = ComboBox1.Text
                    cmd.MoveNext()
                Next v

                Button13.Text = ("4  ") + TextBox1.Text
                cmd.Close()
            End If
            If Label4.Text = "5" Then
                temp = True
                Dim v, w As New Integer
                w = 0
                For v = 0 To DataGridView1.RowCount - 1
                    ' v = DataGridView1.RowCount
                    w = w + DataGridView1.Item("Column5", DataGridView1.Rows.Item(v).Index).Value
                Next v
                TextBox1.Text = w
                cmd.Open("select * from sales_gt5", con, ADODB.CursorTypeEnum.adOpenDynamic, ADODB.LockTypeEnum.adLockOptimistic)
                con.Execute("delete * from sales_gt5")
                For v = 0 To DataGridView1.RowCount - 1
                    cmd.AddNew()
                    cmd.Fields("f_item").Value = DataGridView1.Item("Column2", DataGridView1.Rows.Item(v).Index).Value
                    cmd.Fields("f_charges").Value = DataGridView1.Item("Column3", DataGridView1.Rows.Item(v).Index).Value
                    cmd.Fields("f_quantity").Value = DataGridView1.Item("Column4", DataGridView1.Rows.Item(v).Index).Value
                    cmd.Fields("f_total").Value = DataGridView1.Item("Column5", DataGridView1.Rows.Item(v).Index).Value
                    cmd.Fields("f_waiter").Value = ComboBox1.Text
                    cmd.MoveNext()
                Next v

                Button5.Text = ("5  ") + TextBox1.Text
                cmd.Close()
            End If
            If Label4.Text = "6" Then
                temp = True
                Dim v, w As New Integer
                w = 0
                For v = 0 To DataGridView1.RowCount - 1
                    ' v = DataGridView1.RowCount
                    w = w + DataGridView1.Item("Column5", DataGridView1.Rows.Item(v).Index).Value
                Next v
                TextBox1.Text = w
                cmd.Open("select * from sales_gt6", con, ADODB.CursorTypeEnum.adOpenDynamic, ADODB.LockTypeEnum.adLockOptimistic)
                con.Execute("delete * from sales_gt6")
                For v = 0 To DataGridView1.RowCount - 1
                    cmd.AddNew()
                    cmd.Fields("f_item").Value = DataGridView1.Item("Column2", DataGridView1.Rows.Item(v).Index).Value
                    cmd.Fields("f_charges").Value = DataGridView1.Item("Column3", DataGridView1.Rows.Item(v).Index).Value
                    cmd.Fields("f_quantity").Value = DataGridView1.Item("Column4", DataGridView1.Rows.Item(v).Index).Value
                    cmd.Fields("f_total").Value = DataGridView1.Item("Column5", DataGridView1.Rows.Item(v).Index).Value
                    cmd.Fields("f_waiter").Value = ComboBox1.Text
                    cmd.MoveNext()
                Next v
                Button6.Text = ("6  ") + TextBox1.Text
                cmd.Close()
            End If
            If Label4.Text = "7" Then
                temp = True
                Dim v, w As New Integer
                w = 0
                For v = 0 To DataGridView1.RowCount - 1
                    ' v = DataGridView1.RowCount
                    w = w + DataGridView1.Item("Column5", DataGridView1.Rows.Item(v).Index).Value
                Next v
                TextBox1.Text = w
                cmd.Open("select * from sales_gt7", con, ADODB.CursorTypeEnum.adOpenDynamic, ADODB.LockTypeEnum.adLockOptimistic)
                con.Execute("delete * from sales_gt7")
                For v = 0 To DataGridView1.RowCount - 1
                    cmd.AddNew()
                    cmd.Fields("f_item").Value = DataGridView1.Item("Column2", DataGridView1.Rows.Item(v).Index).Value
                    cmd.Fields("f_charges").Value = DataGridView1.Item("Column3", DataGridView1.Rows.Item(v).Index).Value
                    cmd.Fields("f_quantity").Value = DataGridView1.Item("Column4", DataGridView1.Rows.Item(v).Index).Value
                    cmd.Fields("f_total").Value = DataGridView1.Item("Column5", DataGridView1.Rows.Item(v).Index).Value
                    cmd.Fields("f_waiter").Value = ComboBox1.Text
                    cmd.MoveNext()
                Next v

                Button7.Text = ("7  ") + TextBox1.Text
                cmd.Close()
            End If
            If Label4.Text = "8" Then
                temp = True
                Dim v, w As New Integer
                w = 0
                For v = 0 To DataGridView1.RowCount - 1
                    ' v = DataGridView1.RowCount
                    w = w + DataGridView1.Item("Column5", DataGridView1.Rows.Item(v).Index).Value
                Next v
                TextBox1.Text = w
                cmd.Open("select * from sales_gt8", con, ADODB.CursorTypeEnum.adOpenDynamic, ADODB.LockTypeEnum.adLockOptimistic)
                con.Execute("delete * from sales_gt8")
                For v = 0 To DataGridView1.RowCount - 1
                    cmd.AddNew()
                    cmd.Fields("f_item").Value = DataGridView1.Item("Column2", DataGridView1.Rows.Item(v).Index).Value
                    cmd.Fields("f_charges").Value = DataGridView1.Item("Column3", DataGridView1.Rows.Item(v).Index).Value
                    cmd.Fields("f_quantity").Value = DataGridView1.Item("Column4", DataGridView1.Rows.Item(v).Index).Value
                    cmd.Fields("f_total").Value = DataGridView1.Item("Column5", DataGridView1.Rows.Item(v).Index).Value
                    cmd.Fields("f_waiter").Value = ComboBox1.Text
                    cmd.MoveNext()
                Next v
                Button8.Text = ("8  ") + TextBox1.Text
                cmd.Close()
            End If
            If Label4.Text = "30" Then
                temp = True
                Dim v, w As New Integer
                w = 0
                For v = 0 To DataGridView1.RowCount - 1
                    ' v = DataGridView1.RowCount
                    w = w + DataGridView1.Item("Column5", DataGridView1.Rows.Item(v).Index).Value
                Next v
                TextBox1.Text = w
                cmd.Open("select * from sales_ff15", con, ADODB.CursorTypeEnum.adOpenDynamic, ADODB.LockTypeEnum.adLockOptimistic)
                con.Execute("delete * from sales_ff15")
                For v = 0 To DataGridView1.RowCount - 1
                    cmd.AddNew()
                    cmd.Fields("f_item").Value = DataGridView1.Item("Column2", DataGridView1.Rows.Item(v).Index).Value
                    cmd.Fields("f_charges").Value = DataGridView1.Item("Column3", DataGridView1.Rows.Item(v).Index).Value
                    cmd.Fields("f_quantity").Value = DataGridView1.Item("Column4", DataGridView1.Rows.Item(v).Index).Value
                    cmd.Fields("f_total").Value = DataGridView1.Item("Column5", DataGridView1.Rows.Item(v).Index).Value
                    cmd.Fields("f_waiter").Value = ComboBox1.Text
                    cmd.MoveNext()
                Next v
                Button40.Text = ("30  ") + TextBox1.Text
                cmd.Close()
            End If
            If Label4.Text = "29" Then
                temp = True
                Dim v, w As New Integer
                w = 0
                For v = 0 To DataGridView1.RowCount - 1
                    ' v = DataGridView1.RowCount
                    w = w + DataGridView1.Item("Column5", DataGridView1.Rows.Item(v).Index).Value
                Next v
                TextBox1.Text = w
                cmd.Open("select * from sales_ff14", con, ADODB.CursorTypeEnum.adOpenDynamic, ADODB.LockTypeEnum.adLockOptimistic)
                con.Execute("delete * from sales_ff14")
                For v = 0 To DataGridView1.RowCount - 1
                    cmd.AddNew()
                    cmd.Fields("f_item").Value = DataGridView1.Item("Column2", DataGridView1.Rows.Item(v).Index).Value
                    cmd.Fields("f_charges").Value = DataGridView1.Item("Column3", DataGridView1.Rows.Item(v).Index).Value
                    cmd.Fields("f_quantity").Value = DataGridView1.Item("Column4", DataGridView1.Rows.Item(v).Index).Value
                    cmd.Fields("f_total").Value = DataGridView1.Item("Column5", DataGridView1.Rows.Item(v).Index).Value
                    cmd.Fields("f_waiter").Value = ComboBox1.Text
                    cmd.MoveNext()
                Next v
                Button39.Text = ("29  ") + TextBox1.Text
                cmd.Close()
            End If
            If Label4.Text = "28" Then
                temp = True
                Dim v, w As New Integer
                w = 0
                For v = 0 To DataGridView1.RowCount - 1
                    ' v = DataGridView1.RowCount
                    w = w + DataGridView1.Item("Column5", DataGridView1.Rows.Item(v).Index).Value
                Next v
                TextBox1.Text = w
                cmd.Open("select * from sales_ff13", con, ADODB.CursorTypeEnum.adOpenDynamic, ADODB.LockTypeEnum.adLockOptimistic)
                con.Execute("delete * from sales_ff13")
                For v = 0 To DataGridView1.RowCount - 1
                    cmd.AddNew()
                    cmd.Fields("f_item").Value = DataGridView1.Item("Column2", DataGridView1.Rows.Item(v).Index).Value
                    cmd.Fields("f_charges").Value = DataGridView1.Item("Column3", DataGridView1.Rows.Item(v).Index).Value
                    cmd.Fields("f_quantity").Value = DataGridView1.Item("Column4", DataGridView1.Rows.Item(v).Index).Value
                    cmd.Fields("f_total").Value = DataGridView1.Item("Column5", DataGridView1.Rows.Item(v).Index).Value
                    cmd.Fields("f_waiter").Value = ComboBox1.Text
                    cmd.MoveNext()
                Next v
                Button38.Text = ("28  ") + TextBox1.Text
                cmd.Close()
            End If
            If Label4.Text = "27" Then
                temp = True
                Dim v, w As New Integer
                w = 0
                For v = 0 To DataGridView1.RowCount - 1
                    ' v = DataGridView1.RowCount
                    w = w + DataGridView1.Item("Column5", DataGridView1.Rows.Item(v).Index).Value
                Next v
                TextBox1.Text = w
                cmd.Open("select * from sales_ff12", con, ADODB.CursorTypeEnum.adOpenDynamic, ADODB.LockTypeEnum.adLockOptimistic)
                con.Execute("delete * from sales_ff12")
                For v = 0 To DataGridView1.RowCount - 1
                    cmd.AddNew()
                    cmd.Fields("f_item").Value = DataGridView1.Item("Column2", DataGridView1.Rows.Item(v).Index).Value
                    cmd.Fields("f_charges").Value = DataGridView1.Item("Column3", DataGridView1.Rows.Item(v).Index).Value
                    cmd.Fields("f_quantity").Value = DataGridView1.Item("Column4", DataGridView1.Rows.Item(v).Index).Value
                    cmd.Fields("f_total").Value = DataGridView1.Item("Column5", DataGridView1.Rows.Item(v).Index).Value
                    cmd.Fields("f_waiter").Value = ComboBox1.Text
                    cmd.MoveNext()
                Next v
                Button37.Text = ("27  ") + TextBox1.Text
                cmd.Close()
            End If
            If Label4.Text = "26" Then
                temp = True
                Dim v, w As New Integer
                w = 0
                For v = 0 To DataGridView1.RowCount - 1
                    ' v = DataGridView1.RowCount
                    w = w + DataGridView1.Item("Column5", DataGridView1.Rows.Item(v).Index).Value
                Next v
                TextBox1.Text = w
                cmd.Open("select * from sales_ff11", con, ADODB.CursorTypeEnum.adOpenDynamic, ADODB.LockTypeEnum.adLockOptimistic)
                con.Execute("delete * from sales_ff11")
                For v = 0 To DataGridView1.RowCount - 1
                    cmd.AddNew()
                    cmd.Fields("f_item").Value = DataGridView1.Item("Column2", DataGridView1.Rows.Item(v).Index).Value
                    cmd.Fields("f_charges").Value = DataGridView1.Item("Column3", DataGridView1.Rows.Item(v).Index).Value
                    cmd.Fields("f_quantity").Value = DataGridView1.Item("Column4", DataGridView1.Rows.Item(v).Index).Value
                    cmd.Fields("f_total").Value = DataGridView1.Item("Column5", DataGridView1.Rows.Item(v).Index).Value
                    cmd.Fields("f_waiter").Value = ComboBox1.Text
                    cmd.MoveNext()
                Next v
                Button36.Text = ("26  ") + TextBox1.Text
                cmd.Close()
            End If
            If Label4.Text = "16" Then
                temp = True
                Dim v, w As New Integer
                w = 0
                For v = 0 To DataGridView1.RowCount - 1
                    ' v = DataGridView1.RowCount
                    w = w + DataGridView1.Item("Column5", DataGridView1.Rows.Item(v).Index).Value
                Next v
                TextBox1.Text = w
                cmd.Open("select * from sales_ff1", con, ADODB.CursorTypeEnum.adOpenDynamic, ADODB.LockTypeEnum.adLockOptimistic)
                con.Execute("delete * from sales_ff1")
                For v = 0 To DataGridView1.RowCount - 1
                    cmd.AddNew()
                    cmd.Fields("f_item").Value = DataGridView1.Item("Column2", DataGridView1.Rows.Item(v).Index).Value
                    cmd.Fields("f_charges").Value = DataGridView1.Item("Column3", DataGridView1.Rows.Item(v).Index).Value
                    cmd.Fields("f_quantity").Value = DataGridView1.Item("Column4", DataGridView1.Rows.Item(v).Index).Value
                    cmd.Fields("f_total").Value = DataGridView1.Item("Column5", DataGridView1.Rows.Item(v).Index).Value
                    cmd.Fields("f_waiter").Value = ComboBox1.Text
                    cmd.MoveNext()
                Next v
                Button19.Text = ("16  ") + TextBox1.Text
                cmd.Close()
            End If
            If Label4.Text = "17" Then
                temp = True
                Dim v, w As New Integer
                w = 0
                For v = 0 To DataGridView1.RowCount - 1
                    ' v = DataGridView1.RowCount
                    w = w + DataGridView1.Item("Column5", DataGridView1.Rows.Item(v).Index).Value
                Next v
                TextBox1.Text = w
                cmd.Open("select * from sales_ff2", con, ADODB.CursorTypeEnum.adOpenDynamic, ADODB.LockTypeEnum.adLockOptimistic)
                con.Execute("delete * from sales_ff2")
                For v = 0 To DataGridView1.RowCount - 1
                    cmd.AddNew()
                    cmd.Fields("f_item").Value = DataGridView1.Item("Column2", DataGridView1.Rows.Item(v).Index).Value
                    cmd.Fields("f_charges").Value = DataGridView1.Item("Column3", DataGridView1.Rows.Item(v).Index).Value
                    cmd.Fields("f_quantity").Value = DataGridView1.Item("Column4", DataGridView1.Rows.Item(v).Index).Value
                    cmd.Fields("f_total").Value = DataGridView1.Item("Column5", DataGridView1.Rows.Item(v).Index).Value
                    cmd.Fields("f_waiter").Value = ComboBox1.Text
                    cmd.MoveNext()
                Next v
                Button18.Text = ("17  ") + TextBox1.Text
                cmd.Close()
            End If
            If Label4.Text = "18" Then
                temp = True
                Dim v, w As New Integer
                w = 0
                For v = 0 To DataGridView1.RowCount - 1
                    ' v = DataGridView1.RowCount
                    w = w + DataGridView1.Item("Column5", DataGridView1.Rows.Item(v).Index).Value
                Next v
                TextBox1.Text = w
                cmd.Open("select * from sales_ff3", con, ADODB.CursorTypeEnum.adOpenDynamic, ADODB.LockTypeEnum.adLockOptimistic)
                con.Execute("delete * from sales_ff3")
                For v = 0 To DataGridView1.RowCount - 1
                    cmd.AddNew()
                    cmd.Fields("f_item").Value = DataGridView1.Item("Column2", DataGridView1.Rows.Item(v).Index).Value
                    cmd.Fields("f_charges").Value = DataGridView1.Item("Column3", DataGridView1.Rows.Item(v).Index).Value
                    cmd.Fields("f_quantity").Value = DataGridView1.Item("Column4", DataGridView1.Rows.Item(v).Index).Value
                    cmd.Fields("f_total").Value = DataGridView1.Item("Column5", DataGridView1.Rows.Item(v).Index).Value
                    cmd.Fields("f_waiter").Value = ComboBox1.Text
                    cmd.MoveNext()
                Next v

                Button16.Text = ("18  ") + TextBox1.Text
                cmd.Close()
            End If
            If Label4.Text = "19" Then
                temp = True
                Dim v, w As New Integer
                w = 0
                For v = 0 To DataGridView1.RowCount - 1
                    ' v = DataGridView1.RowCount
                    w = w + DataGridView1.Item("Column5", DataGridView1.Rows.Item(v).Index).Value
                Next v
                TextBox1.Text = w
                cmd.Open("select * from sales_ff4", con, ADODB.CursorTypeEnum.adOpenDynamic, ADODB.LockTypeEnum.adLockOptimistic)
                con.Execute("delete * from sales_ff4")
                For v = 0 To DataGridView1.RowCount - 1
                    cmd.AddNew()
                    cmd.Fields("f_item").Value = DataGridView1.Item("Column2", DataGridView1.Rows.Item(v).Index).Value
                    cmd.Fields("f_charges").Value = DataGridView1.Item("Column3", DataGridView1.Rows.Item(v).Index).Value
                    cmd.Fields("f_quantity").Value = DataGridView1.Item("Column4", DataGridView1.Rows.Item(v).Index).Value
                    cmd.Fields("f_total").Value = DataGridView1.Item("Column5", DataGridView1.Rows.Item(v).Index).Value
                    cmd.Fields("f_waiter").Value = ComboBox1.Text
                    cmd.MoveNext()
                Next v

                Button17.Text = ("19  ") + TextBox1.Text
                cmd.Close()
            End If
            If Label4.Text = "20" Then
                temp = True
                Dim v, w As New Integer
                w = 0
                For v = 0 To DataGridView1.RowCount - 1
                    ' v = DataGridView1.RowCount
                    w = w + DataGridView1.Item("Column5", DataGridView1.Rows.Item(v).Index).Value
                Next v
                TextBox1.Text = w
                cmd.Open("select * from sales_ff5", con, ADODB.CursorTypeEnum.adOpenDynamic, ADODB.LockTypeEnum.adLockOptimistic)
                con.Execute("delete * from sales_ff5")
                For v = 0 To DataGridView1.RowCount - 1
                    cmd.AddNew()
                    cmd.Fields("f_item").Value = DataGridView1.Item("Column2", DataGridView1.Rows.Item(v).Index).Value
                    cmd.Fields("f_charges").Value = DataGridView1.Item("Column3", DataGridView1.Rows.Item(v).Index).Value
                    cmd.Fields("f_quantity").Value = DataGridView1.Item("Column4", DataGridView1.Rows.Item(v).Index).Value
                    cmd.Fields("f_total").Value = DataGridView1.Item("Column5", DataGridView1.Rows.Item(v).Index).Value
                    cmd.Fields("f_waiter").Value = ComboBox1.Text
                    cmd.MoveNext()
                Next v
                Button9.Text = ("20  ") + TextBox1.Text
                cmd.Close()
            End If
            If Label4.Text = "21" Then
                temp = True
                Dim v, w As New Integer
                w = 0
                For v = 0 To DataGridView1.RowCount - 1
                    ' v = DataGridView1.RowCount
                    w = w + DataGridView1.Item("Column5", DataGridView1.Rows.Item(v).Index).Value
                Next v
                TextBox1.Text = w
                cmd.Open("select * from sales_ff6", con, ADODB.CursorTypeEnum.adOpenDynamic, ADODB.LockTypeEnum.adLockOptimistic)
                con.Execute("delete * from sales_ff6")
                For v = 0 To DataGridView1.RowCount - 1
                    cmd.AddNew()
                    cmd.Fields("f_item").Value = DataGridView1.Item("Column2", DataGridView1.Rows.Item(v).Index).Value
                    cmd.Fields("f_charges").Value = DataGridView1.Item("Column3", DataGridView1.Rows.Item(v).Index).Value
                    cmd.Fields("f_quantity").Value = DataGridView1.Item("Column4", DataGridView1.Rows.Item(v).Index).Value
                    cmd.Fields("f_total").Value = DataGridView1.Item("Column5", DataGridView1.Rows.Item(v).Index).Value
                    cmd.Fields("f_waiter").Value = ComboBox1.Text
                    cmd.MoveNext()
                Next v

                Button10.Text = ("21  ") + TextBox1.Text
                cmd.Close()
            End If
            If Label4.Text = "22" Then
                temp = True
                Dim v, w As New Integer
                w = 0
                For v = 0 To DataGridView1.RowCount - 1
                    ' v = DataGridView1.RowCount
                    w = w + DataGridView1.Item("Column5", DataGridView1.Rows.Item(v).Index).Value
                Next v
                TextBox1.Text = w
                cmd.Open("select * from sales_ff7", con, ADODB.CursorTypeEnum.adOpenDynamic, ADODB.LockTypeEnum.adLockOptimistic)
                con.Execute("delete * from sales_ff7")
                For v = 0 To DataGridView1.RowCount - 1
                    cmd.AddNew()
                    cmd.Fields("f_item").Value = DataGridView1.Item("Column2", DataGridView1.Rows.Item(v).Index).Value
                    cmd.Fields("f_charges").Value = DataGridView1.Item("Column3", DataGridView1.Rows.Item(v).Index).Value
                    cmd.Fields("f_quantity").Value = DataGridView1.Item("Column4", DataGridView1.Rows.Item(v).Index).Value
                    cmd.Fields("f_total").Value = DataGridView1.Item("Column5", DataGridView1.Rows.Item(v).Index).Value
                    cmd.Fields("f_waiter").Value = ComboBox1.Text
                    cmd.MoveNext()
                Next v
                Button11.Text = ("22  ") + TextBox1.Text
                cmd.Close()
            End If
            If Label4.Text = "23" Then
                temp = True
                Dim v, w As New Integer
                w = 0
                For v = 0 To DataGridView1.RowCount - 1
                    ' v = DataGridView1.RowCount
                    w = w + DataGridView1.Item("Column5", DataGridView1.Rows.Item(v).Index).Value
                Next v
                TextBox1.Text = w
                cmd.Open("select * from sales_ff8", con, ADODB.CursorTypeEnum.adOpenDynamic, ADODB.LockTypeEnum.adLockOptimistic)
                con.Execute("delete * from sales_ff8")
                For v = 0 To DataGridView1.RowCount - 1
                    cmd.AddNew()
                    cmd.Fields("f_item").Value = DataGridView1.Item("Column2", DataGridView1.Rows.Item(v).Index).Value
                    cmd.Fields("f_charges").Value = DataGridView1.Item("Column3", DataGridView1.Rows.Item(v).Index).Value
                    cmd.Fields("f_quantity").Value = DataGridView1.Item("Column4", DataGridView1.Rows.Item(v).Index).Value
                    cmd.Fields("f_total").Value = DataGridView1.Item("Column5", DataGridView1.Rows.Item(v).Index).Value
                    cmd.Fields("f_waiter").Value = ComboBox1.Text
                    cmd.MoveNext()
                Next v
                Button12.Text = ("23  ") + TextBox1.Text
                cmd.Close()
            End If
            If Label4.Text = Button27.Text Then
                temp = True
                Dim v, w As New Integer
                w = 0
                For v = 0 To DataGridView1.RowCount - 1
                    ' v = DataGridView1.RowCount
                    w = w + DataGridView1.Item("Column5", DataGridView1.Rows.Item(v).Index).Value
                Next v
                TextBox1.Text = w
                cmd.Open("select * from sales_p1", con, ADODB.CursorTypeEnum.adOpenDynamic, ADODB.LockTypeEnum.adLockOptimistic)
                con.Execute("delete * from sales_p1")
                For v = 0 To DataGridView1.RowCount - 1
                    cmd.AddNew()
                    cmd.Fields("f_item").Value = DataGridView1.Item("Column2", DataGridView1.Rows.Item(v).Index).Value
                    cmd.Fields("f_charges").Value = DataGridView1.Item("Column3", DataGridView1.Rows.Item(v).Index).Value
                    cmd.Fields("f_quantity").Value = DataGridView1.Item("Column4", DataGridView1.Rows.Item(v).Index).Value
                    cmd.Fields("f_total").Value = DataGridView1.Item("Column5", DataGridView1.Rows.Item(v).Index).Value
                    cmd.Fields("f_waiter").Value = ComboBox1.Text
                    cmd.MoveNext()
                Next v
                'MsgBox(Val(TextBox1.Text))
                Button27.Text = ("P1  ") + TextBox1.Text
                cmd.Close()
            End If

            If Label4.Text = Button26.Text Then
                temp = True
                Dim v, w As New Integer
                w = 0
                For v = 0 To DataGridView1.RowCount - 1
                    ' v = DataGridView1.RowCount
                    w = w + DataGridView1.Item("Column5", DataGridView1.Rows.Item(v).Index).Value
                Next v
                TextBox1.Text = w
                cmd.Open("select * from sales_p2", con, ADODB.CursorTypeEnum.adOpenDynamic, ADODB.LockTypeEnum.adLockOptimistic)
                con.Execute("delete * from sales_p2")
                For v = 0 To DataGridView1.RowCount - 1
                    cmd.AddNew()
                    cmd.Fields("f_item").Value = DataGridView1.Item("Column2", DataGridView1.Rows.Item(v).Index).Value
                    cmd.Fields("f_charges").Value = DataGridView1.Item("Column3", DataGridView1.Rows.Item(v).Index).Value
                    cmd.Fields("f_quantity").Value = DataGridView1.Item("Column4", DataGridView1.Rows.Item(v).Index).Value
                    cmd.Fields("f_total").Value = DataGridView1.Item("Column5", DataGridView1.Rows.Item(v).Index).Value
                    cmd.Fields("f_waiter").Value = ComboBox1.Text
                    cmd.MoveNext()
                Next v

                Button26.Text = ("P2  ") + TextBox1.Text
                cmd.Close()
            End If
            If Label4.Text = Button24.Text Then
                temp = True
                Dim v, w As New Integer
                w = 0
                For v = 0 To DataGridView1.RowCount - 1
                    ' v = DataGridView1.RowCount
                    w = w + DataGridView1.Item("Column5", DataGridView1.Rows.Item(v).Index).Value
                Next v
                TextBox1.Text = w
                cmd.Open("select * from sales_p3", con, ADODB.CursorTypeEnum.adOpenDynamic, ADODB.LockTypeEnum.adLockOptimistic)
                con.Execute("delete * from sales_p3")
                For v = 0 To DataGridView1.RowCount - 1
                    cmd.AddNew()
                    cmd.Fields("f_item").Value = DataGridView1.Item("Column2", DataGridView1.Rows.Item(v).Index).Value
                    cmd.Fields("f_charges").Value = DataGridView1.Item("Column3", DataGridView1.Rows.Item(v).Index).Value
                    cmd.Fields("f_quantity").Value = DataGridView1.Item("Column4", DataGridView1.Rows.Item(v).Index).Value
                    cmd.Fields("f_total").Value = DataGridView1.Item("Column5", DataGridView1.Rows.Item(v).Index).Value
                    cmd.Fields("f_waiter").Value = ComboBox1.Text
                    cmd.MoveNext()
                Next v

                Button24.Text = ("P3  ") + TextBox1.Text
                cmd.Close()
            End If
            If Label4.Text = Button25.Text Then
                temp = True
                Dim v, w As New Integer
                w = 0
                For v = 0 To DataGridView1.RowCount - 1
                    ' v = DataGridView1.RowCount
                    w = w + DataGridView1.Item("Column5", DataGridView1.Rows.Item(v).Index).Value
                Next v
                ' MsgBox(w)
                TextBox1.Text = w
                cmd.Open("select * from sales_p4", con, ADODB.CursorTypeEnum.adOpenDynamic, ADODB.LockTypeEnum.adLockOptimistic)
                con.Execute("delete * from sales_p4")
                For v = 0 To DataGridView1.RowCount - 1
                    cmd.AddNew()
                    cmd.Fields("f_item").Value = DataGridView1.Item("Column2", DataGridView1.Rows.Item(v).Index).Value
                    cmd.Fields("f_charges").Value = DataGridView1.Item("Column3", DataGridView1.Rows.Item(v).Index).Value
                    cmd.Fields("f_quantity").Value = DataGridView1.Item("Column4", DataGridView1.Rows.Item(v).Index).Value
                    cmd.Fields("f_total").Value = DataGridView1.Item("Column5", DataGridView1.Rows.Item(v).Index).Value
                    cmd.Fields("f_waiter").Value = ComboBox1.Text
                    cmd.MoveNext()
                Next v

                Button25.Text = ("P4  ") + TextBox1.Text
                cmd.Close()
            End If
            If Label4.Text = "10" Then
                temp = True
                Dim v, w As New Integer
                w = 0
                For v = 0 To DataGridView1.RowCount - 1
                    ' v = DataGridView1.RowCount
                    w = w + DataGridView1.Item("Column5", DataGridView1.Rows.Item(v).Index).Value
                Next v
                TextBox1.Text = w
                cmd.Open("select * from sales_p5", con, ADODB.CursorTypeEnum.adOpenDynamic, ADODB.LockTypeEnum.adLockOptimistic)
                con.Execute("delete * from sales_p5")
                For v = 0 To DataGridView1.RowCount - 1
                    cmd.AddNew()
                    cmd.Fields("f_item").Value = DataGridView1.Item("Column2", DataGridView1.Rows.Item(v).Index).Value
                    cmd.Fields("f_charges").Value = DataGridView1.Item("Column3", DataGridView1.Rows.Item(v).Index).Value
                    cmd.Fields("f_quantity").Value = DataGridView1.Item("Column4", DataGridView1.Rows.Item(v).Index).Value
                    cmd.Fields("f_total").Value = DataGridView1.Item("Column5", DataGridView1.Rows.Item(v).Index).Value
                    cmd.Fields("f_waiter").Value = ComboBox1.Text
                    cmd.MoveNext()
                Next v

                Button20.Text = ("10  ") + TextBox1.Text
                cmd.Close()
            End If
            If Label4.Text = "9" Then
                temp = True
                Dim v, w As New Integer
                w = 0
                For v = 0 To DataGridView1.RowCount - 1
                    ' v = DataGridView1.RowCount
                    w = w + DataGridView1.Item("Column5", DataGridView1.Rows.Item(v).Index).Value
                Next v
                TextBox1.Text = w
                cmd.Open("select * from sales_p6", con, ADODB.CursorTypeEnum.adOpenDynamic, ADODB.LockTypeEnum.adLockOptimistic)
                con.Execute("delete * from sales_p6")
                For v = 0 To DataGridView1.RowCount - 1
                    cmd.AddNew()
                    cmd.Fields("f_item").Value = DataGridView1.Item("Column2", DataGridView1.Rows.Item(v).Index).Value
                    cmd.Fields("f_charges").Value = DataGridView1.Item("Column3", DataGridView1.Rows.Item(v).Index).Value
                    cmd.Fields("f_quantity").Value = DataGridView1.Item("Column4", DataGridView1.Rows.Item(v).Index).Value
                    cmd.Fields("f_total").Value = DataGridView1.Item("Column5", DataGridView1.Rows.Item(v).Index).Value
                    cmd.Fields("f_waiter").Value = ComboBox1.Text
                    cmd.MoveNext()
                Next v
                Button21.Text = ("9  ") + TextBox1.Text
                cmd.Close()
            End If
            If Label4.Text = "25" Then
                temp = True
                Dim v, w As New Integer
                w = 0
                For v = 0 To DataGridView1.RowCount - 1
                    ' v = DataGridView1.RowCount
                    w = w + DataGridView1.Item("Column5", DataGridView1.Rows.Item(v).Index).Value
                Next v
                TextBox1.Text = w
                cmd.Open("select * from sales_p7", con, ADODB.CursorTypeEnum.adOpenDynamic, ADODB.LockTypeEnum.adLockOptimistic)
                con.Execute("delete * from sales_p7")
                For v = 0 To DataGridView1.RowCount - 1
                    cmd.AddNew()
                    cmd.Fields("f_item").Value = DataGridView1.Item("Column2", DataGridView1.Rows.Item(v).Index).Value
                    cmd.Fields("f_charges").Value = DataGridView1.Item("Column3", DataGridView1.Rows.Item(v).Index).Value
                    cmd.Fields("f_quantity").Value = DataGridView1.Item("Column4", DataGridView1.Rows.Item(v).Index).Value
                    cmd.Fields("f_total").Value = DataGridView1.Item("Column5", DataGridView1.Rows.Item(v).Index).Value
                    cmd.Fields("f_waiter").Value = ComboBox1.Text
                    cmd.MoveNext()
                Next v

                Button22.Text = ("25  ") + TextBox1.Text
                cmd.Close()
            End If
            If Label4.Text = "24" Then
                temp = True
                Dim v, w As New Integer
                w = 0
                For v = 0 To DataGridView1.RowCount - 1
                    ' v = DataGridView1.RowCount
                    w = w + DataGridView1.Item("Column5", DataGridView1.Rows.Item(v).Index).Value
                Next v
                TextBox1.Text = w
                cmd.Open("select * from sales_p8", con, ADODB.CursorTypeEnum.adOpenDynamic, ADODB.LockTypeEnum.adLockOptimistic)
                con.Execute("delete * from sales_p8")
                For v = 0 To DataGridView1.RowCount - 1
                    cmd.AddNew()
                    cmd.Fields("f_item").Value = DataGridView1.Item("Column2", DataGridView1.Rows.Item(v).Index).Value
                    cmd.Fields("f_charges").Value = DataGridView1.Item("Column3", DataGridView1.Rows.Item(v).Index).Value
                    cmd.Fields("f_quantity").Value = DataGridView1.Item("Column4", DataGridView1.Rows.Item(v).Index).Value
                    cmd.Fields("f_total").Value = DataGridView1.Item("Column5", DataGridView1.Rows.Item(v).Index).Value
                    cmd.Fields("f_waiter").Value = ComboBox1.Text
                    cmd.MoveNext()
                Next v

                Button23.Text = ("24  ") + TextBox1.Text
                cmd.Close()
            End If
            Dim rptDoc As CrystalDecisions.CrystalReports.Engine.ReportDocument
            rptDoc = New CrystalReport2
            rptDoc.SetDataSource(dt)
            rptDoc.PrintToPrinter(1, False, 0, 0)
            g = 0
            Button1.Enabled = False
        End If
    End Sub
    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        g = 0
        If Not Button4.BackColor = Color.DimGray Then
            con.Execute("delete * from sales_gt3")
            ComboBox1.Enabled = True
            ComboBox1.Focus()
            ComboBox1.Text = ""
        Else

            ComboBox1.Enabled = False
            TextBox2.Focus()
        End If
        TextBox1.Text = ""
        TextBox2.Text = ""
        ComboBox2.Text = ""
        i = 1
        If temp = True Then
            DataGridView1.Rows.Clear()
            cmd.Open("select * from sales_gt3", con, ADODB.CursorTypeEnum.adOpenDynamic, ADODB.LockTypeEnum.adLockOptimistic)
            While Not cmd.EOF
                DataGridView1.Rows.Add(Val(i), cmd.Fields("f_item").Value, cmd.Fields("f_charges").Value, cmd.Fields("f_quantity").Value, cmd.Fields("f_total").Value, "E", "X")
                ComboBox1.Text = cmd.Fields("f_waiter").Value
                i = i + 1
                cmd.MoveNext()
            End While
            cmd.Close()
        End If
        Label4.Text = "3"

    End Sub

    Private Sub Button13_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button13.Click
        g = 0
        If Not Button13.BackColor = Color.DimGray Then
            con.Execute("delete * from sales_gt4")
            ComboBox1.Enabled = True
            ComboBox1.Focus()
            ComboBox1.Text = ""
        Else



            ComboBox1.Enabled = False
            TextBox2.Focus()
        End If
        TextBox1.Text = ""
        TextBox2.Text = ""
        ComboBox2.Text = ""
        i = 1
        If temp = True Then
            DataGridView1.Rows.Clear()
            cmd.Open("select * from sales_gt4", con, ADODB.CursorTypeEnum.adOpenDynamic, ADODB.LockTypeEnum.adLockOptimistic)
            While Not cmd.EOF
                DataGridView1.Rows.Add(Val(i), cmd.Fields("f_item").Value, cmd.Fields("f_charges").Value, cmd.Fields("f_quantity").Value, cmd.Fields("f_total").Value, "E", "X")
                ComboBox1.Text = cmd.Fields("f_waiter").Value
                i = i + 1
                cmd.MoveNext()
            End While
            cmd.Close()
        End If
        Label4.Text = "4"

    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        g = 0
        If Not Button5.BackColor = Color.DimGray Then
            con.Execute("delete * from sales_gt5")
            ComboBox1.Enabled = True
            ComboBox1.Focus()
            ComboBox1.Text = ""
        Else



            ComboBox1.Enabled = False
            TextBox2.Focus()
        End If
        TextBox1.Text = ""
        TextBox2.Text = ""
        ComboBox2.Text = ""
        i = 1
        If temp = True Then
            DataGridView1.Rows.Clear()
            cmd.Open("select * from sales_gt5", con, ADODB.CursorTypeEnum.adOpenDynamic, ADODB.LockTypeEnum.adLockOptimistic)
            While Not cmd.EOF
                DataGridView1.Rows.Add(Val(i), cmd.Fields("f_item").Value, cmd.Fields("f_charges").Value, cmd.Fields("f_quantity").Value, cmd.Fields("f_total").Value, "E", "X")
                ComboBox1.Text = cmd.Fields("f_waiter").Value
                i = i + 1
                cmd.MoveNext()
            End While
            cmd.Close()
        End If
        Label4.Text = "5"

    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        g = 0
        If Not Button6.BackColor = Color.DimGray Then
            con.Execute("delete * from sales_gt6")
            ComboBox1.Enabled = True
            ComboBox1.Focus()
            ComboBox1.Text = ""
        Else

            ComboBox1.Enabled = False
            TextBox2.Focus()
        End If
        TextBox1.Text = ""
        TextBox2.Text = ""
        ComboBox2.Text = ""
        i = 1
        If temp = True Then
            DataGridView1.Rows.Clear()
            cmd.Open("select * from sales_gt6", con, ADODB.CursorTypeEnum.adOpenDynamic, ADODB.LockTypeEnum.adLockOptimistic)
            While Not cmd.EOF
                DataGridView1.Rows.Add(Val(i), cmd.Fields("f_item").Value, cmd.Fields("f_charges").Value, cmd.Fields("f_quantity").Value, cmd.Fields("f_total").Value, "E", "X")
                ComboBox1.Text = cmd.Fields("f_waiter").Value
                i = i + 1
                cmd.MoveNext()
            End While
            cmd.Close()
        End If
        Label4.Text = "6"

    End Sub

    Private Sub Button7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button7.Click
        g = 0
        If Not Button7.BackColor = Color.DimGray Then
            con.Execute("delete * from sales_gt7")
            ComboBox1.Enabled = True
            ComboBox1.Focus()
            ComboBox1.Text = ""
        Else

            ComboBox1.Enabled = False
            TextBox2.Focus()
        End If
        TextBox1.Text = ""
        TextBox2.Text = ""
        ComboBox2.Text = ""
        i = 1
        If temp = True Then
            DataGridView1.Rows.Clear()
            cmd.Open("select * from sales_gt7", con, ADODB.CursorTypeEnum.adOpenDynamic, ADODB.LockTypeEnum.adLockOptimistic)
            While Not cmd.EOF
                DataGridView1.Rows.Add(Val(i), cmd.Fields("f_item").Value, cmd.Fields("f_charges").Value, cmd.Fields("f_quantity").Value, cmd.Fields("f_total").Value, "E", "X")
                ComboBox1.Text = cmd.Fields("f_waiter").Value
                i = i + 1
                cmd.MoveNext()
            End While
            cmd.Close()
        End If
        Label4.Text = "7"

    End Sub

    Private Sub Button8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button8.Click
        g = 0
        If Not Button8.BackColor = Color.DimGray Then
            con.Execute("delete * from sales_gt8")
            ComboBox1.Enabled = True
            ComboBox1.Focus()
            ComboBox1.Text = ""
        Else

            ComboBox1.Enabled = False
            TextBox2.Focus()
        End If
        TextBox1.Text = ""
        TextBox2.Text = ""
        ComboBox2.Text = ""
        i = 1
        If temp = True Then
            DataGridView1.Rows.Clear()
            cmd.Open("select * from sales_gt8", con, ADODB.CursorTypeEnum.adOpenDynamic, ADODB.LockTypeEnum.adLockOptimistic)
            While Not cmd.EOF
                DataGridView1.Rows.Add(Val(i), cmd.Fields("f_item").Value, cmd.Fields("f_charges").Value, cmd.Fields("f_quantity").Value, cmd.Fields("f_total").Value, "E", "X")
                ComboBox1.Text = cmd.Fields("f_waiter").Value
                i = i + 1
                cmd.MoveNext()
            End While
            cmd.Close()
        End If
        Label4.Text = "8"

    End Sub

    Private Sub Button19_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button19.Click
        g = 0
        If Not Button19.BackColor = Color.DimGray Then
            con.Execute("delete * from sales_ff1")
            ComboBox1.Enabled = True
            ComboBox1.Focus()
            ComboBox1.Text = ""
        Else

            ComboBox1.Enabled = False
            TextBox2.Focus()
        End If
        TextBox1.Text = ""
        TextBox2.Text = ""
        ComboBox2.Text = ""
        i = 1
        If temp = True Then
            DataGridView1.Rows.Clear()
            cmd.Open("select * from sales_ff1", con, ADODB.CursorTypeEnum.adOpenDynamic, ADODB.LockTypeEnum.adLockOptimistic)
            While Not cmd.EOF
                DataGridView1.Rows.Add(Val(i), cmd.Fields("f_item").Value, cmd.Fields("f_charges").Value, cmd.Fields("f_quantity").Value, cmd.Fields("f_total").Value, "E", "X")
                ComboBox1.Text = cmd.Fields("f_waiter").Value
                i = i + 1
                cmd.MoveNext()
            End While
            cmd.Close()
        End If
        Label4.Text = "16"

    End Sub

    Private Sub Button18_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button18.Click
        g = 0
        If Not Button18.BackColor = Color.DimGray Then
            con.Execute("delete * from sales_ff2")
            ComboBox1.Enabled = True
            ComboBox1.Focus()
            ComboBox1.Text = ""
        Else

            ComboBox1.Enabled = False
            TextBox2.Focus()
        End If
        TextBox2.Text = ""
        ComboBox2.Text = ""
        TextBox1.Text = ""
        i = 1
        If temp = True Then
            DataGridView1.Rows.Clear()
            cmd.Open("select * from sales_ff2", con, ADODB.CursorTypeEnum.adOpenDynamic, ADODB.LockTypeEnum.adLockOptimistic)
            While Not cmd.EOF
                DataGridView1.Rows.Add(Val(i), cmd.Fields("f_item").Value, cmd.Fields("f_charges").Value, cmd.Fields("f_quantity").Value, cmd.Fields("f_total").Value, "E", "X")
                ComboBox1.Text = cmd.Fields("f_waiter").Value
                i = i + 1
                cmd.MoveNext()
            End While
            cmd.Close()
        End If
        Label4.Text = "17"

    End Sub

    Private Sub Button16_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button16.Click
        g = 0
        If Not Button16.BackColor = Color.DimGray Then
            con.Execute("delete * from sales_ff3")
            ComboBox1.Enabled = True
            ComboBox1.Focus()
            ComboBox1.Text = ""
        Else

            ComboBox1.Enabled = False
            TextBox2.Focus()
        End If
        TextBox2.Text = ""
        ComboBox2.Text = ""
        TextBox1.Text = ""
        i = 1
        If temp = True Then
            DataGridView1.Rows.Clear()
            cmd.Open("select * from sales_ff3", con, ADODB.CursorTypeEnum.adOpenDynamic, ADODB.LockTypeEnum.adLockOptimistic)
            While Not cmd.EOF
                DataGridView1.Rows.Add(Val(i), cmd.Fields("f_item").Value, cmd.Fields("f_charges").Value, cmd.Fields("f_quantity").Value, cmd.Fields("f_total").Value, "E", "X")
                ComboBox1.Text = cmd.Fields("f_waiter").Value
                i = i + 1
                cmd.MoveNext()
            End While
            cmd.Close()
        End If
        Label4.Text = "18"

    End Sub

    Private Sub Button17_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button17.Click
        g = 0
        If Not Button17.BackColor = Color.DimGray Then
            con.Execute("delete * from sales_ff4")
            ComboBox1.Enabled = True
            ComboBox1.Focus()
            ComboBox1.Text = ""
        Else

            ComboBox1.Enabled = False
            TextBox2.Focus()
        End If
        TextBox2.Text = ""
        ComboBox2.Text = ""
        TextBox1.Text = ""
        i = 1
        If temp = True Then
            DataGridView1.Rows.Clear()
            cmd.Open("select * from sales_ff4", con, ADODB.CursorTypeEnum.adOpenDynamic, ADODB.LockTypeEnum.adLockOptimistic)
            While Not cmd.EOF
                DataGridView1.Rows.Add(Val(i), cmd.Fields("f_item").Value, cmd.Fields("f_charges").Value, cmd.Fields("f_quantity").Value, cmd.Fields("f_total").Value, "E", "X")
                ComboBox1.Text = cmd.Fields("f_waiter").Value
                i = i + 1
                cmd.MoveNext()
            End While
            cmd.Close()
        End If
        Label4.Text = "19"

    End Sub

    Private Sub Button9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button9.Click
        g = 0
        If Not Button9.BackColor = Color.DimGray Then
            con.Execute("delete * from sales_ff5")
            ComboBox1.Enabled = True
            ComboBox1.Focus()
            ComboBox1.Text = ""
        Else

            ComboBox1.Enabled = False
            TextBox2.Focus()
        End If
        TextBox2.Text = ""
        ComboBox2.Text = ""
        TextBox1.Text = ""
        i = 1
        If temp = True Then
            DataGridView1.Rows.Clear()
            cmd.Open("select * from sales_ff5", con, ADODB.CursorTypeEnum.adOpenDynamic, ADODB.LockTypeEnum.adLockOptimistic)
            While Not cmd.EOF
                DataGridView1.Rows.Add(Val(i), cmd.Fields("f_item").Value, cmd.Fields("f_charges").Value, cmd.Fields("f_quantity").Value, cmd.Fields("f_total").Value, "E", "X")
                ComboBox1.Text = cmd.Fields("f_waiter").Value
                i = i + 1
                cmd.MoveNext()
            End While
            cmd.Close()
        End If
        Label4.Text = "20"

    End Sub

    Private Sub Button10_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button10.Click
        g = 0
        If Not Button10.BackColor = Color.DimGray Then
            con.Execute("delete * from sales_ff6")
            ComboBox1.Enabled = True
            ComboBox1.Focus()
            ComboBox1.Text = ""
        Else

            ComboBox1.Enabled = False
            TextBox2.Focus()
        End If
        TextBox2.Text = ""
        ComboBox2.Text = ""
        TextBox1.Text = ""
        i = 1
        If temp = True Then
            DataGridView1.Rows.Clear()
            cmd.Open("select * from sales_ff6", con, ADODB.CursorTypeEnum.adOpenDynamic, ADODB.LockTypeEnum.adLockOptimistic)
            While Not cmd.EOF
                DataGridView1.Rows.Add(Val(i), cmd.Fields("f_item").Value, cmd.Fields("f_charges").Value, cmd.Fields("f_quantity").Value, cmd.Fields("f_total").Value, "E", "X")
                ComboBox1.Text = cmd.Fields("f_waiter").Value
                i = i + 1
                cmd.MoveNext()
            End While
            cmd.Close()
        End If
        Label4.Text = "21"

    End Sub

    Private Sub Button11_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button11.Click
        g = 0
        If Not Button11.BackColor = Color.DimGray Then
            con.Execute("delete * from sales_ff7")
            ComboBox1.Enabled = True
            ComboBox1.Focus()
            ComboBox1.Text = ""
        Else

            ComboBox1.Enabled = False
            TextBox2.Focus()
        End If
        TextBox2.Text = ""
        ComboBox2.Text = ""
        TextBox1.Text = ""
        i = 1
        If temp = True Then
            DataGridView1.Rows.Clear()
            cmd.Open("select * from sales_ff7", con, ADODB.CursorTypeEnum.adOpenDynamic, ADODB.LockTypeEnum.adLockOptimistic)
            While Not cmd.EOF
                DataGridView1.Rows.Add(Val(i), cmd.Fields("f_item").Value, cmd.Fields("f_charges").Value, cmd.Fields("f_quantity").Value, cmd.Fields("f_total").Value, "E", "X")
                ComboBox1.Text = cmd.Fields("f_waiter").Value
                i = i + 1
                cmd.MoveNext()
            End While
            cmd.Close()
        End If
        Label4.Text = "22"

    End Sub

    Private Sub Button12_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button12.Click
        g = 0
        If Not Button12.BackColor = Color.DimGray Then
            con.Execute("delete * from sales_ff8")
            ComboBox1.Enabled = True
            ComboBox1.Focus()
            ComboBox1.Text = ""
        Else

            ComboBox1.Enabled = False
            TextBox2.Focus()
        End If
        TextBox2.Text = ""
        ComboBox2.Text = ""
        TextBox1.Text = ""
        i = 1
        If temp = True Then
            DataGridView1.Rows.Clear()
            cmd.Open("select * from sales_ff8", con, ADODB.CursorTypeEnum.adOpenDynamic, ADODB.LockTypeEnum.adLockOptimistic)
            While Not cmd.EOF
                DataGridView1.Rows.Add(Val(i), cmd.Fields("f_item").Value, cmd.Fields("f_charges").Value, cmd.Fields("f_quantity").Value, cmd.Fields("f_total").Value, "E", "X")
                ComboBox1.Text = cmd.Fields("f_waiter").Value
                i = i + 1
                cmd.MoveNext()
            End While
            cmd.Close()
        End If
        Label4.Text = "23"

    End Sub

    Private Sub Button27_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button27.Click
        g = 0
        Button1.Enabled = False
        ComboBox1.Text = ""
        ComboBox1.Enabled = False
        If Not Button27.BackColor = Color.DimGray Then
            con.Execute("delete * from sales_p1")

            TextBox2.Focus()
        End If
        TextBox2.Text = ""
        ComboBox2.Text = ""
        TextBox1.Text = ""
        i = 1
        If temp = True Then
            DataGridView1.Rows.Clear()
            cmd.Open("select * from sales_p1", con, ADODB.CursorTypeEnum.adOpenDynamic, ADODB.LockTypeEnum.adLockOptimistic)
            While Not cmd.EOF
                DataGridView1.Rows.Add(Val(i), cmd.Fields("f_item").Value, cmd.Fields("f_charges").Value, cmd.Fields("f_quantity").Value, cmd.Fields("f_total").Value, "E", "X")
                ComboBox1.Text = cmd.Fields("f_waiter").Value
                i = i + 1
                cmd.MoveNext()
            End While
            cmd.Close()
        End If
        Label4.Text = "P1"

    End Sub

    Private Sub Button26_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button26.Click
        g = 0
        Button1.Enabled = False
        ComboBox1.Text = ""
        ComboBox1.Enabled = False
        If Not Button26.BackColor = Color.DimGray Then
            con.Execute("delete * from sales_p2")

            TextBox2.Focus()
        End If
        TextBox2.Text = ""
        ComboBox2.Text = ""
        TextBox1.Text = ""
        i = 1
        If temp = True Then
            DataGridView1.Rows.Clear()
            cmd.Open("select * from sales_p2", con, ADODB.CursorTypeEnum.adOpenDynamic, ADODB.LockTypeEnum.adLockOptimistic)
            While Not cmd.EOF
                DataGridView1.Rows.Add(Val(i), cmd.Fields("f_item").Value, cmd.Fields("f_charges").Value, cmd.Fields("f_quantity").Value, cmd.Fields("f_total").Value, "E", "X")
                ComboBox1.Text = cmd.Fields("f_waiter").Value
                i = i + 1
                cmd.MoveNext()
            End While
            cmd.Close()
        End If
        Label4.Text = "P2"

    End Sub

    Private Sub Button24_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button24.Click
        g = 0
        Button1.Enabled = False
        ComboBox1.Text = ""
        ComboBox1.Enabled = False
        If Not Button24.BackColor = Color.DimGray Then
            con.Execute("delete * from sales_p3")

            TextBox2.Focus()
        End If
        TextBox2.Text = ""
        ComboBox2.Text = ""
        TextBox1.Text = ""
        i = 1
        If temp = True Then
            DataGridView1.Rows.Clear()
            cmd.Open("select * from sales_p3", con, ADODB.CursorTypeEnum.adOpenDynamic, ADODB.LockTypeEnum.adLockOptimistic)
            While Not cmd.EOF
                DataGridView1.Rows.Add(Val(i), cmd.Fields("f_item").Value, cmd.Fields("f_charges").Value, cmd.Fields("f_quantity").Value, cmd.Fields("f_total").Value, "E", "X")
                ComboBox1.Text = cmd.Fields("f_waiter").Value
                i = i + 1
                cmd.MoveNext()
            End While
            cmd.Close()
        End If
        Label4.Text = "P3"

    End Sub

    Private Sub Button25_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button25.Click
        g = 0
        Button1.Enabled = False
        ComboBox1.Text = ""
        ComboBox1.Enabled = False
        If Not Button25.BackColor = Color.DimGray Then
            con.Execute("delete * from sales_p4")

            TextBox2.Focus()
        End If
        TextBox2.Text = ""
        ComboBox2.Text = ""
        TextBox1.Text = ""
        i = 1
        If temp = True Then
            DataGridView1.Rows.Clear()
            cmd.Open("select * from sales_p4", con, ADODB.CursorTypeEnum.adOpenDynamic, ADODB.LockTypeEnum.adLockOptimistic)
            While Not cmd.EOF
                DataGridView1.Rows.Add(Val(i), cmd.Fields("f_item").Value, cmd.Fields("f_charges").Value, cmd.Fields("f_quantity").Value, cmd.Fields("f_total").Value, "E", "X")
                ComboBox1.Text = cmd.Fields("f_waiter").Value
                i = i + 1
                cmd.MoveNext()
            End While
            cmd.Close()
        End If
        Label4.Text = "P4"

    End Sub

    Private Sub Button20_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button20.Click
        g = 0
        If Not Button20.BackColor = Color.DimGray Then
            ComboBox1.Enabled = True
            ComboBox1.Focus()
            ComboBox1.Text = ""
            con.Execute("delete * from sales_p5")
        Else

            ComboBox1.Enabled = False
            TextBox2.Focus()
        End If
        TextBox2.Text = ""
        ComboBox2.Text = ""
        TextBox1.Text = ""
        i = 1
        If temp = True Then
            DataGridView1.Rows.Clear()
            cmd.Open("select * from sales_p5", con, ADODB.CursorTypeEnum.adOpenDynamic, ADODB.LockTypeEnum.adLockOptimistic)
            While Not cmd.EOF
                DataGridView1.Rows.Add(Val(i), cmd.Fields("f_item").Value, cmd.Fields("f_charges").Value, cmd.Fields("f_quantity").Value, cmd.Fields("f_total").Value, "E", "X")
                ComboBox1.Text = cmd.Fields("f_waiter").Value
                i = i + 1
                cmd.MoveNext()
            End While
            cmd.Close()
        End If
        Label4.Text = "10"

    End Sub

    Private Sub Button21_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button21.Click
        g = 0
        If Not Button21.BackColor = Color.DimGray Then
            ComboBox1.Enabled = True
            ComboBox1.Focus()
            con.Execute("delete * from sales_p6")
            ComboBox1.Text = ""
        Else

            ComboBox1.Enabled = False
            TextBox2.Focus()
        End If
        TextBox2.Text = ""
        ComboBox2.Text = ""
        TextBox1.Text = ""
        i = 1
        If temp = True Then
            DataGridView1.Rows.Clear()
            cmd.Open("select * from sales_p6", con, ADODB.CursorTypeEnum.adOpenDynamic, ADODB.LockTypeEnum.adLockOptimistic)
            While Not cmd.EOF
                DataGridView1.Rows.Add(Val(i), cmd.Fields("f_item").Value, cmd.Fields("f_charges").Value, cmd.Fields("f_quantity").Value, cmd.Fields("f_total").Value, "E", "X")
                ComboBox1.Text = cmd.Fields("f_waiter").Value
                i = i + 1
                cmd.MoveNext()
            End While
            cmd.Close()
        End If
        Label4.Text = "9"

    End Sub

    Private Sub Button22_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button22.Click
        g = 0
        If Not Button22.BackColor = Color.DimGray Then
            con.Execute("delete * from sales_p7")
            ComboBox1.Enabled = True
            ComboBox1.Focus()
            ComboBox1.Text = ""
        Else

            ComboBox1.Enabled = False
            TextBox2.Focus()
        End If
        TextBox2.Text = ""
        ComboBox2.Text = ""
        TextBox1.Text = ""
        i = 1
        If temp = True Then
            DataGridView1.Rows.Clear()
            cmd.Open("select * from sales_p7", con, ADODB.CursorTypeEnum.adOpenDynamic, ADODB.LockTypeEnum.adLockOptimistic)
            While Not cmd.EOF
                DataGridView1.Rows.Add(Val(i), cmd.Fields("f_item").Value, cmd.Fields("f_charges").Value, cmd.Fields("f_quantity").Value, cmd.Fields("f_total").Value, "E", "X")
                ComboBox1.Text = cmd.Fields("f_waiter").Value
                i = i + 1
                cmd.MoveNext()
            End While
            cmd.Close()
        End If
        Label4.Text = "25"

    End Sub

    Private Sub Button23_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button23.Click
        g = 0
        If Not Button23.BackColor = Color.DimGray Then
            con.Execute("delete * from sales_p8")
            ComboBox1.Enabled = True
            ComboBox1.Focus()
            ComboBox1.Text = ""
        Else

            ComboBox1.Enabled = False
            TextBox2.Focus()
        End If
        TextBox2.Text = ""
        ComboBox2.Text = ""
        TextBox1.Text = ""
        i = 1
        If temp = True Then
            DataGridView1.Rows.Clear()
            cmd.Open("select * from sales_p8", con, ADODB.CursorTypeEnum.adOpenDynamic, ADODB.LockTypeEnum.adLockOptimistic)
            While Not cmd.EOF
                DataGridView1.Rows.Add(Val(i), cmd.Fields("f_item").Value, cmd.Fields("f_charges").Value, cmd.Fields("f_quantity").Value, cmd.Fields("f_total").Value, "E", "X")
                ComboBox1.Text = cmd.Fields("f_waiter").Value
                i = i + 1
                cmd.MoveNext()
            End While
            cmd.Close()
        End If
        Label4.Text = "24"

    End Sub
    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        g = g + 1
        Button1.Enabled = True
        If (Label4.Text = Button15.Text) Then
            Button15.BackColor = Color.DimGray
        End If
        If (Label4.Text = Button14.Text) Then
            Button14.BackColor = Color.DimGray
        End If
        If (Label4.Text = Button4.Text) Then
            Button4.BackColor = Color.DimGray
        End If
        If (Label4.Text = Button13.Text) Then
            Button13.BackColor = Color.DimGray
        End If
        If (Label4.Text = Button5.Text) Then
            Button5.BackColor = Color.DimGray
        End If
        If (Label4.Text = Button6.Text) Then
            Button6.BackColor = Color.DimGray
        End If
        If (Label4.Text = Button7.Text) Then
            Button7.BackColor = Color.DimGray
        End If
        If (Label4.Text = Button8.Text) Then
            Button8.BackColor = Color.DimGray
        End If
        If (Label4.Text = Button19.Text) Then
            Button19.BackColor = Color.DimGray
        End If
        If (Label4.Text = Button18.Text) Then
            Button18.BackColor = Color.DimGray
        End If
        If (Label4.Text = Button16.Text) Then
            Button16.BackColor = Color.DimGray
        End If
        If (Label4.Text = Button17.Text) Then
            Button17.BackColor = Color.DimGray
        End If
        If (Label4.Text = Button9.Text) Then
            Button9.BackColor = Color.DimGray
        End If
        If (Label4.Text = Button10.Text) Then
            Button10.BackColor = Color.DimGray
        End If
        If (Label4.Text = Button11.Text) Then
            Button11.BackColor = Color.DimGray
        End If
        If (Label4.Text = Button12.Text) Then
            Button12.BackColor = Color.DimGray
        End If
        If (Label4.Text = Button27.Text) Then
            Button27.BackColor = Color.DimGray
            Button1.Enabled = False
        End If
        If (Label4.Text = Button26.Text) Then
            Button26.BackColor = Color.DimGray
            Button1.Enabled = False
        End If
        If (Label4.Text = Button24.Text) Then
            Button24.BackColor = Color.DimGray
            Button1.Enabled = False
        End If
        If (Label4.Text = Button25.Text) Then
            Button25.BackColor = Color.DimGray
            Button1.Enabled = False
        End If
        If (Label4.Text = Button20.Text) Then
            Button20.BackColor = Color.DimGray
        End If
        If (Label4.Text = Button21.Text) Then
            Button21.BackColor = Color.DimGray
        End If
        If (Label4.Text = Button22.Text) Then
            Button22.BackColor = Color.DimGray
        End If
        If (Label4.Text = Button23.Text) Then
            Button23.BackColor = Color.DimGray
        End If
        If (Label4.Text = Button2.Text) Then
            Button2.BackColor = Color.DimGray
        End If
        If (Label4.Text = Button32.Text) Then
            Button32.BackColor = Color.DimGray
        End If
        If (Label4.Text = Button33.Text) Then
            Button33.BackColor = Color.DimGray
        End If
        If (Label4.Text = Button34.Text) Then
            Button34.BackColor = Color.DimGray
        End If
        If (Label4.Text = Button35.Text) Then
            Button35.BackColor = Color.DimGray
        End If
        If (Label4.Text = Button36.Text) Then
            Button36.BackColor = Color.DimGray
        End If
        If (Label4.Text = Button37.Text) Then
            Button37.BackColor = Color.DimGray
        End If
        If (Label4.Text = Button38.Text) Then
            Button38.BackColor = Color.DimGray
        End If
        If (Label4.Text = Button39.Text) Then
            Button39.BackColor = Color.DimGray
        End If
        If (Label4.Text = Button40.Text) Then
            Button40.BackColor = Color.DimGray
        End If
        If (Label4.Text = Button41.Text) Then
            Button40.BackColor = Color.DimGray
            Button1.Enabled = False
        End If

        cmd3.Open("select f_rate from food_details where f_name='" & ComboBox2.Text & "'", con, ADODB.CursorTypeEnum.adOpenDynamic, ADODB.LockTypeEnum.adLockOptimistic)
        rate = cmd3.Fields("f_rate").Value
        amount = rate * TextBox5.Text
        DataGridView1.Rows.Add(Val(i), ComboBox2.Text, rate, TextBox5.Text, amount, "E", "X")
        ComboBox2.SelectedText = ""
        i = i + 1
        cmd3.Close()
    End Sub
    Private Sub DataGridView1_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        Dim b As New Integer
        Dim a As String
        If (DataGridView1.Item("Column6", DataGridView1.CurrentRow.Index).Selected) Then
n:          a = InputBox("Enter Quantity")
            If a = "" Then
                MsgBox("Enter Quantity")
                GoTo n
            End If

            amount = a * DataGridView1.Item("Column3", DataGridView1.CurrentRow.Index).Value
            DataGridView1.Item("Column4", DataGridView1.CurrentRow.Index).Value = a
            DataGridView1.Item("Column5", DataGridView1.CurrentRow.Index).Value = amount
        End If
        If (DataGridView1.Item("Column7", DataGridView1.CurrentRow.Index).Selected) Then
            If Not (DataGridView1.Item("Column7", DataGridView1.CurrentRow.Index).Selected) = DataGridView1.RowCount - 1 Then
                g = g + 1
            End If
            DataGridView1.Rows.Remove(DataGridView1.CurrentRow)

            If (Not g = 0) Then
                g = g - 1
            End If
        End If
    End Sub


    Private Sub Button29_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button29.Click
       
        If DataGridView1.RowCount = 0 Then
            MsgBox("No Item")
            Button1.Enabled = False
        Else
            If Not Label6.Text = Date.Today.Date.ToString Then
                TextBox3.Text = Val(TextBox3.Text) + 1
                cmd.Open("select * from bill_number", con, ADODB.CursorTypeEnum.adOpenDynamic, ADODB.LockTypeEnum.adLockOptimistic)
                cmd2.Open("select * from bill_no", con, ADODB.CursorTypeEnum.adOpenDynamic, ADODB.LockTypeEnum.adLockOptimistic)
                cmd2.AddNew()
                cmd2.Fields("bill").Value = cmd.Fields("bill").Value
                cmd2.Fields("std").Value = cmd.Fields("std").Value
                cmd2.Update()
                cmd2.Close()
                cmd.Fields("bill").Value = cmd.Fields("bill").Value + 1
                cmd.Fields("std").Value = Date.Today
                Label6.Text = Date.Today
                cmd.Update()
                cmd.Close()
            Else
                TextBox3.Text = Val(TextBox3.Text) + 1
                cmd.Open("select * from bill_number", con, ADODB.CursorTypeEnum.adOpenDynamic, ADODB.LockTypeEnum.adLockOptimistic)
                cmd.Fields("bill").Value = TextBox3.Text
                cmd.Update()
                cmd.Close()
            End If
            cmd.Open("select * from report", con, ADODB.CursorTypeEnum.adOpenDynamic, ADODB.LockTypeEnum.adLockOptimistic)
            For v = 0 To DataGridView1.RowCount - 1
                cmd.AddNew()
                cmd.Fields("r_item").Value = DataGridView1.Item("Column2", DataGridView1.Rows.Item(v).Index).Value
                cmd.Fields("r_quantity").Value = DataGridView1.Item("Column4", DataGridView1.Rows.Item(v).Index).Value
                cmd.Fields("r_total").Value = DataGridView1.Item("Column5", DataGridView1.Rows.Item(v).Index).Value
                cmd.Fields("r_date").Value = Label6.Text
                cmd.Fields("r_tabno").Value = Label4.Text
                cmd.Fields("r_bill").Value = TextBox3.Text

                cmd.Fields("r_time").Value = Label13.Text
                cmd.Fields("r_no").Value = DataGridView1.Item("Column1", DataGridView1.Rows.Item(v).Index).Value
                cmd.MoveNext()
            Next v
            cmd.Update()
            cmd.Close()
            Dim y, w, h As New Integer
            w = 0
            For y = 0 To DataGridView1.RowCount - 1
                w = w + DataGridView1.Item("Column5", DataGridView1.Rows.Item(y).Index).Value
            Next y
            TextBox1.Text = w
            DataGridView2.Rows.Add(TextBox3.Text, Label4.Text, ComboBox1.Text, TextBox1.Text, "Update")
            cmd.Open("select * from uptdate", con, ADODB.CursorTypeEnum.adOpenDynamic, ADODB.LockTypeEnum.adLockOptimistic)
            cmd.AddNew()
            cmd.Fields("bill").Value = TextBox3.Text
            cmd.Fields("table").Value = Label4.Text
            cmd.Fields("waiter").Value = ComboBox1.Text
            cmd.Fields("amt").Value = TextBox1.Text
            cmd.Update()
            cmd.Close()
            'reprint.Visible = True
            If (Label4.Text = "1") Then
                Button15.BackColor = Color.Gainsboro
                con.Execute("delete * from sales")
                Button15.Text = "1"
            End If
            If (Label4.Text = "2") Then
                Button14.BackColor = Color.Gainsboro
                con.Execute("delete * from sales_gt2")
                Button14.Text = "2"
            End If
            If (Label4.Text = "3") Then
                Button4.BackColor = Color.Gainsboro
                con.Execute("delete * from sales_gt3")
                Button4.Text = "3"
            End If
            If (Label4.Text = "4") Then
                Button13.BackColor = Color.Gainsboro
                con.Execute("delete * from sales_gt4")
                Button13.Text = "4"
            End If
            If (Label4.Text = "5") Then
                Button5.BackColor = Color.Gainsboro
                con.Execute("delete * from sales_gt5")
                Button5.Text = "5"
            End If
            If (Label4.Text = "6") Then
                Button6.BackColor = Color.Gainsboro
                con.Execute("delete * from sales_gt6")
                Button6.Text = "6"
            End If
            If (Label4.Text = "7") Then
                Button7.BackColor = Color.Gainsboro
                con.Execute("delete * from sales_gt7")
                Button7.Text = "7"
            End If
            If (Label4.Text = "8") Then
                Button8.BackColor = Color.Gainsboro
                con.Execute("delete * from sales_gt8")
                Button8.Text = "8"
            End If
            If (Label4.Text = "16") Then
                Button19.BackColor = Color.Gainsboro
                con.Execute("delete * from sales_ff1")
                Button19.Text = "16"
            End If
            If (Label4.Text = "17") Then
                Button18.BackColor = Color.Gainsboro
                con.Execute("delete * from sales_ff2")
                Button18.Text = "17"
            End If
            If (Label4.Text = "18") Then
                Button16.BackColor = Color.Gainsboro
                con.Execute("delete * from sales_ff3")
                Button16.Text = "18"
            End If
            If (Label4.Text = "19") Then
                Button17.BackColor = Color.Gainsboro
                con.Execute("delete * from sales_ff4")
                Button17.Text = "19"
            End If
            If (Label4.Text = "20") Then
                Button9.BackColor = Color.Gainsboro
                con.Execute("delete * from sales_ff5")
                Button9.Text = "20"
            End If
            If (Label4.Text = "21") Then
                Button10.BackColor = Color.Gainsboro
                con.Execute("delete * from sales_ff6")
                Button10.Text = "21"
            End If
            If (Label4.Text = "22") Then
                Button11.BackColor = Color.Gainsboro
                con.Execute("delete * from sales_ff7")
                Button11.Text = "22"
            End If
            If (Label4.Text = "23") Then
                Button12.BackColor = Color.Gainsboro
                con.Execute("delete * from sales_ff8")
                Button12.Text = "23"
            End If
            If (Label4.Text = "P1") Then
                Button27.BackColor = Color.Gainsboro
                Button27.Text = "P1"
            End If
            If (Label4.Text = "P2") Then
                Button26.BackColor = Color.Gainsboro
                Button26.Text = "P2"
            End If
            If (Label4.Text = "P3") Then
                Button24.BackColor = Color.Gainsboro
                Button24.Text = "P3"
            End If
            If (Label4.Text = "P4") Then
                Button25.BackColor = Color.Gainsboro
                Button25.Text = "P4"
            End If
            If (Label4.Text = "10") Then
                Button20.BackColor = Color.Gainsboro
                con.Execute("delete * from sales_p5")
                Button20.Text = "10"
            End If
            If (Label4.Text = "9") Then
                Button21.BackColor = Color.Gainsboro
                con.Execute("delete * from sales_p6")
                Button21.Text = "9"
            End If
            If (Label4.Text = "25") Then
                Button22.BackColor = Color.Gainsboro
                con.Execute("delete * from sales_p7")
                Button22.Text = "25"
            End If
            If (Label4.Text = "24") Then
                Button23.BackColor = Color.Gainsboro
                con.Execute("delete * from sales_p8")
                Button23.Text = "24"
            End If
            If (Label4.Text = "11") Then
                Button2.BackColor = Color.Gainsboro
                con.Execute("delete * from sales_gt11")
                Button2.Text = "11"
            End If
            If (Label4.Text = "12") Then
                Button32.BackColor = Color.Gainsboro
                con.Execute("delete * from sales_gt12")
                Button32.Text = "12"
            End If
            If (Label4.Text = "13") Then
                Button33.BackColor = Color.Gainsboro
                con.Execute("delete * from sales_gt13")
                Button33.Text = "13"
            End If
            If (Label4.Text = "14") Then
                Button34.BackColor = Color.Gainsboro
                con.Execute("delete * from sales_gt14")
                Button34.Text = "14"
            End If
            If (Label4.Text = "15") Then
                Button35.BackColor = Color.Gainsboro
                con.Execute("delete * from sales_gt15")
                Button35.Text = "15"
            End If
            If (Label4.Text = "26") Then
                Button36.BackColor = Color.Gainsboro
                con.Execute("delete * from sales_ff11")
                Button36.Text = "26"
            End If
            If (Label4.Text = "27") Then
                Button37.BackColor = Color.Gainsboro
                con.Execute("delete * from sales_ff12")
                Button37.Text = "27"
            End If
            If (Label4.Text = "28") Then
                Button38.BackColor = Color.Gainsboro
                con.Execute("delete * from sales_ff13")
                Button38.Text = "28"
            End If
            If (Label4.Text = "29") Then
                Button39.BackColor = Color.Gainsboro
                con.Execute("delete * from sales_ff14")
                Button39.Text = "29"
            End If
            If (Label4.Text = "30") Then
                Button40.BackColor = Color.Gainsboro
                con.Execute("delete * from sales_ff15")
                Button40.Text = "30"
            End If
            If (Label4.Text = "P5") Then
                Button41.BackColor = Color.Gainsboro
                Button41.Text = "P5"
            End If
            Me.DataGridView1.Sort(Me.DataGridView1.Columns(1), System.ComponentModel.ListSortDirection.Ascending)
            Dim dt As New DataTable
            With dt
                .Columns.Add("Bill")
                .Columns.Add("Waiter")
                .Columns.Add("Table")
                .Columns.Add("Items")
                .Columns.Add("Qty")
                .Columns.Add("Amount")
            End With
            For Each dr As DataGridViewRow In Me.DataGridView1.Rows
                dt.Rows.Add(Me.TextBox3.Text, Me.ComboBox1.Text, Me.Label4.Text, dr.Cells(1).Value, dr.Cells(3).Value, dr.Cells(4).Value)
            Next
            Dim rptDoc As CrystalDecisions.CrystalReports.Engine.ReportDocument
            rptDoc = New CrystalReport1
            rptDoc.SetDataSource(dt)
            rptDoc.PrintToPrinter(1, False, 0, 0)
            Me.TextBox1.Text = ""
            Me.TextBox2.Text = ""
            Me.Label4.Text = ""
            Me.ComboBox1.Text = ""
            Me.ComboBox2.Text = ""
            Me.Label4.Text = ""
            DataGridView1.Rows.Clear()
            main.Enabled = True
            'reprint.Close()
            g = 0
        End If
    End Sub
    Private Sub Button31_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button31.Click
        cmd.Open("select f_name from food_details where f_srn='" & TextBox2.Text & "'", con, ADODB.CursorTypeEnum.adOpenDynamic, ADODB.LockTypeEnum.adLockOptimistic)
        If cmd.EOF Or cmd.BOF Then
            MsgBox("Invalid Item Number")
            cmd.Close()
        Else
            ComboBox2.Text = cmd.Fields("f_name").Value
        End If
        cmd.Close()
    End Sub
    Private Sub TextBox2_PreviewKeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.PreviewKeyDownEventArgs) Handles TextBox2.PreviewKeyDown

        If e.KeyCode = Keys.Enter Then
            cmd.Open("select f_name from food_details where f_srn='" & TextBox2.Text & "'", con, ADODB.CursorTypeEnum.adOpenDynamic, ADODB.LockTypeEnum.adLockOptimistic)
            If cmd.EOF Or cmd.BOF Then
                MsgBox("Invalid Item Number")
                cmd.Close()
            Else
                ComboBox2.Text = cmd.Fields("f_name").Value
                TextBox5.Focus()
                cmd.Close()
            End If
        End If
    End Sub
    Private Sub ComboBox2_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox2.SelectedIndexChanged
        TextBox4.Text = ComboBox2.Text
        Button3.Focus()
    End Sub

    Private Sub DataGridView2_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs)
        If (DataGridView2.Item("Column8", DataGridView2.CurrentRow.Index).Selected) Then
            DataGridView2.Rows.Remove(DataGridView2.CurrentRow)
            MsgBox("Submitted")
        End If
    End Sub
    Private Sub TextBox5_PreviewKeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.PreviewKeyDownEventArgs) Handles TextBox5.PreviewKeyDown

        If e.KeyCode = Keys.Decimal Or TextBox5.Text = "." Then
            TextBox5.Text = ""
            MsgBox("Fill Quantity properly.")
            TextBox5.Focus()
            TextBox5.Text = ""
        End If

        If e.KeyCode = Keys.Enter Then
            If TextBox5.Text = "" Or Not IsNumeric(TextBox5.Text) Or TextBox5.Text = "." Then
                TextBox5.Text = ""
                'MsgBox("Fill Quantity properly.")
                TextBox5.Text = ""
                TextBox5.Focus()

            Else

                g = g + 1
                Button1.Enabled = True
                If (Label4.Text = Button2.Text) Then
                    Button2.BackColor = Color.DimGray
                End If
                If (Label4.Text = Button32.Text) Then
                    Button32.BackColor = Color.DimGray
                End If
                If (Label4.Text = Button33.Text) Then
                    Button33.BackColor = Color.DimGray
                End If
                If (Label4.Text = Button34.Text) Then
                    Button34.BackColor = Color.DimGray
                End If
                If (Label4.Text = Button35.Text) Then
                    Button35.BackColor = Color.DimGray
                End If
                If (Label4.Text = Button36.Text) Then
                    Button36.BackColor = Color.DimGray
                End If
                If (Label4.Text = Button37.Text) Then
                    Button37.BackColor = Color.DimGray
                End If
                If (Label4.Text = Button38.Text) Then
                    Button38.BackColor = Color.DimGray
                End If
                If (Label4.Text = Button39.Text) Then
                    Button39.BackColor = Color.DimGray
                End If
                If (Label4.Text = Button40.Text) Then
                    Button40.BackColor = Color.DimGray
                End If

                If (Label4.Text = Button15.Text) Then
                    Button15.BackColor = Color.DimGray
                End If
                If (Label4.Text = Button14.Text) Then
                    Button14.BackColor = Color.DimGray
                End If
                If (Label4.Text = Button4.Text) Then
                    Button4.BackColor = Color.DimGray
                End If
                If (Label4.Text = Button13.Text) Then
                    Button13.BackColor = Color.DimGray
                End If
                If (Label4.Text = Button5.Text) Then
                    Button5.BackColor = Color.DimGray
                End If
                If (Label4.Text = Button6.Text) Then
                    Button6.BackColor = Color.DimGray
                End If
                If (Label4.Text = Button7.Text) Then
                    Button7.BackColor = Color.DimGray
                End If
                If (Label4.Text = Button8.Text) Then
                    Button8.BackColor = Color.DimGray
                End If
                If (Label4.Text = Button19.Text) Then
                    Button19.BackColor = Color.DimGray
                End If
                If (Label4.Text = Button18.Text) Then
                    Button18.BackColor = Color.DimGray
                End If
                If (Label4.Text = Button16.Text) Then
                    Button16.BackColor = Color.DimGray
                End If
                If (Label4.Text = Button17.Text) Then
                    Button17.BackColor = Color.DimGray
                End If
                If (Label4.Text = Button9.Text) Then
                    Button9.BackColor = Color.DimGray
                End If
                If (Label4.Text = Button10.Text) Then
                    Button10.BackColor = Color.DimGray
                End If
                If (Label4.Text = Button11.Text) Then
                    Button11.BackColor = Color.DimGray
                End If
                If (Label4.Text = Button12.Text) Then
                    Button12.BackColor = Color.DimGray
                End If
                If (Label4.Text = Button20.Text) Then
                    Button20.BackColor = Color.DimGray
                End If
                If (Label4.Text = Button21.Text) Then
                    Button21.BackColor = Color.DimGray
                End If
                If (Label4.Text = Button22.Text) Then
                    Button22.BackColor = Color.DimGray
                End If
                If (Label4.Text = Button23.Text) Then
                    Button23.BackColor = Color.DimGray
                End If

                cmd3.Open("select f_rate from food_details where f_name='" & ComboBox2.Text & "'", con, ADODB.CursorTypeEnum.adOpenDynamic, ADODB.LockTypeEnum.adLockOptimistic)
                rate = cmd3.Fields("f_rate").Value
                amount = rate * Val(TextBox5.Text)
                DataGridView1.Rows.Add(Val(i), ComboBox2.Text, rate, TextBox5.Text, amount, "E", "X")
                If (Label4.Text = Button41.Text) Then
                    Button41.BackColor = Color.DimGray
                    Dim v, w As New Integer
                    w = 0

                    For v = 0 To DataGridView1.RowCount - 1
                        w = w + DataGridView1.Item("Column5", DataGridView1.Rows.Item(v).Index).Value
                    Next v

                    TextBox1.Text = w
                    Button1.Enabled = False
                End If
                If (Label4.Text = Button27.Text) Then
                    Button27.BackColor = Color.DimGray
                    Dim v, w As New Integer
                    w = 0

                    For v = 0 To DataGridView1.RowCount - 1
                        w = w + DataGridView1.Item("Column5", DataGridView1.Rows.Item(v).Index).Value
                    Next v

                    TextBox1.Text = w
                    Button1.Enabled = False
                End If
                If (Label4.Text = Button26.Text) Then
                    Button26.BackColor = Color.DimGray
                    Dim v, w As New Integer
                    w = 0

                    For v = 0 To DataGridView1.RowCount - 1
                        w = w + DataGridView1.Item("Column5", DataGridView1.Rows.Item(v).Index).Value
                    Next v

                    TextBox1.Text = w
                    Button1.Enabled = False
                End If
                If (Label4.Text = Button24.Text) Then
                    Button24.BackColor = Color.DimGray
                    Dim v, w As New Integer
                    w = 0

                    For v = 0 To DataGridView1.RowCount - 1
                        w = w + DataGridView1.Item("Column5", DataGridView1.Rows.Item(v).Index).Value
                    Next v

                    TextBox1.Text = w
                    Button1.Enabled = False
                End If
                If (Label4.Text = Button25.Text) Then
                    Button25.BackColor = Color.DimGray
                    Dim v, w As New Integer
                    w = 0

                    For v = 0 To DataGridView1.RowCount - 1
                        w = w + DataGridView1.Item("Column5", DataGridView1.Rows.Item(v).Index).Value
                    Next v

                    TextBox1.Text = w
                    Button1.Enabled = False
                End If

                ComboBox2.SelectedText = ""
                i = i + 1
                cmd3.Close()
                TextBox2.Text = ""
                TextBox4.Text = ""
                TextBox5.Text = ""

                ComboBox2.Text = ""
                TextBox2.Focus()
            End If
        End If
    End Sub

    Private Sub TextBox2_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox2.TextChanged
        If Label4.Text = "" Then
            MsgBox("Select Table")
            TextBox2.Text = ""
        End If
    End Sub
    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        g = 0
        If Not Button2.BackColor = Color.DimGray Then
            con.Execute("delete * from sales_gt11")
            ComboBox1.Enabled = True
            ComboBox1.Focus()
            ComboBox1.Text = ""
        Else

            ComboBox1.Enabled = False
            TextBox2.Focus()
        End If
        'TextBox2.Focus()
        TextBox1.Text = ""
        TextBox2.Text = ""
        ComboBox2.Text = ""
        i = 1
        If temp = True Then
            DataGridView1.Rows.Clear()
            cmd.Open("select * from sales_gt11", con, ADODB.CursorTypeEnum.adOpenDynamic, ADODB.LockTypeEnum.adLockOptimistic)

            While Not cmd.EOF
                DataGridView1.Rows.Add(Val(i), cmd.Fields("f_item").Value, cmd.Fields("f_charges").Value, cmd.Fields("f_quantity").Value, cmd.Fields("f_total").Value, "E", "X")
                ComboBox1.Text = cmd.Fields("f_waiter").Value
                i = i + 1
                cmd.MoveNext()
            End While
            cmd.Close()
        End If
        Label4.Text = "11"
    End Sub

    Private Sub Button32_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button32.Click
        g = 0
        If Not Button32.BackColor = Color.DimGray Then
            con.Execute("delete * from sales_gt12")
            ComboBox1.Enabled = True
            ComboBox1.Focus()
            ComboBox1.Text = ""
        Else

            ComboBox1.Enabled = False
            TextBox2.Focus()
        End If
        TextBox1.Text = ""
        TextBox2.Text = ""
        ComboBox2.Text = ""
        i = 1
        If temp = True Then
            DataGridView1.Rows.Clear()
            cmd.Open("select * from sales_gt12", con, ADODB.CursorTypeEnum.adOpenDynamic, ADODB.LockTypeEnum.adLockOptimistic)

            While Not cmd.EOF
                DataGridView1.Rows.Add(Val(i), cmd.Fields("f_item").Value, cmd.Fields("f_charges").Value, cmd.Fields("f_quantity").Value, cmd.Fields("f_total").Value, "E", "X")
                ComboBox1.Text = cmd.Fields("f_waiter").Value
                i = i + 1
                cmd.MoveNext()
            End While
            cmd.Close()
        End If
        Label4.Text = "12"
    End Sub

    Private Sub Button33_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button33.Click
        g = 0
        If Not Button33.BackColor = Color.DimGray Then
            con.Execute("delete * from sales_gt13")
            ComboBox1.Enabled = True
            ComboBox1.Focus()
            ComboBox1.Text = ""
        Else

            ComboBox1.Enabled = False
            TextBox2.Focus()
        End If
        TextBox1.Text = ""
        TextBox2.Text = ""
        ComboBox2.Text = ""
        i = 1
        If temp = True Then
            DataGridView1.Rows.Clear()
            cmd.Open("select * from sales_gt13", con, ADODB.CursorTypeEnum.adOpenDynamic, ADODB.LockTypeEnum.adLockOptimistic)

            While Not cmd.EOF
                DataGridView1.Rows.Add(Val(i), cmd.Fields("f_item").Value, cmd.Fields("f_charges").Value, cmd.Fields("f_quantity").Value, cmd.Fields("f_total").Value, "E", "X")
                ComboBox1.Text = cmd.Fields("f_waiter").Value
                i = i + 1
                cmd.MoveNext()
            End While
            cmd.Close()
        End If
        Label4.Text = "13"
    End Sub

    Private Sub Button34_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button34.Click
        g = 0
        If Not Button34.BackColor = Color.DimGray Then
            con.Execute("delete * from sales_gt14")
            ComboBox1.Enabled = True
            ComboBox1.Focus()
            ComboBox1.Text = ""
        Else

            ComboBox1.Enabled = False
            TextBox2.Focus()
        End If
        TextBox1.Text = ""
        TextBox2.Text = ""
        ComboBox2.Text = ""
        i = 1
        If temp = True Then
            DataGridView1.Rows.Clear()
            cmd.Open("select * from sales_gt14", con, ADODB.CursorTypeEnum.adOpenDynamic, ADODB.LockTypeEnum.adLockOptimistic)

            While Not cmd.EOF
                DataGridView1.Rows.Add(Val(i), cmd.Fields("f_item").Value, cmd.Fields("f_charges").Value, cmd.Fields("f_quantity").Value, cmd.Fields("f_total").Value, "E", "X")
                ComboBox1.Text = cmd.Fields("f_waiter").Value
                i = i + 1
                cmd.MoveNext()
            End While
            cmd.Close()
        End If
        Label4.Text = "14"
    End Sub

    Private Sub Button35_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button35.Click
        g = 0
        If Not Button35.BackColor = Color.DimGray Then
            con.Execute("delete * from sales_gt15")
            ComboBox1.Enabled = True
            ComboBox1.Focus()
            ComboBox1.Text = ""
        Else

            ComboBox1.Enabled = False
            TextBox2.Focus()
        End If
        TextBox1.Text = ""
        TextBox2.Text = ""
        ComboBox2.Text = ""
        i = 1
        If temp = True Then
            DataGridView1.Rows.Clear()
            cmd.Open("select * from sales_gt15", con, ADODB.CursorTypeEnum.adOpenDynamic, ADODB.LockTypeEnum.adLockOptimistic)

            While Not cmd.EOF
                DataGridView1.Rows.Add(Val(i), cmd.Fields("f_item").Value, cmd.Fields("f_charges").Value, cmd.Fields("f_quantity").Value, cmd.Fields("f_total").Value, "E", "X")
                ComboBox1.Text = cmd.Fields("f_waiter").Value
                i = i + 1
                cmd.MoveNext()
            End While
            cmd.Close()
        End If
        Label4.Text = "15"
    End Sub

    Private Sub Button36_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button36.Click
        g = 0
        If Not Button36.BackColor = Color.DimGray Then
            con.Execute("delete * from sales_ff11")
            ComboBox1.Enabled = True
            ComboBox1.Focus()
            ComboBox1.Text = ""
        Else

            ComboBox1.Enabled = False
            TextBox2.Focus()
        End If
        TextBox1.Text = ""
        TextBox2.Text = ""
        ComboBox2.Text = ""
        i = 1
        If temp = True Then
            DataGridView1.Rows.Clear()
            cmd.Open("select * from sales_ff11", con, ADODB.CursorTypeEnum.adOpenDynamic, ADODB.LockTypeEnum.adLockOptimistic)
            While Not cmd.EOF
                DataGridView1.Rows.Add(Val(i), cmd.Fields("f_item").Value, cmd.Fields("f_charges").Value, cmd.Fields("f_quantity").Value, cmd.Fields("f_total").Value, "E", "X")
                ComboBox1.Text = cmd.Fields("f_waiter").Value
                i = i + 1
                cmd.MoveNext()
            End While
            cmd.Close()
        End If
        Label4.Text = "26"
    End Sub

    Private Sub Button37_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button37.Click
        g = 0
        If Not Button37.BackColor = Color.DimGray Then
            con.Execute("delete * from sales_ff12")
            ComboBox1.Enabled = True
            ComboBox1.Focus()
            ComboBox1.Text = ""
        Else

            ComboBox1.Enabled = False
            TextBox2.Focus()
        End If
        TextBox1.Text = ""
        TextBox2.Text = ""
        ComboBox2.Text = ""
        i = 1
        If temp = True Then
            DataGridView1.Rows.Clear()
            cmd.Open("select * from sales_ff12", con, ADODB.CursorTypeEnum.adOpenDynamic, ADODB.LockTypeEnum.adLockOptimistic)
            While Not cmd.EOF
                DataGridView1.Rows.Add(Val(i), cmd.Fields("f_item").Value, cmd.Fields("f_charges").Value, cmd.Fields("f_quantity").Value, cmd.Fields("f_total").Value, "E", "X")
                ComboBox1.Text = cmd.Fields("f_waiter").Value
                i = i + 1
                cmd.MoveNext()
            End While
            cmd.Close()
        End If
        Label4.Text = "27"
    End Sub

    Private Sub Button38_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button38.Click
        g = 0
        If Not Button38.BackColor = Color.DimGray Then
            con.Execute("delete * from sales_ff13")
            ComboBox1.Enabled = True
            ComboBox1.Focus()
            ComboBox1.Text = ""
        Else

            ComboBox1.Enabled = False
            TextBox2.Focus()
        End If
        TextBox1.Text = ""
        TextBox2.Text = ""
        ComboBox2.Text = ""
        i = 1
        If temp = True Then
            DataGridView1.Rows.Clear()
            cmd.Open("select * from sales_ff13", con, ADODB.CursorTypeEnum.adOpenDynamic, ADODB.LockTypeEnum.adLockOptimistic)
            While Not cmd.EOF
                DataGridView1.Rows.Add(Val(i), cmd.Fields("f_item").Value, cmd.Fields("f_charges").Value, cmd.Fields("f_quantity").Value, cmd.Fields("f_total").Value, "E", "X")
                ComboBox1.Text = cmd.Fields("f_waiter").Value
                i = i + 1
                cmd.MoveNext()
            End While
            cmd.Close()
        End If
        Label4.Text = "28"
    End Sub

    Private Sub Button39_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button39.Click
        g = 0
        If Not Button39.BackColor = Color.DimGray Then
            con.Execute("delete * from sales_ff14")
            ComboBox1.Enabled = True
            ComboBox1.Focus()
            ComboBox1.Text = ""
        Else

            ComboBox1.Enabled = False
            TextBox2.Focus()
        End If
        TextBox1.Text = ""
        TextBox2.Text = ""
        ComboBox2.Text = ""
        i = 1
        If temp = True Then
            DataGridView1.Rows.Clear()
            cmd.Open("select * from sales_ff14", con, ADODB.CursorTypeEnum.adOpenDynamic, ADODB.LockTypeEnum.adLockOptimistic)
            While Not cmd.EOF
                DataGridView1.Rows.Add(Val(i), cmd.Fields("f_item").Value, cmd.Fields("f_charges").Value, cmd.Fields("f_quantity").Value, cmd.Fields("f_total").Value, "E", "X")
                ComboBox1.Text = cmd.Fields("f_waiter").Value
                i = i + 1
                cmd.MoveNext()
            End While
            cmd.Close()
        End If
        Label4.Text = "29"
    End Sub

    Private Sub Button40_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button40.Click
        g = 0
        If Not Button40.BackColor = Color.DimGray Then
            con.Execute("delete * from sales_ff15")
            ComboBox1.Enabled = True
            ComboBox1.Focus()
            ComboBox1.Text = ""
        Else

            ComboBox1.Enabled = False
            TextBox2.Focus()
        End If
        TextBox1.Text = ""
        TextBox2.Text = ""
        ComboBox2.Text = ""
        i = 1
        If temp = True Then
            DataGridView1.Rows.Clear()
            cmd.Open("select * from sales_ff15", con, ADODB.CursorTypeEnum.adOpenDynamic, ADODB.LockTypeEnum.adLockOptimistic)
            While Not cmd.EOF
                DataGridView1.Rows.Add(Val(i), cmd.Fields("f_item").Value, cmd.Fields("f_charges").Value, cmd.Fields("f_quantity").Value, cmd.Fields("f_total").Value, "E", "X")
                ComboBox1.Text = cmd.Fields("f_waiter").Value
                i = i + 1
                cmd.MoveNext()
            End While
            cmd.Close()
        End If
        Label4.Text = "30"
    End Sub

    Private Sub ComboBox1_PreviewKeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.PreviewKeyDownEventArgs) Handles ComboBox1.PreviewKeyDown

        If e.KeyCode = Keys.Enter Then

            ' If Not IsNumeric(ComboBox1.Text) Then
            TextBox2.Focus()
            ComboBox1.Enabled = False
            'Else
            '   MsgBox("Enter waiter name properly.")
            '   ComboBox1.Text = ""
            '  ComboBox1.Focus()


        End If
        ' End If
    End Sub

    Private Sub DataGridView2_CellContentClick_1(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView2.CellContentClick
        'If (DataGridView2.Item("DataGridViewTextBoxColumn1", DataGridView2.CurrentRow.Index).Selected) Then
        'DataGridView2.Rows.Remove(DataGridView2.CurrentRow)
        '
        'con.Execute("delete * from uptdate where bill='" & DataGridView2.Item("DataGridViewTextBoxColumn1", DataGridView2.CurrentRow.Index).Value & "'")
        'End If
        If (DataGridView2.Item("Column8", DataGridView2.CurrentRow.Index).Selected) Then
            uptdate.Enabled = True
            uptdate.Show()
            'DataGridView2.Rows.Remove(DataGridView2.CurrentRow)
        End If
    End Sub

    Private Sub Button41_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button41.Click
        g = 0
        Button1.Enabled = False
        ComboBox1.Text = ""
        ComboBox1.Enabled = False
        If Not Button41.BackColor = Color.DimGray Then
            con.Execute("delete * from sales_p51")

            TextBox2.Focus()
        End If
        TextBox2.Text = ""
        ComboBox2.Text = ""
        TextBox1.Text = ""
        i = 1
        If temp = True Then
            DataGridView1.Rows.Clear()
            cmd.Open("select * from sales_p51", con, ADODB.CursorTypeEnum.adOpenDynamic, ADODB.LockTypeEnum.adLockOptimistic)
            While Not cmd.EOF
                DataGridView1.Rows.Add(Val(i), cmd.Fields("f_item").Value, cmd.Fields("f_charges").Value, cmd.Fields("f_quantity").Value, cmd.Fields("f_total").Value, "E", "X")
                ComboBox1.Text = cmd.Fields("f_waiter").Value
                i = i + 1
                cmd.MoveNext()
            End While
            cmd.Close()
        End If
        Label4.Text = "P5"
    End Sub

    Private Sub Button42_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button42.Click

        Label16.Visible = True
        TextBox6.Visible = True
        TextBox7.Visible = True
        TextBox6.Focus()

        Label17.Visible = True
        Button43.Visible = True
        TextBox6.Text = ""
        TextBox7.Text = ""
        'TextBox6.Text = Label4.Text
    End Sub

    Private Sub Button43_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button43.Click
        If TextBox6.Text = "1" And Not TextBox7.Text = "1" And Button15.BackColor = Color.DimGray Then
            cmd5.Open("select * from sales", con, ADODB.CursorTypeEnum.adOpenDynamic, ADODB.LockTypeEnum.adLockOptimistic)
            zero()
            cmd5.Close()
            con.Execute("delete * from sales")
            Button15.Text = "1"
            Button15.BackColor = Color.Gainsboro
        End If
        If TextBox6.Text = "2" And Not TextBox7.Text = "2" And Button14.BackColor = Color.DimGray Then
            cmd5.Open("select * from sales_gt2", con, ADODB.CursorTypeEnum.adOpenDynamic, ADODB.LockTypeEnum.adLockOptimistic)
            zero()
            cmd5.Close()
            con.Execute("delete * from sales_gt2")
            Button14.Text = "2"
            Button14.BackColor = Color.Gainsboro
        End If
        If TextBox6.Text = "3" And Not TextBox7.Text = "3" And Button4.BackColor = Color.DimGray Then
            cmd5.Open("select * from sales_gt3", con, ADODB.CursorTypeEnum.adOpenDynamic, ADODB.LockTypeEnum.adLockOptimistic)
            zero()
            cmd5.Close()
            con.Execute("delete * from sales_gt3")
            Button4.Text = "3"
            Button4.BackColor = Color.Gainsboro
        End If
        If TextBox6.Text = "4" And Not TextBox7.Text = "4" And Button13.BackColor = Color.DimGray Then
            cmd5.Open("select * from sales_gt4", con, ADODB.CursorTypeEnum.adOpenDynamic, ADODB.LockTypeEnum.adLockOptimistic)
            zero()
            cmd5.Close()
            con.Execute("delete * from sales_gt4")
            Button13.Text = "4"
            Button13.BackColor = Color.Gainsboro
        End If
        If TextBox6.Text = "5" And Not TextBox7.Text = "5" And Button5.BackColor = Color.DimGray Then
            cmd5.Open("select * from sales_gt5", con, ADODB.CursorTypeEnum.adOpenDynamic, ADODB.LockTypeEnum.adLockOptimistic)
            zero()
            cmd5.Close()
            con.Execute("delete * from sales_gt5")
            Button5.Text = "5"
            Button5.BackColor = Color.Gainsboro
        End If
        If TextBox6.Text = "6" And Not TextBox7.Text = "6" And Button6.BackColor = Color.DimGray Then
            cmd5.Open("select * from sales_gt6", con, ADODB.CursorTypeEnum.adOpenDynamic, ADODB.LockTypeEnum.adLockOptimistic)
            zero()
            cmd5.Close()
            con.Execute("delete * from sales_gt6")
            Button6.Text = "6"
            Button6.BackColor = Color.Gainsboro
        End If
        If TextBox6.Text = "7" And Not TextBox7.Text = "7" And Button7.BackColor = Color.DimGray Then
            cmd5.Open("select * from sales_gt7", con, ADODB.CursorTypeEnum.adOpenDynamic, ADODB.LockTypeEnum.adLockOptimistic)
            zero()
            cmd5.Close()
            con.Execute("delete * from sales_gt7")
            Button7.Text = "7"
            Button7.BackColor = Color.Gainsboro
        End If
        If TextBox6.Text = "8" And Not TextBox7.Text = "8" And Button8.BackColor = Color.DimGray Then
            cmd5.Open("select * from sales_gt8", con, ADODB.CursorTypeEnum.adOpenDynamic, ADODB.LockTypeEnum.adLockOptimistic)
            zero()
            cmd5.Close()
            con.Execute("delete * from sales_gt8")
            Button8.Text = "8"
            Button8.BackColor = Color.Gainsboro
        End If
        If TextBox6.Text = "9" And Not TextBox7.Text = "9" And Button21.BackColor = Color.DimGray Then
            cmd5.Open("select * from sales_p6", con, ADODB.CursorTypeEnum.adOpenDynamic, ADODB.LockTypeEnum.adLockOptimistic)
            zero()
            cmd5.Close()
            con.Execute("delete * from sales_p6")
            Button21.Text = "9"
            Button21.BackColor = Color.Gainsboro
        End If
        If TextBox6.Text = "10" And Not TextBox7.Text = "10" And Button20.BackColor = Color.DimGray Then
            cmd5.Open("select * from sales_p5", con, ADODB.CursorTypeEnum.adOpenDynamic, ADODB.LockTypeEnum.adLockOptimistic)
            zero()
            cmd5.Close()
            con.Execute("delete * from sales_p5")
            Button20.Text = "10"
            Button20.BackColor = Color.Gainsboro
        End If
        If TextBox6.Text = "11" And Not TextBox7.Text = "11" And Button2.BackColor = Color.DimGray Then
            cmd5.Open("select * from sales_gt11", con, ADODB.CursorTypeEnum.adOpenDynamic, ADODB.LockTypeEnum.adLockOptimistic)
            zero()
            cmd5.Close()
            con.Execute("delete * from sales_gt11")
            Button2.Text = "11"
            Button2.BackColor = Color.Gainsboro
        End If
        If TextBox6.Text = "12" And Not TextBox7.Text = "12" And Button32.BackColor = Color.DimGray Then
            cmd5.Open("select * from sales_gt12", con, ADODB.CursorTypeEnum.adOpenDynamic, ADODB.LockTypeEnum.adLockOptimistic)
            zero()
            cmd5.Close()
            con.Execute("delete * from sales_gt12")
            Button32.Text = "12"
            Button32.BackColor = Color.Gainsboro
        End If
        If TextBox6.Text = "13" And Not TextBox7.Text = "13" And Button33.BackColor = Color.DimGray Then
            cmd5.Open("select * from sales_gt13", con, ADODB.CursorTypeEnum.adOpenDynamic, ADODB.LockTypeEnum.adLockOptimistic)
            zero()
            cmd5.Close()
            con.Execute("delete * from sales_gt13")
            Button33.Text = "13"
            Button33.BackColor = Color.Gainsboro
        End If
        If TextBox6.Text = "14" And Not TextBox7.Text = "14" And Button34.BackColor = Color.DimGray Then
            cmd5.Open("select * from sales_gt14", con, ADODB.CursorTypeEnum.adOpenDynamic, ADODB.LockTypeEnum.adLockOptimistic)
            zero()
            cmd5.Close()
            con.Execute("delete * from sales_gt14")
            Button34.Text = "14"
            Button34.BackColor = Color.Gainsboro
        End If
        If TextBox6.Text = "15" And Not TextBox7.Text = "15" And Button35.BackColor = Color.DimGray Then
            cmd5.Open("select * from sales_gt15", con, ADODB.CursorTypeEnum.adOpenDynamic, ADODB.LockTypeEnum.adLockOptimistic)
            zero()
            cmd5.Close()
            con.Execute("delete * from sales_gt15")
            Button35.Text = "15"
            Button35.BackColor = Color.Gainsboro
        End If
        If TextBox6.Text = "16" And Not TextBox7.Text = "16" And Button19.BackColor = Color.DimGray Then
            cmd5.Open("select * from sales_ff1", con, ADODB.CursorTypeEnum.adOpenDynamic, ADODB.LockTypeEnum.adLockOptimistic)
            zero()
            cmd5.Close()
            con.Execute("delete * from sales_ff1")
            Button19.Text = "16"
            Button19.BackColor = Color.Gainsboro
        End If
        If TextBox6.Text = "17" And Not TextBox7.Text = "17" And Button18.BackColor = Color.DimGray Then
            cmd5.Open("select * from sales_ff2", con, ADODB.CursorTypeEnum.adOpenDynamic, ADODB.LockTypeEnum.adLockOptimistic)
            zero()
            cmd5.Close()
            con.Execute("delete * from sales_ff2")
            Button18.Text = "17"
            Button18.BackColor = Color.Gainsboro
        End If
        If TextBox6.Text = "18" And Not TextBox7.Text = "18" And Button16.BackColor = Color.DimGray Then
            cmd5.Open("select * from sales_ff3", con, ADODB.CursorTypeEnum.adOpenDynamic, ADODB.LockTypeEnum.adLockOptimistic)
            zero()
            cmd5.Close()
            con.Execute("delete * from sales_ff3")
            Button16.Text = "18"
            Button16.BackColor = Color.Gainsboro
        End If
        If TextBox6.Text = "19" And Not TextBox7.Text = "19" And Button17.BackColor = Color.DimGray Then
            cmd5.Open("select * from sales_ff4", con, ADODB.CursorTypeEnum.adOpenDynamic, ADODB.LockTypeEnum.adLockOptimistic)
            zero()
            cmd5.Close()
            con.Execute("delete * from sales_ff4")
            Button17.Text = "19"
            Button17.BackColor = Color.Gainsboro
        End If
        If TextBox6.Text = "20" And Not TextBox7.Text = "20" And Button9.BackColor = Color.DimGray Then
            cmd5.Open("select * from sales_ff5", con, ADODB.CursorTypeEnum.adOpenDynamic, ADODB.LockTypeEnum.adLockOptimistic)
            zero()
            cmd5.Close()
            con.Execute("delete * from sales_ff5")
            Button9.Text = "20"
            Button9.BackColor = Color.Gainsboro
        End If
        If TextBox6.Text = "21" And Not TextBox7.Text = "21" And Button10.BackColor = Color.DimGray Then
            cmd5.Open("select * from sales_ff6", con, ADODB.CursorTypeEnum.adOpenDynamic, ADODB.LockTypeEnum.adLockOptimistic)
            zero()
            cmd5.Close()
            con.Execute("delete * from sales_ff6")
            Button10.Text = "21"
            Button10.BackColor = Color.Gainsboro
        End If
        If TextBox6.Text = "22" And Not TextBox7.Text = "22" And Button11.BackColor = Color.DimGray Then
            cmd5.Open("select * from sales_ff7", con, ADODB.CursorTypeEnum.adOpenDynamic, ADODB.LockTypeEnum.adLockOptimistic)
            zero()
            cmd5.Close()
            con.Execute("delete * from sales_ff7")
            Button11.Text = "22"
            Button11.BackColor = Color.Gainsboro
        End If
        If TextBox6.Text = "23" And Not TextBox7.Text = "23" And Button12.BackColor = Color.DimGray Then
            cmd5.Open("select * from sales_ff8", con, ADODB.CursorTypeEnum.adOpenDynamic, ADODB.LockTypeEnum.adLockOptimistic)
            zero()
            cmd5.Close()
            con.Execute("delete * from sales_ff8")
            Button12.Text = "23"
            Button12.BackColor = Color.Gainsboro
        End If
        If TextBox6.Text = "24" And Not TextBox7.Text = "24" And Button23.BackColor = Color.DimGray Then
            cmd5.Open("select * from sales_p8", con, ADODB.CursorTypeEnum.adOpenDynamic, ADODB.LockTypeEnum.adLockOptimistic)
            zero()
            cmd5.Close()
            con.Execute("delete * from sales_p8")
            Button23.Text = "24"
            Button23.BackColor = Color.Gainsboro
        End If
        If TextBox6.Text = "25" And Not TextBox7.Text = "25" And Button22.BackColor = Color.DimGray Then
            cmd5.Open("select * from sales_p7", con, ADODB.CursorTypeEnum.adOpenDynamic, ADODB.LockTypeEnum.adLockOptimistic)
            zero()
            cmd5.Close()
            con.Execute("delete * from sales_p7")
            Button22.Text = "25"
            Button22.BackColor = Color.Gainsboro
        End If
        If TextBox6.Text = "26" And Not TextBox7.Text = "26" And Button36.BackColor = Color.DimGray Then
            cmd5.Open("select * from sales_ff11", con, ADODB.CursorTypeEnum.adOpenDynamic, ADODB.LockTypeEnum.adLockOptimistic)
            zero()
            cmd5.Close()
            con.Execute("delete * from sales_ff11")
            Button36.Text = "26"
            Button36.BackColor = Color.Gainsboro
        End If
        If TextBox6.Text = "27" And Not TextBox7.Text = "27" And Button37.BackColor = Color.DimGray Then
            cmd5.Open("select * from sales_ff12", con, ADODB.CursorTypeEnum.adOpenDynamic, ADODB.LockTypeEnum.adLockOptimistic)
            zero()
            cmd5.Close()
            con.Execute("delete * from sales_ff12")
            Button37.Text = "27"
            Button37.BackColor = Color.Gainsboro
        End If
        If TextBox6.Text = "28" And Not TextBox7.Text = "28" And Button38.BackColor = Color.DimGray Then
            cmd5.Open("select * from sales_ff13", con, ADODB.CursorTypeEnum.adOpenDynamic, ADODB.LockTypeEnum.adLockOptimistic)
            zero()
            cmd5.Close()
            con.Execute("delete * from sales_ff13")
            Button38.Text = "28"
            Button38.BackColor = Color.Gainsboro
        End If
        If TextBox6.Text = "29" And Not TextBox7.Text = "29" And Button39.BackColor = Color.DimGray Then
            cmd5.Open("select * from sales_ff14", con, ADODB.CursorTypeEnum.adOpenDynamic, ADODB.LockTypeEnum.adLockOptimistic)
            zero()
            cmd5.Close()
            con.Execute("delete * from sales_ff14")
            Button39.Text = "29"
            Button39.BackColor = Color.Gainsboro
        End If
        If TextBox6.Text = "30" And Not TextBox7.Text = "30" And Button40.BackColor = Color.DimGray Then
            cmd5.Open("select * from sales_ff15", con, ADODB.CursorTypeEnum.adOpenDynamic, ADODB.LockTypeEnum.adLockOptimistic)
            zero()
            cmd5.Close()
            con.Execute("delete * from sales_ff15")
            Button40.Text = "30"
            Button40.BackColor = Color.Gainsboro
        End If
        Label16.Visible = False
        TextBox6.Visible = False
        TextBox7.Visible = False
        Label17.Visible = False
        Button43.Visible = False
    End Sub

    Sub zero()
        Dim x1 As Integer
        x1 = 0
        If TextBox7.Text = "1" Then
            cmd6.Open("select * from sales", con, ADODB.CursorTypeEnum.adOpenDynamic, ADODB.LockTypeEnum.adLockOptimistic)
            While Not cmd5.EOF
                cmd6.AddNew()
                cmd6.Fields("f_item").Value = cmd5.Fields("f_item").Value
                cmd6.Fields("f_charges").Value = cmd5.Fields("f_charges").Value
                cmd6.Fields("f_quantity").Value = cmd5.Fields("f_quantity").Value
                cmd6.Fields("f_waiter").Value = cmd5.Fields("f_waiter").Value
                cmd6.Fields("f_total").Value = cmd5.Fields("f_total").Value
                x1 = x1 + cmd5.Fields("f_total").Value
                cmd5.MoveNext()
                cmd6.Update()

            End While
            Button15.Text = "1 " + x1.ToString
            Button15.BackColor = Color.DimGray
        End If
        If TextBox7.Text = "2" Then
            cmd6.Open("select * from sales_gt2", con, ADODB.CursorTypeEnum.adOpenDynamic, ADODB.LockTypeEnum.adLockOptimistic)
            While Not cmd5.EOF
                cmd6.AddNew()
                cmd6.Fields("f_item").Value = cmd5.Fields("f_item").Value
                cmd6.Fields("f_charges").Value = cmd5.Fields("f_charges").Value
                cmd6.Fields("f_quantity").Value = cmd5.Fields("f_quantity").Value
                cmd6.Fields("f_waiter").Value = cmd5.Fields("f_waiter").Value
                cmd6.Fields("f_total").Value = cmd5.Fields("f_total").Value
                x1 = x1 + cmd5.Fields("f_total").Value
                cmd5.MoveNext()
                cmd6.Update()

            End While
            Button14.Text = "2 " + x1.ToString
            Button14.BackColor = Color.DimGray
        End If
        If TextBox7.Text = "3" Then
            cmd6.Open("select * from sales_gt3", con, ADODB.CursorTypeEnum.adOpenDynamic, ADODB.LockTypeEnum.adLockOptimistic)
            While Not cmd5.EOF
                cmd6.AddNew()
                cmd6.Fields("f_item").Value = cmd5.Fields("f_item").Value
                cmd6.Fields("f_charges").Value = cmd5.Fields("f_charges").Value
                cmd6.Fields("f_quantity").Value = cmd5.Fields("f_quantity").Value
                cmd6.Fields("f_waiter").Value = cmd5.Fields("f_waiter").Value
                cmd6.Fields("f_total").Value = cmd5.Fields("f_total").Value
                x1 = x1 + cmd5.Fields("f_total").Value
                cmd5.MoveNext()
                cmd6.Update()
            End While
            Button4.Text = "3 " + x1.ToString
            Button4.BackColor = Color.DimGray
        End If
        If TextBox7.Text = "4" Then
            cmd6.Open("select * from sales_gt4", con, ADODB.CursorTypeEnum.adOpenDynamic, ADODB.LockTypeEnum.adLockOptimistic)
            While Not cmd5.EOF
                cmd6.AddNew()
                cmd6.Fields("f_item").Value = cmd5.Fields("f_item").Value
                cmd6.Fields("f_charges").Value = cmd5.Fields("f_charges").Value
                cmd6.Fields("f_quantity").Value = cmd5.Fields("f_quantity").Value
                cmd6.Fields("f_waiter").Value = cmd5.Fields("f_waiter").Value
                cmd6.Fields("f_total").Value = cmd5.Fields("f_total").Value
                x1 = x1 + cmd5.Fields("f_total").Value
                cmd5.MoveNext()
                cmd6.Update()
            End While
            Button13.Text = "4 " + x1.ToString
            Button13.BackColor = Color.DimGray
        End If
        If TextBox7.Text = "5" Then
            cmd6.Open("select * from sales_gt5", con, ADODB.CursorTypeEnum.adOpenDynamic, ADODB.LockTypeEnum.adLockOptimistic)
            While Not cmd5.EOF
                cmd6.AddNew()
                cmd6.Fields("f_item").Value = cmd5.Fields("f_item").Value
                cmd6.Fields("f_charges").Value = cmd5.Fields("f_charges").Value
                cmd6.Fields("f_quantity").Value = cmd5.Fields("f_quantity").Value
                cmd6.Fields("f_waiter").Value = cmd5.Fields("f_waiter").Value
                cmd6.Fields("f_total").Value = cmd5.Fields("f_total").Value
                x1 = x1 + cmd5.Fields("f_total").Value
                cmd5.MoveNext()
                cmd6.Update()
            End While
            Button5.Text = "5 " + x1.ToString
            Button5.BackColor = Color.DimGray
        End If
        If TextBox7.Text = "6" Then
            cmd6.Open("select * from sales_gt6", con, ADODB.CursorTypeEnum.adOpenDynamic, ADODB.LockTypeEnum.adLockOptimistic)
            While Not cmd5.EOF
                cmd6.AddNew()
                cmd6.Fields("f_item").Value = cmd5.Fields("f_item").Value
                cmd6.Fields("f_charges").Value = cmd5.Fields("f_charges").Value
                cmd6.Fields("f_quantity").Value = cmd5.Fields("f_quantity").Value
                cmd6.Fields("f_waiter").Value = cmd5.Fields("f_waiter").Value
                cmd6.Fields("f_total").Value = cmd5.Fields("f_total").Value
                x1 = x1 + cmd5.Fields("f_total").Value
                cmd5.MoveNext()
                cmd6.Update()
            End While
            Button6.Text = "6 " + x1.ToString
            Button6.BackColor = Color.DimGray
        End If
        If TextBox7.Text = "7" Then
            cmd6.Open("select * from sales_gt7", con, ADODB.CursorTypeEnum.adOpenDynamic, ADODB.LockTypeEnum.adLockOptimistic)
            While Not cmd5.EOF
                cmd6.AddNew()
                cmd6.Fields("f_item").Value = cmd5.Fields("f_item").Value
                cmd6.Fields("f_charges").Value = cmd5.Fields("f_charges").Value
                cmd6.Fields("f_quantity").Value = cmd5.Fields("f_quantity").Value
                cmd6.Fields("f_waiter").Value = cmd5.Fields("f_waiter").Value
                cmd6.Fields("f_total").Value = cmd5.Fields("f_total").Value
                x1 = x1 + cmd5.Fields("f_total").Value
                cmd5.MoveNext()
                cmd6.Update()
            End While
            Button7.Text = "7 " + x1.ToString
            Button7.BackColor = Color.DimGray
        End If
        If TextBox7.Text = "8" Then
            cmd6.Open("select * from sales_gt8", con, ADODB.CursorTypeEnum.adOpenDynamic, ADODB.LockTypeEnum.adLockOptimistic)
            While Not cmd5.EOF
                cmd6.AddNew()
                cmd6.Fields("f_item").Value = cmd5.Fields("f_item").Value
                cmd6.Fields("f_charges").Value = cmd5.Fields("f_charges").Value
                cmd6.Fields("f_quantity").Value = cmd5.Fields("f_quantity").Value
                cmd6.Fields("f_waiter").Value = cmd5.Fields("f_waiter").Value
                cmd6.Fields("f_total").Value = cmd5.Fields("f_total").Value
                x1 = x1 + cmd5.Fields("f_total").Value
                cmd5.MoveNext()
                cmd6.Update()
            End While
            Button8.Text = "8 " + x1.ToString
            Button8.BackColor = Color.DimGray
        End If
        If TextBox7.Text = "9" Then
            cmd6.Open("select * from sales_p6", con, ADODB.CursorTypeEnum.adOpenDynamic, ADODB.LockTypeEnum.adLockOptimistic)
            While Not cmd5.EOF
                cmd6.AddNew()
                cmd6.Fields("f_item").Value = cmd5.Fields("f_item").Value
                cmd6.Fields("f_charges").Value = cmd5.Fields("f_charges").Value
                cmd6.Fields("f_quantity").Value = cmd5.Fields("f_quantity").Value
                cmd6.Fields("f_waiter").Value = cmd5.Fields("f_waiter").Value
                cmd6.Fields("f_total").Value = cmd5.Fields("f_total").Value
                x1 = x1 + cmd5.Fields("f_total").Value
                cmd5.MoveNext()
                cmd6.Update()
            End While
            Button21.Text = "9 " + x1.ToString
            Button21.BackColor = Color.DimGray
        End If
        If TextBox7.Text = "10" Then
            cmd6.Open("select * from sales_p5", con, ADODB.CursorTypeEnum.adOpenDynamic, ADODB.LockTypeEnum.adLockOptimistic)
            While Not cmd5.EOF
                cmd6.AddNew()
                cmd6.Fields("f_item").Value = cmd5.Fields("f_item").Value
                cmd6.Fields("f_charges").Value = cmd5.Fields("f_charges").Value
                cmd6.Fields("f_quantity").Value = cmd5.Fields("f_quantity").Value
                cmd6.Fields("f_waiter").Value = cmd5.Fields("f_waiter").Value
                cmd6.Fields("f_total").Value = cmd5.Fields("f_total").Value
                x1 = x1 + cmd5.Fields("f_total").Value
                cmd5.MoveNext()
                cmd6.Update()
            End While
            Button20.Text = "10 " + x1.ToString
            Button20.BackColor = Color.DimGray
        End If
        If TextBox7.Text = "11" Then
            cmd6.Open("select * from sales_gt11", con, ADODB.CursorTypeEnum.adOpenDynamic, ADODB.LockTypeEnum.adLockOptimistic)
            While Not cmd5.EOF
                cmd6.AddNew()
                cmd6.Fields("f_item").Value = cmd5.Fields("f_item").Value
                cmd6.Fields("f_charges").Value = cmd5.Fields("f_charges").Value
                cmd6.Fields("f_quantity").Value = cmd5.Fields("f_quantity").Value
                cmd6.Fields("f_waiter").Value = cmd5.Fields("f_waiter").Value
                cmd6.Fields("f_total").Value = cmd5.Fields("f_total").Value
                x1 = x1 + cmd5.Fields("f_total").Value
                cmd5.MoveNext()
                cmd6.Update()
            End While
            Button2.Text = "11 " + x1.ToString
            Button2.BackColor = Color.DimGray
        End If
        If TextBox7.Text = "12" Then
            cmd6.Open("select * from sales_gt12", con, ADODB.CursorTypeEnum.adOpenDynamic, ADODB.LockTypeEnum.adLockOptimistic)
            While Not cmd5.EOF
                cmd6.AddNew()
                cmd6.Fields("f_item").Value = cmd5.Fields("f_item").Value
                cmd6.Fields("f_charges").Value = cmd5.Fields("f_charges").Value
                cmd6.Fields("f_quantity").Value = cmd5.Fields("f_quantity").Value
                cmd6.Fields("f_waiter").Value = cmd5.Fields("f_waiter").Value
                cmd6.Fields("f_total").Value = cmd5.Fields("f_total").Value
                x1 = x1 + cmd5.Fields("f_total").Value
                cmd5.MoveNext()
                cmd6.Update()
            End While
            Button32.Text = "12 " + x1.ToString
            Button32.BackColor = Color.DimGray
        End If
        If TextBox7.Text = "13" Then
            cmd6.Open("select * from sales_gt13", con, ADODB.CursorTypeEnum.adOpenDynamic, ADODB.LockTypeEnum.adLockOptimistic)
            While Not cmd5.EOF
                cmd6.AddNew()
                cmd6.Fields("f_item").Value = cmd5.Fields("f_item").Value
                cmd6.Fields("f_charges").Value = cmd5.Fields("f_charges").Value
                cmd6.Fields("f_quantity").Value = cmd5.Fields("f_quantity").Value
                cmd6.Fields("f_waiter").Value = cmd5.Fields("f_waiter").Value
                cmd6.Fields("f_total").Value = cmd5.Fields("f_total").Value
                x1 = x1 + cmd5.Fields("f_total").Value
                cmd5.MoveNext()
                cmd6.Update()
            End While
            Button33.Text = "13 " + x1.ToString
            Button33.BackColor = Color.DimGray
        End If
        If TextBox7.Text = "14" Then
            cmd6.Open("select * from sales_gt14", con, ADODB.CursorTypeEnum.adOpenDynamic, ADODB.LockTypeEnum.adLockOptimistic)
            While Not cmd5.EOF
                cmd6.AddNew()
                cmd6.Fields("f_item").Value = cmd5.Fields("f_item").Value
                cmd6.Fields("f_charges").Value = cmd5.Fields("f_charges").Value
                cmd6.Fields("f_quantity").Value = cmd5.Fields("f_quantity").Value
                cmd6.Fields("f_waiter").Value = cmd5.Fields("f_waiter").Value
                cmd6.Fields("f_total").Value = cmd5.Fields("f_total").Value
                x1 = x1 + cmd5.Fields("f_total").Value
                cmd5.MoveNext()
                cmd6.Update()
            End While
            Button34.Text = "14 " + x1.ToString
            Button34.BackColor = Color.DimGray
        End If
        If TextBox7.Text = "15" Then
            cmd6.Open("select * from sales_gt15", con, ADODB.CursorTypeEnum.adOpenDynamic, ADODB.LockTypeEnum.adLockOptimistic)
            While Not cmd5.EOF
                cmd6.AddNew()
                cmd6.Fields("f_item").Value = cmd5.Fields("f_item").Value
                cmd6.Fields("f_charges").Value = cmd5.Fields("f_charges").Value
                cmd6.Fields("f_quantity").Value = cmd5.Fields("f_quantity").Value
                cmd6.Fields("f_waiter").Value = cmd5.Fields("f_waiter").Value
                cmd6.Fields("f_total").Value = cmd5.Fields("f_total").Value
                x1 = x1 + cmd5.Fields("f_total").Value
                cmd5.MoveNext()
                cmd6.Update()
            End While
            Button35.Text = "15 " + x1.ToString
            Button35.BackColor = Color.DimGray
        End If
        If TextBox7.Text = "16" Then
            cmd6.Open("select * from sales_ff1", con, ADODB.CursorTypeEnum.adOpenDynamic, ADODB.LockTypeEnum.adLockOptimistic)
            While Not cmd5.EOF
                cmd6.AddNew()
                cmd6.Fields("f_item").Value = cmd5.Fields("f_item").Value
                cmd6.Fields("f_charges").Value = cmd5.Fields("f_charges").Value
                cmd6.Fields("f_quantity").Value = cmd5.Fields("f_quantity").Value
                cmd6.Fields("f_waiter").Value = cmd5.Fields("f_waiter").Value
                cmd6.Fields("f_total").Value = cmd5.Fields("f_total").Value
                x1 = x1 + cmd5.Fields("f_total").Value
                cmd5.MoveNext()
                cmd6.Update()
            End While
            Button19.Text = "16 " + x1.ToString
            Button19.BackColor = Color.DimGray
        End If
        If TextBox7.Text = "17" Then
            cmd6.Open("select * from sales_ff2", con, ADODB.CursorTypeEnum.adOpenDynamic, ADODB.LockTypeEnum.adLockOptimistic)
            While Not cmd5.EOF
                cmd6.AddNew()
                cmd6.Fields("f_item").Value = cmd5.Fields("f_item").Value
                cmd6.Fields("f_charges").Value = cmd5.Fields("f_charges").Value
                cmd6.Fields("f_quantity").Value = cmd5.Fields("f_quantity").Value
                cmd6.Fields("f_waiter").Value = cmd5.Fields("f_waiter").Value
                cmd6.Fields("f_total").Value = cmd5.Fields("f_total").Value
                x1 = x1 + cmd5.Fields("f_total").Value
                cmd5.MoveNext()
                cmd6.Update()
            End While
            Button18.Text = "17 " + x1.ToString
            Button18.BackColor = Color.DimGray
        End If
        If TextBox7.Text = "18" Then
            cmd6.Open("select * from sales_ff3", con, ADODB.CursorTypeEnum.adOpenDynamic, ADODB.LockTypeEnum.adLockOptimistic)
            While Not cmd5.EOF
                cmd6.AddNew()
                cmd6.Fields("f_item").Value = cmd5.Fields("f_item").Value
                cmd6.Fields("f_charges").Value = cmd5.Fields("f_charges").Value
                cmd6.Fields("f_quantity").Value = cmd5.Fields("f_quantity").Value
                cmd6.Fields("f_waiter").Value = cmd5.Fields("f_waiter").Value
                cmd6.Fields("f_total").Value = cmd5.Fields("f_total").Value
                x1 = x1 + cmd5.Fields("f_total").Value
                cmd5.MoveNext()
                cmd6.Update()
            End While
            Button16.Text = "18 " + x1.ToString
            Button16.BackColor = Color.DimGray
        End If
        If TextBox7.Text = "19" Then
            cmd6.Open("select * from sales_ff4", con, ADODB.CursorTypeEnum.adOpenDynamic, ADODB.LockTypeEnum.adLockOptimistic)
            While Not cmd5.EOF
                cmd6.AddNew()
                cmd6.Fields("f_item").Value = cmd5.Fields("f_item").Value
                cmd6.Fields("f_charges").Value = cmd5.Fields("f_charges").Value
                cmd6.Fields("f_quantity").Value = cmd5.Fields("f_quantity").Value
                cmd6.Fields("f_waiter").Value = cmd5.Fields("f_waiter").Value
                cmd6.Fields("f_total").Value = cmd5.Fields("f_total").Value
                x1 = x1 + cmd5.Fields("f_total").Value
                cmd5.MoveNext()
                cmd6.Update()
            End While
            Button17.Text = "19 " + x1.ToString
            Button17.BackColor = Color.DimGray
        End If
        If TextBox7.Text = "20" Then
            cmd6.Open("select * from sales_ff5", con, ADODB.CursorTypeEnum.adOpenDynamic, ADODB.LockTypeEnum.adLockOptimistic)
            While Not cmd5.EOF
                cmd6.AddNew()
                cmd6.Fields("f_item").Value = cmd5.Fields("f_item").Value
                cmd6.Fields("f_charges").Value = cmd5.Fields("f_charges").Value
                cmd6.Fields("f_quantity").Value = cmd5.Fields("f_quantity").Value
                cmd6.Fields("f_waiter").Value = cmd5.Fields("f_waiter").Value
                cmd6.Fields("f_total").Value = cmd5.Fields("f_total").Value
                x1 = x1 + cmd5.Fields("f_total").Value
                cmd5.MoveNext()
                cmd6.Update()
            End While
            Button9.Text = "20 " + x1.ToString
            Button9.BackColor = Color.DimGray
        End If
        If TextBox7.Text = "21" Then
            cmd6.Open("select * from sales_ff6", con, ADODB.CursorTypeEnum.adOpenDynamic, ADODB.LockTypeEnum.adLockOptimistic)
            While Not cmd5.EOF
                cmd6.AddNew()
                cmd6.Fields("f_item").Value = cmd5.Fields("f_item").Value
                cmd6.Fields("f_charges").Value = cmd5.Fields("f_charges").Value
                cmd6.Fields("f_quantity").Value = cmd5.Fields("f_quantity").Value
                cmd6.Fields("f_waiter").Value = cmd5.Fields("f_waiter").Value
                cmd6.Fields("f_total").Value = cmd5.Fields("f_total").Value
                x1 = x1 + cmd5.Fields("f_total").Value
                cmd5.MoveNext()
                cmd6.Update()
            End While
            Button10.Text = "21 " + x1.ToString
            Button10.BackColor = Color.DimGray
        End If
        If TextBox7.Text = "22" Then
            cmd6.Open("select * from sales_ff7", con, ADODB.CursorTypeEnum.adOpenDynamic, ADODB.LockTypeEnum.adLockOptimistic)
            While Not cmd5.EOF
                cmd6.AddNew()
                cmd6.Fields("f_item").Value = cmd5.Fields("f_item").Value
                cmd6.Fields("f_charges").Value = cmd5.Fields("f_charges").Value
                cmd6.Fields("f_quantity").Value = cmd5.Fields("f_quantity").Value
                cmd6.Fields("f_waiter").Value = cmd5.Fields("f_waiter").Value
                cmd6.Fields("f_total").Value = cmd5.Fields("f_total").Value
                x1 = x1 + cmd5.Fields("f_total").Value
                cmd5.MoveNext()
                cmd6.Update()
            End While
            Button11.Text = "22 " + x1.ToString
            Button11.BackColor = Color.DimGray
        End If
        If TextBox7.Text = "23" Then
            cmd6.Open("select * from sales_ff8", con, ADODB.CursorTypeEnum.adOpenDynamic, ADODB.LockTypeEnum.adLockOptimistic)
            While Not cmd5.EOF
                cmd6.AddNew()
                cmd6.Fields("f_item").Value = cmd5.Fields("f_item").Value
                cmd6.Fields("f_charges").Value = cmd5.Fields("f_charges").Value
                cmd6.Fields("f_quantity").Value = cmd5.Fields("f_quantity").Value
                cmd6.Fields("f_waiter").Value = cmd5.Fields("f_waiter").Value
                cmd6.Fields("f_total").Value = cmd5.Fields("f_total").Value
                x1 = x1 + cmd5.Fields("f_total").Value
                cmd5.MoveNext()
                cmd6.Update()
            End While
            Button12.Text = "23 " + x1.ToString
            Button12.BackColor = Color.DimGray
        End If
        If TextBox7.Text = "24" Then
            cmd6.Open("select * from sales_p8", con, ADODB.CursorTypeEnum.adOpenDynamic, ADODB.LockTypeEnum.adLockOptimistic)
            While Not cmd5.EOF
                cmd6.AddNew()
                cmd6.Fields("f_item").Value = cmd5.Fields("f_item").Value
                cmd6.Fields("f_charges").Value = cmd5.Fields("f_charges").Value
                cmd6.Fields("f_quantity").Value = cmd5.Fields("f_quantity").Value
                cmd6.Fields("f_waiter").Value = cmd5.Fields("f_waiter").Value
                cmd6.Fields("f_total").Value = cmd5.Fields("f_total").Value
                x1 = x1 + cmd5.Fields("f_total").Value
                cmd5.MoveNext()
                cmd6.Update()
            End While
            Button23.Text = "24 " + x1.ToString
            Button23.BackColor = Color.DimGray
        End If
        If TextBox7.Text = "25" Then
            cmd6.Open("select * from sales_p7", con, ADODB.CursorTypeEnum.adOpenDynamic, ADODB.LockTypeEnum.adLockOptimistic)
            While Not cmd5.EOF
                cmd6.AddNew()
                cmd6.Fields("f_item").Value = cmd5.Fields("f_item").Value
                cmd6.Fields("f_charges").Value = cmd5.Fields("f_charges").Value
                cmd6.Fields("f_quantity").Value = cmd5.Fields("f_quantity").Value
                cmd6.Fields("f_waiter").Value = cmd5.Fields("f_waiter").Value
                cmd6.Fields("f_total").Value = cmd5.Fields("f_total").Value
                x1 = x1 + cmd5.Fields("f_total").Value
                cmd5.MoveNext()
                cmd6.Update()
            End While
            Button22.Text = "25 " + x1.ToString
            Button22.BackColor = Color.DimGray
        End If
        If TextBox7.Text = "26" Then
            cmd6.Open("select * from sales_ff11", con, ADODB.CursorTypeEnum.adOpenDynamic, ADODB.LockTypeEnum.adLockOptimistic)
            While Not cmd5.EOF
                cmd6.AddNew()
                cmd6.Fields("f_item").Value = cmd5.Fields("f_item").Value
                cmd6.Fields("f_charges").Value = cmd5.Fields("f_charges").Value
                cmd6.Fields("f_quantity").Value = cmd5.Fields("f_quantity").Value
                cmd6.Fields("f_waiter").Value = cmd5.Fields("f_waiter").Value
                cmd6.Fields("f_total").Value = cmd5.Fields("f_total").Value
                x1 = x1 + cmd5.Fields("f_total").Value
                cmd5.MoveNext()
                cmd6.Update()
            End While
            Button36.Text = "26 " + x1.ToString
            Button36.BackColor = Color.DimGray
        End If
        If TextBox7.Text = "27" Then
            cmd6.Open("select * from sales_ff12", con, ADODB.CursorTypeEnum.adOpenDynamic, ADODB.LockTypeEnum.adLockOptimistic)
            While Not cmd5.EOF
                cmd6.AddNew()
                cmd6.Fields("f_item").Value = cmd5.Fields("f_item").Value
                cmd6.Fields("f_charges").Value = cmd5.Fields("f_charges").Value
                cmd6.Fields("f_quantity").Value = cmd5.Fields("f_quantity").Value
                cmd6.Fields("f_waiter").Value = cmd5.Fields("f_waiter").Value
                cmd6.Fields("f_total").Value = cmd5.Fields("f_total").Value
                x1 = x1 + cmd5.Fields("f_total").Value
                cmd5.MoveNext()
                cmd6.Update()
            End While
            Button37.Text = "27 " + x1.ToString
            Button37.BackColor = Color.DimGray
        End If
        If TextBox7.Text = "28" Then
            cmd6.Open("select * from sales_ff13", con, ADODB.CursorTypeEnum.adOpenDynamic, ADODB.LockTypeEnum.adLockOptimistic)
            While Not cmd5.EOF
                cmd6.AddNew()
                cmd6.Fields("f_item").Value = cmd5.Fields("f_item").Value
                cmd6.Fields("f_charges").Value = cmd5.Fields("f_charges").Value
                cmd6.Fields("f_quantity").Value = cmd5.Fields("f_quantity").Value
                cmd6.Fields("f_waiter").Value = cmd5.Fields("f_waiter").Value
                cmd6.Fields("f_total").Value = cmd5.Fields("f_total").Value
                x1 = x1 + cmd5.Fields("f_total").Value
                cmd5.MoveNext()
                cmd6.Update()
            End While
            Button38.Text = "28 " + x1.ToString
            Button38.BackColor = Color.DimGray
        End If
        If TextBox7.Text = "29" Then
            cmd6.Open("select * from sales_ff14", con, ADODB.CursorTypeEnum.adOpenDynamic, ADODB.LockTypeEnum.adLockOptimistic)
            While Not cmd5.EOF
                cmd6.AddNew()
                cmd6.Fields("f_item").Value = cmd5.Fields("f_item").Value
                cmd6.Fields("f_charges").Value = cmd5.Fields("f_charges").Value
                cmd6.Fields("f_quantity").Value = cmd5.Fields("f_quantity").Value
                cmd6.Fields("f_waiter").Value = cmd5.Fields("f_waiter").Value
                cmd6.Fields("f_total").Value = cmd5.Fields("f_total").Value
                x1 = x1 + cmd5.Fields("f_total").Value
                cmd5.MoveNext()
                cmd6.Update()
            End While
            Button39.Text = "29 " + x1.ToString
            Button39.BackColor = Color.DimGray
        End If
        If TextBox7.Text = "30" Then
            cmd6.Open("select * from sales_ff15", con, ADODB.CursorTypeEnum.adOpenDynamic, ADODB.LockTypeEnum.adLockOptimistic)
            While Not cmd5.EOF
                cmd6.AddNew()
                cmd6.Fields("f_item").Value = cmd5.Fields("f_item").Value
                cmd6.Fields("f_charges").Value = cmd5.Fields("f_charges").Value
                cmd6.Fields("f_quantity").Value = cmd5.Fields("f_quantity").Value
                cmd6.Fields("f_waiter").Value = cmd5.Fields("f_waiter").Value
                cmd6.Fields("f_total").Value = cmd5.Fields("f_total").Value
                x1 = x1 + cmd5.Fields("f_total").Value
                cmd5.MoveNext()
                cmd6.Update()
            End While
            Button40.Text = "30 " + x1.ToString
            Button40.BackColor = Color.DimGray
        End If
        cmd6.Close()
    End Sub

    
    Private Sub TextBox5_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox5.TextChanged

    End Sub
End Class


