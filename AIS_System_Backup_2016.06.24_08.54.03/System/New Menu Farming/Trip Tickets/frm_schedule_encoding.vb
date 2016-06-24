Imports Telerik.WinControls.UI
Imports Telerik.WinControls
Imports AIS_System.System_mod
Imports System.Data.SqlClient
Imports Telerik.WinControls.Data
Imports System.ComponentModel
Public Class Frm_schedule_encoding
    Dim sysmod As New System_mod

#Region "LISTVIEW COLUMN"
    Sub trip_ticket_schedule_encoding_column()

        Me.lv_schedule_header.Columns.Clear()

        With Me.lv_schedule_header
            .Columns.Add("id", "dtl_id")
            .Columns.Add("count", "#")
            .Columns.Add("lot_no", "LOT NUMBER")
            .Columns.Add("work_operation", "WORK OPERATION")


            .Columns("id").Width = 60
            .Columns("id").Visible = False
            .Columns("count").Width = 30
            .Columns("lot_no").Width = 120
            .Columns("work_operation").Width = 220


            .FullRowSelect = True
            '.ShowGridLines = True
            .ShowGroups = True
            .EnableGrouping = True
            .MultiSelect = False

            Me.lv_schedule_header.EnableGrouping = True
            Me.lv_schedule_header.ShowGroups = True
        End With
    End Sub

    Sub trip_ticket_schedule_viewing_column()

        Me.lv_schedule_detail.Columns.Clear()

        With Me.lv_schedule_detail
            '.Columns.Add("id", "id")
            .Columns.Add("count", "#")
            .Columns.Add("lot_no", "LOT NUMBER")
            .Columns.Add("location", "LOCATION")
            .Columns.Add("operation", "WORK OPERATION")
            .Columns.Add("time_started", "TIME STARTED")
            .Columns.Add("time_stopped", "TIME STOPPED")
            .Columns.Add("operate_hrs", "WORK HOURS")
            .Columns.Add("area_finish", "AREA FINISH")


            '.Columns("id").Width = 60
            '.Columns("id").Visible = False
            .Columns("count").Width = 30
            .Columns("lot_no").Width = 120
            .Columns("location").Width = 180
            .Columns("operation").Width = 220
            .Columns("time_started").Width = 100
            .Columns("time_stopped").Width = 100
            .Columns("operate_hrs").Width = 80
            .Columns("area_finish").Width = 80


            .FullRowSelect = True
            '.ShowGridLines = True
            .ShowGroups = True
            .EnableGrouping = True
            .MultiSelect = False

            Me.lv_schedule_detail.EnableGrouping = True
            Me.lv_schedule_detail.ShowGroups = True
        End With
    End Sub
#End Region
    Private Sub Frm_schedule_encoding_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ThemeResolutionService.ApplicationThemeName = My.Settings.global_themes
        'Farming_Operation.Server_time()

    End Sub

    Private Sub Frm_schedule_encoding_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        Frm_main.Enabled = True
        schedule_form_view.trip_ticket_listview_load()
    End Sub
    Private Sub Frm_schedule_encoding_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        If e.CloseReason = CloseReason.UserClosing Then
            If MessageBox.Show("If you proceed this command all queued data will be remove and all unprocess data will erase.?", "Warning!", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                'Frm_main.Enabled = True
            Else
                e.Cancel = True
            End If
        End If
    End Sub
    Private Sub btn_schedule_headerdone_Click(sender As Object, e As EventArgs) Handles btn_schedule_headerdone.Click
        Me.gb_header_menu.Enabled = False
        Me.gb_header_data.Enabled = True

        trip_ticket_schedule_encoding_column()
        schedule_form_view.trip_ticket_schedule_header_data()
    End Sub

    Private Sub btn_schedule_heacercancel_Click(sender As Object, e As EventArgs) Handles btn_schedule_heacercancel.Click
        Me.gb_header_menu.Enabled = True
        Me.gb_header_data.Enabled = False

        Me.lv_schedule_header.Columns.Clear()
    End Sub

    Private Sub btn_schedule_detailcancel_Click(sender As Object, e As EventArgs) Handles btn_schedule_detailcancel.Click
        Me.gb_header_data.Enabled = True
        Me.gb_detail_menu.Enabled = False
        schedule_form_view.clear_field_text()
    End Sub

    Private Sub btn_schedule_detaildone_Click(sender As Object, e As EventArgs) Handles btn_schedule_detaildone.Click
        trip_ticket_schedule_viewing_column()
        sysmod.Update_schedule_dtl(slct_id_dtl_schedule, Me.tp_start_time.Value, Me.tp_stop_time.Value, time_operates_infarm, Me.se_area_finish.Value)


        Dim msg = MsgBox("Successfully add to queued..." & vbCrLf & " Endode another data in the List-?", vbInformation + vbYesNo, "Done...")

        sysmod.count_schedule_dtl(slct_id_hdr_schedule)

        If msg = vbYes Then
            If count_remain = 0 Then
                MsgBox("No more data item to be updated.")

                Me.gb_detail_menu.Enabled = False
                Me.gb_detail_data.Enabled = True
                'Exit Sub
            Else
                Me.gb_detail_menu.Enabled = False
                Me.gb_header_data.Enabled = True
            End If
            'Me.gb_detail_menu.Enabled = False
            'Me.gb_header_data.Enabled = True
        Else
            Me.gb_detail_menu.Enabled = False
            Me.gb_detail_data.Enabled = True
        End If

        schedule_form_view.trip_ticket_schedule_detail_data()
        schedule_form_view.trip_ticket_schedule_header_data()
        schedule_form_view.clear_field_text()
    End Sub

    Private Sub btn_schedule_detailprocesscancel_Click(sender As Object, e As EventArgs) Handles btn_schedule_detailprocesscancel.Click
        sysmod.count_schedule_dtl(slct_id_hdr_schedule)

        If count_remain = 0 Then
            MsgBox("No more data item to be updated.")
            Exit Sub
        Else
            Me.gb_header_data.Enabled = True
            Me.gb_detail_data.Enabled = False
        End If

       
    End Sub

    Private Sub lv_schedule_header_CellFormatting(sender As Object, e As ListViewCellFormattingEventArgs) Handles lv_schedule_header.CellFormatting
        If TypeOf e.CellElement Is DetailListViewHeaderCellElement Then
            e.CellElement.TextAlignment = ContentAlignment.MiddleLeft
        Else
            e.CellElement.ResetValue(LightVisualElement.TextAlignmentProperty, Telerik.WinControls.ValueResetFlags.Local)
        End If

        If (TypeOf e.CellElement Is DetailListViewDataCellElement) Then
            e.CellElement.TextAlignment = ContentAlignment.MiddleLeft
        End If

        If (e.CellElement).Data.Name = "count" Then
            If (TypeOf e.CellElement Is DetailListViewHeaderCellElement) Then
                e.CellElement.TextAlignment = ContentAlignment.MiddleCenter
            End If

            If (TypeOf e.CellElement Is DetailListViewDataCellElement) Then
                e.CellElement.TextAlignment = ContentAlignment.MiddleCenter
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

    Private Sub lv_schedule_header_ItemMouseDoubleClick(sender As Object, e As ListViewItemEventArgs) Handles lv_schedule_header.ItemMouseDoubleClick
        Me.gb_header_data.Enabled = False
        Me.gb_detail_menu.Enabled = True

        schedule_form_view.trip_ticket_scheduled_header_id()
    End Sub

    Private Sub lv_schedule_detail_CellFormatting(sender As Object, e As ListViewCellFormattingEventArgs) Handles lv_schedule_detail.CellFormatting
        If TypeOf e.CellElement Is DetailListViewHeaderCellElement Then
            e.CellElement.TextAlignment = ContentAlignment.MiddleLeft
        Else
            e.CellElement.ResetValue(LightVisualElement.TextAlignmentProperty, Telerik.WinControls.ValueResetFlags.Local)
        End If

        If (TypeOf e.CellElement Is DetailListViewDataCellElement) Then
            e.CellElement.TextAlignment = ContentAlignment.MiddleLeft
        End If

        If (e.CellElement).Data.Name = "count" Then
            If (TypeOf e.CellElement Is DetailListViewHeaderCellElement) Then
                e.CellElement.TextAlignment = ContentAlignment.MiddleCenter
            End If

            If (TypeOf e.CellElement Is DetailListViewDataCellElement) Then
                e.CellElement.TextAlignment = ContentAlignment.MiddleCenter
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

    Private Sub btn_schedule_detalprocess_Click(sender As Object, e As EventArgs) Handles btn_schedule_detalprocess.Click
        sysmod.process_accomplisht(user_id, slct_id_hdr_schedule, tp_e_timeout.Value, tp_e_timein.Value, tp_ja_timein.Value, tp_ja_timeout.Value _
                                  , Me.txt_remarks.Text, "", Frm_main.txt_fullname.Text)
    End Sub

    Private Sub tp_start_time_ValueChanged(sender As Object, e As EventArgs) Handles tp_start_time.ValueChanged
        time_operate()
    End Sub

    Private Sub tp_stop_time_ValueChanged(sender As Object, e As EventArgs) Handles tp_stop_time.ValueChanged
        time_operate()
    End Sub

    Sub time_operate()
        Dim span As TimeSpan = tp_stop_time.Value - tp_start_time.Value
        Dim tot_hours = span.Hours.ToString
        Dim tot_min = span.Minutes.ToString

        If span.Hours.ToString <= "0" Then
            Me.se_hours.Text = "0:0 hrs"
            time_operates_infarm = "0:0"
        ElseIf span.Hours.ToString < "2" Then
            Me.se_hours.Text = tot_hours + ":" + tot_min + " hr"
            time_operates_infarm = tot_hours + ":" + tot_min
        Else
            Me.se_hours.Text = tot_hours + ":" + tot_min + " hrs"
            time_operates_infarm = tot_hours + ":" + tot_min
        End If
    End Sub

End Class
