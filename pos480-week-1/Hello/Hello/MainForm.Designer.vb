<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MainForm
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
        Me.btnHello = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnHello
        '
        Me.btnHello.BackColor = System.Drawing.SystemColors.MenuHighlight
        Me.btnHello.Font = New System.Drawing.Font("Castellar", 8.1!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnHello.ForeColor = System.Drawing.Color.FloralWhite
        Me.btnHello.Location = New System.Drawing.Point(195, 240)
        Me.btnHello.Name = "btnHello"
        Me.btnHello.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.btnHello.Size = New System.Drawing.Size(274, 118)
        Me.btnHello.TabIndex = 0
        Me.btnHello.Text = "Hello!"
        Me.btnHello.UseVisualStyleBackColor = False
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(16.0!, 31.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(674, 387)
        Me.Controls.Add(Me.btnHello)
        Me.Name = "MainForm"
        Me.Text = "Hello"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnHello As System.Windows.Forms.Button

End Class
