Imports Telerik.WinControls.UI
Imports Telerik.WinControls
Imports AIS_System.System_mod
Imports System.Data.SqlClient
Imports Telerik.WinControls.Data
Imports System.ComponentModel
Public Class Frm_trip_ticket_monitoring
    Dim sysmod As New System_mod

#Region "LISTVIEW COLUMN"
    Sub trip_ticket_list_listview_column()
        Me.lv_trip_ticket_list.Columns.Clear()

        With Me.lv_trip_ticket_list
            .Columns.Add("count", "#")
            .Columns.Add("trip_no", "TRIP TICKET NO.")
            .Columns.Add("destination", "DESTINATION")
            .Columns.Add("status", "STATUS")
            .Columns.Add("need_date", "need_date")

            .Columns("count").Width = 40
            .Columns("trip_no").Width = 110
            .Columns("destination").Width = 120
            .Columns("status").Width = 80
            .Columns("need_date").Visible = False

            .FullRowSelect = True
            .ShowGroups = True
            .EnableGrouping = True
            .MultiSelect = False

        End With
    End Sub

    Sub trip_ticket_processed_listview_column()
        Me.lv_tripticket_processed.Columns.Clear()

        With Me.lv_tripticket_processed
            .Columns.Add("hdr_id", "hdrid")
            .Columns.Add("count", "#")
            .Columns.Add("trip_no", "TRIP TICKET NO.")
            .Columns.Add("equip_type", "EQUIPMENT TYPE")
            .Columns.Add("imple_code", "IMPLEMENT CODE")
            .Columns.Add("driver", "DRIVER")
            .Columns.Add("prpose", "PURPOSE")

            .Columns("hdr_id").Width = 60
            .Columns("hdr_id").Visible = False
            .Columns("count").Width = 50
            .Columns("trip_no").Width = 110
            .Columns("equip_type").Width = 140
            .Columns("imple_code").Width = 120
            .Columns("driver").Width = 150
            .Columns("prpose").Width = 200

            .FullRowSelect = True
            .ShowGroups = True
            .EnableGrouping = True
            .MultiSelect = False
        End With
    End Sub

    Sub trip_ticket_unprocessed_listview_column()
        Me.lv_tripticket_unprocessed.Columns.Clear()

        With Me.lv_tripticket_unprocessed
            .Columns.Add("hdr_id", "hdrid")
            .Columns.Add("count", "#")
            .Columns.Add("trip_no", "TRIP TICKET NO.")
            .Columns.Add("equip_type", "EQUIPMENT TYPE")
            .Columns.Add("imple_code", "IMPLEMENT CODE")
            .Columns.Add("driver", "DRIVER")
            .Columns.Add("prpose", "PURPOSE")

            .Columns("hdr_id").Width = 60
            .Columns("hdr_id").Visible = False
            .Columns("count").Width = 50
            .Columns("trip_no").Width = 110
            .Columns("equip_type").Width = 140
            .Columns("imple_code").Width = 120
            .Columns("driver").Width = 150
            .Columns("prpose").Width = 200

            .FullRowSelect = True
            .ShowGroups = True
            .EnableGrouping = True
            .MultiSelect = False
        End With
    End Sub

    Sub trip_ticket_information_listview_column()
        Me.lv_tripticket_information.Columns.Clear()

        With Me.lv_tripticket_information
            .Columns.Add("count", "#")
            .Columns.Add("lot_no", "LOT NO.")
            .Columns.Add("date_planted", "DATE PLANTED")
            .Columns.Add("variety", "VARIETY")
            .Columns.Add("lot_owner", "LOT OWNER")
            .Columns.Add("operation", "WORK TO PERFORMED")
            .Columns.Add("request_date", "REQUEST DATE")
            .Columns.Add("request_by", "REQUEST BY")
            .Columns.Add("approved_date", "APPROVED DATE")
            .Columns.Add("approved_by", "APPROVED BY")

            .Columns("count").Width = 50
            .Columns("lot_no").Width = 110
            .Columns("date_planted").Width = 140
            .Columns("variety").Width = 120
            .Columns("lot_owner").Width = 150
            .Columns("operation").Width = 200
            .Columns("request_date").Width = 150
            .Columns("request_by").Width = 150
            .Columns("approved_date").Width = 150
            .Columns("approved_by").Width = 150

            .FullRowSelect = True
            .ShowGroups = True
            .EnableGrouping = True
            .MultiSelect = False
        End With
    End Sub
#End Region
    Private Sub Frm_trip_ticket_monitoring_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ThemeResolutionService.ApplicationThemeName = My.Settings.global_themes
        'Farming_Operation.Server_time()

        trip_ticket_list_listview_column() : trip_ticket_processed_listview_column() : trip_ticket_unprocessed_listview_column() : trip_ticket_information_listview_column()
    End Sub

    Private Sub listview_formatting(sender As Object, e As ListViewCellFormattingEventArgs) Handles lv_tripticket_unprocessed.CellFormatting, _
        lv_tripticket_processed.CellFormatting, lv_tripticket_information.CellFormatting, lv_trip_ticket_list.CellFormatting
        trip_ticket_class.lv_cellformatting(e)
    End Sub

    Private Sub btn_lotno_Click(sender As Object, e As EventArgs) Handles btn_lotno.Click
        trip_ticket_class.issued_trip_ticket_listview()

        Me.lv_trip_ticket_list.GroupDescriptors.Clear()
        'Dim groupByType As New GroupDescriptor("need_date")
        Dim groupByType As New GroupDescriptor(New SortDescriptor() {New SortDescriptor("need_date", ListSortDirection.Descending)})
        Me.lv_trip_ticket_list.GroupDescriptors.Add(groupByType)

        trip_ticket_class.group_expantion(Me.lv_trip_ticket_list.Groups.Count, lv_trip_ticket_list)



    End Sub

    Private Sub lv_trip_ticket_list_VisualItemFormatting(sender As Object, e As ListViewVisualItemEventArgs) Handles lv_trip_ticket_list.VisualItemFormatting
        trip_ticket_class.group_count(e)
    End Sub

    Private Sub lv_trip_ticket_list_MouseDown(sender As Object, e As MouseEventArgs) Handles lv_trip_ticket_list.MouseDown
        If e.Button = Windows.Forms.MouseButtons.Right Then
            Me.cms_issued_ticket.Show(Me, Me.PointToClient(MousePosition))
        End If
    End Sub

    Private Sub view_more_date_info_Click(sender As Object, e As EventArgs) Handles view_more_date_info.Click
        trip_ticket_class.Global_need_date_selected()
        trip_ticket_class.processed_trip_ticket_listview(need_dates)
        trip_ticket_class.unprocessed_trip_ticket_listview(need_dates)


        'trip_ticket_class.dispalyed_selected_listview_item(lv_tripticket_processed)
        'trip_ticket_class.dispalyed_selected_listview_item(lv_tripticket_unprocessed)
    End Sub

    Private Sub lv_tripticket_processed_SelectedItemChanged(sender As Object, e As EventArgs) Handles lv_tripticket_processed.SelectedItemChanged
        trip_ticket_class.Global_processed_selected()
        trip_ticket_class.information_trip_ticket_listview(hdr_id_monitoring, 0)

        trip_ticket_class.dispalyed_selected_listview_item(lv_tripticket_information)
        Me.lv_tripticket_unprocessed.SelectedItem = Nothing
    End Sub


    Private Sub lv_tripticket_unprocessed_SelectedItemChanged(sender As Object, e As EventArgs) Handles lv_tripticket_unprocessed.SelectedItemChanged
        trip_ticket_class.Global_unprocessed_selected()
        trip_ticket_class.information_trip_ticket_listview(hdr_id_monitoring, 1)

        trip_ticket_class.dispalyed_selected_listview_item(lv_tripticket_information)
        Me.lv_tripticket_processed.SelectedItem = Nothing
    End Sub
End Class
