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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btnBrowse = New System.Windows.Forms.Button()
        Me.txtFileLocation = New System.Windows.Forms.TextBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.lnkCopySHA256 = New System.Windows.Forms.LinkLabel()
        Me.lnkCopySHA1 = New System.Windows.Forms.LinkLabel()
        Me.lnkCopyMD5 = New System.Windows.Forms.LinkLabel()
        Me.txtFileSHA256 = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtFileSHA1 = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtFileMD5 = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.picFileCompareResult = New System.Windows.Forms.PictureBox()
        Me.lblFileCompareResult = New System.Windows.Forms.Label()
        Me.txtFileCompare = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.btnFileCompare = New System.Windows.Forms.Button()
        Me.btnFileCalculateHash = New System.Windows.Forms.Button()
        Me.btnOptions = New System.Windows.Forms.Button()
        Me.btnAbout = New System.Windows.Forms.Button()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        CType(Me.picFileCompareResult, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btnBrowse)
        Me.GroupBox1.Controls.Add(Me.txtFileLocation)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(495, 59)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "File"
        '
        'btnBrowse
        '
        Me.btnBrowse.Location = New System.Drawing.Point(405, 18)
        Me.btnBrowse.Name = "btnBrowse"
        Me.btnBrowse.Size = New System.Drawing.Size(75, 23)
        Me.btnBrowse.TabIndex = 1
        Me.btnBrowse.Text = "Browse"
        Me.btnBrowse.UseVisualStyleBackColor = True
        '
        'txtFileLocation
        '
        Me.txtFileLocation.AllowDrop = True
        Me.txtFileLocation.Location = New System.Drawing.Point(20, 19)
        Me.txtFileLocation.Name = "txtFileLocation"
        Me.txtFileLocation.Size = New System.Drawing.Size(379, 20)
        Me.txtFileLocation.TabIndex = 0
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.lnkCopySHA256)
        Me.GroupBox2.Controls.Add(Me.lnkCopySHA1)
        Me.GroupBox2.Controls.Add(Me.lnkCopyMD5)
        Me.GroupBox2.Controls.Add(Me.txtFileSHA256)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.txtFileSHA1)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.txtFileMD5)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 77)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(495, 122)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "CheckSums"
        '
        'lnkCopySHA256
        '
        Me.lnkCopySHA256.AutoSize = True
        Me.lnkCopySHA256.Location = New System.Drawing.Point(406, 100)
        Me.lnkCopySHA256.Name = "lnkCopySHA256"
        Me.lnkCopySHA256.Size = New System.Drawing.Size(74, 13)
        Me.lnkCopySHA256.TabIndex = 2
        Me.lnkCopySHA256.TabStop = True
        Me.lnkCopySHA256.Text = "Copy SHA256"
        '
        'lnkCopySHA1
        '
        Me.lnkCopySHA1.AutoSize = True
        Me.lnkCopySHA1.Location = New System.Drawing.Point(245, 100)
        Me.lnkCopySHA1.Name = "lnkCopySHA1"
        Me.lnkCopySHA1.Size = New System.Drawing.Size(62, 13)
        Me.lnkCopySHA1.TabIndex = 2
        Me.lnkCopySHA1.TabStop = True
        Me.lnkCopySHA1.Text = "Copy SHA1"
        '
        'lnkCopyMD5
        '
        Me.lnkCopyMD5.AutoSize = True
        Me.lnkCopyMD5.Location = New System.Drawing.Point(70, 100)
        Me.lnkCopyMD5.Name = "lnkCopyMD5"
        Me.lnkCopyMD5.Size = New System.Drawing.Size(57, 13)
        Me.lnkCopyMD5.TabIndex = 2
        Me.lnkCopyMD5.TabStop = True
        Me.lnkCopyMD5.Text = "Copy MD5"
        '
        'txtFileSHA256
        '
        Me.txtFileSHA256.Location = New System.Drawing.Point(73, 73)
        Me.txtFileSHA256.Name = "txtFileSHA256"
        Me.txtFileSHA256.ReadOnly = True
        Me.txtFileSHA256.Size = New System.Drawing.Size(407, 20)
        Me.txtFileSHA256.TabIndex = 1
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(6, 77)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(50, 13)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "SHA256:"
        '
        'txtFileSHA1
        '
        Me.txtFileSHA1.Location = New System.Drawing.Point(73, 47)
        Me.txtFileSHA1.Name = "txtFileSHA1"
        Me.txtFileSHA1.ReadOnly = True
        Me.txtFileSHA1.Size = New System.Drawing.Size(407, 20)
        Me.txtFileSHA1.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(6, 51)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(38, 13)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "SHA1:"
        '
        'txtFileMD5
        '
        Me.txtFileMD5.Location = New System.Drawing.Point(73, 21)
        Me.txtFileMD5.Name = "txtFileMD5"
        Me.txtFileMD5.ReadOnly = True
        Me.txtFileMD5.Size = New System.Drawing.Size(407, 20)
        Me.txtFileMD5.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 25)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(33, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "MD5:"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.picFileCompareResult)
        Me.GroupBox3.Controls.Add(Me.lblFileCompareResult)
        Me.GroupBox3.Controls.Add(Me.txtFileCompare)
        Me.GroupBox3.Controls.Add(Me.Label4)
        Me.GroupBox3.Location = New System.Drawing.Point(16, 205)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(495, 100)
        Me.GroupBox3.TabIndex = 2
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Compare"
        '
        'picFileCompareResult
        '
        Me.picFileCompareResult.Image = Global.CheckSum.My.Resources.Resources.correct
        Me.picFileCompareResult.Location = New System.Drawing.Point(73, 44)
        Me.picFileCompareResult.Name = "picFileCompareResult"
        Me.picFileCompareResult.Size = New System.Drawing.Size(50, 50)
        Me.picFileCompareResult.TabIndex = 3
        Me.picFileCompareResult.TabStop = False
        '
        'lblFileCompareResult
        '
        Me.lblFileCompareResult.AutoSize = True
        Me.lblFileCompareResult.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFileCompareResult.Location = New System.Drawing.Point(136, 59)
        Me.lblFileCompareResult.Name = "lblFileCompareResult"
        Me.lblFileCompareResult.Size = New System.Drawing.Size(35, 20)
        Me.lblFileCompareResult.TabIndex = 2
        Me.lblFileCompareResult.Text = "N/A"
        '
        'txtFileCompare
        '
        Me.txtFileCompare.Location = New System.Drawing.Point(73, 17)
        Me.txtFileCompare.Name = "txtFileCompare"
        Me.txtFileCompare.Size = New System.Drawing.Size(407, 20)
        Me.txtFileCompare.TabIndex = 1
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(7, 20)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(35, 13)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "Hash:"
        '
        'btnFileCompare
        '
        Me.btnFileCompare.Location = New System.Drawing.Point(517, 82)
        Me.btnFileCompare.Name = "btnFileCompare"
        Me.btnFileCompare.Size = New System.Drawing.Size(91, 23)
        Me.btnFileCompare.TabIndex = 3
        Me.btnFileCompare.Text = "Compare Hash"
        Me.btnFileCompare.UseVisualStyleBackColor = True
        '
        'btnFileCalculateHash
        '
        Me.btnFileCalculateHash.Location = New System.Drawing.Point(517, 16)
        Me.btnFileCalculateHash.Name = "btnFileCalculateHash"
        Me.btnFileCalculateHash.Size = New System.Drawing.Size(91, 23)
        Me.btnFileCalculateHash.TabIndex = 3
        Me.btnFileCalculateHash.Text = "Calculate Hash"
        Me.btnFileCalculateHash.UseVisualStyleBackColor = True
        '
        'btnOptions
        '
        Me.btnOptions.Location = New System.Drawing.Point(517, 214)
        Me.btnOptions.Name = "btnOptions"
        Me.btnOptions.Size = New System.Drawing.Size(91, 23)
        Me.btnOptions.TabIndex = 4
        Me.btnOptions.Text = "Options"
        Me.btnOptions.UseVisualStyleBackColor = True
        '
        'btnAbout
        '
        Me.btnAbout.Location = New System.Drawing.Point(517, 280)
        Me.btnAbout.Name = "btnAbout"
        Me.btnAbout.Size = New System.Drawing.Size(91, 23)
        Me.btnAbout.TabIndex = 4
        Me.btnAbout.Text = "About"
        Me.btnAbout.UseVisualStyleBackColor = True
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.DefaultExt = "*.*"
        Me.OpenFileDialog1.Filter = "All files (*.*)|*.*"
        Me.OpenFileDialog1.Title = "Select File"
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(518, 148)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(91, 23)
        Me.btnClear.TabIndex = 3
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(621, 313)
        Me.Controls.Add(Me.btnAbout)
        Me.Controls.Add(Me.btnOptions)
        Me.Controls.Add(Me.btnFileCalculateHash)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnFileCompare)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "CheckSum"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        CType(Me.picFileCompareResult, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents txtFileSHA256 As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtFileSHA1 As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtFileMD5 As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents btnBrowse As System.Windows.Forms.Button
    Friend WithEvents txtFileLocation As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents picFileCompareResult As System.Windows.Forms.PictureBox
    Friend WithEvents lblFileCompareResult As System.Windows.Forms.Label
    Friend WithEvents txtFileCompare As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents btnFileCompare As System.Windows.Forms.Button
    Friend WithEvents btnFileCalculateHash As System.Windows.Forms.Button
    Friend WithEvents btnOptions As System.Windows.Forms.Button
    Friend WithEvents btnAbout As System.Windows.Forms.Button
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents btnClear As System.Windows.Forms.Button
    Friend WithEvents lnkCopyMD5 As System.Windows.Forms.LinkLabel
    Friend WithEvents lnkCopySHA256 As System.Windows.Forms.LinkLabel
    Friend WithEvents lnkCopySHA1 As System.Windows.Forms.LinkLabel

End Class
