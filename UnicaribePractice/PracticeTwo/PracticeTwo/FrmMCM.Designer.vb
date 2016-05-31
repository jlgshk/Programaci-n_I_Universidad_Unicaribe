<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmMCM
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
        Me.Num1TextBox = New System.Windows.Forms.TextBox()
        Me.Num2TextBox = New System.Windows.Forms.TextBox()
        Me.MCMButton = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 24)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(56, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Número 1:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 81)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(56, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Número 2:"
        '
        'Num1TextBox
        '
        Me.Num1TextBox.Location = New System.Drawing.Point(74, 24)
        Me.Num1TextBox.Name = "Num1TextBox"
        Me.Num1TextBox.Size = New System.Drawing.Size(100, 20)
        Me.Num1TextBox.TabIndex = 1
        '
        'Num2TextBox
        '
        Me.Num2TextBox.Location = New System.Drawing.Point(74, 78)
        Me.Num2TextBox.Name = "Num2TextBox"
        Me.Num2TextBox.Size = New System.Drawing.Size(100, 20)
        Me.Num2TextBox.TabIndex = 4
        '
        'MCMButton
        '
        Me.MCMButton.Location = New System.Drawing.Point(114, 104)
        Me.MCMButton.Name = "MCMButton"
        Me.MCMButton.Size = New System.Drawing.Size(60, 48)
        Me.MCMButton.TabIndex = 5
        Me.MCMButton.Text = "Buscar M. C. M."
        Me.MCMButton.UseVisualStyleBackColor = True
        '
        'FrmMCM
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(222, 186)
        Me.Controls.Add(Me.MCMButton)
        Me.Controls.Add(Me.Num2TextBox)
        Me.Controls.Add(Me.Num1TextBox)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmMCM"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Minimo Común Multiplo"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Num1TextBox As System.Windows.Forms.TextBox
    Friend WithEvents Num2TextBox As System.Windows.Forms.TextBox
    Friend WithEvents MCMButton As System.Windows.Forms.Button
End Class
