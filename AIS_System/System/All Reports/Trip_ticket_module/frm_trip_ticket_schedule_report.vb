Imports Telerik.WinControls.UI
Imports Telerik.WinControls
Imports AIS_System.System_mod
Imports System.Data.SqlClient
Imports Telerik.WinControls.Data
Imports Report_Lib
Public Class Frm_trip_ticket_schedule_report

    Private Sub Frm_trip_ticket_schedule_report_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ThemeResolutionService.ApplicationThemeName = My.Settings.global_themes
        'Farming_Operation.Server_time()

        Dim instanceReportSource = New Telerik.Reporting.InstanceReportSource()
        instanceReportSource.ReportDocument = New trip_ticket_schedule_report(slct_id_hdr_schedule)
        Me.ReportViewer1.ReportSource = instanceReportSource
        Me.ReportViewer1.RefreshReport()
    End Sub

    Private Sub Frm_trip_ticket_schedule_report_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        Frm_main.Enabled = True
        schedule_form_view.trip_ticket_listview_load()
    End Sub
End Class
