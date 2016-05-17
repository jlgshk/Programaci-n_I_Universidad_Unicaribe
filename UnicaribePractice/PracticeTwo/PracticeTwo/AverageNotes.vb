Public Class AverageNotes

    Private averageResult As Integer
    Private lbNotes As String
    Private contador As Integer = 0
    Private acumulador As Integer

    Private Sub ClearNotes()
        LblNotes.Text = "Calificaciones: "
        LblResult.Text = String.Empty
        LblResult.ForeColor = Color.Black
        averageResult = 0
        contador = 0
        acumulador = 0
        TextBoxNote.Text = String.Empty
        TextBoxNote.Focus()

    End Sub

    Private Sub Form1_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        ClearNotes()


    End Sub

    Private Sub Btn_Click(sender As System.Object, e As System.EventArgs) Handles Btn.Click
        ClearNotes()
    End Sub

    Private Sub TextBoxNote_KeyDown(sender As System.Object, e As System.Windows.Forms.KeyEventArgs) Handles TextBoxNote.KeyDown
        Dim data As Integer = 0

        If e.KeyData = Keys.Enter Then
            If Not contador = 6 Then
                If Integer.TryParse(TextBoxNote.Text, data) And data > 0 And data <= 100 Then
                    'Agregar logica para mostrar promedio y calificaciones en un label
                    LblNotes.Text += TextBoxNote.Text + " "
                    TextBoxNote.Text = String.Empty
                    acumulador += data
                    contador += 1
                    LblResult.Text = String.Format("{0:#.00}", (acumulador / contador))
                    DisplayLabelResulColor((acumulador / contador))

                Else
                    MsgBox("Debe ingresar un calficación correcta.", MsgBoxStyle.Critical, "Error ingresando datos")
                    TextBoxNote.Text = String.Empty
                    TextBoxNote.Focus()

                End If
            Else
                MsgBox("Maximo de calificación ingresa.", MsgBoxStyle.Information, "Reporte")
            End If

        End If
    End Sub

    Private Sub DisplayLabelResulColor(promedio As Integer)
        Select Case promedio
            Case 90 To 100
                LblResult.ForeColor = Color.Green
            Case 80 To 89
                LblResult.ForeColor = Color.Blue
            Case 70 To 79
                LblResult.ForeColor = Color.RoyalBlue
            Case 1 To 69
                LblResult.ForeColor = Color.Red
        End Select
    End Sub
End Class
