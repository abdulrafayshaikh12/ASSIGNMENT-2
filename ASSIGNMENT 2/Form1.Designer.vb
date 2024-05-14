<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form
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
        Me.Bn1 = New System.Windows.Forms.Button()
        Me.Bn2 = New System.Windows.Forms.Button()
        Me.Lb1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Bn1
        '
        Me.Bn1.BackColor = System.Drawing.Color.SkyBlue
        Me.Bn1.Font = New System.Drawing.Font("Modern No. 20", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Bn1.Location = New System.Drawing.Point(183, 160)
        Me.Bn1.Name = "Bn1"
        Me.Bn1.Size = New System.Drawing.Size(128, 73)
        Me.Bn1.TabIndex = 0
        Me.Bn1.Text = "Searching"
        Me.Bn1.UseVisualStyleBackColor = False
        '
        'Bn2
        '
        Me.Bn2.BackColor = System.Drawing.Color.SkyBlue
        Me.Bn2.Font = New System.Drawing.Font("Modern No. 20", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Bn2.Location = New System.Drawing.Point(403, 160)
        Me.Bn2.Name = "Bn2"
        Me.Bn2.Size = New System.Drawing.Size(132, 73)
        Me.Bn2.TabIndex = 1
        Me.Bn2.Text = "Sorting"
        Me.Bn2.UseVisualStyleBackColor = False
        '
        'Lb1
        '
        Me.Lb1.AutoSize = True
        Me.Lb1.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Lb1.Font = New System.Drawing.Font("Modern No. 20", 24.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lb1.Location = New System.Drawing.Point(177, 55)
        Me.Lb1.Name = "Lb1"
        Me.Lb1.Size = New System.Drawing.Size(385, 34)
        Me.Lb1.TabIndex = 2
        Me.Lb1.Text = "Welcome to My First Page"
        '
        'Form
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Lb1)
        Me.Controls.Add(Me.Bn2)
        Me.Controls.Add(Me.Bn1)
        Me.Name = "Form"
        Me.Text = "Form"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Bn1 As Button
    Friend WithEvents Bn2 As Button
    Friend WithEvents Lb1 As Label
End Class
