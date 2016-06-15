Imports Telerik.WinControls.UI
Imports Telerik.WinControls
Imports AIS_System.System_mod
Imports System.Data.SqlClient
Imports Telerik.WinControls.Data
Imports System.ComponentModel

Public Class Frm_trip_ticket_NEWS
    Dim sysmod As New System_mod
    Dim ctr As Integer = 0
    Dim ctr2 As Integer = 0

#Region "LISTVIEW COLUMN"
    Sub trip_ticket_request_form_column()

        Me.lv_request_tt.Columns.Clear()

        With Me.lv_request_tt
            .Columns.Add("id", "hdr_id")
            .Columns.Add("dtl_id", "dtl_id")
            .Columns.Add("lot_id", "lot_id")
            .Columns.Add("count", "#")
            .Columns.Add("req_no", "REQUEST NUMBER")
            .Columns.Add("date_req", "DATE REQUESTED")
            .Columns.Add("date_needed", "DATE NEEDED")
            .Columns.Add("time_needed", "TIME NEEDED")
            .Columns.Add("location", "LOCATION")
            .Columns.Add("lot_no", "LOT NUMBER")
            .Columns.Add("operation", "WORK TO PERFORM")
            .Columns.Add("purpose", "PURPOSE")
            .Columns.Add("req_by", "REQUESTED BY")



            .Columns("id").Width = 60
            .Columns("id").Visible = False
            .Columns("dtl_id").Width = 60
            .Columns("dtl_id").Visible = False
            .Columns("lot_id").Width = 60
            .Columns("lot_id").Visible = False
            .Columns("count").Width = 60
            .Columns("req_no").Width = 120
            .Columns("req_no").Visible = False
            .Columns("date_req").Width = 100
            .Columns("date_needed").Width = 100
            .Columns("time_needed").Width = 100
            .Columns("location").Width = 120
            .Columns("lot_no").Width = 100
            .Columns("operation").Width = 170
            .Columns("purpose").Width = 300
            .Columns("req_by").Width = 150


            .FullRowSelect = True
            '.ShowGridLines = True
            .ShowGroups = True
            .EnableGrouping = True
            .MultiSelect = False

            Me.lv_request_tt.EnableGrouping = True
            Me.lv_request_tt.ShowGroups = True
        End With
    End Sub
    Sub trip_ticket_scheduled_form_column()

        Me.lv_trip_ticket_scheduled.Columns.Clear()

        With Me.lv_trip_ticket_scheduled
            .Columns.Add("id", "hdr_id")
            '.Columns.Add("dtl_id", "dtl_id")
            .Columns.Add("count", "#")
            .Columns.Add("tt_no", "TRIP TICKET NO.")
            .Columns.Add("trip_date", "TRIP DATE")
            .Columns.Add("location", "DESTINATION")
            .Columns.Add("equip_type", "EQUIPMENT TYPE")
            .Columns.Add("equip_no", "EQUIPMENT NO.")
            .Columns.Add("imple_code", "IMPLEMENT CODE")
            .Columns.Add("driver", "DRIVER")
            .Columns.Add("purpose", "PURPOSE")
            .Columns.Add("req_by", "REQUESTED BY")
            .Columns.Add("app_bt", "APPROVED BY")



            .Columns("id").Width = 60
            .Columns("id").Visible = False
            '.Columns("dtl_id").Width = 60
            '.Columns("dtl_id").Visible = False
            .Columns("count").Width = 60
            .Columns("tt_no").Width = 130
            .Columns("trip_date").Width = 100
            .Columns("location").Width = 100
            .Columns("equip_type").Width = 110
            .Columns("equip_no").Width = 100
            .Columns("imple_code").Width = 110
            .Columns("driver").Width = 120
            .Columns("purpose").Width = 250
            .Columns("req_by").Width = 150
            .Columns("app_bt").Width = 150

            .FullRowSelect = True
            '.ShowGridLines = True
            .ShowGroups = True
            .EnableGrouping = True
            .MultiSelect = False

            Me.lv_trip_ticket_scheduled.EnableGrouping = True
            Me.lv_trip_ticket_scheduled.ShowGroups = True
        End With
    End Sub
    Sub trip_ticket_accomplished_form_column()

        Me.lv_accomplished_ticket.Columns.Clear()

        With Me.lv_accomplished_ticket
            .Columns.Add("id", "hdr_id")
            .Columns.Add("count", "#")
            .Columns.Add("trip_date", "TRIP DATE")
            .Columns.Add("trip_no", "TRIP NUMBER")
            .Columns.Add("location", "LOCATION")
            .Columns.Add("work_done", "TRIP WORK ITEM DONE")
            .Columns.Add("operate_hrs", "TRIP TOTAL OPERATE HOURS")
            .Columns.Add("area_done", "TRIP TOTAL AREA DONE")
            .Columns.Add("grand_amount", "TRIP TICKET GRAND TOTAL AMOUNT")


            .Columns("id").Width = 60
            .Columns("id").Visible = False
            .Columns("count").Width = 60
            .Columns("trip_date").Width = 150
            .Columns("trip_no").Width = 150
            .Columns("location").Width = 180
            .Columns("work_done").Width = 180
            .Columns("operate_hrs").Width = 180
            .Columns("area_done").Width = 200
            .Columns("grand_amount").Width = 220

            .FullRowSelect = True
            '.ShowGridLines = True
            .ShowGroups = True
            .EnableGrouping = True
            .MultiSelect = False

            Me.lv_accomplished_ticket.EnableGrouping = True
            Me.lv_accomplished_ticket.ShowGroups = True
        End With
    End Sub
    Sub trip_ticket_accomplished_item_column()

        Me.lv_approved_request_item.Columns.Clear()

        With Me.lv_approved_request_item
            .Columns.Add("id", "hdr_id")
            '.Columns.Add("dtl_id", "dtl_id")
            .Columns.Add("count", "#")
            .Columns.Add("req_no", "REQUEST NO.")
            .Columns.Add("tt_no", "TRIP TICKET NO.")
            .Columns.Add("trip_date", "TRIP DATE")
            .Columns.Add("location", "DESTINATION")
            .Columns.Add("equip_type", "EQUIPMENT TYPE")
            .Columns.Add("equip_no", "EQUIPMENT NO.")
            .Columns.Add("imple_code", "IMPLEMENT CODE")
            .Columns.Add("driver", "DRIVER")
            .Columns.Add("purpose", "PURPOSE")
            .Columns.Add("req_by", "REQUESTED BY")
            .Columns.Add("app_bt", "APPROVED BY")


            .Columns("id").Width = 60
            .Columns("id").Visible = False
            '.Columns("dtl_id").Width = 60
            '.Columns("dtl_id").Visible = False
            .Columns("count").Width = 60
            .Columns("req_no").Width = 130
            .Columns("tt_no").Width = 130
            .Columns("trip_date").Width = 100
            .Columns("location").Width = 100
            .Columns("equip_type").Width = 110
            .Columns("equip_no").Width = 100
            .Columns("imple_code").Width = 110
            .Columns("driver").Width = 120
            .Columns("purpose").Width = 250
            .Columns("req_by").Width = 150
            .Columns("app_bt").Width = 150

            .FullRowSelect = True
            '.ShowGridLines = True
            .ShowGroups = True
            .EnableGrouping = True
            .MultiSelect = False

            Me.lv_approved_request_item.EnableGrouping = True
            Me.lv_approved_request_item.ShowGroups = True
        End With
    End Sub
    Sub trip_ticket_schedule_processed_data_column()

        Me.lv_trip_ticket_schedule_processed_data.Columns.Clear()

        With Me.lv_trip_ticket_schedule_processed_data
            .Columns.Add("id", "hdr_id")
            '.Columns.Add("dtl_id", "dtl_id")
            .Columns.Add("count", "#")
            .Columns.Add("tt_no", "TRIP TICKET NO.")
            .Columns.Add("trip_date", "TRIP DATE")
            .Columns.Add("location", "DESTINATION")
            .Columns.Add("equip_type", "EQUIPMENT TYPE")
            .Columns.Add("equip_no", "EQUIPMENT NO.")
            .Columns.Add("imple_code", "IMPLEMENT CODE")
            .Columns.Add("driver", "DRIVER")
            .Columns.Add("purpose", "PURPOSE")
            .Columns.Add("req_by", "REQUESTED BY")
            .Columns.Add("app_bt", "APPROVED BY")
            .Columns.Add("process_by", "PROCESSED BY")

            .Columns("id").Width = 60
            .Columns("id").Visible = False
            '.Columns("dtl_id").Width = 60
            '.Columns("dtl_id").Visible = False
            .Columns("count").Width = 60
            .Columns("tt_no").Width = 130
            .Columns("trip_date").Width = 100
            .Columns("location").Width = 100
            .Columns("equip_type").Width = 110
            .Columns("equip_no").Width = 100
            .Columns("imple_code").Width = 110
            .Columns("driver").Width = 120
            .Columns("purpose").Width = 250
            .Columns("req_by").Width = 150
            .Columns("app_bt").Width = 150
            .Columns("process_by").Width = 150

            .FullRowSelect = True
            '.ShowGridLines = True
            .ShowGroups = True
            .EnableGrouping = True
            .MultiSelect = False

            Me.lv_trip_ticket_schedule_processed_data.EnableGrouping = True
            Me.lv_trip_ticket_schedule_processed_data.ShowGroups = True
        End With
    End Sub
    Sub trip_ticket_accomplihed_posted_data_column()

        Me.lv_accomplished_posted_data.Columns.Clear()

        With Me.lv_accomplished_posted_data
            .Columns.Add("id", "hdr_id")
            '.Columns.Add("dtl_id", "dtl_id")
            .Columns.Add("count", "#")
            .Columns.Add("tt_no", "TRIP TICKET NO.")
            .Columns.Add("trip_date", "TRIP DATE")
            .Columns.Add("location", "DESTINATION")
            .Columns.Add("equip_type", "EQUIPMENT TYPE")
            .Columns.Add("equip_no", "EQUIPMENT NO.")
            .Columns.Add("imple_code", "IMPLEMENT CODE")
            .Columns.Add("driver", "DRIVER")
            .Columns.Add("purpose", "PURPOSE")
            .Columns.Add("req_by", "REQUESTED BY")
            .Columns.Add("app_bt", "APPROVED BY")
            .Columns.Add("process_by", "PROCESSED BY")

            .Columns("id").Width = 60
            .Columns("id").Visible = False
            '.Columns("dtl_id").Width = 60
            '.Columns("dtl_id").Visible = False
            .Columns("count").Width = 60
            .Columns("tt_no").Width = 130
            .Columns("trip_date").Width = 100
            .Columns("location").Width = 100
            .Columns("equip_type").Width = 110
            .Columns("equip_no").Width = 100
            .Columns("imple_code").Width = 110
            .Columns("driver").Width = 120
            .Columns("purpose").Width = 250
            .Columns("req_by").Width = 150
            .Columns("app_bt").Width = 150
            .Columns("process_by").Width = 150

            .FullRowSelect = True
            '.ShowGridLines = True
            .ShowGroups = True
            .EnableGrouping = True
            .MultiSelect = False

            Me.lv_accomplished_posted_data.EnableGrouping = True
            Me.lv_accomplished_posted_data.ShowGroups = True
        End With
    End Sub
#End Region

    

    Private Sub Frm_trip_ticket_NEWS_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ThemeResolutionService.ApplicationThemeName = My.Settings.global_themes
        'Farming_Operation.Server_time()
        AddHandler Me.pv_tab.SelectedPageChanged, New System.EventHandler(AddressOf Me.pv_tab_SelectedPageChanged)

        Me.lv_request_tt.GroupDescriptors.Clear()
        Dim groupByType As New GroupDescriptor(New SortDescriptor() {New SortDescriptor("req_no", ListSortDirection.Descending)})
        lv_request_tt.GroupDescriptors.Add(groupByType)
    End Sub
    Private Sub menubtn_add_Click(sender As Object, e As EventArgs) Handles menubtn_add.Click
        Frm_request_form_add.Show()
        Frm_main.Enabled = False
    End Sub
    Private Sub menubtn_review_Click(sender As Object, e As EventArgs) Handles menubtn_review.Click
        If slct_id_req_hdr <= 0 Then
            MsgBox("Select an Item on the list please to continue to next process.")
        Else
            request_form_view.for_approval_info()

            Frm_request_form_approve.Show()
            Frm_main.Enabled = False
        End If
    End Sub
    Private Sub UpdateToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles menubtn_modify.Click
        Frm_request_form_update.Show()
        Frm_main.Enabled = False
    End Sub
    Private Sub lv_request_tt_MouseDown(sender As Object, e As MouseEventArgs) Handles lv_request_tt.MouseDown
        If e.Button = Windows.Forms.MouseButtons.Right Then
            Me.cms_menucontrol_tripticket_request.Show(Me, Me.PointToClient(MousePosition))
        End If
    End Sub

    Private Sub pvp1_tab_SelectedPageChanged(sender As Object, e As EventArgs) Handles pvp1_tab.SelectedPageChanged

        If Me.pvp1_tab.SelectedPage Is pvp1_1 Then
            tp_global.Enabled = True
        End If

        If Me.pvp1_tab.SelectedPage Is pvp1_2 Then
            trip_ticket_accomplished_item_column()
            request_form_view.trip_ticket_request_form_approved_data_load()

            Me.lv_approved_request_item.GroupDescriptors.Clear()
            Dim groupByType As New GroupDescriptor("trip_date")
            Me.lv_approved_request_item.GroupDescriptors.Add(groupByType)

        End If
    End Sub

    Private Sub lv_request_tt_CellFormatting(sender As Object, e As ListViewCellFormattingEventArgs) Handles lv_request_tt.CellFormatting
        If TypeOf e.CellElement Is DetailListViewHeaderCellElement Then
            e.CellElement.TextAlignment = ContentAlignment.MiddleCenter
        Else
            e.CellElement.ResetValue(LightVisualElement.TextAlignmentProperty, Telerik.WinControls.ValueResetFlags.Local)
        End If

        If (TypeOf e.CellElement Is DetailListViewDataCellElement) Then
            e.CellElement.TextAlignment = ContentAlignment.MiddleCenter
        End If

        If (TypeOf e.CellElement Is DetailListViewCellElement) Then
            e.CellElement.DrawFill = False
            e.CellElement.DrawBorder = False
        Else
            e.CellElement.ResetValue(LightVisualElement.DrawBorderProperty, Telerik.WinControls.ValueResetFlags.Local)
            e.CellElement.ResetValue(LightVisualElement.DrawFillProperty, Telerik.WinControls.ValueResetFlags.Local)
        End If
    End Sub

    Private Sub menubtn_refresh_Click(sender As Object, e As EventArgs) Handles menubtn_refresh.Click
        trip_ticket_request_form_column()
        request_form_view.trip_ticket_listview_load()
        slct_id_req_hdr = 0
    End Sub

    Private Sub lv_request_tt_SelectedItemChanged(sender As Object, e As EventArgs) Handles lv_request_tt.SelectedItemChanged
        request_form_view.Global_trip_ticket_request_selected()
        'MsgBox(slct_id_req_hdr)
    End Sub

    Private Sub tp_global_Tick(sender As Object, e As EventArgs) Handles tp_global.Tick
        trip_ticket_request_form_column()
        request_form_view.trip_ticket_listview_load()

        Me.lv_request_tt.GroupDescriptors.Clear()
        Dim groupByType As New GroupDescriptor(New SortDescriptor() {New SortDescriptor("req_no", ListSortDirection.Descending)})
        lv_request_tt.GroupDescriptors.Add(groupByType)

        Me.tp_global.Enabled = False
        Me.lbl_waiting_load.Visible = False
    End Sub

    Private Sub pv_tab_SelectedPageChanged(sender As Object, e As EventArgs) Handles pv_tab.SelectedPageChanged
        ctr2 += 1
        If ctr2 >= 2 Then
            If Me.pv_tab.Pages.IndexOf(Me.pv_tab.SelectedPage).ToString() = "1" Then
                'Me.pvp2_tab.SelectedPage = pvp2_1

                trip_ticket_scheduled_form_column()
                schedule_form_view.trip_ticket_listview_load()

                Me.lv_trip_ticket_scheduled.GroupDescriptors.Clear()
                Dim groupByType As New GroupDescriptor("trip_date")
                Me.lv_trip_ticket_scheduled.GroupDescriptors.Add(groupByType)
            ElseIf Me.pv_tab.Pages.IndexOf(Me.pv_tab.SelectedPage).ToString() = "2" Then

                trip_ticket_accomplished_form_column()
                accomplished_form_view.trip_ticket_accomplished_listview_load()
                Me.lv_accomplished_ticket.GroupDescriptors.Clear()
                Dim groupByType As New GroupDescriptor("trip_date")
                Me.lv_accomplished_ticket.GroupDescriptors.Add(groupByType)
            End If
        End If
    End Sub

    Private Sub pvp2_tab_SelectedPageChanged(sender As Object, e As EventArgs) Handles pvp2_tab.SelectedPageChanged
        If Me.pvp2_tab.SelectedPage Is pvp2_2 Then
            Me.lv_trip_ticket_schedule_processed_data.Columns.Clear()
            trip_ticket_schedule_processed_data_column()
            schedule_form_view.trip_ticket_schedule_form_processed_data_load()

            Me.lv_trip_ticket_schedule_processed_data.GroupDescriptors.Clear()
            Dim groupByType As New GroupDescriptor("trip_date")
            Me.lv_trip_ticket_schedule_processed_data.GroupDescriptors.Add(groupByType)
        End If
    End Sub

    Private Sub lv_trip_ticket_scheduled_CellFormatting(sender As Object, e As ListViewCellFormattingEventArgs) Handles lv_trip_ticket_scheduled.CellFormatting
        If TypeOf e.CellElement Is DetailListViewHeaderCellElement Then
            e.CellElement.TextAlignment = ContentAlignment.MiddleCenter
        Else
            e.CellElement.ResetValue(LightVisualElement.TextAlignmentProperty, Telerik.WinControls.ValueResetFlags.Local)
        End If

        If (TypeOf e.CellElement Is DetailListViewDataCellElement) Then
            e.CellElement.TextAlignment = ContentAlignment.MiddleCenter
        End If

        If (TypeOf e.CellElement Is DetailListViewCellElement) Then
            e.CellElement.DrawFill = False
            e.CellElement.DrawBorder = False
        Else
            e.CellElement.ResetValue(LightVisualElement.DrawBorderProperty, Telerik.WinControls.ValueResetFlags.Local)
            e.CellElement.ResetValue(LightVisualElement.DrawFillProperty, Telerik.WinControls.ValueResetFlags.Local)
        End If
    End Sub
    Private Sub review_tripticket_schedule_Click(sender As Object, e As EventArgs) Handles review_tripticket_schedule.Click
        Frm_main.Enabled = False
        Frm_schedule_encoding.Show()

        schedule_form_view.trip_ticket_scheduled_slct_lv()
    End Sub
    Private Sub lv_trip_ticket_scheduled_MouseDown(sender As Object, e As MouseEventArgs) Handles lv_trip_ticket_scheduled.MouseDown
        If e.Button = Windows.Forms.MouseButtons.Right Then
            Me.cms_tripticket_schedule.Show(Me, Me.PointToClient(MousePosition))
        End If
    End Sub

    Private Sub lv_accomplished_ticket_MouseDown(sender As Object, e As MouseEventArgs) Handles lv_accomplished_ticket.MouseDown
        If e.Button = Windows.Forms.MouseButtons.Right Then
            Me.cms_tripticket_accomplished.Show(Me, Me.PointToClient(MousePosition))
        End If
    End Sub

    Private Sub ToolStripMenuItem5_Click(sender As Object, e As EventArgs) Handles posting_review.Click
        If slct_id_req_hdr = Nothing Then
            MsgBox("Select an Item please to proceed.")
            Exit Sub
        End If
        Frm_main.Enabled = False
        Frm_accomplished_posting.Show()
    End Sub

    Private Sub lv_accomplished_ticket_CellFormatting(sender As Object, e As ListViewCellFormattingEventArgs) Handles lv_accomplished_ticket.CellFormatting
        If TypeOf e.CellElement Is DetailListViewHeaderCellElement Then
            e.CellElement.TextAlignment = ContentAlignment.MiddleCenter
        Else
            e.CellElement.ResetValue(LightVisualElement.TextAlignmentProperty, Telerik.WinControls.ValueResetFlags.Local)
        End If

        If (TypeOf e.CellElement Is DetailListViewDataCellElement) Then
            e.CellElement.TextAlignment = ContentAlignment.MiddleCenter
        End If

        If (e.CellElement).Data.Name = "grand_amount" Then
            If (TypeOf e.CellElement Is DetailListViewHeaderCellElement) Then
                e.CellElement.TextAlignment = ContentAlignment.MiddleRight
            End If

            If (TypeOf e.CellElement Is DetailListViewDataCellElement) Then
                e.CellElement.TextAlignment = ContentAlignment.MiddleRight
            End If
        End If

        If (TypeOf e.CellElement Is DetailListViewCellElement) Then
            e.CellElement.DrawFill = False
            e.CellElement.DrawBorder = False
        Else
            e.CellElement.ResetValue(LightVisualElement.DrawBorderProperty, Telerik.WinControls.ValueResetFlags.Local)
            e.CellElement.ResetValue(LightVisualElement.DrawFillProperty, Telerik.WinControls.ValueResetFlags.Local)
        End If
    End Sub

    Private Sub lv_accomplished_ticket_SelectedItemChanged(sender As Object, e As EventArgs) Handles lv_accomplished_ticket.SelectedItemChanged
        slct_id_req_hdr = Nothing
        If Me.lv_accomplished_ticket.SelectedItems.Count > 0 Then
            With Me.lv_accomplished_ticket.SelectedItems(0)
                slct_id_req_hdr = .SubItems(0)
                Frm_accomplished_posting.txt_trip_ticket_no.Text = .SubItems(3)
            End With
        End If
    End Sub

    Private Sub ToolStripMenuItem3_Click(sender As Object, e As EventArgs) Handles posting_refresh.Click
        accomplished_form_view.trip_ticket_accomplished_listview_load()
    End Sub

    Private Sub posting_Click(sender As Object, e As EventArgs) Handles posting.Click
        If slct_id_req_hdr = Nothing Then
            MsgBox("Please select an item first to proceed.")
            Exit Sub
        End If

        sysmod.Update_posting_status(slct_id_req_hdr)
        sysmod.Update_after_posting(slct_id_req_hdr)

        accomplished_form_view.trip_ticket_accomplished_listview_load()
    End Sub

    Private Sub print_hardcopy_Click(sender As Object, e As EventArgs) Handles print_hardcopy.Click
        schedule_form_view.trip_ticket_scheduled_slct_lv()

        Frm_trip_ticket_schedule_report.Show()
        Frm_main.Enabled = False

    End Sub

    Private Sub refresh_schedule_list_Click(sender As Object, e As EventArgs) Handles refresh_schedule_list.Click
        schedule_form_view.trip_ticket_listview_load()
    End Sub

    Private Sub lv_approved_request_item_CellFormatting(sender As Object, e As ListViewCellFormattingEventArgs) Handles lv_approved_request_item.CellFormatting
        request_form_view.lv_cellformatting(e)
    End Sub

    Private Sub lv_trip_ticket_schedule_processed_data_CellFormatting(sender As Object, e As ListViewCellFormattingEventArgs) Handles lv_trip_ticket_schedule_processed_data.CellFormatting
        schedule_form_view.lv_cellformatting(e)
    End Sub
    Private Sub pvp3_tab_SelectedPageChanged(sender As Object, e As EventArgs) Handles pvp3_tab.SelectedPageChanged
        If Me.pvp3_tab.SelectedPage Is pvp3_2 Then

            Me.lv_accomplished_posted_data.Columns.Clear()
            trip_ticket_accomplihed_posted_data_column()
            accomplished_form_view.trip_ticket_accomplihed_form_posted_data_load()

            Me.lv_accomplished_posted_data.GroupDescriptors.Clear()
            Dim groupByType As New GroupDescriptor("trip_date")
            Me.lv_accomplished_posted_data.GroupDescriptors.Add(groupByType)
        End If
    End Sub

    Private Sub lv_accomplished_posted_data_CellFormatting(sender As Object, e As ListViewCellFormattingEventArgs) Handles lv_accomplished_posted_data.CellFormatting
        accomplished_form_view.lv_cellformatting(e)
    End Sub

    Private Sub lv_trip_ticket_scheduled_SelectedItemChanged(sender As Object, e As EventArgs) Handles lv_trip_ticket_scheduled.SelectedItemChanged
        'Frm_main.Enabled = False
        'Frm_schedule_encoding.Show()

        schedule_form_view.trip_ticket_scheduled_slct_lv()
    End Sub

    Private Sub lv_accomplished_posted_data_SelectedItemChanged(sender As Object, e As EventArgs) Handles lv_accomplished_posted_data.SelectedItemChanged
        accomplished_form_view.Global_schedule_processed_data_selected()

        form_type = 2
    End Sub

    Private Sub lv_trip_ticket_schedule_processed_data_SelectedItemChanged(sender As Object, e As EventArgs) Handles lv_trip_ticket_schedule_processed_data.SelectedItemChanged
        schedule_form_view.Global_schedule_processed_data_selected()

        form_type = 1
    End Sub

    Private Sub lv_approved_request_item_SelectedItemChanged(sender As Object, e As EventArgs) Handles lv_approved_request_item.SelectedItemChanged
        request_form_view.Global_approve_request_data_selected()

        form_type = 0
    End Sub

    Private Sub lv_approved_request_item_MouseDown(sender As Object, e As MouseEventArgs) Handles lv_approved_request_item.MouseDown
        If e.Button = Windows.Forms.MouseButtons.Right Then
            Me.cms_status.Show(Me, Me.PointToClient(MousePosition))
        End If
    End Sub
    Private Sub lv_trip_ticket_schedule_processed_data_MouseDown(sender As Object, e As MouseEventArgs) Handles lv_trip_ticket_schedule_processed_data.MouseDown
        If e.Button = Windows.Forms.MouseButtons.Right Then
            Me.cms_status.Show(Me, Me.PointToClient(MousePosition))
        End If
    End Sub
    Private Sub lv_accomplished_posted_data_MouseDown(sender As Object, e As MouseEventArgs) Handles lv_accomplished_posted_data.MouseDown
        If e.Button = Windows.Forms.MouseButtons.Right Then
            Me.cms_status.Show(Me, Me.PointToClient(MousePosition))
        End If


    End Sub
    Private Sub cmsmoredetails_Click(sender As Object, e As EventArgs) Handles cmsmoredetails.Click
        If slct_id_req_hdr = Nothing Then
            MsgBox("Please select an record to proceed.", vbInformation + vbOKOnly, "Warning")
            Exit Sub
        End If
        Frm_main.Enabled = False
        Frm_form_status.Show()
    End Sub
End Class
