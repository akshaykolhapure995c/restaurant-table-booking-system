Public Class firstpage
    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        Label1.ForeColor = Color.Lavender
        Timer2.Enabled = True
        Timer1.Enabled = False
    End Sub

    Private Sub Timer2_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer2.Tick

        Label1.ForeColor = Color.BlanchedAlmond
        Timer1.Enabled = True
        Timer2.Enabled = False
    End Sub

    Private Sub LinkLabel1_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        login.Show()
        Me.Hide()
    End Sub

    Private Sub LinkLabel2_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel2.LinkClicked
        login.Show()
        Me.Hide()
    End Sub

    Private Sub firstpage_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        LinkLabel1.Focus()
    End Sub

    Private Sub LinkLabel1_PreviewKeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.PreviewKeyDownEventArgs) Handles LinkLabel1.PreviewKeyDown
        If e.KeyCode = Keys.Escape Then
            Me.Close()
        End If
    End Sub
End Class