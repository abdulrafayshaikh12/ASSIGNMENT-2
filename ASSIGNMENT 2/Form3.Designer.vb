<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frmsort
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
        Me.Bn7 = New System.Windows.Forms.Button()
        Me.Bn8 = New System.Windows.Forms.Button()
        Me.Bn9 = New System.Windows.Forms.Button()
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.SuspendLayout()
        '
        'Bn7
        '
        Me.Bn7.BackColor = System.Drawing.Color.SkyBlue
        Me.Bn7.Font = New System.Drawing.Font("Modern No. 20", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Bn7.Location = New System.Drawing.Point(78, 75)
        Me.Bn7.Name = "Bn7"
        Me.Bn7.Size = New System.Drawing.Size(143, 74)
        Me.Bn7.TabIndex = 0
        Me.Bn7.Text = "Bubble Sort"
        Me.Bn7.UseVisualStyleBackColor = False
        '
        'Bn8
        '
        Me.Bn8.BackColor = System.Drawing.Color.SkyBlue
        Me.Bn8.Font = New System.Drawing.Font("Modern No. 20", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Bn8.Location = New System.Drawing.Point(78, 183)
        Me.Bn8.Name = "Bn8"
        Me.Bn8.Size = New System.Drawing.Size(143, 72)
        Me.Bn8.TabIndex = 1
        Me.Bn8.Text = "Insertion Sort"
        Me.Bn8.UseVisualStyleBackColor = False
        '
        'Bn9
        '
        Me.Bn9.BackColor = System.Drawing.Color.SkyBlue
        Me.Bn9.Font = New System.Drawing.Font("Modern No. 20", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Bn9.Location = New System.Drawing.Point(586, 137)
        Me.Bn9.Name = "Bn9"
        Me.Bn9.Size = New System.Drawing.Size(124, 70)
        Me.Bn9.TabIndex = 2
        Me.Bn9.Text = "Main Menu"
        Me.Bn9.UseVisualStyleBackColor = False
        '
        'ListBox1
        '
        Me.ListBox1.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.ListBox1.Font = New System.Drawing.Font("Modern No. 20", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.ItemHeight = 18
        Me.ListBox1.Location = New System.Drawing.Point(285, 12)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(120, 310)
        Me.ListBox1.TabIndex = 3
        '
        'Frmsort
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.ListBox1)
        Me.Controls.Add(Me.Bn9)
        Me.Controls.Add(Me.Bn8)
        Me.Controls.Add(Me.Bn7)
        Me.Name = "Frmsort"
        Me.Text = "Frmsort"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Bn7 As Button
    Friend WithEvents Bn8 As Button
    Friend WithEvents Bn9 As Button
    Friend WithEvents ListBox1 As ListBox
End Class
