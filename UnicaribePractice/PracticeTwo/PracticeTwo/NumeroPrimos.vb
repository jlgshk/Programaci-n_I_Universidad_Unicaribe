Public Class NumeroPrimos

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        For x = 1 To 100
            If EsPrimo(x) Then
                ListBox1.Items.Add(x)
            End If
        Next
    End Sub

    Private Function EsPrimo(a As Integer) As Boolean
        For i = 2 To a / 2
            If a Mod 2 = 0 Then
                Return False
            End If
        Next
        Return True
    End Function

End Class