Option Strict On

Public Class HashFile

    Private _strFile As String = ""
    'Private _strMD5 As String = ""
    'Private _strSHA1 As String = ""
    'Private _strSHA256 As String = ""
    Dim fileBytes() As Byte

    ' ***************************
    Public Sub New(ByVal strFile As String)
        Me._strFile = strFile
        fileBytes = IO.File.ReadAllBytes(Me._strFile)
    End Sub

    ' ********************************
    ' * Calculates the MD5 of a file *
    ' ********************************
    Public Function getMD5() As String
        Dim strMD5 As String = ""

        Try
            ' MD5 hasher
            Dim hasher As New System.Security.Cryptography.MD5CryptoServiceProvider

            ' Hashed bytes
            Dim hashedBytes() As Byte = hasher.ComputeHash(fileBytes)

            ' Calls function to convert to string
            strMD5 = convertByteArray(hashedBytes)

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

        Return strMD5.ToLower
    End Function

    ' *********************************
    ' * Calculates the SHA1 of a file *
    ' *********************************
    Public Function getSHA1() As String
        Dim strSHA1 As String = ""

        Try
            ' MD5 hasher
            Dim hasher As New System.Security.Cryptography.SHA1CryptoServiceProvider


            ' Hashed bytes
            Dim hashedBytes() As Byte = hasher.ComputeHash(fileBytes)

            ' Calls function to convert to string
            strSHA1 = convertByteArray(hashedBytes)

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

        Return strSHA1.ToLower
    End Function

    ' ***********************************
    ' * Calculates the SHA256 of a file *
    ' ********************************
    Public Function getSHA256() As String
        Dim strSHA256 As String = ""

        Try
            ' MD5 hasher
            Dim hasher As New System.Security.Cryptography.SHA256CryptoServiceProvider

            ' Hashed bytes
            Dim hashedBytes() As Byte = hasher.ComputeHash(fileBytes)

            ' Calls function to convert to string
            strSHA256 = convertByteArray(hashedBytes)

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

        Return strSHA256.ToLower
    End Function

    ' *********************************
    ' * Converts byte array to string *
    ' *********************************
    Private Function convertByteArray(ByVal byteArray() As Byte) As String
        Dim strConvertedString As String = ""

        For i As Integer = 0 To byteArray.Length - 1
            strConvertedString &= byteArray(i).ToString("X2")
        Next

        Return strConvertedString
    End Function
End Class
