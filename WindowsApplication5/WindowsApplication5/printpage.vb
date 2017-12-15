Public Class printpage


    Private Sub printpage_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
  

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        PrintForm1.Form = Me
        PrintForm1.PrintAction = Printing.PrintAction.PrintToPrinter
        PrintForm1.Print()
    End Sub
End Class