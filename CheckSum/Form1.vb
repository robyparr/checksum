Option Strict On

Public Class Form1

    ' Functions
    Private Function CalculateHash() As Boolean
        If (Me.txtFileLocation.Text = Nothing) Then
            MsgBox("Select a file to check.", MsgBoxStyle.Critical)
            Return False

        ElseIf (Not IO.File.Exists(Me.txtFileLocation.Text)) Then
            MsgBox("No file with this name exists.", MsgBoxStyle.Critical)
            Return False
        End If

        Dim hasher As New HashFile(Me.txtFileLocation.Text)

        If (My.Settings.CheckMD5) Then
            Me.txtFileMD5.Text = hasher.getMD5()
        End If

        If (My.Settings.CheckSHA1) Then
            Me.txtFileSHA1.Text = hasher.getSHA1()
        End If

        If (My.Settings.CheckSHA256) Then
            Me.txtFileSHA256.Text = hasher.getSHA256()
        End If

        Return True
    End Function

    ' Controls
    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.lblFileCompareResult.Text = ""

        If (My.Application.CommandLineArgs.Count <> 0) Then
            Me.txtFileLocation.Text = My.Computer.FileSystem.GetFileInfo(My.Application.CommandLineArgs(0)).ToString

            CalculateHash()
        End If
    End Sub

    Private Sub btnFileCalculateHash_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFileCalculateHash.Click
        CalculateHash()
    End Sub

    Private Sub btnBrowse_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBrowse.Click
        If (Me.OpenFileDialog1.ShowDialog() = Windows.Forms.DialogResult.OK) Then
            Me.txtFileLocation.Text = Me.OpenFileDialog1.FileName
        End If
    End Sub

    Private Sub btnFileCompare_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFileCompare.Click
        If (Me.txtFileCompare.Text.Length = 0) Then
            MsgBox("Please enter a value to compare against.", MsgBoxStyle.Critical)
            Me.txtFileCompare.Focus()
            Exit Sub
        End If

        ' Checks md5
        If (Me.txtFileCompare.Text.ToLower = Me.txtFileMD5.Text) Then
            Me.lblFileCompareResult.ForeColor = Color.Green
            Me.lblFileCompareResult.Text = "Match found against MD5."
            Me.picFileCompareResult.Image = My.Resources.Check

        ElseIf (Me.txtFileCompare.Text.ToLower = Me.txtFileSHA1.Text) Then
            Me.lblFileCompareResult.ForeColor = Color.Green
            Me.lblFileCompareResult.Text = "Match found against SHA1."
            Me.picFileCompareResult.Image = My.Resources.Check

        ElseIf (Me.txtFileCompare.Text.ToLower = Me.txtFileSHA256.Text) Then
            Me.lblFileCompareResult.ForeColor = Color.Green
            Me.lblFileCompareResult.Text = "Match found against SHA256."
            Me.picFileCompareResult.Image = My.Resources.Check

        Else
            Me.lblFileCompareResult.ForeColor = Color.Red
            Me.lblFileCompareResult.Text = "No match found!"
            Me.picFileCompareResult.Image = My.Resources.X
        End If
    End Sub

    Private Sub btnClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClear.Click
        Me.txtFileCompare.Clear()
        Me.txtFileLocation.Clear()
        Me.txtFileMD5.Clear()
        Me.txtFileSHA1.Clear()
        Me.txtFileSHA256.Clear()
        Me.lblFileCompareResult.Text = ""
        Me.picFileCompareResult.Image = My.Resources.correct
    End Sub

    Private Sub btnOptions_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOptions.Click
        Form2.ShowDialog()
    End Sub

    Private Sub txtFileLocation_DragEnter(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DragEventArgs) Handles txtFileLocation.DragEnter
        ' Drag Enter
        If (e.Data.GetDataPresent(DataFormats.FileDrop)) Then
            e.Effect = DragDropEffects.Copy
        Else
            e.Effect = DragDropEffects.None
        End If
    End Sub

    Private Sub txtFileLocation_DragDrop(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DragEventArgs) Handles txtFileLocation.DragDrop
        ' Drag Drop
        If (e.Data.GetDataPresent(DataFormats.FileDrop)) Then
            Dim dropfile As String() = CType(e.Data.GetData(DataFormats.FileDrop), String())

            If (dropfile.Length <> 1) Then
                MsgBox("You can only drag 1 file.")
                Exit Sub
            End If

            If (IO.File.Exists(dropfile(0))) Then
                Me.txtFileLocation.Text = dropfile(0)
            End If
        End If
    End Sub

    Private Sub lnkCopyMD5_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles lnkCopyMD5.LinkClicked
        If (Me.txtFileMD5.Text <> "") Then
            My.Computer.Clipboard.SetText(Me.txtFileMD5.Text)
        End If
    End Sub

    Private Sub lnkCopySHA1_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles lnkCopySHA1.LinkClicked
        If (Me.txtFileSHA1.Text <> "") Then
            My.Computer.Clipboard.SetText(Me.txtFileSHA1.Text)
        End If
    End Sub

    Private Sub lnkCopySHA256_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles lnkCopySHA256.LinkClicked
        If (Me.txtFileSHA256.Text <> "") Then
            My.Computer.Clipboard.SetText(Me.txtFileSHA256.Text)
        End If
    End Sub
End Class
