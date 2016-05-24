<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmIdentifiedNumberPosAndNeg
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
        Me.NegativeListBox = New System.Windows.Forms.ListBox()
        Me.PositiveListBox = New System.Windows.Forms.ListBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.CounterLabel = New System.Windows.Forms.Label()
        Me.ErrorProvider = New System.Windows.Forms.ErrorProvider(Me.components)
        CType(Me.ErrorProvider, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(15, 20)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(85, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Ingresa Número:"
        '
        'NumberTextBox
        '
        Me.NumberTextBox.Location = New System.Drawing.Point(106, 17)
        Me.NumberTextBox.Name = "NumberTextBox"
        Me.NumberTextBox.Size = New System.Drawing.Size(66, 20)
        Me.NumberTextBox.TabIndex = 1
        '
        'NegativeListBox
        '
        Me.NegativeListBox.FormattingEnabled = True
        Me.NegativeListBox.Location = New System.Drawing.Point(16, 89)
        Me.NegativeListBox.Name = "NegativeListBox"
        Me.NegativeListBox.Size = New System.Drawing.Size(55, 212)
        Me.NegativeListBox.TabIndex = 5
        '
        'PositiveListBox
        '
        Me.PositiveListBox.FormattingEnabled = True
        Me.PositiveListBox.Location = New System.Drawing.Point(114, 89)
        Me.PositiveListBox.Name = "PositiveListBox"
        Me.PositiveListBox.Size = New System.Drawing.Size(49, 212)
        Me.PositiveListBox.TabIndex = 6
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(13, 55)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(58, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Negativos:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(111, 55)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(52, 13)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Positivos:"
        '
        'CounterLabel
        '
        Me.CounterLabel.AutoSize = True
        Me.CounterLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CounterLabel.ForeColor = System.Drawing.Color.CornflowerBlue
        Me.CounterLabel.Location = New System.Drawing.Point(99, 324)
        Me.CounterLabel.Name = "CounterLabel"
        Me.CounterLabel.Size = New System.Drawing.Size(95, 16)
        Me.CounterLabel.TabIndex = 7
        Me.CounterLabel.Text = "Contador: 00"
        '
        'ErrorProvider
        '
        Me.ErrorProvider.ContainerControl = Me
        '
        'FrmIdentifiedNumberPosAndNeg
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Orange
        Me.ClientSize = New System.Drawing.Size(206, 349)
        Me.Controls.Add(Me.CounterLabel)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.PositiveListBox)
        Me.Controls.Add(Me.NegativeListBox)
        Me.Controls.Add(Me.NumberTextBox)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmIdentifiedNumberPosAndNeg"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Positivos y Negativos"
        CType(Me.ErrorProvider, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents NumberTextBox As System.Windows.Forms.TextBox
    Friend WithEvents NegativeListBox As System.Windows.Forms.ListBox
    Friend WithEvents PositiveListBox As System.Windows.Forms.ListBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents CounterLabel As System.Windows.Forms.Label
    Friend WithEvents ErrorProvider As System.Windows.Forms.ErrorProvider
End Class
