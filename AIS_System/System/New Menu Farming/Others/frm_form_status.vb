Imports Telerik.WinControls.UI
Imports Telerik.WinControls
Imports AIS_System.System_mod
Imports System.Data.SqlClient
Imports Telerik.WinControls.Data
Imports System.ComponentModel
Public Class Frm_form_status
    Dim sysmod As New System_mod

#Region "LISTVIEW COLUMN"
    Sub request_listview_column()
        Me.lv_approved_request.Columns.Clear()

        With Me.lv_approved_request
            .Columns.Add("id", "hdr_id")
            .Columns.Add("count", "#")
            .Columns.Add("lot_no", "LOT NO.")
            .Columns.Add("owner_name", "LOT OWNER NAME")
            .Columns.Add("ownership", "OWNERSHIP")
            .Columns.Add("association", "ASSOCIATION")
            .Columns.Add("date_planted", "DATE PLANTED")
            .Columns.Add("variety", "VARIETY")
            .Columns.Add("current_area", "CURRENT AREA")
            .Columns.Add("soil_type", "SOIL TYPE")
            .Columns.Add("fiscal_year", "CROP YEAR")

            .Columns("id").Width = 60
            .Columns("id").Visible = False
            '.Columns("dtl_id").Width = 60
            '.Columns("dtl_id").Visible = False
            .Columns("count").Width = 60
            .Columns("lot_no").Width = 130
            .Columns("owner_name").Width = 200
            .Columns("ownership").Width = 150
            .Columns("association").Width = 150
            .Columns("date_planted").Width = 100
            .Columns("variety").Width = 110
            .Columns("current_area").Width = 100
            .Columns("soil_type").Width = 100
            .Columns("fiscal_year").Width = 100

            .FullRowSelect = True
            '.ShowGridLines = True
            .ShowGroups = True
            .EnableGrouping = True
            .MultiSelect = False

            Me.lv_approved_request.EnableGrouping = True
            Me.lv_approved_request.ShowGroups = True
        End With
    End Sub

    Sub schedule_listview_column()
        Me.lv_approved_request.Columns.Clear()

        With Me.lv_approved_request
            .Columns.Add("id", "hdr_id")
            .Columns.Add("count", "#")
            .Columns.Add("lot_no", "LOT NO.")
            .Columns.Add("owner_name", "LOT OWNER NAME")
            .Columns.Add("ownership", "OWNERSHIP")
            .Columns.Add("association", "ASSOCIATION")
            .Columns.Add("date_planted", "DATE PLANTED")
            .Columns.Add("variety", "VARIETY")
            .Columns.Add("current_area", "CURRENT AREA")
            .Columns.Add("soil_type", "SOIL TYPE")
            .Columns.Add("fiscal_year", "CROP YEAR")

            .Columns("id").Width = 60
            .Columns("id").Visible = False
            '.Columns("dtl_id").Width = 60
            '.Columns("dtl_id").Visible = False
            .Columns("count").Width = 60
            .Columns("lot_no").Width = 130
            .Columns("owner_name").Width = 200
            .Columns("ownership").Width = 150
            .Columns("association").Width = 150
            .Columns("date_planted").Width = 100
            .Columns("variety").Width = 110
            .Columns("current_area").Width = 100
            .Columns("soil_type").Width = 100
            .Columns("fiscal_year").Width = 100

            .FullRowSelect = True
            '.ShowGridLines = True
            .ShowGroups = True
            .EnableGrouping = True
            .MultiSelect = False

            Me.lv_approved_request.EnableGrouping = True
            Me.lv_approved_request.ShowGroups = True
        End With
    End Sub

    Sub accomplished_listview_column()
        Me.lv_approved_request.Columns.Clear()

        With Me.lv_approved_request
            .Columns.Add("id", "hdr_id")
            .Columns.Add("count", "#")
            .Columns.Add("lot_no", "LOT NO.")
            .Columns.Add("owner_name", "LOT OWNER NAME")
            .Columns.Add("ownership", "OWNERSHIP")
            .Columns.Add("association", "ASSOCIATION")
            .Columns.Add("date_planted", "DATE PLANTED")
            .Columns.Add("variety", "VARIETY")
            .Columns.Add("current_area", "CURRENT AREA")
            .Columns.Add("soil_type", "SOIL TYPE")
            .Columns.Add("fiscal_year", "CROP YEAR")

            .Columns("id").Width = 60
            .Columns("id").Visible = False
            '.Columns("dtl_id").Width = 60
            '.Columns("dtl_id").Visible = False
            .Columns("count").Width = 60
            .Columns("lot_no").Width = 130
            .Columns("owner_name").Width = 200
            .Columns("ownership").Width = 150
            .Columns("association").Width = 150
            .Columns("date_planted").Width = 100
            .Columns("variety").Width = 110
            .Columns("current_area").Width = 100
            .Columns("soil_type").Width = 100
            .Columns("fiscal_year").Width = 100

            .FullRowSelect = True
            '.ShowGridLines = True
            .ShowGroups = True
            .EnableGrouping = True
            .MultiSelect = False

            Me.lv_approved_request.EnableGrouping = True
            Me.lv_approved_request.ShowGroups = True
        End With
    End Sub
#End Region
    Private Sub Frm_form_status_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ThemeResolutionService.ApplicationThemeName = My.Settings.global_themes
        'Farming_Operation.Server_time()

        Me.lv_approved_request.Columns.Clear()
        Select Case form_type
            Case 0
                Me.panel_menu.Visible = False
                request_listview_column()
                status_only.approved_data_listview(slct_id_req_hdr)
            Case 1
                status_only.processed_data_time(slct_id_req_hdr)
                Me.panel_menu.Visible = True
                schedule_listview_column()
                status_only.processed_data_listview(slct_id_req_hdr)
            Case 2
                Me.panel_menu.Visible = False
                accomplished_listview_column()
                status_only.posted_data_listview(slct_id_req_hdr)
        End Select
    End Sub

    Private Sub Frm_form_status_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        Frm_main.Enabled = True

        'Select Case form_type
        '    Case 0
        '        request_form_view.trip_ticket_request_form_approved_data_load()
        '    Case 1
        '        schedule_form_view.trip_ticket_schedule_form_processed_data_load()
        '    Case 2
        '        accomplished_form_view.trip_ticket_accomplihed_form_posted_data_load()
        'End Select
        slct_id_req_hdr = Nothing
    End Sub

    Private Sub lv_approved_request_CellFormatting(sender As Object, e As ListViewCellFormattingEventArgs) Handles lv_approved_request.CellFormatting
        status_only.lv_cellformatting(e)
    End Sub
End Class
