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
        Me.btnLanguage = New System.Windows.Forms.Button()
        Me.btnColor = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.lblHello = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnLanguage
        '
        Me.btnLanguage.Location = New System.Drawing.Point(315, 293)
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
        Me.btnExit.Location = New System.Drawing.Point(635, 291)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(146, 84)
        Me.btnExit.TabIndex = 5
        Me.btnExit.Text = "Close"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'lblHello
        '
        Me.lblHello.AutoSize = True
        Me.lblHello.Font = New System.Drawing.Font("Microsoft Sans Serif", 40.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHello.Location = New System.Drawing.Point(171, 74)
        Me.lblHello.Name = "lblHello"
        Me.lblHello.Size = New System.Drawing.Size(372, 153)
        Me.lblHello.TabIndex = 6
        Me.lblHello.Text = "Hello"
        '
        'HelloForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(16.0!, 31.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(793, 378)
        Me.Controls.Add(Me.lblHello)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnColor)
        Me.Controls.Add(Me.btnLanguage)
        Me.Name = "HelloForm"
        Me.Text = "HelloForm"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnLanguage As System.Windows.Forms.Button
    Friend WithEvents btnColor As System.Windows.Forms.Button
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents lblHello As System.Windows.Forms.Label
End Class
