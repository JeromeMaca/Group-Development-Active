Imports Microsoft.VisualBasic
Imports System.Data
Imports System.Data.SqlClient
Imports System.IO
Imports System.Text
Imports System.Security.Cryptography

Imports Telerik.WinControls.UI
Imports Telerik.WinControls
Imports System.Configuration

Public Class security_mod

    Dim strFileToEncrypt As String
    Dim strFileToDecrypt As String
    Dim strOutputEncrypt As String
    Dim strOutputDecrypt As String
    Dim fsInput As System.IO.FileStream
    Dim fsOutput As System.IO.FileStream

    Dim txtFileToEncrypt As String = ""
    Dim txtDestinationEncrypt As String = ""
    Dim txtFileToDecrypt As String = ""
    Dim txtDestinationDecrypt As String = ""
    Dim str_file_path_to_decrypt As String = ""

    Public err_catcher As Integer = 0

    Private Function CreateKey(ByVal strPassword As String) As Byte()
        'Convert strPassword to an array and store in chrData.
        Dim chrData() As Char = strPassword.ToCharArray
        'Use intLength to get strPassword size.
        Dim intLength As Integer = chrData.GetUpperBound(0)
        'Declare bytDataToHash and make it the same size as chrData.
        Dim bytDataToHash(intLength) As Byte

        'Use For Next to convert and store chrData into bytDataToHash.
        For i As Integer = 0 To chrData.GetUpperBound(0)
            bytDataToHash(i) = CByte(Asc(chrData(i)))
        Next

        'Declare what hash to use.
        Dim SHA512 As New System.Security.Cryptography.SHA512Managed
        'Declare bytResult, Hash bytDataToHash and store it in bytResult.
        Dim bytResult As Byte() = SHA512.ComputeHash(bytDataToHash)
        'Declare bytKey(31).  It will hold 256 bits.
        Dim bytKey(31) As Byte

        'Use For Next to put a specific size (256 bits) of 
        'bytResult into bytKey. The 0 To 31 will put the first 256 bits
        'of 512 bits into bytKey.
        For i As Integer = 0 To 31
            bytKey(i) = bytResult(i)
        Next

        Return bytKey 'Return the key.
    End Function

    Private Function CreateIV(ByVal strPassword As String) As Byte()
        'Convert strPassword to an array and store in chrData.
        Dim chrData() As Char = strPassword.ToCharArray
        'Use intLength to get strPassword size.
        Dim intLength As Integer = chrData.GetUpperBound(0)
        'Declare bytDataToHash and make it the same size as chrData.
        Dim bytDataToHash(intLength) As Byte

        'Use For Next to convert and store chrData into bytDataToHash.
        For i As Integer = 0 To chrData.GetUpperBound(0)
            bytDataToHash(i) = CByte(Asc(chrData(i)))
        Next

        'Declare what hash to use.
        Dim SHA512 As New System.Security.Cryptography.SHA512Managed
        'Declare bytResult, Hash bytDataToHash and store it in bytResult.
        Dim bytResult As Byte() = SHA512.ComputeHash(bytDataToHash)
        'Declare bytIV(15).  It will hold 128 bits.
        Dim bytIV(15) As Byte

        'Use For Next to put a specific size (128 bits) of 
        'bytResult into bytIV. The 0 To 30 for bytKey used the first 256 bits.
        'of the hashed password. The 32 To 47 will put the next 128 bits into bytIV.
        For i As Integer = 32 To 47
            bytIV(i - 32) = bytResult(i)
        Next

        Return bytIV 'return the IV
    End Function

#Region "4. Encrypt / Decrypt File "

    '****************************
    '** Encrypt/Decrypt File
    '****************************

    Private Enum CryptoAction
        'Define the enumeration for CryptoAction.
        ActionEncrypt = 1
        ActionDecrypt = 2
    End Enum

    Private Sub EncryptOrDecryptFile(ByVal strInputFile As String, _
                                     ByVal strOutputFile As String, _
                                     ByVal bytKey() As Byte, _
                                     ByVal bytIV() As Byte, _
                                     ByVal Direction As CryptoAction)
        Try 'In case of errors.

            'Setup file streams to handle input and output.
            fsInput = New System.IO.FileStream(strInputFile, FileMode.Open, _
                                               FileAccess.Read)
            fsOutput = New System.IO.FileStream(strOutputFile, FileMode.OpenOrCreate, _
                                                FileAccess.Write)
            fsOutput.SetLength(0) 'make sure fsOutput is empty


            'Declare variables for encrypt/decrypt process.
            Dim bytBuffer(4096) As Byte 'holds a block of bytes for processing
            Dim lngBytesProcessed As Long = 0 'running count of bytes processed
            Dim lngFileLength As Long = fsInput.Length 'the input file's length
            Dim intBytesInCurrentBlock As Integer 'current bytes being processed
            Dim csCryptoStream As CryptoStream
            'Declare your CryptoServiceProvider.
            Dim cspRijndael As New System.Security.Cryptography.RijndaelManaged
            'Setup Progress Bar

            'pbStatus.Value = 0
            'pbStatus.Maximum = 100

            'Determine if ecryption or decryption and setup CryptoStream.
            Select Case Direction
                Case CryptoAction.ActionEncrypt
                    csCryptoStream = New CryptoStream(fsOutput, _
                    cspRijndael.CreateEncryptor(bytKey, bytIV), _
                    CryptoStreamMode.Write)

                Case CryptoAction.ActionDecrypt
                    csCryptoStream = New CryptoStream(fsOutput, _
                    cspRijndael.CreateDecryptor(bytKey, bytIV), _
                    CryptoStreamMode.Write)
            End Select

            'Use While to loop until all of the file is processed.
            While lngBytesProcessed < lngFileLength
                'Read file with the input filestream.
                intBytesInCurrentBlock = fsInput.Read(bytBuffer, 0, 4096)
                'Write output file with the cryptostream.
                csCryptoStream.Write(bytBuffer, 0, intBytesInCurrentBlock)
                'Update lngBytesProcessed
                lngBytesProcessed = lngBytesProcessed + CLng(intBytesInCurrentBlock)
                'Update Progress Bar

                'pbStatus.Value = CInt((lngBytesProcessed / lngFileLength) * 100)
            End While

            'Close FileStreams and CryptoStream.
            csCryptoStream.Close()
            fsInput.Close()
            fsOutput.Close()

            'If encrypting then delete the original unencrypted file.
            If Direction = CryptoAction.ActionEncrypt Then
                Dim fileOriginal As New FileInfo(strFileToEncrypt)
                fileOriginal.Delete()
            End If

            'If decrypting then delete the encrypted file.
            If Direction = CryptoAction.ActionDecrypt Then
                Dim fileEncrypted As New FileInfo(strFileToDecrypt)
                fileEncrypted.Delete()
            End If

            'Update the user when the file is done.
            Dim Wrap As String = Chr(13) + Chr(10)
            If Direction = CryptoAction.ActionEncrypt Then
                'MsgBox("Encryption Complete" + Wrap + Wrap + _
                '        "Total bytes processed = " + _
                '        lngBytesProcessed.ToString, _
                '        MsgBoxStyle.Information, "Done")

                'Update the progress bar and textboxes.

                'pbStatus.Value = 0
                'txtFileToEncrypt.Text = "Click Browse to load file."
                'txtPassEncrypt.Text = ""
                'txtConPassEncrypt.Text = ""
                'txtDestinationEncrypt.Text = ""
                'btnChangeEncrypt.Enabled = False
                'btnEncrypt.Enabled = False

            Else
                'Update the user when the file is done.
                'MsgBox("Decryption Complete" + Wrap + Wrap + _
                '       "Total bytes processed = " + _
                '        lngBytesProcessed.ToString, _
                '        MsgBoxStyle.Information, "Done")

                'Update the progress bar and textboxes.


                'pbStatus.Value = 0
                'txtFileToDecrypt.Text = "Click Browse to load file."
                'txtPassDecrypt.Text = ""
                'txtConPassDecrypt.Text = ""
                'txtDestinationDecrypt.Text = ""
                'btnChangeDecrypt.Enabled = False
                'btnDecrypt.Enabled = False
            End If


            'Catch file not found error.
        Catch When Err.Number = 53 'if file not found
            'MsgBox("Please check to make sure the path and filename" + _
            '        "are correct and if the file exists.", _
            '         MsgBoxStyle.Exclamation, "Invalid Path or Filename")

            'Catch all other errors. And delete partial files.
            err_catcher = 53
        Catch
            If fsInput Is Nothing Then
                Exit Sub
            End If

            fsInput.Close()
            fsOutput.Close()

            If Direction = CryptoAction.ActionDecrypt Then
                Dim fileDelete As New FileInfo(txtDestinationDecrypt)
                fileDelete.Delete()

                'pbStatus.Value = 0
                'txtPassDecrypt.Text = ""
                'txtConPassDecrypt.Text = ""

                'MsgBox("Please check to make sure that you entered the correct" + _
                '        "password.", MsgBoxStyle.Exclamation, "Invalid Password")
            Else
                Dim fileDelete As New FileInfo(txtDestinationEncrypt)
                fileDelete.Delete()

                'pbStatus.Value = 0
                'txtPassEncrypt.Text = ""
                'txtConPassEncrypt.Text = ""

                MsgBox("This file cannot be encrypted.", _
                        MsgBoxStyle.Exclamation, "Invalid File")

            End If

        End Try
    End Sub

#End Region


#Region "5. To be encrpt file path"
    Public Sub filepathtobeencrypt()
        Dim config As System.Configuration.Configuration = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.PerUserRoamingAndLocal)
        strFileToEncrypt = config.FilePath

        txtFileToEncrypt = strFileToEncrypt
        txtDestinationEncrypt = strFileToEncrypt

        Dim iPosition As Integer = 0
        Dim i As Integer = 0

        'Get the position of the last "\" in the OpenFileDialog.FileName path.
        '-1 is when the character your searching for is not there.
        'IndexOf searches from left to right.
        While strFileToEncrypt.IndexOf("\"c, i) <> -1
            iPosition = strFileToEncrypt.IndexOf("\"c, i)
            i = iPosition + 1
        End While

        'Assign strOutputFile to the position after the last "\" in the path.
        'This position is the beginning of the file name.
        strOutputEncrypt = strFileToEncrypt.Substring(iPosition + 1)
        'Assign S the entire path, ending at the last "\".
        Dim S As String = strFileToEncrypt.Substring(0, iPosition + 1)
        'Replace the "." in the file extension with "_".
        strOutputEncrypt = strOutputEncrypt.Replace("."c, "_"c)

        System.IO.File.SetAttributes(S, FileAttributes.Hidden)
        'The final file name.  XXXXX.encrypt
        txtDestinationEncrypt = S + strOutputEncrypt + ".encrypt"
        'Update buttons.
        'btnEncrypt.Enabled = True
        'btnChangeEncrypt.Enabled = True
    End Sub

    Public Sub filepathtobedecrypt()
        Dim config As System.Configuration.Configuration = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.PerUserRoamingAndLocal)

        str_file_path_to_decrypt = config.FilePath

        txtDestinationEncrypt = str_file_path_to_decrypt

        Dim iPositions As Integer = 0
        Dim iss As Integer = 0

        While str_file_path_to_decrypt.IndexOf("\"c, iss) <> -1
            iPositions = str_file_path_to_decrypt.IndexOf("\"c, iss)
            iss = iPositions + 1
        End While

        strOutputEncrypt = str_file_path_to_decrypt.Substring(iPositions + 1)
        Dim Ss As String = str_file_path_to_decrypt.Substring(0, iPositions + 1)
        strOutputEncrypt = strOutputEncrypt.Replace("."c, "_"c)
        txtDestinationEncrypt = Ss + strOutputEncrypt + ".encrypt"


        strFileToDecrypt = txtDestinationEncrypt

        txtFileToDecrypt = strFileToDecrypt
        Dim iPosition As Integer = 0
        Dim i As Integer = 0
        'Get the position of the last "\" in the OpenFileDialog.FileName path.
        '-1 is when the character your searching for is not there.
        'IndexOf searches from left to right.

        While strFileToDecrypt.IndexOf("\"c, i) <> -1
            iPosition = strFileToDecrypt.IndexOf("\"c, i)
            i = iPosition + 1
        End While

        'strOutputFile = the file path minus the last 8 characters (.encrypt)
        strOutputDecrypt = strFileToDecrypt.Substring(0, strFileToDecrypt.Length - 8)
        'Assign S the entire path, ending at the last "\".
        Dim S As String = strFileToDecrypt.Substring(0, iPosition + 1)
        'Assign strOutputFile to the position after the last "\" in the path.
        strOutputDecrypt = strOutputDecrypt.Substring((iPosition + 1))

        System.IO.File.SetAttributes(S, FileAttributes.Hidden)
        'Replace "_" with "."
        txtDestinationDecrypt = S + strOutputDecrypt.Replace("_"c, "."c)


        'Update buttons
        'btnDecrypt.Enabled = True
        'btnChangeDecrypt.Enabled = True
    End Sub
#End Region


#Region "Encryption / Decryption"
    Public Sub encryption()
        Dim txt_pass = "Jerome"
        'Declare variables for the key and iv.
        'The key needs to hold 256 bits and the iv 128 bits.
        Dim bytKey As Byte()
        Dim bytIV As Byte()
        'Send the password to the CreateKey function.
        bytKey = CreateKey(txt_pass)
        'Send the password to the CreateIV function.
        bytIV = CreateIV(txt_pass)
        'Start the encryption.
        EncryptOrDecryptFile(strFileToEncrypt, txtDestinationEncrypt, bytKey, bytIV, CryptoAction.ActionEncrypt)
    End Sub

    Public Sub decryption()
        Dim txt_pass = "Jerome"
        'Declare variables for the key and iv.
        'The key needs to hold 256 bits and the iv 128 bits.
        Dim bytKey As Byte()
        Dim bytIV As Byte()
        'Send the password to the CreateKey function.
        bytKey = CreateKey(txt_pass)
        'Send the password to the CreateIV function.
        bytIV = CreateIV(txt_pass)
        'Start the encryption.
        EncryptOrDecryptFile(strFileToDecrypt, txtDestinationDecrypt, bytKey, bytIV, CryptoAction.ActionDecrypt)
    End Sub
#End Region
End Class
