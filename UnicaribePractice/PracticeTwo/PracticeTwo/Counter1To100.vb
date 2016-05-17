Public Class Counter1To100

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        If ListBoxCounter.Items.Count > 0 Then
            ListBoxCounter.Items.Clear()
        End If
        For x = 1 To 100
            If x <> 25 Then
                ListBoxCounter.Items.Add(x)
            End If
        Next
    End Sub
End Class