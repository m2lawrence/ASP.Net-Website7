
Partial Class MasterPage2
    Inherits System.Web.UI.MasterPage

    Private Sub MasterPage2_Load(sender As Object, e As EventArgs) Handles Me.Load
        LblHeader.Text = Session("header")
    End Sub
End Class

