<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.lblHelloUser = New System.Windows.Forms.Label()
        Me.lblHello = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lblHelloUser
        '
        Me.lblHelloUser.AutoSize = True
        Me.lblHelloUser.Location = New System.Drawing.Point(55, 34)
        Me.lblHelloUser.Name = "lblHelloUser"
        Me.lblHelloUser.Size = New System.Drawing.Size(0, 13)
        Me.lblHelloUser.TabIndex = 0
        '
        'lblHello
        '
        Me.lblHello.AutoSize = True
        Me.lblHello.Location = New System.Drawing.Point(58, 34)
        Me.lblHello.Name = "lblHello"
        Me.lblHello.Size = New System.Drawing.Size(0, 13)
        Me.lblHello.TabIndex = 1
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 262)
        Me.Controls.Add(Me.lblHello)
        Me.Controls.Add(Me.lblHelloUser)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblHelloUser As System.Windows.Forms.Label
    Private WithEvents lblHello As System.Windows.Forms.Label

End Class
