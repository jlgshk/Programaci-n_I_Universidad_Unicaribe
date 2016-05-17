Public Class DiferentDates

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        Dim result = Date.Compare(InitDateTimePicker.Value, EndDateTimePicker.Value)

        If result = 0 Then
            MsgBox("La fecha no puede ser igual", MsgBoxStyle.Information, "Reporte")
        ElseIf result > 0 Then
            MsgBox("La fecha inicial no puede ser mayor a la final", MsgBoxStyle.Information, "Reporte")
        Else
            Dim diffDay = DateDiff(DateInterval.Day, InitDateTimePicker.Value, EndDateTimePicker.Value)
            Dim diffHours = DateDiff(DateInterval.Hour, InitDateTimePicker.Value, EndDateTimePicker.Value)
            MsgBox(String.Format("Dias de diferencia {0}  -  Horas de diferencias {1}", diffDay, diffHours))
        End If


    End Sub
    Private Sub InicialTimePicker()
        InitDateTimePicker.Value = Date.Now
        EndDateTimePicker.Value = Date.Now
    End Sub
    Private Sub DiferentDates_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        
        InicialTimePicker()
    End Sub

    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs) Handles Button2.Click
        InicialTimePicker()
    End Sub
End Class