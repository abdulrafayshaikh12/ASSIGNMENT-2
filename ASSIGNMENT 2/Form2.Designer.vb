<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frmsearch
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
        Me.Bn3 = New System.Windows.Forms.Button()
        Me.Bn5 = New System.Windows.Forms.Button()
        Me.Bn6 = New System.Windows.Forms.Button()
        Me.Ll1 = New System.Windows.Forms.Label()
        Me.Tx1 = New System.Windows.Forms.TextBox()
        Me.LISTBOX1 = New System.Windows.Forms.ListBox()
        Me.SuspendLayout()
        '
        'Bn3
        '
        Me.Bn3.BackColor = System.Drawing.Color.SkyBlue
        Me.Bn3.Font = New System.Drawing.Font("Modern No. 20", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Bn3.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Bn3.Location = New System.Drawing.Point(203, 48)
        Me.Bn3.Name = "Bn3"
        Me.Bn3.Size = New System.Drawing.Size(112, 71)
        Me.Bn3.TabIndex = 0
        Me.Bn3.Text = "Data from External File"
        Me.Bn3.UseVisualStyleBackColor = False
        '
        'Bn5
        '
        Me.Bn5.BackColor = System.Drawing.Color.SkyBlue
        Me.Bn5.Font = New System.Drawing.Font("Modern No. 20", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Bn5.Location = New System.Drawing.Point(441, 220)
        Me.Bn5.Name = "Bn5"
        Me.Bn5.Size = New System.Drawing.Size(122, 70)
        Me.Bn5.TabIndex = 2
        Me.Bn5.Text = "Linear Search From User Data"
        Me.Bn5.UseVisualStyleBackColor = False
        '
        'Bn6
        '
        Me.Bn6.BackColor = System.Drawing.Color.SkyBlue
        Me.Bn6.Font = New System.Drawing.Font("Modern No. 20", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Bn6.Location = New System.Drawing.Point(615, 220)
        Me.Bn6.Name = "Bn6"
        Me.Bn6.Size = New System.Drawing.Size(111, 70)
        Me.Bn6.TabIndex = 3
        Me.Bn6.Text = "Binary Search From User Data"
        Me.Bn6.UseVisualStyleBackColor = False
        '
        'Ll1
        '
        Me.Ll1.AutoSize = True
        Me.Ll1.Font = New System.Drawing.Font("Modern No. 20", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Ll1.Location = New System.Drawing.Point(321, 77)
        Me.Ll1.Name = "Ll1"
        Me.Ll1.Size = New System.Drawing.Size(135, 15)
        Me.Ll1.TabIndex = 4
        Me.Ll1.Text = "Enter No. To Search"
        '
        'Tx1
        '
        Me.Tx1.Font = New System.Drawing.Font("Modern No. 20", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Tx1.Location = New System.Drawing.Point(556, 71)
        Me.Tx1.Name = "Tx1"
        Me.Tx1.Size = New System.Drawing.Size(170, 25)
        Me.Tx1.TabIndex = 5
        '
        'LISTBOX1
        '
        Me.LISTBOX1.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.LISTBOX1.Font = New System.Drawing.Font("Modern No. 20", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LISTBOX1.FormattingEnabled = True
        Me.LISTBOX1.ItemHeight = 18
        Me.LISTBOX1.Location = New System.Drawing.Point(47, 48)
        Me.LISTBOX1.Name = "LISTBOX1"
        Me.LISTBOX1.Size = New System.Drawing.Size(120, 130)
        Me.LISTBOX1.TabIndex = 6
        '
        'Frmsearch
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.LISTBOX1)
        Me.Controls.Add(Me.Tx1)
        Me.Controls.Add(Me.Ll1)
        Me.Controls.Add(Me.Bn6)
        Me.Controls.Add(Me.Bn5)
        Me.Controls.Add(Me.Bn3)
        Me.Name = "Frmsearch"
        Me.Text = "Frmsearch"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Bn3 As Button
    Friend WithEvents Bn5 As Button
    Friend WithEvents Bn6 As Button
    Friend WithEvents Ll1 As Label
    Friend WithEvents Tx1 As TextBox
    Friend WithEvents LISTBOX1 As ListBox
End Class
