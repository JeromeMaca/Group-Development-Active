Imports Telerik.WinControls.UI
Imports Telerik.WinControls
Imports AIS_System.System_mod
Imports System.Data.SqlClient
Imports Telerik.WinControls.Data

Public Class Frm_request_form_add
    Dim sysmod As New System_mod
    Dim tim As DateTime

#Region "LISTVIEW COLUMN"
    Sub trip_ticket_request_form_column()
        Me.lv_queued.Columns.Clear()

        With Me.lv_queued
            .Columns.Add("hdr_id", "hdr_id")
            .Columns.Add("dtl_id", "dtl_id")
            .Columns.Add("count", "#")
            .Columns.Add("date_req", "DATE NEEDED")
            .Columns.Add("time_req", "TIME NEEDED")
            .Columns.Add("code", "LOT CODE")
            .Columns.Add("location", "LOCATION")
            .Columns.Add("owner_name", "PLANTER NAME")
            .Columns.Add("operation", "WORK OPERATION")

            .Columns("hdr_id").Width = 20
            .Columns("hdr_id").Visible = False
            .Columns("dtl_id").Width = 20
            .Columns("dtl_id").Visible = False
            .Columns("count").Width = 60
            .Columns("date_req").Width = 180
            .Columns("time_req").Width = 100
            .Columns("code").Width = 200
            .Columns("location").Width = 200
            .Columns("owner_name").Width = 250
            .Columns("operation").Width = 350

            If Me.chk_group.Checked = True Then
                .Columns("code").Visible = False
                .Columns("location").Visible = True
            Else
                .Columns("code").Visible = True
                .Columns("location").Visible = False
            End If


            .FullRowSelect = True
            '.ShowGridLines = True
            .ShowGroups = True
            .EnableGrouping = True
            .MultiSelect = False

            Me.lv_queued.EnableGrouping = True
            Me.lv_queued.ShowGroups = True
        End With
    End Sub
#End Region

    Private Sub Frm_request_form_add_Load(sender As Object, e As EventArgs) Handles Me.Load
        ThemeResolutionService.ApplicationThemeName = My.Settings.global_themes
        'Farming_Operation.Server_time()

        tim = Frm_main.txt_actualtime.Text
        Me.dt_ST_date.Value = tim

        Dim groupByType As New GroupDescriptor("location")
        Me.lv_queued.GroupDescriptors.Add(groupByType)

        trip_ticket_request_form_column()
        request_form_view.dp_location_load()
        request_form_view.request_order_idcode()

        request_form_view.requested_form_listview()
    End Sub

    Private Sub Frm_request_form_add_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        Frm_main.Enabled = True

        request_form_view.trip_ticket_listview_load()
        slct_id_req_hdr = 0
    End Sub

    Private Sub btn_cancel_Click(sender As Object, e As EventArgs)
        Me.Close()
    End Sub

    Private Sub dp_location_SelectedIndexChanged(sender As Object, e As UI.Data.PositionChangedEventArgs) Handles dp_location.SelectedIndexChanged
        request_form_view.dp_lot_code_load(Me.dp_location.Text)
    End Sub

    Private Sub dp_location_lot_SelectedIndexChanged(sender As Object, e As UI.Data.PositionChangedEventArgs) Handles dp_location_lot.SelectedIndexChanged
        request_form_view.dp_operation_load()
        request_form_view.request_slct_dp_lot(Me.dp_location_lot.Text)
    End Sub

    Private Sub dp_workoperations_SelectedIndexChanged(sender As Object, e As UI.Data.PositionChangedEventArgs) Handles dp_workoperations.SelectedIndexChanged
        request_form_view.request_slct_dp_work_operation(Me.dp_workoperations.Text)
    End Sub
    Private Sub btn_add_request_Click(sender As Object, e As EventArgs) Handles btn_add_request.Click
        sysmod.Add_requestform(Me.dt_ST_date.Value, dp_lot_id, order_no, req_cat_id, user_id, Me.tp_ST_neededtime.Value, Replace(Trim(Me.txt_ST_purpose.Text), "'", "`"))
        request_form_view.requested_form_listview()
        Me.dp_location.Enabled = False
        Me.dp_location_lot.SelectedItem = Nothing
        Me.dp_workoperations.SelectedItem = Nothing
        Me.txt_planter.Text = ""
    End Sub

    Private Sub lv_queued_CellFormatting(sender As Object, e As ListViewCellFormattingEventArgs) Handles lv_queued.CellFormatting
        If TypeOf e.CellElement Is DetailListViewHeaderCellElement Then
            e.CellElement.TextAlignment = ContentAlignment.MiddleCenter
        Else
            e.CellElement.ResetValue(LightVisualElement.TextAlignmentProperty, Telerik.WinControls.ValueResetFlags.Local)
        End If

        If (TypeOf e.CellElement Is DetailListViewDataCellElement) Then
            e.CellElement.TextAlignment = ContentAlignment.MiddleCenter
        End If

       If (TypeOf e.Cellelement Is DetailListViewCellElement) Then
            e.CellElement.DrawFill = False
            e.CellElement.DrawBorder = False
        Else
            e.CellElement.ResetValue(LightVisualElement.DrawBorderProperty, Telerik.WinControls.ValueResetFlags.Local)
            e.CellElement.ResetValue(LightVisualElement.DrawFillProperty, Telerik.WinControls.ValueResetFlags.Local)
        End If
    End Sub

    Private Sub chk_group_CheckedChanged(sender As Object, e As EventArgs) Handles chk_group.CheckedChanged
        If Me.chk_group.Checked = True Then
            request_form_view.requested_form_listview()
            Me.lv_queued.GroupDescriptors.Clear()
            trip_ticket_request_form_column()
            Dim groupByType As New GroupDescriptor("code")
            Me.lv_queued.GroupDescriptors.Add(groupByType)
        Else
            request_form_view.requested_form_listview()
            Me.lv_queued.GroupDescriptors.Clear()
            trip_ticket_request_form_column()
            Dim groupByType As New GroupDescriptor("location")
            Me.lv_queued.GroupDescriptors.Add(groupByType)
        End If
    End Sub

    Private Sub btn_new_request_Click(sender As Object, e As EventArgs) Handles btn_new_request.Click
        request_form_view.request_order_idcode()
        Me.dp_location.Enabled = True
        Me.dp_location.SelectedItem = Nothing
        Me.txt_planter.Text = ""
    End Sub

    Private Sub lv_queued_SelectedItemChanged(sender As Object, e As EventArgs) Handles lv_queued.SelectedItemChanged
        request_form_view.Global_loc_masterlist_selected()
        'MsgBox(slct_id_req_hdr & vbCrLf & slct_id_req_dtl)
    End Sub

    Private Sub btn_cancel_selected_queued_Click(sender As Object, e As EventArgs) Handles btn_cancel_selected_queued.Click
        sysmod.Delete_request_queued_data("1", slct_id_req_dtl, slct_id_req_hdr, user_id)
    End Sub

    Private Sub btn_cancel_all_queued_request_Click(sender As Object, e As EventArgs) Handles btn_cancel_all_queued_request.Click
        sysmod.Delete_request_queued_data("0", slct_id_req_hdr, slct_id_req_dtl, user_id)
    End Sub

    Private Sub btn_cancel_add_Click(sender As Object, e As EventArgs) Handles btn_cancel_add.Click
        request_form_view.request_order_idcode()
        Me.dp_location.Enabled = True
        Me.dp_location.SelectedItem = Nothing
        Me.txt_planter.Text = ""
    End Sub

    Private Sub btn_save_request_Click(sender As Object, e As EventArgs) Handles btn_save_request.Click
        request_form_view.request_req_no()
        sysmod.confirm_requestform(user_id)

        If sysmod.msgb <> 1 Then
            MsgBox(sysmod.msgS, vbInformation + vbOKOnly, "AIS: DONE.")
            request_form_view.requested_form_listview()
        Else
            MsgBox(sysmod.msgS, vbExclamation + vbOKOnly, "AIS: ERROR...")
        End If
    End Sub
End Class
