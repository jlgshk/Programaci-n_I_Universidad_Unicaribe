<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CalcularIndiceAcademico
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TextBoxCredito = New System.Windows.Forms.TextBox()
        Me.ComboBoxAsignatura = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TextBoxCalificacion = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.ListBoxAsignatura = New System.Windows.Forms.ListBox()
        Me.LabelIndiceFinal = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(171, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "CALCULAR INDICE ACADEMICO:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(30, 95)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(43, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Credito:"
        '
        'TextBoxCredito
        '
        Me.TextBoxCredito.Location = New System.Drawing.Point(75, 92)
        Me.TextBoxCredito.Name = "TextBoxCredito"
        Me.TextBoxCredito.ReadOnly = True
        Me.TextBoxCredito.Size = New System.Drawing.Size(50, 20)
        Me.TextBoxCredito.TabIndex = 2
        '
        'ComboBoxAsignatura
        '
        Me.ComboBoxAsignatura.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBoxAsignatura.FormattingEnabled = True
        Me.ComboBoxAsignatura.Location = New System.Drawing.Point(75, 52)
        Me.ComboBoxAsignatura.Name = "ComboBoxAsignatura"
        Me.ComboBoxAsignatura.Size = New System.Drawing.Size(170, 21)
        Me.ComboBoxAsignatura.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 55)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(57, 13)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "Asignatura"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(12, 319)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(95, 13)
        Me.Label4.TabIndex = 1
        Me.Label4.Text = "Indice Académico:"
        '
        'TextBoxCalificacion
        '
        Me.TextBoxCalificacion.Location = New System.Drawing.Point(100, 133)
        Me.TextBoxCalificacion.Name = "TextBoxCalificacion"
        Me.TextBoxCalificacion.Size = New System.Drawing.Size(83, 20)
        Me.TextBoxCalificacion.TabIndex = 4
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(133, 186)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(112, 23)
        Me.Button1.TabIndex = 5
        Me.Button1.Text = "Generar Indice"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'ListBoxAsignatura
        '
        Me.ListBoxAsignatura.FormattingEnabled = True
        Me.ListBoxAsignatura.Location = New System.Drawing.Point(304, 13)
        Me.ListBoxAsignatura.Name = "ListBoxAsignatura"
        Me.ListBoxAsignatura.Size = New System.Drawing.Size(247, 212)
        Me.ListBoxAsignatura.TabIndex = 6
        '
        'LabelIndiceFinal
        '
        Me.LabelIndiceFinal.AutoSize = True
        Me.LabelIndiceFinal.Location = New System.Drawing.Point(113, 319)
        Me.LabelIndiceFinal.Name = "LabelIndiceFinal"
        Me.LabelIndiceFinal.Size = New System.Drawing.Size(0, 13)
        Me.LabelIndiceFinal.TabIndex = 7
        '
        'CalcularIndiceAcademico
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(563, 359)
        Me.Controls.Add(Me.LabelIndiceFinal)
        Me.Controls.Add(Me.ListBoxAsignatura)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.TextBoxCalificacion)
        Me.Controls.Add(Me.ComboBoxAsignatura)
        Me.Controls.Add(Me.TextBoxCredito)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "CalcularIndiceAcademico"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "CalcularIndiceAcademico"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents TextBoxCredito As System.Windows.Forms.TextBox
    Friend WithEvents ComboBoxAsignatura As System.Windows.Forms.ComboBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents TextBoxCalificacion As System.Windows.Forms.TextBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents ListBoxAsignatura As System.Windows.Forms.ListBox
    Friend WithEvents LabelIndiceFinal As System.Windows.Forms.Label
End Class
