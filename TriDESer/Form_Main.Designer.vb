<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form_Main
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
        Me.Label_Input = New System.Windows.Forms.Label()
        Me.TextBox_Input = New System.Windows.Forms.TextBox()
        Me.TextBox_Output = New System.Windows.Forms.TextBox()
        Me.Label_Output = New System.Windows.Forms.Label()
        Me.Button_Gen = New System.Windows.Forms.Button()
        Me.Button_CryptMode = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label_Input
        '
        Me.Label_Input.AutoSize = True
        Me.Label_Input.Location = New System.Drawing.Point(12, 15)
        Me.Label_Input.Name = "Label_Input"
        Me.Label_Input.Size = New System.Drawing.Size(39, 12)
        Me.Label_Input.TabIndex = 0
        Me.Label_Input.Text = "Input : "
        '
        'TextBox_Input
        '
        Me.TextBox_Input.Location = New System.Drawing.Point(61, 12)
        Me.TextBox_Input.Name = "TextBox_Input"
        Me.TextBox_Input.Size = New System.Drawing.Size(411, 22)
        Me.TextBox_Input.TabIndex = 1
        '
        'TextBox_Output
        '
        Me.TextBox_Output.Location = New System.Drawing.Point(61, 40)
        Me.TextBox_Output.Name = "TextBox_Output"
        Me.TextBox_Output.Size = New System.Drawing.Size(411, 22)
        Me.TextBox_Output.TabIndex = 3
        '
        'Label_Output
        '
        Me.Label_Output.AutoSize = True
        Me.Label_Output.Location = New System.Drawing.Point(12, 43)
        Me.Label_Output.Name = "Label_Output"
        Me.Label_Output.Size = New System.Drawing.Size(46, 12)
        Me.Label_Output.TabIndex = 2
        Me.Label_Output.Text = "Output : "
        '
        'Button_Gen
        '
        Me.Button_Gen.Location = New System.Drawing.Point(397, 77)
        Me.Button_Gen.Name = "Button_Gen"
        Me.Button_Gen.Size = New System.Drawing.Size(75, 23)
        Me.Button_Gen.TabIndex = 4
        Me.Button_Gen.Text = "Generate"
        Me.Button_Gen.UseVisualStyleBackColor = True
        '
        'Button_CryptMode
        '
        Me.Button_CryptMode.Location = New System.Drawing.Point(316, 77)
        Me.Button_CryptMode.Name = "Button_CryptMode"
        Me.Button_CryptMode.Size = New System.Drawing.Size(75, 23)
        Me.Button_CryptMode.TabIndex = 5
        Me.Button_CryptMode.Text = "Encrypt"
        Me.Button_CryptMode.UseVisualStyleBackColor = True
        '
        'Form_Main
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(484, 112)
        Me.Controls.Add(Me.Button_CryptMode)
        Me.Controls.Add(Me.Button_Gen)
        Me.Controls.Add(Me.TextBox_Output)
        Me.Controls.Add(Me.Label_Output)
        Me.Controls.Add(Me.TextBox_Input)
        Me.Controls.Add(Me.Label_Input)
        Me.Name = "Form_Main"
        Me.ShowIcon = False
        Me.Text = "TriDESer"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label_Input As System.Windows.Forms.Label
    Friend WithEvents TextBox_Input As System.Windows.Forms.TextBox
    Friend WithEvents TextBox_Output As System.Windows.Forms.TextBox
    Friend WithEvents Label_Output As System.Windows.Forms.Label
    Friend WithEvents Button_Gen As System.Windows.Forms.Button
    Friend WithEvents Button_CryptMode As System.Windows.Forms.Button

End Class
