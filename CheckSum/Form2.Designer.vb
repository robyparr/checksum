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
        Me.chkWindowsShell = New System.Windows.Forms.CheckBox()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.chkMD5 = New System.Windows.Forms.CheckBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.chkSHA1 = New System.Windows.Forms.CheckBox()
        Me.chkSHA256 = New System.Windows.Forms.CheckBox()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'chkWindowsShell
        '
        Me.chkWindowsShell.AutoSize = True
        Me.chkWindowsShell.Location = New System.Drawing.Point(13, 13)
        Me.chkWindowsShell.Name = "chkWindowsShell"
        Me.chkWindowsShell.Size = New System.Drawing.Size(158, 17)
        Me.chkWindowsShell.TabIndex = 0
        Me.chkWindowsShell.Text = "Integrate with windows shell"
        Me.chkWindowsShell.UseVisualStyleBackColor = True
        '
        'btnSave
        '
        Me.btnSave.Location = New System.Drawing.Point(143, 15)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(75, 23)
        Me.btnSave.TabIndex = 1
        Me.btnSave.Text = "Save"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Panel1.Controls.Add(Me.btnCancel)
        Me.Panel1.Controls.Add(Me.btnSave)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel1.Location = New System.Drawing.Point(0, 91)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(311, 50)
        Me.Panel1.TabIndex = 2
        '
        'btnCancel
        '
        Me.btnCancel.Location = New System.Drawing.Point(224, 15)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(75, 23)
        Me.btnCancel.TabIndex = 1
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'chkMD5
        '
        Me.chkMD5.AutoSize = True
        Me.chkMD5.Location = New System.Drawing.Point(13, 58)
        Me.chkMD5.Name = "chkMD5"
        Me.chkMD5.Size = New System.Drawing.Size(49, 17)
        Me.chkMD5.TabIndex = 0
        Me.chkMD5.Text = "MD5"
        Me.chkMD5.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 42)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(146, 13)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Retrieve Checksums for:"
        '
        'chkSHA1
        '
        Me.chkSHA1.AutoSize = True
        Me.chkSHA1.Location = New System.Drawing.Point(68, 58)
        Me.chkSHA1.Name = "chkSHA1"
        Me.chkSHA1.Size = New System.Drawing.Size(54, 17)
        Me.chkSHA1.TabIndex = 0
        Me.chkSHA1.Text = "SHA1"
        Me.chkSHA1.UseVisualStyleBackColor = True
        '
        'chkSHA256
        '
        Me.chkSHA256.AutoSize = True
        Me.chkSHA256.Location = New System.Drawing.Point(128, 58)
        Me.chkSHA256.Name = "chkSHA256"
        Me.chkSHA256.Size = New System.Drawing.Size(66, 17)
        Me.chkSHA256.TabIndex = 0
        Me.chkSHA256.Text = "SHA256"
        Me.chkSHA256.UseVisualStyleBackColor = True
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(311, 141)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.chkSHA256)
        Me.Controls.Add(Me.chkSHA1)
        Me.Controls.Add(Me.chkMD5)
        Me.Controls.Add(Me.chkWindowsShell)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.Name = "Form2"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Options"
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents chkWindowsShell As System.Windows.Forms.CheckBox
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents btnCancel As System.Windows.Forms.Button
    Friend WithEvents chkMD5 As System.Windows.Forms.CheckBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents chkSHA1 As System.Windows.Forms.CheckBox
    Friend WithEvents chkSHA256 As System.Windows.Forms.CheckBox
End Class
