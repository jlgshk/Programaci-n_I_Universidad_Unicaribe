Public Class FrmMCM
    Dim listaNum As List(Of Integer)

    Private Sub MCMButton_Click(sender As System.Object, e As System.EventArgs) Handles MCMButton.Click
        Dim num1, num2 As Integer
        listaNum = New List(Of Integer)


        If Integer.TryParse(Num1TextBox.Text, num1) And Integer.TryParse(Num2TextBox.Text, num2) And num1 > 0 And num2 > 0 Then
            MCM(num1, num2)
        Else
            MsgBox("Debe ingresar un número correcto", MsgBoxStyle.Information)
        End If

    End Sub

    Protected Sub MCM(num1 As Integer, num2 As Integer)
        Dim contador = 2
        Dim isEnter = True
        Do

            If num1 Mod contador = 0 Or num2 Mod contador = 0 And num1 > 1 And num2 > 1 Then

                If num1 Mod contador = 0 Then
                    num1 = num1 / contador
                End If

                If num2 Mod contador = 0 Then
                    num2 = num2 / contador
                End If
                listaNum.Add(contador)

            Else
                contador += 1
            End If


        Loop Until num1 = 1 And num2 = 1

        Dim MCMResult = 1
        For Each item In listaNum
            MCMResult = MCMResult * item
        Next

        MsgBox(MCMResult.ToString)


    End Sub
End Class