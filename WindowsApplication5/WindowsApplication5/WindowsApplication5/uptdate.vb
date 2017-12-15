Imports System.IO

Public Class uptdate
    Dim con As New ADODB.Connection
    Dim cmd As New ADODB.Recordset
    Dim dr As New System.Windows.Forms.DataGridViewRow
    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
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
            dt.Rows.Add(Me.Label1.Text, Me.Label3.Text, Me.Label4.Text, dr.Cells(1).Value, dr.Cells(2).Value, dr.Cells(3).Value)
        Next
        Dim rptDoc As CrystalDecisions.CrystalReports.Engine.ReportDocument
        rptDoc = New CrystalReport1
        rptDoc.SetDataSource(dt)
        rptDoc.PrintToPrinter(1, False, 0, 0)
        'reprint.Close()
        Me.Close()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        'cmd.Open("select * from update", con, ADODB.CursorTypeEnum.adOpenDynamic, ADODB.LockTypeEnum.adLockOptimistic)
        con.Execute("delete * from uptdate where bill='" & Label1.Text & "'")
        'cmd.Close()
        'MsgBox("Submitted")
        sales.DataGridView2.Rows.Remove(sales.DataGridView2.CurrentRow)
        Me.Close()
    End Sub

    Private Sub uptdate_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        TextBox1.Enabled = False
        con.Open("dsn=abc")
        Label4.Text = sales.DataGridView2.Item("DataGridViewTextBoxColumn2", sales.DataGridView2.CurrentRow.Index).Value
        Label3.Text = sales.DataGridView2.Item("DataGridViewTextBoxColumn3", sales.DataGridView2.CurrentRow.Index).Value
        Label1.Text = sales.DataGridView2.Item("DataGridViewTextBoxColumn1", sales.DataGridView2.CurrentRow.Index).Value
        TextBox1.Text = sales.DataGridView2.Item("DataGridViewTextBoxColumn4", sales.DataGridView2.CurrentRow.Index).Value
        Dim i As Integer
        i = 1
        cmd.Open("select * from report where r_bill='" & sales.DataGridView2.Item("DataGridViewTextBoxColumn1", sales.DataGridView2.CurrentRow.Index).Value & "' and r_date='" & Date.Today & "'", con, ADODB.CursorTypeEnum.adOpenDynamic, ADODB.LockTypeEnum.adLockOptimistic)
        While Not cmd.EOF
            DataGridView1.Rows.Add(Val(i), cmd.Fields("r_item").Value, cmd.Fields("r_quantity").Value, cmd.Fields("r_total").Value)
            cmd.MoveNext()
            i = i + 1
        End While
        cmd.Close()
    End Sub
End Class