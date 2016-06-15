Imports Telerik.WinControls.UI
Imports Telerik.WinControls
Imports AIS_System.site_mod
Imports System.Data.SqlClient
Public Class Frm_job_ticket_NEW
    Dim mymod As New site_mod

    Private Sub Frm_job_ticket_NEW_Load(sender As Object, e As EventArgs) Handles Me.Load
        ThemeResolutionService.ApplicationThemeName = My.Settings.global_themes
        'Farming_Operation.Server_time()
    End Sub
End Class
