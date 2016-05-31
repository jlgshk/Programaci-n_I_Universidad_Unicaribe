Public Class FrmASCIICode

    Private Sub ASCIIButton_Click(sender As System.Object, e As System.EventArgs) Handles ASCIIButton.Click
        If ASCIIListBox.Items.Count > 0 Then
            ASCIIListBox.Items.Clear()
        End If
        For x = 1 To 255 Step 1
            ASCIIListBox.Items.Add(String.Format("{0} - ASCII : {1}", x, Chr(x)))
        Next
    End Sub
End Class