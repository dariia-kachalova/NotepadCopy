<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
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
        Me.btnFind = New System.Windows.Forms.Button()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.TextFindWhat = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.ChkMatchCase = New System.Windows.Forms.CheckBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.RdoDown = New System.Windows.Forms.RadioButton()
        Me.RdoUp = New System.Windows.Forms.RadioButton()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnFind
        '
        Me.btnFind.Location = New System.Drawing.Point(579, 12)
        Me.btnFind.Name = "btnFind"
        Me.btnFind.Size = New System.Drawing.Size(167, 68)
        Me.btnFind.TabIndex = 0
        Me.btnFind.Text = "Find Next"
        Me.btnFind.UseVisualStyleBackColor = True
        '
        'btnCancel
        '
        Me.btnCancel.Location = New System.Drawing.Point(579, 102)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(167, 68)
        Me.btnCancel.TabIndex = 1
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'TextFindWhat
        '
        Me.TextFindWhat.AutoSize = True
        Me.TextFindWhat.Location = New System.Drawing.Point(42, 36)
        Me.TextFindWhat.Name = "TextFindWhat"
        Me.TextFindWhat.Size = New System.Drawing.Size(76, 20)
        Me.TextFindWhat.TabIndex = 2
        Me.TextFindWhat.Text = "Find what:"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(136, 36)
        Me.TextBox1.Multiline = True
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(295, 109)
        Me.TextBox1.TabIndex = 3
        '
        'ChkMatchCase
        '
        Me.ChkMatchCase.AutoSize = True
        Me.ChkMatchCase.Location = New System.Drawing.Point(24, 182)
        Me.ChkMatchCase.Name = "ChkMatchCase"
        Me.ChkMatchCase.Size = New System.Drawing.Size(107, 24)
        Me.ChkMatchCase.TabIndex = 4
        Me.ChkMatchCase.Text = "Match Case"
        Me.ChkMatchCase.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.RdoDown)
        Me.GroupBox1.Controls.Add(Me.RdoUp)
        Me.GroupBox1.Location = New System.Drawing.Point(231, 191)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(197, 60)
        Me.GroupBox1.TabIndex = 5
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Direction"
        '
        'RdoDown
        '
        Me.RdoDown.AutoSize = True
        Me.RdoDown.Location = New System.Drawing.Point(79, 19)
        Me.RdoDown.Name = "RdoDown"
        Me.RdoDown.Size = New System.Drawing.Size(69, 24)
        Me.RdoDown.TabIndex = 1
        Me.RdoDown.TabStop = True
        Me.RdoDown.Text = "Down"
        Me.RdoDown.UseVisualStyleBackColor = True
        '
        'RdoUp
        '
        Me.RdoUp.AutoSize = True
        Me.RdoUp.Location = New System.Drawing.Point(0, 19)
        Me.RdoUp.Name = "RdoUp"
        Me.RdoUp.Size = New System.Drawing.Size(49, 24)
        Me.RdoUp.TabIndex = 0
        Me.RdoUp.TabStop = True
        Me.RdoUp.Text = "Up"
        Me.RdoUp.UseVisualStyleBackColor = True
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(762, 309)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.ChkMatchCase)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.TextFindWhat)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnFind)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Form2"
        Me.Text = "Find"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnFind As Button
    Friend WithEvents btnCancel As Button
    Friend WithEvents TextFindWhat As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents ChkMatchCase As CheckBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents RdoDown As RadioButton
    Friend WithEvents RdoUp As RadioButton
End Class
