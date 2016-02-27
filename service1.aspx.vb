
Partial Class service1
    Inherits System.Web.UI.Page

    Private Sub service1_Load(sender As Object, e As EventArgs) Handles Me.Load
        Session("header") = "Lawn Care"
    End Sub
End Class
