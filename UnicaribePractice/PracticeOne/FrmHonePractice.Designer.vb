<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmHonePractice
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmHonePractice))
        Me.DisplayDataListBox = New System.Windows.Forms.ListBox()
        Me.BtnImpares = New System.Windows.Forms.Button()
        Me.BtnPares = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.TxtTable = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DisplayDataListBox
        '
        Me.DisplayDataListBox.BackColor = System.Drawing.SystemColors.HotTrack
        Me.DisplayDataListBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DisplayDataListBox.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.DisplayDataListBox.FormattingEnabled = True
        Me.DisplayDataListBox.ItemHeight = 20
        Me.DisplayDataListBox.Location = New System.Drawing.Point(381, 13)
        Me.DisplayDataListBox.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.DisplayDataListBox.Name = "DisplayDataListBox"
        Me.DisplayDataListBox.Size = New System.Drawing.Size(304, 424)
        Me.DisplayDataListBox.TabIndex = 8
        '
        'BtnImpares
        '
        Me.BtnImpares.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.BtnImpares.Location = New System.Drawing.Point(12, 13)
        Me.BtnImpares.Name = "BtnImpares"
        Me.BtnImpares.Size = New System.Drawing.Size(363, 56)
        Me.BtnImpares.TabIndex = 1
        Me.BtnImpares.Text = "Num. Impares del 500 al 1 { Incluyendo el 500 }"
        Me.BtnImpares.UseVisualStyleBackColor = True
        '
        'BtnPares
        '
        Me.BtnPares.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.BtnPares.Location = New System.Drawing.Point(12, 75)
        Me.BtnPares.Name = "BtnPares"
        Me.BtnPares.Size = New System.Drawing.Size(363, 56)
        Me.BtnPares.TabIndex = 2
        Me.BtnPares.Text = "Num. pares del 1 al 600 { Incluyendo el 1 }"
        Me.BtnPares.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.TxtTable)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.Button1)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 137)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(363, 158)
        Me.GroupBox1.TabIndex = 3
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Tabla de multiplicar {Demo}"
        '
        'TxtTable
        '
        Me.TxtTable.Location = New System.Drawing.Point(134, 37)
        Me.TxtTable.Name = "TxtTable"
        Me.TxtTable.Size = New System.Drawing.Size(87, 22)
        Me.TxtTable.TabIndex = 5
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label1.Location = New System.Drawing.Point(6, 37)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(121, 16)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Ingrese un número:"
        '
        'Button1
        '
        Me.Button1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Button1.Location = New System.Drawing.Point(9, 80)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(348, 56)
        Me.Button1.TabIndex = 6
        Me.Button1.Text = "Generar tabla"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.PracticeOne.My.Resources.Resources.UNICARIBE_LOGO
        Me.PictureBox1.Location = New System.Drawing.Point(12, 301)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(147, 148)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 3
        Me.PictureBox1.TabStop = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label2.Location = New System.Drawing.Point(165, 392)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(49, 16)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Label2"
        '
        'FrmHonePractice
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(697, 460)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.BtnPares)
        Me.Controls.Add(Me.BtnImpares)
        Me.Controls.Add(Me.DisplayDataListBox)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.SystemColors.Control
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmHonePractice"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Práctica I : Programación I {Unicaribe}"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DisplayDataListBox As System.Windows.Forms.ListBox
    Friend WithEvents BtnImpares As System.Windows.Forms.Button
    Friend WithEvents BtnPares As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents TxtTable As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Label2 As System.Windows.Forms.Label

End Class
