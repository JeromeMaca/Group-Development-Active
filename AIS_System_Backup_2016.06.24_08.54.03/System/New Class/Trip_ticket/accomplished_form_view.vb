Imports System.Data.SqlClient
Imports Telerik.WinControls.UI
Imports Telerik.WinControls
Imports Telerik.Data
Imports Telerik.WinControls.Data
Imports System.ComponentModel
Public Class accomplished_form_view

#Region "LISTVIEW FORMATTING CELL"
    Shared Sub lv_cellformatting(e)
        If TypeOf e.CellElement Is DetailListViewHeaderCellElement Then
            e.CellElement.TextAlignment = ContentAlignment.MiddleCenter
        Else
            e.CellElement.ResetValue(LightVisualElement.TextAlignmentProperty, Telerik.WinControls.ValueResetFlags.Local)
        End If

        If (TypeOf e.CellElement Is DetailListViewDataCellElement) Then
            e.CellElement.TextAlignment = ContentAlignment.MiddleCenter
        End If

        If (e.CellElement).Data.Name = "count" Then
            If (TypeOf e.CellElement Is DetailListViewHeaderCellElement) Then
                e.CellElement.TextAlignment = ContentAlignment.MiddleCenter
            End If

            If (TypeOf e.CellElement Is DetailListViewDataCellElement) Then
                e.CellElement.TextAlignment = ContentAlignment.MiddleCenter
            End If
        End If

        If (TypeOf e.Cellelement Is DetailListViewCellElement) Then
            e.CellElement.DrawFill = False
            e.CellElement.DrawBorder = False
        Else
            e.CellElement.ResetValue(LightVisualElement.DrawBorderProperty, Telerik.WinControls.ValueResetFlags.Local)
            e.CellElement.ResetValue(LightVisualElement.DrawFillProperty, Telerik.WinControls.ValueResetFlags.Local)
        End If
    End Sub
#End Region

#Region "ACCOMPLISHED FORM LISTVIEW LOAD"
    Shared Sub trip_ticket_accomplished_listview_load()
        Try
            sql = ""
            sql = "SELECT  ROW_NUMBER() over (ORDER BY trip_ticket_no DESC) as #,hdr_id,CONVERT(VARCHAR(12), trip_date, 107) as trip_date," _
                    & " REPLICATE('0', 6 - LEN(trip_ticket_no)) + CAST(trip_ticket_no AS varchar) AS trip_ticket_no,location,(SELECT COUNT(hdr_id)) as tot_work_done," _
                    & " (CAST(SUM(DATEDIFF(HOUR, '0:00:00', operate_hours)) AS VARCHAR(10)) +':'+ CAST((SUM(DATEDIFF(MINUTE, '0:00:00', operate_hours))%60) AS VARCHAR(10))) as tot_operate_hrs," _
                    & " (SELECT SUM(area_done)) as tot_area_done,(SELECT SUM(amount)) as grand_tot_amount" _
                    & " FROM v_ais_trip_ticket_schedule_form WHERE dtl_stats='2' AND post_status='0' GROUP BY hdr_id,trip_date,trip_ticket_no,location"

            Using sqlCnn = New SqlConnection(My.Settings.Conn_string)

                Frm_trip_ticket_NEWS.lv_accomplished_ticket.Items.Clear()

                sqlCnn.Open()
                sqlCmd = New SqlCommand(sql, sqlCnn)

                Using sqlReader As SqlDataReader = sqlCmd.ExecuteReader()

                    While (sqlReader.Read())
                        Dim list As New ListViewDataItem
                        list.SubItems.Add(sqlReader(1).ToString())
                        list.SubItems.Add(sqlReader(0).ToString())
                        list.SubItems.Add(sqlReader(2).ToString())
                        list.SubItems.Add(sqlReader(3).ToString())
                        list.SubItems.Add(sqlReader(4).ToString())
                        list.SubItems.Add(sqlReader(5).ToString())
                        list.SubItems.Add(sqlReader(6).ToString())
                        list.SubItems.Add(sqlReader(7).ToString())
                        list.SubItems.Add(sqlReader(8).ToString())

                        Frm_trip_ticket_NEWS.lv_accomplished_ticket.Items.Add(list)
                    End While
                End Using
                sqlCmd.Connection.Close()
            End Using
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        slct_id = Nothing
    End Sub
#End Region

#Region "POSTING DATA LISTVIEW LOAD"
    Shared Sub accomplished_posting_listview_load()
        Try
            sql = ""
            'sql = "SELECT ROW_NUMBER() over (ORDER BY lot_no) as #, dtl_id,lot_no,work_operation,operate_hours,area_done,rate_per_area,amount FROM v_ais_trip_ticket_schedule_form" _
            '        & " WHERE hdr_id ='" & slct_id_req_hdr & "' AND status ='1' AND dtl_stats = '2'"

            sql = "SELECT ROW_NUMBER() over (ORDER BY lot_no) as #,b.dtl_id,b.lot_no,b.work_operation,b.operate_hours,b.area_done,b.rate_per_area,b.amount,a.gand_tot" _
                & " FROM(SELECT SUM(amount) AS gand_tot,hdr_id FROM v_ais_trip_ticket_schedule_form GROUP BY hdr_id) a" _
                & " INNER JOIN v_trip_ticket_schedule_form b ON a.hdr_id=b.hdr_id" _
                & " WHERE b.hdr_id ='" & slct_id_req_hdr & "' AND b.post_status = '0' AND b.dtl_stats = '2'"

            Using sqlCnn = New SqlConnection(My.Settings.Conn_string)

                Frm_accomplished_posting.lv_posting.Items.Clear()

                sqlCnn.Open()
                sqlCmd = New SqlCommand(sql, sqlCnn)

                Using sqlReader As SqlDataReader = sqlCmd.ExecuteReader()

                    While (sqlReader.Read())
                        Dim list As New ListViewDataItem
                        list.SubItems.Add(sqlReader(1).ToString())
                        list.SubItems.Add(sqlReader(0).ToString())
                        list.SubItems.Add(sqlReader(2).ToString())
                        list.SubItems.Add(sqlReader(3).ToString())
                        list.SubItems.Add(sqlReader(4).ToString())
                        list.SubItems.Add(sqlReader(5).ToString())
                        list.SubItems.Add(sqlReader(6).ToString())
                        list.SubItems.Add(sqlReader(7).ToString())
                        list.SubItems.Add(sqlReader(8).ToString())
                        Frm_accomplished_posting.lv_posting.Items.Add(list)

                        Frm_accomplished_posting.txt_grandtotal.Text = sqlReader(8)
                    End While
                End Using
                sqlCmd.Connection.Close()
            End Using
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        slct_id = Nothing
    End Sub
#End Region

#Region "CLEAR FIELD"
    Shared Sub clear_field_posting()
        For Each tx As Control In Frm_accomplished_posting.gb_menu.Controls
            If TypeOf (tx) Is RadTextBox = True Then
                tx.Text = ""
            End If
        Next

        For Each tx As Control In Frm_accomplished_posting.gb_menu.Controls
            If TypeOf (tx) Is CurrencyTextBox.CurrencyTextBox = True Then
                tx.Text = ""
            End If
        Next
    End Sub
#End Region

#Region "POSTED ITEM LIST ACCOMPLISHED FORM LISTVIEW LOAD"
    Shared Sub trip_ticket_accomplihed_form_posted_data_load()
        Try
            sql = ""
            sql = "SELECT ROW_NUMBER() over ( PARTITION BY trip_date ORDER BY CONVERT(VARCHAR(12), hdr_create_date, 107) DESC) as #," _
                     & "hdr_id,REPLICATE('0', 6 - LEN(trip_ticket_no)) + CAST(trip_ticket_no AS varchar) AS trip_ticket_no," _
                       & "CONVERT(VARCHAR(12), trip_date, 107) as trip_date,location, equip_type, equip_no, imple_code," _
                        & "driver, purpose, requested_by, approved_by, accomplished_by FROM v_ais_trip_ticket_schedule_form WHERE dtl_stats = 2" _
                         & " AND status = 1 AND posted_date IS NOT NULL AND posted_by IS NOT NULL GROUP BY hdr_create_date,hdr_id,reg_no,trip_ticket_no," _
                           & "trip_date,location, equip_type, equip_no, imple_code, driver, purpose, requested_by, approved_by,accomplished_by"

            Using sqlCnn = New SqlConnection(My.Settings.Conn_string)

                Frm_trip_ticket_NEWS.lv_accomplished_posted_data.Items.Clear()

                sqlCnn.Open()
                sqlCmd = New SqlCommand(sql, sqlCnn)

                Using sqlReader As SqlDataReader = sqlCmd.ExecuteReader()

                    While (sqlReader.Read())
                        Dim list As New ListViewDataItem
                        list.SubItems.Add(sqlReader(1).ToString())
                        list.SubItems.Add(sqlReader(0).ToString())
                        list.SubItems.Add(sqlReader(2).ToString())
                        list.SubItems.Add(sqlReader(3).ToString())
                        list.SubItems.Add(sqlReader(4).ToString())
                        list.SubItems.Add(sqlReader(5).ToString())
                        list.SubItems.Add(sqlReader(6).ToString())
                        list.SubItems.Add(sqlReader(7).ToString())
                        list.SubItems.Add(sqlReader(8).ToString())
                        list.SubItems.Add(sqlReader(9).ToString())
                        list.SubItems.Add(sqlReader(10).ToString())
                        list.SubItems.Add(sqlReader(11).ToString())
                        list.SubItems.Add(sqlReader(12).ToString())

                        Frm_trip_ticket_NEWS.lv_accomplished_posted_data.Items.Add(list)
                    End While
                End Using
                sqlCmd.Connection.Close()
            End Using
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        slct_id = Nothing
    End Sub
#End Region

#Region "SELECTED ITEM LISTVIEW"
    Shared Sub Global_schedule_processed_data_selected()
        If Frm_trip_ticket_NEWS.lv_accomplished_posted_data.SelectedItems.Count > 0 Then
            With Frm_trip_ticket_NEWS.lv_accomplished_posted_data.SelectedItems(0)
                slct_id_req_hdr = .SubItems(0)
            End With
        End If
    End Sub
#End Region
End Class
