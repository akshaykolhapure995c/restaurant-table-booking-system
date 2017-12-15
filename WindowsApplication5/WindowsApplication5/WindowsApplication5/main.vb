
Public Class main
    Dim con As New ADODB.Connection
    Dim cmd As New ADODB.Recordset
    Private Sub SalesToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SalesToolStripMenuItem.Click
        sales.Show()
    End Sub

    Private Sub WaiterToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles WaiterToolStripMenuItem.Click
        waiter_details.Show()

    End Sub

    Private Sub FoodItemToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FoodItemToolStripMenuItem.Click
        food_details.Show()

    End Sub

    Private Sub CloseToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CloseToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub ChangePasswordToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ChangePasswordToolStripMenuItem.Click
        change_pwd.Show()
    End Sub

    Private Sub HelpToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        bill.Show()
    End Sub

    Private Sub BackUpToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BackUpToolStripMenuItem.Click
        backup.Show()
    End Sub

    Private Sub main_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        For Each prog As Process In Process.GetProcesses
            If prog.ProcessName = "WindowsApplication5" Then
                prog.Kill()
            End If
        Next
    End Sub

    Private Sub main_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        con.Open("dsn=abc")
        Me.Enabled = True
    End Sub

    Private Sub ByBillToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ByBillToolStripMenuItem.Click
        bill1.Show()
    End Sub

    Private Sub ViewByToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ViewByToolStripMenuItem.Click
        report.Show()
    End Sub
End Class
