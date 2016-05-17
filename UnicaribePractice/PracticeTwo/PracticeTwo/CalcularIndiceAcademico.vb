Imports System.Collections.Generic
Imports System.Linq

Public Class CalcularIndiceAcademico
    Private lista As List(Of Asignatura) = New List(Of Asignatura)
    Private totalCreditoObtenido As Integer
    Private totalPuntoObtenido As Integer
    Private indiceFinal As Double

    Private Sub CalcularIndiceAcademico_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        

        Dim info As Asignatura = New Asignatura()
        info.Nombre = "INFORMATICA"
        info.Credito = 3

        Dim mate As Asignatura = New Asignatura()
        mate.Nombre = "MATEMATICA"
        mate.Credito = 3

        Dim lengua As Asignatura = New Asignatura()
        lengua.Nombre = "LENGUA ESPAÑOLA"
        lengua.Credito = 4

        Dim prog As Asignatura = New Asignatura()
        prog.Nombre = "PROGRAMACION I"
        prog.Credito = 3



        lista.Add(info)
        lista.Add(mate)
        lista.Add(lengua)
        lista.Add(prog)

        For Each item In lista
            ComboBoxAsignatura.Items.Add(item)
        Next
    End Sub



    Private Sub ComboBoxAsignatura_SelectedValueChanged(sender As System.Object, e As System.EventArgs) Handles ComboBoxAsignatura.SelectedValueChanged
        Dim datos = ComboBoxAsignatura.SelectedItem().ToString()
        For Each item In lista
            If datos.Equals(item.Nombre) Then
                TextBoxCredito.Text = item.Credito
                Exit For
            End If
        Next
    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        Dim calificacion As Integer

        'Validar el ComboBox
        If ComboBoxAsignatura.SelectedIndex = -1 Then
            MsgBox("Selecciones una asignatura")
            ComboBoxAsignatura.Focus()
        End If


        If Integer.TryParse(TextBoxCalificacion.Text, calificacion) And calificacion > 0 Then
            Dim isExit As Boolean = True


            Dim msg = String.Format("Asig: {0}  Cr: {1}  Ca: {2} ", ComboBoxAsignatura.SelectedItem.ToString(), TextBoxCredito.Text, TextBoxCalificacion.Text)

            If ListBoxAsignatura.Items.Count > 0 Then
                For Each item In ListBoxAsignatura.Items
                    If item.ToString().Contains(ComboBoxAsignatura.SelectedItem.ToString()) Then
                        MsgBox("Existe")
                        isExit = False
                        Exit For
                    End If
                Next

            Else

            End If

            If isExit Then
                ListBoxAsignatura.Items.Add(msg)

                'Multiplicar CREDITO POR CALIFICACION 
                Dim cr As Integer = Integer.Parse(TextBoxCredito.Text)
                Dim cal As Integer = Integer.Parse(TextBoxCalificacion.Text)
                Dim result As Integer = cr * cal

                totalCreditoObtenido += cr
                totalPuntoObtenido += (cr * cal)
                indiceFinal = (totalPuntoObtenido / totalCreditoObtenido) / 25

                LabelIndiceFinal.Text = String.Format("{0:#0.00}", indiceFinal)




            End If
        Else
            MsgBox("Ingrese calificación correcta")
            'mostrar por pantalla que ingrese una calificacion
        End If

    End Sub
End Class