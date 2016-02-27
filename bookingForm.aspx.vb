
Partial Class bookingForm
    Inherits System.Web.UI.Page

    Private Sub bookingForm_Load(sender As Object, e As EventArgs) Handles Me.Load
        Session("header") = "Booking Form"

    End Sub

    Protected Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click

        If txtFirstName.Text.Trim = "" Then
            Exit Sub
        End If

        If txtLastName.Text.Trim = "" Then
            Exit Sub
        End If

        If txtEmailAddress.Text.Trim = "" Then
            Exit Sub
        End If

        If txtMobileNo.Text.Trim = "" Then
            Exit Sub
        End If

        If txtHomeAddress.Text.Trim = "" Then
            Exit Sub
        End If

        Dim index1 As Integer 'dimension 1
        Dim index2 As Integer 'dimension 2

        'it goes to the row and asks what is in column 1 and 2. 
        Dim testArray2D(4, 2) As String '(4=rows, 2=columns)

        testArray2D(0, 0) = "Happy Green Giant Ltd - Customer's Invoice!" + vbCrLf + vbCrLf + "1. Customer's Name: "
        testArray2D(0, 1) = txtFirstName.Text

        testArray2D(1, 0) = " "
        testArray2D(1, 1) = txtLastName.Text + vbCrLf

        testArray2D(2, 0) = "2. Email Address: "
        testArray2D(2, 1) = txtEmailAddress.Text + vbCrLf

        testArray2D(3, 0) = "3. Mobile Number: "
        testArray2D(3, 1) = txtMobileNo.Text + vbCrLf

        testArray2D(4, 0) = "4. Delivery Address: "
        testArray2D(4, 1) = txtHomeAddress.Text + vbCrLf

        txtSummary.Text = ""
        For index1 = 0 To 4
            For index2 = 0 To 1
                txtSummary.Text += testArray2D(index1, index2)
            Next
        Next
        txtSummary.Text += "5. Product: " + DropDownProducts.SelectedItem.Text + vbCrLf
        txtSummary.Text += "6. Unit Quantity: " + DropDownListQuantity.Text + vbCrLf
        txtSummary.Text += "7. Unit Price: £" + txtUnitPrice.Text + vbCrLf
        txtSummary.Text += "8. Total Cost: £" + TextBoxSummary.Text

    End Sub


    Protected Sub DropDownProducts_SelectedIndexChanged(sender As Object, e As EventArgs) Handles DropDownProducts.SelectedIndexChanged

        If DropDownProducts.SelectedValue = "1" Then
            'Flowers £5.
            txtUnitPrice.Text = "5"

        ElseIf DropDownProducts.SelectedValue = "2" Then
            'Seeds £4.
            txtUnitPrice.Text = "4"
        ElseIf DropDownProducts.SelectedValue = "3" Then
            'Bug £1.
            txtUnitPrice.Text = "1"
        Else
            'Grass Lawn Square £3.
            txtUnitPrice.Text = "3"
        End If

        TextBoxSummary.Text = Val(txtUnitPrice.Text) * Val(DropDownListQuantity.Text)
    End Sub

    Protected Sub DropDownListQuantity_SelectedIndexChanged(sender As Object, e As EventArgs) Handles DropDownListQuantity.SelectedIndexChanged
        TextBoxSummary.Text = Val(txtUnitPrice.Text) * Val(DropDownListQuantity.Text)
    End Sub
End Class



'For ROWS = 0 To 2
'    For Columns = 0 To 1


'        txtSummary.Text += testArray2D(ROWS, Columns)
'    Next
'Next
'For ROWS = 0 To 2
'    txtSummary.Text += testArray2D(ROWS, 0)
'    txtSummary.Text += testArray2D(ROWS, 1)

'Next
'txtSummary.Text += testArray2D(0, 0)
'txtSummary.Text += testArray2D(0, 1)
'txtSummary.Text += testArray2D(1, 0)
'txtSummary.Text += testArray2D(1, 1)
'txtSummary.Text += testArray2D(2, 0)
'txtSummary.Text += testArray2D(2, 1)



