Imports Telerik.WinControls.UI
Imports Telerik.WinControls
Imports AIS_System.System_mod
Imports AIS_System.User_Accounts_view
Imports AIS_System.security_mod
Imports System.IO

Public Class frm_login

    Dim sysmod As New System_mod
    Dim useraccount As New User_Accounts_view
    Dim secmod As New security_mod
    Private Sub defaultT_Click(sender As Object, e As EventArgs) Handles defaultT.Click
        Me.ThemeName = ""
        ThemeResolutionService.ApplicationThemeName = Me.ThemeName

        With My.Settings
            .global_themes = Me.ThemeName
            .Save()
        End With
    End Sub
    Private Sub MetroT_Click(sender As Object, e As EventArgs) Handles MetroT.Click
        Me.ThemeName = "TelerikMetro"
        ThemeResolutionService.ApplicationThemeName = Me.ThemeName

        With My.Settings
            .global_themes = Me.ThemeName
            .Save()
        End With
    End Sub

    Private Sub MetroBT_Click(sender As Object, e As EventArgs) Handles MetroBT.Click
        Me.ThemeName = "TelerikMetroBlue"
        ThemeResolutionService.ApplicationThemeName = Me.ThemeName

        With My.Settings
            .global_themes = Me.ThemeName
            .Save()
        End With
    End Sub

    Private Sub LightT_Click(sender As Object, e As EventArgs) Handles LightT.Click
        Me.ThemeName = "VisualStudio2012Light"
        ThemeResolutionService.ApplicationThemeName = Me.ThemeName

        With My.Settings
            .global_themes = Me.ThemeName
            .Save()
        End With
    End Sub

    Private Sub DarkT_Click(sender As Object, e As EventArgs) Handles DarkT.Click
        Me.ThemeName = "VisualStudio2012Dark"
        ThemeResolutionService.ApplicationThemeName = Me.ThemeName

        With My.Settings
            .global_themes = Me.ThemeName
            .Save()
        End With
    End Sub

    Private Sub LightT2_Click(sender As Object, e As EventArgs) Handles LightT2.Click
        Me.ThemeName = "Office2013Light"
        ThemeResolutionService.ApplicationThemeName = Me.ThemeName

        With My.Settings
            .global_themes = Me.ThemeName
            .Save()
        End With
    End Sub

    Private Sub win7_Click(sender As Object, e As EventArgs) Handles win7.Click
        Me.ThemeName = "Windows7"
        ThemeResolutionService.ApplicationThemeName = Me.ThemeName

        With My.Settings
            .global_themes = Me.ThemeName
            .Save()
        End With
    End Sub

    Private Sub win8_Click(sender As Object, e As EventArgs) Handles win8.Click
        Me.ThemeName = "Windows8"
        ThemeResolutionService.ApplicationThemeName = Me.ThemeName

        With My.Settings
            .global_themes = Me.ThemeName
            .Save()
        End With
    End Sub

    Private Sub office2010blue_Click(sender As Object, e As EventArgs) Handles office2010blue.Click
        Me.ThemeName = "Office2010Blue"
        ThemeResolutionService.ApplicationThemeName = Me.ThemeName

        With My.Settings
            .global_themes = Me.ThemeName
            .Save()
        End With
    End Sub

    Private Sub office2010silver_Click(sender As Object, e As EventArgs) Handles office2010silver.Click
        Me.ThemeName = "Office2010Silver"
        ThemeResolutionService.ApplicationThemeName = Me.ThemeName

        With My.Settings
            .global_themes = Me.ThemeName
            .Save()
        End With
    End Sub

    Private Sub office2010black_Click(sender As Object, e As EventArgs) Handles office2010black.Click
        Me.ThemeName = "Office2010Black"
        ThemeResolutionService.ApplicationThemeName = Me.ThemeName

        With My.Settings
            .global_themes = Me.ThemeName
            .Save()
        End With
    End Sub
    Private Sub frm_login_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ThemeResolutionService.ApplicationThemeName = My.Settings.global_themes

        ' DECRYPTION

        'secmod.filepathtobedecrypt()
        'secmod.decryption()

        'If secmod.err_catcher <> 53 Then
        '    Dim ctr = 0
        '    ctr += 1
        '    If ctr = 1 Then
        '        Application.Restart()
        '    End If
        'End If
    End Sub

    Private Sub btn_login_Click(sender As Object, e As EventArgs) Handles btn_login.Click


        useraccount.logging_in(Replace(Trim(Me.txt_username.Text), "'", "`"), Replace(Trim(Me.txt_password.Text), "'", "`"))

        If msgstats = 2 Then
            MsgBox(usermsg, vbInformation & vbOKOnly, "AIS: Successfully")
            Frm_main.Show()
            Me.Hide()

            'ENCRYPTION

            'secmod.filepathtobeencrypt()
            'secmod.encryption()
        Else
            MsgBox(usermsg, vbInformation & vbOKOnly, "AIS: Unsuccessful")
            Exit Sub
        End If
    End Sub

    Private Sub btn_database_Click(sender As Object, e As EventArgs) Handles btn_database.Click
        Frm_databaseConnection.Show()
        Me.Hide()
    End Sub

    Private Sub frm_login_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Application.Exit()
    End Sub

    Private Sub txt_password_KeyDown(sender As Object, e As KeyEventArgs) Handles txt_password.KeyDown
        If e.KeyCode = Keys.Enter Then
            Me.btn_login.PerformClick()
        End If
    End Sub

    Private Sub txt_username_KeyDown(sender As Object, e As KeyEventArgs) Handles txt_username.KeyDown
        If e.KeyCode = Keys.Enter Then
            Me.btn_login.PerformClick()
        End If
    End Sub

End Class
