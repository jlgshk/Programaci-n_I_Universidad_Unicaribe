Public Class FrmIdentifiedNumberPosAndNeg

    Dim counter As Byte
    Dim isNumber As Boolean = False

    Private Sub FrmIdentifiedNumberPosAndNeg_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        ControlReset()

    End Sub

    Protected Sub ControlReset()
        CounterLabel.Text = String.Empty
        NegativeListBox.Items.Clear()
        PositiveListBox.Items.Clear()
        NumberTextBox.Text = String.Empty
        counter = 10
    End Sub

    Protected Sub DoCounter(data As Byte, predicate As Boolean)
        If predicate Then 'If predicate is true counter is one less
            Me.counter -= 1
        Else 'Else predicate is false up one
            Me.counter += 1
        End If

    End Sub


    Private Sub NumberTextBox_KeyDown(sender As System.Object, e As System.Windows.Forms.KeyEventArgs) Handles NumberTextBox.KeyDown
        Dim data As Integer = 0

        If e.KeyData = Keys.Enter Then
            If Not counter = 0 Then
                If Integer.TryParse(NumberTextBox.Text, data) Then
                    If data = 0 Then

                        MsgBox("Debes ingresar un número diferente a cero", MsgBoxStyle.Information, "Información")
                        isNumber = False
                    ElseIf data >= 1 Then
                        PositiveListBox.Items.Add(data.ToString)
                        isNumber = True
                    Else
                        NegativeListBox.Items.Add(data.ToString)
                        isNumber = True
                    End If

                    If isNumber Then
                        DoCounter(1, True)
                        CounterLabel.Text = String.Format("Contador {0}", Me.counter)
                        NumberTextBox.Text = String.Empty
                    Else
                        NumberTextBox.Text = String.Empty
                    End If
                Else
                    MsgBox("Debes ingresar un numero positivo o negativo", MsgBoxStyle.Information, "Información")
                    NumberTextBox.Text = String.Empty
                End If

            Else
                MsgBox("Ha agotado la cantidad de número a ingresar, por favor presione el botón de reiniciar para empezar de nuevo", MsgBoxStyle.Information, "Información")

            End If

        End If
    End Sub
End Class