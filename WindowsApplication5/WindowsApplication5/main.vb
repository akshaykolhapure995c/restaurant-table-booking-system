Public Class main
    Private Sub SalesToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SalesToolStripMenuItem.Click
        Me.Enabled = False
        sales.Show()
    End Sub

    Private Sub WaiterToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles WaiterToolStripMenuItem.Click
        waiter_details.Show()
        Me.Enabled = False
    End Sub

    Private Sub FoodItemToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FoodItemToolStripMenuItem.Click
        food_details.Show()
        Me.Enabled = False
    End Sub

    Private Sub TablesToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TablesToolStripMenuItem.Click
        tables.Show()
        Me.Enabled = False
    End Sub

    Private Sub CloseToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CloseToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub GroundFloorToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        view_gnd_table.Show()
        Me.Enabled = False
    End Sub
End Class
