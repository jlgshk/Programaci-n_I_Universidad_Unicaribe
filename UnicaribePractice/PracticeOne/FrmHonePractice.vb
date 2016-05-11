Imports System.Text


Public Class FrmHonePractice
    Dim listOfNum As List(Of Integer)

    Private Sub FrmHonePractice_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        listOfNum = New List(Of Integer)
        Dim sb = New StringBuilder()
        sb.AppendLine("Jorge Luis Guzmán Saldaña").AppendLine("Matrícula: 2014-3825").AppendLine("Asignatura: Programación I")

        Label2.Text = sb.ToString()
    End Sub

    Private Sub ClearListViewBox()
        DisplayDataListBox.Items.Clear()
    End Sub

    Private Sub ClearListOfNum()
        Me.listOfNum.Clear()
    End Sub

    Private Sub FillListViewBox()
        ClearListViewBox()

        For Each item In listOfNum
            DisplayDataListBox.Items.Add(item)
        Next
    End Sub

    Private Sub BtnImpares_Click(sender As System.Object, e As System.EventArgs) Handles BtnImpares.Click
        ClearListOfNum()
        'contar los numero impares del 500 al 1 incluyendo el 500 aunque sea par.
        For c = 500 To 1 Step -1
            If c Mod 2 <> 0 Or c = 500 Then
                listOfNum.Add(c)
            End If
        Next
        FillListViewBox()

    End Sub

    Private Sub BtnPares_Click(sender As System.Object, e As System.EventArgs) Handles BtnPares.Click
        ClearListOfNum()
        'Contar los numero pares del 1 al 600 incluyendo el 1 aunque no sea par..
        For c = 1 To 600
            If c Mod 2 = 0 Or c = 1 Then
                listOfNum.Add(c)
            End If
        Next
        FillListViewBox()
    End Sub

    Public Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        Dim val As Integer
        If Integer.TryParse(TxtTable.Text, val) And val <= 12 And val > 0 Then
            GenerateTable(val)
        Else
            Dim msg = String.Format("Ingresar un valor correcto del 1 al 12")
            MsgBox(msg)
            TxtTable.Text = String.Empty

        End If

        TxtTable.Focus()
    End Sub

    Private Sub GenerateTable(num As Integer)
        ClearListViewBox()
        For item = 1 To 12
            Dim output = String.Format("{0} x {1} = {2}", item, num, (item * num))
            DisplayDataListBox.Items.Add(output)
        Next
    End Sub
End Class
