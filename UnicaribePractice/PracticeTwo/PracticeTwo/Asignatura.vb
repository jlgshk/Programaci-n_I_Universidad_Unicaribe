Public Class Asignatura
    Public Nombre As String
    Public Credito As Integer

    Public Overrides Function ToString() As String
        Return String.Format("{0}", Nombre)
    End Function

End Class
