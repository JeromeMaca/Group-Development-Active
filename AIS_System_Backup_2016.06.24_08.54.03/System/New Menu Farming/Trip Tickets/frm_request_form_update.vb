Imports Telerik.WinControls.UI
Imports Telerik.WinControls
Imports AIS_System.System_mod
Imports System.Data.SqlClient

Public Class Frm_request_form_update

    Private Sub Frm_request_form_update_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ThemeResolutionService.ApplicationThemeName = My.Settings.global_themes
        'Farming_Operation.Server_time()
    End Sub

    Private Sub Frm_request_form_update_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        Frm_main.Enabled = True
    End Sub
End Class
