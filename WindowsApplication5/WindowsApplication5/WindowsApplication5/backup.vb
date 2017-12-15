Imports System.IO

Public Class backup

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click

        Using openDialog As New OpenFileDialog()
            openDialog.CheckFileExists = True
            openDialog.CheckPathExists = True
            openDialog.Filter = "Microsoft Access Database (*.accdb)|*.accdb"
            openDialog.RestoreDirectory = True


            Using saveDialog As New SaveFileDialog()

                saveDialog.Filter = "Microsoft Access Database (*.accdb)|*.accdb"
                saveDialog.RestoreDirectory = True

                If openDialog.ShowDialog() = Windows.Forms.DialogResult.OK AndAlso saveDialog.ShowDialog() = Windows.Forms.DialogResult.OK Then
                    If File.Exists(openDialog.FileName) Then
                        File.Copy(openDialog.FileName, saveDialog.FileName)
                        MsgBox("Backed up data successfully.", MsgBoxStyle.Information, "Done")

                    End If
                End If
            End Using
        End Using
    End Sub

    Private Sub backup_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
    Private Sub backup_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        Me.Enabled = False
        main.Enabled = True
    End Sub
End Class