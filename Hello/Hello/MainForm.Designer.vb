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
        Me.lblProgram = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnHello
        '
        Me.btnHello.BackColor = System.Drawing.Color.Silver
        Me.btnHello.Font = New System.Drawing.Font("Castellar", 8.1!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnHello.ForeColor = System.Drawing.Color.Black
        Me.btnHello.Location = New System.Drawing.Point(12, 254)
        Me.btnHello.Name = "btnHello"
        Me.btnHello.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.btnHello.Size = New System.Drawing.Size(769, 118)
        Me.btnHello.TabIndex = 0
        Me.btnHello.Text = "Say Hello!"
        Me.btnHello.UseVisualStyleBackColor = False
        '
        'lblProgram
        '
        Me.lblProgram.AutoSize = True
        Me.lblProgram.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblProgram.Location = New System.Drawing.Point(109, 40)
        Me.lblProgram.Name = "lblProgram"
        Me.lblProgram.Size = New System.Drawing.Size(581, 184)
        Me.lblProgram.TabIndex = 1
        Me.lblProgram.Text = "Title: Hello" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Author: Larissa Thompson" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Due Date:  2017-02-27" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Class: POS/408 - D" & _
    "r. Bill Spees"
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(16.0!, 31.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(793, 378)
        Me.Controls.Add(Me.lblProgram)
        Me.Controls.Add(Me.btnHello)
        Me.Name = "MainForm"
        Me.Text = "Hello"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnHello As System.Windows.Forms.Button
    Friend WithEvents lblProgram As System.Windows.Forms.Label

End Class
