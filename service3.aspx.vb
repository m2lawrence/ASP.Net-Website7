
Partial Class service3
    Inherits System.Web.UI.Page

    Private Sub service3_Load(sender As Object, e As EventArgs) Handles Me.Load
        Session("header") = "Garden Creatures"
    End Sub
End Class
