<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmFactorial
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
        Me.components = New System.ComponentModel.Container()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.NumberTextBox = New System.Windows.Forms.TextBox()
        Me.DisplayError = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.DisplayFactorialButton = New System.Windows.Forms.Button()
        CType(Me.DisplayError, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(13, 22)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(50, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Factorial:"
        '
        'NumberTextBox
        '
        Me.NumberTextBox.Location = New System.Drawing.Point(69, 19)
        Me.NumberTextBox.Name = "NumberTextBox"
        Me.NumberTextBox.Size = New System.Drawing.Size(69, 20)
        Me.NumberTextBox.TabIndex = 1
        '
        'DisplayError
        '
        Me.DisplayError.ContainerControl = Me
        '
        'DisplayFactorialButton
        '
        Me.DisplayFactorialButton.Location = New System.Drawing.Point(108, 84)
        Me.DisplayFactorialButton.Name = "DisplayFactorialButton"
        Me.DisplayFactorialButton.Size = New System.Drawing.Size(112, 64)
        Me.DisplayFactorialButton.TabIndex = 2
        Me.DisplayFactorialButton.Text = "Generar"
        Me.DisplayFactorialButton.UseVisualStyleBackColor = True
        '
        'FrmFactorial
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(232, 160)
        Me.Controls.Add(Me.DisplayFactorialButton)
        Me.Controls.Add(Me.NumberTextBox)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmFactorial"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Generar el factorial de un  número. "
        CType(Me.DisplayError, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents NumberTextBox As System.Windows.Forms.TextBox
    Friend WithEvents DisplayError As System.Windows.Forms.ErrorProvider
    Friend WithEvents DisplayFactorialButton As System.Windows.Forms.Button
End Class
