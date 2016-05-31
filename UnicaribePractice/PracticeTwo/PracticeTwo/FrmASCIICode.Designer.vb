<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmASCIICode
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
        Me.ASCIIButton = New System.Windows.Forms.Button()
        Me.ASCIIListBox = New System.Windows.Forms.ListBox()
        Me.SuspendLayout()
        '
        'ASCIIButton
        '
        Me.ASCIIButton.Location = New System.Drawing.Point(13, 12)
        Me.ASCIIButton.Name = "ASCIIButton"
        Me.ASCIIButton.Size = New System.Drawing.Size(200, 50)
        Me.ASCIIButton.TabIndex = 0
        Me.ASCIIButton.Text = "ASCII"
        Me.ASCIIButton.UseVisualStyleBackColor = True
        '
        'ASCIIListBox
        '
        Me.ASCIIListBox.Font = New System.Drawing.Font("Lucida Console", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ASCIIListBox.FormattingEnabled = True
        Me.ASCIIListBox.ItemHeight = 17
        Me.ASCIIListBox.Location = New System.Drawing.Point(12, 68)
        Me.ASCIIListBox.Name = "ASCIIListBox"
        Me.ASCIIListBox.Size = New System.Drawing.Size(201, 310)
        Me.ASCIIListBox.TabIndex = 1
        '
        'FrmASCIICode
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(226, 391)
        Me.Controls.Add(Me.ASCIIListBox)
        Me.Controls.Add(Me.ASCIIButton)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmASCIICode"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Código ASCII"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ASCIIButton As System.Windows.Forms.Button
    Friend WithEvents ASCIIListBox As System.Windows.Forms.ListBox
End Class
