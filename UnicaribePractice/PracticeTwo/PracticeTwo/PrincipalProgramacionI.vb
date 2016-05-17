Public Class PrincipalProgramacionI

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        Dim a As AverageNotes = New AverageNotes()
        a.ShowDialog()
    End Sub

    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs) Handles Button2.Click
        Dim counter As Counter1To100 = New Counter1To100()
        counter.ShowDialog()
    End Sub

    Private Sub Button4_Click(sender As System.Object, e As System.EventArgs) Handles Button4.Click
        Dim diff As DiferentDates = New DiferentDates()
        diff.ShowDialog()

    End Sub

    Private Sub Button5_Click(sender As System.Object, e As System.EventArgs) Handles Button5.Click
        Dim indice As CalcularIndiceAcademico = New CalcularIndiceAcademico()
        indice.ShowDialog()
    End Sub

    Private Sub Button3_Click(sender As System.Object, e As System.EventArgs) Handles Button3.Click
        Dim primo As NumeroPrimos = New NumeroPrimos()
        primo.ShowDialog()
    End Sub
End Class