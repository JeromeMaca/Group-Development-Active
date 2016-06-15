Imports Telerik.WinControls.UI
Imports Telerik.WinControls
Imports AIS_System.System_mod
Imports System.Data.SqlClient
Imports Telerik.WinControls.Data
Imports System.ComponentModel
Public Class Frm_lot_by_lot_monitoring
    Dim sysmod As New System_mod

#Region "LISTVIEW COLUMN"
    Sub lotno_listview_column()
        Me.lv_lotcodelist.Columns.Clear()

        With Me.lv_lotcodelist
            .Columns.Add("count", "#")
            .Columns.Add("lot_no", "LOT NUMBER")

        
            .Columns("count").Width = 60
            .Columns("lot_no").Width = 180

            .FullRowSelect = True
            .ShowGroups = True
            .EnableGrouping = True
            .MultiSelect = False
          
        End With
    End Sub

    Sub activity_listview_column()
        Me.lv_lotcode_history.Columns.Clear()

        With Me.lv_lotcode_history
            .Columns.Add("id", "hdr_id")
            .Columns.Add("count", "#")
            .Columns.Add("ticket_no", "TRIP TICKET NO.")
            .Columns.Add("need_date", "TRIP TICKET DATE")
            .Columns.Add("work_performed", "OPERATION PERFORMED")
            .Columns.Add("purpose", "PURPOSE")
            .Columns.Add("date_planted", "DATE PLANTED")
            .Columns.Add("cur_variety", "VARIETY")
            .Columns.Add("cur_area", "TOTAL AREA")
            .Columns.Add("operate_rate", "OPERATION RATE")
            .Columns.Add("ope_hours", "WORK HOURS")
            .Columns.Add("area_done", "AREA FINISH")
            .Columns.Add("total_amount", "TOTAL AMOUNT")

            .Columns("id").Width = 60
            .Columns("id").Visible = False
            .Columns("count").Width = 60
            .Columns("ticket_no").Width = 120
            .Columns("need_date").Width = 150
            .Columns("work_performed").Width = 180
            .Columns("purpose").Width = 220
            .Columns("date_planted").Width = 100
            .Columns("cur_variety").Width = 110
            .Columns("cur_area").Width = 100
            .Columns("operate_rate").Width = 100
            .Columns("ope_hours").Width = 100
            .Columns("area_done").Width = 100
            .Columns("total_amount").Width = 110

            .FullRowSelect = True
            '.ShowGridLines = True
            .ShowGroups = True
            .EnableGrouping = True
            .MultiSelect = False

            Me.lv_lotcode_history.EnableGrouping = True
            Me.lv_lotcode_history.ShowGroups = True
        End With
    End Sub

    Sub equipment_listview_column()
        Me.lv_equipment.Columns.Clear()

        With Me.lv_equipment
            .Columns.Add("count", "#")
            .Columns.Add("owner_name", "EQUIPMENT OWNER")
            .Columns.Add("type", "TRIP TICKET DATE")
            .Columns.Add("model_plate", "MODEL / PLATE NO.")
            .Columns.Add("driver", "EQUIPMENT DRIVER")
            .Columns.Add("equip_in", "TIME IN")
            .Columns.Add("equip_out", "TIME OUT")
            .Columns.Add("job_arrival", "JOBSITE ARRIVAL")
            .Columns.Add("job_departure", "JOBSITE DEPARTURE")
            '.Columns.Add("area_done", "AREA FINISH")
            '.Columns.Add("total_amount", "TOTAL AMOUNT")

            .Columns("count").Width = 60
            .Columns("owner_name").Width = 200
            .Columns("type").Width = 180
            .Columns("model_plate").Width = 130
            .Columns("driver").Width = 150
            .Columns("equip_in").Width = 100
            .Columns("equip_out").Width = 100
            .Columns("job_arrival").Width = 120
            .Columns("job_departure").Width = 120
            '.Columns("area_done").Width = 100
            '.Columns("total_amount").Width = 100

            .FullRowSelect = True
            '.ShowGridLines = True
            .ShowGroups = True
            .EnableGrouping = True
            .MultiSelect = False

            Me.lv_equipment.EnableGrouping = True
            Me.lv_equipment.ShowGroups = True
        End With
    End Sub

    Sub implement_listview_column()
        Me.lv_implement.Columns.Clear()

        With Me.lv_implement
            .Columns.Add("count", "#")
            .Columns.Add("owner_name", "EQUIPMENT OWNER")
            .Columns.Add("imple_desc", "IMPLEMENT DESCRIPTION")
            .Columns.Add("imple_code", "IMPLEMENT CODE")

            .Columns("count").Width = 60
            .Columns("owner_name").Width = 200
            .Columns("imple_desc").Width = 280
            .Columns("imple_code").Width = 150

            .FullRowSelect = True
            '.ShowGridLines = True
            .ShowGroups = True
            .EnableGrouping = True
            .MultiSelect = False

            Me.lv_implement.EnableGrouping = True
            Me.lv_implement.ShowGroups = True
        End With
    End Sub

#End Region
    Private Sub Frm_lot_by_lot_monitoring_Load(sender As Object, e As EventArgs) Handles Me.Load
        ThemeResolutionService.ApplicationThemeName = My.Settings.global_themes
        'Farming_Operation.Server_time()
        lot_history_class.dp_location_load()

        lotno_listview_column()
        activity_listview_column()
        equipment_listview_column()
        implement_listview_column()
    End Sub

    Private Sub dp_location_SelectedIndexChanged(sender As Object, e As UI.Data.PositionChangedEventArgs) Handles dp_location.SelectedIndexChanged
        Me.lv_lotcodelist.Items.Clear()
        lot_history_class.dp_cropyear_load()
    End Sub

    Private Sub dp_cropyear_SelectedIndexChanged(sender As Object, e As UI.Data.PositionChangedEventArgs) Handles dp_cropyear.SelectedIndexChanged
        'lotno_listview_column()
    End Sub

    Private Sub txt_reqno_TextChanged(sender As Object, e As EventArgs) Handles txt_search.TextChanged
        lot_history_class.monitoring_lotcode_search(Me.dp_location.SelectedItem.ToString, Me.dp_cropyear.SelectedItem.ToString, Replace(Trim(Me.txt_search.Text), "'", "`"))
    End Sub

    Private Sub lv_lotcodelist_SelectedItemChanged(sender As Object, e As EventArgs) Handles lv_lotcodelist.SelectedItemChanged
        lot_history_class.Global_lot_number_selected()

        'activity_listview_column()
        lot_history_class.activity_load_listview(lotno, Me.dp_cropyear.SelectedItem.ToString)

        Me.lv_lotcode_history.GroupDescriptors.Clear()
        Dim groupByType As New GroupDescriptor("cur_variety")
        Me.lv_lotcode_history.GroupDescriptors.Add(groupByType)

        lot_history_class.dispalyed_selected_listview_item(lv_lotcode_history)
    End Sub

    Private Sub btn_lotno_Click(sender As Object, e As EventArgs) Handles btn_lotno.Click
        lot_history_class.monitoring_lotcode_load_listvoew(Me.dp_location.SelectedItem.ToString, Me.dp_cropyear.SelectedItem.ToString)
    End Sub

    Private Sub lv_lotcode_history_SelectedItemChanged(sender As Object, e As EventArgs) Handles lv_lotcode_history.SelectedItemChanged
        'equipment_listview_column()
        lot_history_class.Global_activity_dtl_id_selected()
        lot_history_class.equipment_load_listview(dtl_id_monitoring)
        lot_history_class.implement_load_listview(dtl_id_monitoring)

        lot_history_class.dispalyed_selected_listview_item(lv_equipment)
        lot_history_class.dispalyed_selected_listview_item(lv_implement)
    End Sub

    Private Sub cellformatin(sender As Object, e As ListViewCellFormattingEventArgs) Handles lv_implement.CellFormatting _
        , lv_equipment.CellFormatting, lv_lotcode_history.CellFormatting, lv_lotcodelist.CellFormatting

        lot_history_class.lv_cellformatting(e)
    End Sub

    Private Sub lv_lotcodelist_MouseDown(sender As Object, e As MouseEventArgs) Handles lv_lotcodelist.MouseDown
        If e.Button = Windows.Forms.MouseButtons.Right Then
            Me.cms_menu.Show(Me, Me.PointToClient(MousePosition))
        End If
    End Sub
End Class
