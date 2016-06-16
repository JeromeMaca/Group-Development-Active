Imports Telerik.WinControls
Imports Telerik.WinControls.Data
Imports AIS_System.System_mod
Imports System.ComponentModel

Public Class Frm_user_control_permission
    Private Sub Frm_user_control_permission_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ThemeResolutionService.ApplicationThemeName = My.Settings.global_themes
        'sysmod.Server_time

    End Sub

    Private Sub Frm_user_control_permission_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        Frm_main.Enabled = True
    End Sub
End Class
