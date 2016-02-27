
Partial Class contact
    Inherits System.Web.UI.Page

    Private Sub contact_Load(sender As Object, e As EventArgs) Handles Me.Load
        Session("header") = "Contact Us"
    End Sub
End Class
