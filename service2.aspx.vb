
Partial Class service2
    Inherits System.Web.UI.Page

    Private Sub service2_Load(sender As Object, e As EventArgs) Handles Me.Load
        Session("header") = "Flowers"
    End Sub
End Class
