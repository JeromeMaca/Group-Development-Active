Imports System.Data.SqlClient
Imports System.Windows.Forms
Imports System.IO
Imports System.Configuration
Imports System.Diagnostics
Imports Microsoft.VisualBasic
Imports AIS_System.security_mod
Public Class Frm_databaseConnection
    Dim secmod As New security_mod
    Private Sub Frm_databaseConnection_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        frm_login.Show()
    End Sub

    Private Sub chk_authentication_ToggleStateChanged(sender As Object, args As Telerik.WinControls.UI.StateChangedEventArgs) Handles chk_authentication.ToggleStateChanged
        If Me.chk_authentication.Checked = True Then
            txt_serverusername.Enabled = True
            txt_serverpass.Enabled = True
        Else
            txt_serverusername.Enabled = False
            txt_serverpass.Enabled = False
            Me.txt_serverusername.Text = ""
            Me.txt_serverpass.Text = ""
        End If
    End Sub

    Private Sub cb_serverdatabasename_Click(sender As Object, e As EventArgs) Handles cb_serverdatabasename.Click
        Try
            If Me.chk_authentication.Checked = True Then
                If Me.txt_servername.Text <> "" Then
                    sqlCnn = New SqlConnection("Data Source=" & Trim(txt_servername.Text) & ";Database=Master;User ID=" & Trim(txt_serverusername.Text) & ";Password=" & Trim(txt_serverpass.Text) & ";")



                    sqlCnn.Open()
                    cb_serverdatabasename.Items.Clear()
                    sqlCmd = New SqlCommand("select * from sysdatabases", sqlCnn)
                    sqlReader = sqlCmd.ExecuteReader
                    While sqlReader.Read
                        cb_serverdatabasename.Items.Add(sqlReader(0))
                    End While
                    sqlReader.Close()
                    sqlCnn.Close()
                End If
            Else
                If Me.txt_servername.Text <> "" Then
                    sqlCnn = New SqlConnection("Data Source=" & Trim(txt_servername.Text) & ";Database=Master;integrated security=SSPI;")


                    sqlCnn.Open()
                    cb_serverdatabasename.Items.Clear()
                    sqlCmd = New SqlCommand("select * from sysdatabases", sqlCnn)
                    sqlReader = sqlCmd.ExecuteReader
                    While sqlReader.Read
                        cb_serverdatabasename.Items.Add(sqlReader(0))
                    End While
                    sqlReader.Close()
                    sqlCnn.Close()
                End If
            End If
        Catch ex As Exception
            MsgBox("ERROR!" + vbCrLf + ex.Message.ToString, vbCritical, "Please Contact your System Administrator.")
            Exit Sub
        End Try
    End Sub

    Private Sub btn_save_Click(sender As Object, e As EventArgs) Handles btn_save.Click

        If Me.txt_servername.Text <> "" And Me.cb_serverdatabasename.Text <> "" Then
            With My.Settings
                If chk_authentication.Checked = True Then
                    .Conn_string = Trim("Data Source=" & Trim(txt_servername.Text) & ";Database=" & Trim(cb_serverdatabasename.Text) & ";User ID=" & Trim(txt_serverusername.Text) & ";Password=" & Trim(txt_serverpass.Text) & ";")
                    .Server_username = Trim(txt_serverusername.Text)
                    .Server_userpass = Trim(txt_serverpass.Text)
                Else
                    .Conn_string = Trim("Data Source=" & Trim(txt_servername.Text) & ";Database=" & Trim(cb_serverdatabasename.Text) & ";integrated security=SSPI;")
                    .Server_username = ""
                    .Server_userpass = ""
                End If
                .Conn_servername = Trim(txt_servername.Text)
                .Server_dbname = Trim(cb_serverdatabasename.Text)
            End With

            'My.Settings.Dataset_Conn_Strings = My.Settings.Conn_string
            My.Settings.Save()
            MsgBox("Successfully Configured...", vbInformation + vbOKOnly, "Done...")
            Me.Close()
        Else
            MsgBox("Incomplete Data Set-up!", vbExclamation + vbOKOnly, "System Warning!")
        End If

    End Sub

    Private Sub btn_reset_Click(sender As Object, e As EventArgs) Handles btn_reset.Click
        With My.Settings
            .Conn_string = ""
            .Conn_servername = ""
            .Server_dbname = ""
            .Server_username = ""
            .Server_userpass = ""
            .Save()
        End With
        Me.txt_servername.Text = ""
        Me.txt_serverusername.Text = ""
        Me.txt_serverpass.Text = ""
        Me.cb_serverdatabasename.Text = ""

        MsgBox("Successfully Reset Configuration...", vbInformation + vbOKOnly, "Done...")
        'Me.Close()
    End Sub

    Private Sub Frm_databaseConnection_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If My.Settings.Conn_string <> Nothing Then
            txt_servername.Text = Trim(My.Settings.Conn_servername)
            txt_serverusername.Text = Trim(My.Settings.Server_username)
            txt_serverpass.Text = Trim(My.Settings.Server_userpass)

            If My.Settings.Server_username <> Nothing And My.Settings.Server_userpass <> Nothing Then
                Me.chk_authentication.Checked = True
            Else
                Me.chk_authentication.Checked = False
            End If

            cb_serverdatabasename.Text = Trim(My.Settings.Server_dbname)

        Else
            MsgBox("No Current Configuration Setting.", vbInformation + vbOKOnly, "System Warning!")
        End If

    End Sub
End Class
