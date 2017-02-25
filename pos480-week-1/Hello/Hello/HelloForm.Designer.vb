<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class HelloForm
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
        Me.txtHello = New System.Windows.Forms.TextBox()
        Me.ckbMove = New System.Windows.Forms.CheckBox()
        Me.btnLanguage = New System.Windows.Forms.Button()
        Me.btnColor = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'txtHello
        '
        Me.txtHello.Font = New System.Drawing.Font("Elephant", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtHello.Location = New System.Drawing.Point(216, 49)
        Me.txtHello.Name = "txtHello"
        Me.txtHello.ReadOnly = True
        Me.txtHello.Size = New System.Drawing.Size(239, 111)
        Me.txtHello.TabIndex = 1
        Me.txtHello.Text = "Hello"
        '
        'ckbMove
        '
        Me.ckbMove.AutoSize = True
        Me.ckbMove.Location = New System.Drawing.Point(12, 163)
        Me.ckbMove.Name = "ckbMove"
        Me.ckbMove.Size = New System.Drawing.Size(161, 36)
        Me.ckbMove.TabIndex = 2
        Me.ckbMove.Text = "Moving?"
        Me.ckbMove.UseVisualStyleBackColor = True
        '
        'btnLanguage
        '
        Me.btnLanguage.Location = New System.Drawing.Point(12, 205)
        Me.btnLanguage.Name = "btnLanguage"
        Me.btnLanguage.Size = New System.Drawing.Size(297, 82)
        Me.btnLanguage.TabIndex = 3
        Me.btnLanguage.Text = "Change Language"
        Me.btnLanguage.UseVisualStyleBackColor = True
        '
        'btnColor
        '
        Me.btnColor.Location = New System.Drawing.Point(12, 293)
        Me.btnColor.Name = "btnColor"
        Me.btnColor.Size = New System.Drawing.Size(297, 82)
        Me.btnColor.TabIndex = 4
        Me.btnColor.Text = "Change Color"
        Me.btnColor.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(516, 293)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(146, 84)
        Me.btnExit.TabIndex = 5
        Me.btnExit.Text = "Close"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'HelloForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(16.0!, 31.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(674, 387)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnColor)
        Me.Controls.Add(Me.btnLanguage)
        Me.Controls.Add(Me.ckbMove)
        Me.Controls.Add(Me.txtHello)
        Me.Name = "HelloForm"
        Me.Text = "HelloForm"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtHello As System.Windows.Forms.TextBox
    Friend WithEvents ckbMove As System.Windows.Forms.CheckBox
    Friend WithEvents btnLanguage As System.Windows.Forms.Button
    Friend WithEvents btnColor As System.Windows.Forms.Button
    Friend WithEvents btnExit As System.Windows.Forms.Button
End Class
