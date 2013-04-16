Public Class Form2

    ' Controls
    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        If (chkWindowsShell.Checked) Then
            AddWindowsShellIntegration("Hash File")
        Else
            RemoveWindowsShellIntegration("Hash File")
        End If

        My.Settings.WindowsShell = Me.chkWindowsShell.Checked
        My.Settings.CheckMD5 = Me.chkMD5.Checked
        My.Settings.CheckSHA1 = Me.chkSHA1.Checked
        My.Settings.CheckSHA256 = Me.chkSHA256.Checked

        My.Settings.Save()
        Me.Close()
    End Sub

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub

    Private Sub Form2_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        chkWindowsShell.Checked = My.Settings.WindowsShell
        chkMD5.Checked = My.Settings.CheckMD5
        chkSHA1.Checked = My.Settings.CheckSHA1
        chkSHA256.Checked = My.Settings.CheckSHA256
    End Sub

    ' Functions
    Private Sub AddWindowsShellIntegration(ByVal MenuName As String)
        ' Locations
        Dim AddProgram As String = "*\\shell\\" & MenuName
        Dim Command As String = "*\\shell\\" & MenuName & "\\command"

        ' Registry key to add the menu to context menu
        Dim AddMenu As Microsoft.Win32.RegistryKey = Nothing

        ' Registry key to add command of what to do when clicked
        Dim AddCmd As Microsoft.Win32.RegistryKey = Nothing

        Try
            ' Creates menu item
            AddMenu = Microsoft.Win32.Registry.ClassesRoot.CreateSubKey(AddProgram)

            If (AddMenu IsNot Nothing) Then
                AddMenu.SetValue("", MenuName)
            End If

            ' Creates command
            AddCmd = Microsoft.Win32.Registry.ClassesRoot.CreateSubKey(Command)
            If (AddCmd IsNot Nothing) Then
                AddCmd.SetValue("", Application.ExecutablePath + " %1")
            End If

        Catch ex As Exception
            MsgBox(ex.ToString)

        Finally
            If (AddMenu IsNot Nothing) Then
                AddMenu.Close()
            End If
            If (AddCmd IsNot Nothing) Then
                AddCmd.Close()
            End If
        End Try
    End Sub

    Private Sub RemoveWindowsShellIntegration(ByVal MenuName As String)
        ' Locations
        Dim RemoveProgram As String = "*\\shell\\" & MenuName
        Dim Command As String = "*\\shell\\" & MenuName & "\\command"

        ' Registry key to add the menu to context menu
        Dim AddMenu As Microsoft.Win32.RegistryKey = Nothing

        ' Registry key to add command of what to do when clicked
        Dim AddCmd As Microsoft.Win32.RegistryKey = Nothing

        Try
            Dim reg As Microsoft.Win32.RegistryKey = Microsoft.Win32.Registry.ClassesRoot.OpenSubKey(Command)

            If (reg IsNot Nothing) Then
                reg.Close()
                Microsoft.Win32.Registry.ClassesRoot.DeleteSubKey(Command)
            End If

            reg = Microsoft.Win32.Registry.ClassesRoot.OpenSubKey(RemoveProgram)

            If (reg IsNot Nothing) Then
                reg.Close()
                Microsoft.Win32.Registry.ClassesRoot.DeleteSubKey(RemoveProgram)
            End If
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub
End Class