Imports Telerik.WinControls.UI
Imports Telerik.WinControls
Imports AIS_System.site_mod
Imports System.Data.SqlClient

Public Class Frm_trip_ticket_NEW
    Dim mymod As New site_mod
    Private Sub Frm_trip_ticket_NEW_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ThemeResolutionService.ApplicationThemeName = My.Settings.global_themes
        'Farming_Operation.Server_time()
    End Sub


    Private Sub menubtn_add_Click(sender As Object, e As EventArgs) Handles menubtn_add.Click
        Frm_request_form_add.Show()
        Frm_main.Enabled = False
    End Sub

    Private Sub menubtn_review_Click(sender As Object, e As EventArgs) Handles menubtn_review.Click
        Frm_request_form_approve.Show()
        Frm_main.Enabled = False
    End Sub

    Private Sub UpdateToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles UpdateToolStripMenuItem.Click
        Frm_request_form_update.Show()
        Frm_main.Enabled = False
    End Sub

    Private Sub lv_request_opearation_MouseDown(sender As Object, e As MouseEventArgs) Handles lv_request_opearation.MouseDown
        If e.Button = Windows.Forms.MouseButtons.Right Then
            Me.cms_menucontrol_tripticket_request.Show(Me, Me.PointToClient(MousePosition))
        End If
    End Sub
End Class
