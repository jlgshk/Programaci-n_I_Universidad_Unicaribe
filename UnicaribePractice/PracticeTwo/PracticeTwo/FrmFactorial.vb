Public Class FrmFactorial

    Private Sub DisplayFactorialButton_Click(sender As System.Object, e As System.EventArgs) Handles DisplayFactorialButton.Click
        Dim val As Integer
        If Integer.TryParse(NumberTextBox.Text, val) And val > 0 Then
            'GenerateTable(val)
            Try
                Dim output As Decimal = GenerateFactorial(val)

                MsgBox(String.Format("Factorial del {0} : {1:n0}", val, output), MsgBoxStyle.Information, "Factorial")

            Catch ex As Exception
                MsgBox("RESULTADO NO SOPORTADO", MsgBoxStyle.Critical, "ERROR")

            End Try
            NumberTextBox.Text = String.Empty
        Else
            Dim msg = String.Format("Debe ingresar un número positivo.")
            MsgBox(msg)
            NumberTextBox.Text = String.Empty

        End If

        NumberTextBox.Focus()
    End Sub

    Protected Function GenerateFactorial(num As Integer)
        Dim result As Decimal = 1
        Try
            For x = 1 To num
                result *= x
            Next
        Catch ex As Exception
            Return ex
        End Try

        Return result

    End Function

End Class