Imports System.Data.SqlClient
Imports Telerik.WinControls.UI

Public Class lot_history_class

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

        If (e.CellElement).Data.Name = "lot_no" Then
            If (TypeOf e.CellElement Is DetailListViewHeaderCellElement) Then
                e.CellElement.TextAlignment = ContentAlignment.MiddleLeft
            End If

            If (TypeOf e.CellElement Is DetailListViewDataCellElement) Then
                e.CellElement.TextAlignment = ContentAlignment.MiddleLeft
            End If
        End If

        ''''''''''DISABLED CELL COLOR SELECTION
        If (TypeOf e.Cellelement Is DetailListViewCellElement) Then
            e.CellElement.DrawFill = False
            e.CellElement.DrawBorder = False
        Else
            e.CellElement.ResetValue(LightVisualElement.DrawBorderProperty, Telerik.WinControls.ValueResetFlags.Local)
            e.CellElement.ResetValue(LightVisualElement.DrawFillProperty, Telerik.WinControls.ValueResetFlags.Local)
        End If
    End Sub
#End Region

#Region "LOAD DROP DOWN"
    Shared Sub dp_location_load()
        Try
            Frm_lot_by_lot_monitoring.dp_location.Items.Clear()
            sql = ""
            sql = "SELECT DISTINCT location FROM v_trip_ticket_schedule_form WHERE status=1 and dtl_stats=2 ORDER BY location ASC"

            Using sqlCnn = New SqlConnection(My.Settings.Conn_string)
                sqlCnn.Open()
                Using sqlCmd = New SqlCommand(sql, sqlCnn)
                    Dim sqlReader As SqlDataReader = sqlCmd.ExecuteReader()
                    While (sqlReader.Read())
                        Dim desc = sqlReader.Item("location")
                        Frm_lot_by_lot_monitoring.dp_location.Items.Add(desc)
                        'Frm_master_list_location_info.dp_locationinfo_desc.Items.Add(desc)
                    End While
                End Using
                sqlCnn.Close()
            End Using
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Shared Sub dp_cropyear_load()
        Try
            Frm_lot_by_lot_monitoring.dp_cropyear.Items.Clear()
            sql = ""
            sql = "SELECT DISTINCT fiscal_year FROM v_trip_ticket_schedule_form ORDER BY fiscal_year DESC"

            Using sqlCnn = New SqlConnection(My.Settings.Conn_string)
                sqlCnn.Open()
                Using sqlCmd = New SqlCommand(sql, sqlCnn)
                    Dim sqlReader As SqlDataReader = sqlCmd.ExecuteReader()
                    While (sqlReader.Read())
                        Dim desc = sqlReader.Item("fiscal_year")
                        Frm_lot_by_lot_monitoring.dp_cropyear.Items.Add(desc)
                        'Frm_master_list_location_info.dp_locationinfo_desc.Items.Add(desc)
                    End While
                End Using
                sqlCnn.Close()
            End Using
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
#End Region

#Region "SELECTED ITEM LISTVIEW"
    Shared Sub Global_lot_number_selected()
        If Frm_lot_by_lot_monitoring.lv_lotcodelist.SelectedItems.Count > 0 Then
            With Frm_lot_by_lot_monitoring.lv_lotcodelist.SelectedItems(0)
                lotno = .SubItems(1)
            End With
        End If
    End Sub

    Shared Sub Global_activity_dtl_id_selected()
        If Frm_lot_by_lot_monitoring.lv_lotcode_history.SelectedItems.Count > 0 Then
            With Frm_lot_by_lot_monitoring.lv_lotcode_history.SelectedItems(0)
                dtl_id_monitoring = .SubItems(0)
            End With
        End If
    End Sub

    Shared Sub dispalyed_selected_listview_item(lv_name As RadListView)
        If lv_name.Items.Count <> 0 Then
            lv_name.SelectedItem = lv_name.Items(0)
        End If
    End Sub
#End Region

#Region "LISTVIEW LOAD"
    Shared Sub monitoring_lotcode_load_listvoew(location, cropyear)
        Try
            sql = ""
            sql = "SELECT  ROW_NUMBER() over (ORDER BY lot_no) as #,lot_no FROM v_trip_ticket_schedule_form WHERE status=1 and dtl_stats=2 AND location ='" _
                    & "" & location & "' AND fiscal_year='" & cropyear & "' AND posted_by IS NOT NULL GROUP BY lot_no"

            Using sqlCnn = New SqlConnection(My.Settings.Conn_string)

                Frm_lot_by_lot_monitoring.lv_lotcodelist.Items.Clear()

                sqlCnn.Open()
                sqlCmd = New SqlCommand(sql, sqlCnn)

                Using sqlReader As SqlDataReader = sqlCmd.ExecuteReader()

                    While (sqlReader.Read())
                        Dim list As New ListViewDataItem
                        list.SubItems.Add(sqlReader(0).ToString())
                        list.SubItems.Add(sqlReader(1).ToString())

                        Frm_lot_by_lot_monitoring.lv_lotcodelist.Items.Add(list)
                    End While
                End Using
                sqlCmd.Connection.Close()
            End Using
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Shared Sub activity_load_listview(lot_no, cropyear)
        Try
            sql = ""
            sql = "SELECT  ROW_NUMBER() over (PARTITION BY variety,lot_no ORDER BY lot_no ) as #,dtl_id" _
                    & " ,REPLICATE('0', 6 - LEN(trip_ticket_no)) + CAST(trip_ticket_no AS varchar) AS trip_ticket_no" _
                     & ",CONVERT(VARCHAR(12), need_date, 107) as need_date,work_operation,purpose," _
                      & "CONVERT(VARCHAR(12), date_planted, 107) as date_planted,variety,current_area" _
                     & ",rate_per_area,SUBSTRING(convert(varchar, [operate_hours] ,108),1,5) + ' ' + 'Hours' as operate_hours" _
                    & ",area_done,amount FROM v_trip_ticket_schedule_form WHERE status= 1 AND" _
                      & " lot_no='" & lot_no & "' AND fiscal_year='" & fiscal_year & "' AND dtl_stats = 2 AND posted_by IS NOT NULL"

            Using sqlCnn = New SqlConnection(My.Settings.Conn_string)

                Frm_lot_by_lot_monitoring.lv_lotcode_history.Items.Clear()

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

                        Frm_lot_by_lot_monitoring.lv_lotcode_history.Items.Add(list)
                    End While
                End Using
                sqlCmd.Connection.Close()
            End Using
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Shared Sub equipment_load_listview(dtl_id)
        Try
            sql = ""
            sql = "SELECT  ROW_NUMBER() over (PARTITION BY variety,lot_no ORDER BY lot_no ) as #,owner_equip,equip_type,equip_no,driver" _
                    & ",CONVERT(varchar(15),CAST(equip_timein AS TIME),100) as equip_timein" _
                     & ",CONVERT(varchar(15),CAST(equip_timeout AS TIME),100) as equip_timeout" _
                      & ",CONVERT(varchar(15),CAST(jobsite_arrival_time AS TIME),100) as jobsite_arrival_time" _
                       & ",CONVERT(varchar(15),CAST(jobsite_departure_time AS TIME),100) as jobsite_departure_time" _
                        & " FROM v_trip_ticket_schedule_form WHERE dtl_id='" & dtl_id & "'"

            Using sqlCnn = New SqlConnection(My.Settings.Conn_string)

                Frm_lot_by_lot_monitoring.lv_equipment.Items.Clear()

                sqlCnn.Open()
                sqlCmd = New SqlCommand(sql, sqlCnn)

                Using sqlReader As SqlDataReader = sqlCmd.ExecuteReader()

                    While (sqlReader.Read())
                        Dim list As New ListViewDataItem
                        list.SubItems.Add(sqlReader(0).ToString())
                        list.SubItems.Add(sqlReader(1).ToString())
                        list.SubItems.Add(sqlReader(2).ToString())
                        list.SubItems.Add(sqlReader(3).ToString())
                        list.SubItems.Add(sqlReader(4).ToString())
                        list.SubItems.Add(sqlReader(5).ToString())
                        list.SubItems.Add(sqlReader(6).ToString())
                        list.SubItems.Add(sqlReader(7).ToString())
                        list.SubItems.Add(sqlReader(8).ToString())

                        Frm_lot_by_lot_monitoring.lv_equipment.Items.Add(list)
                    End While
                End Using
                sqlCmd.Connection.Close()
            End Using
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Shared Sub implement_load_listview(dtl_id)
        Try
            sql = ""
            sql = "SELECT  ROW_NUMBER() over (PARTITION BY variety,lot_no ORDER BY lot_no ) as #,owner_imple,imple_desc,imple_code FROM v_trip_ticket_schedule_form WHERE dtl_id='" & dtl_id & "'"

            Using sqlCnn = New SqlConnection(My.Settings.Conn_string)

                Frm_lot_by_lot_monitoring.lv_implement.Items.Clear()

                sqlCnn.Open()
                sqlCmd = New SqlCommand(sql, sqlCnn)

                Using sqlReader As SqlDataReader = sqlCmd.ExecuteReader()

                    While (sqlReader.Read())
                        Dim list As New ListViewDataItem
                        list.SubItems.Add(sqlReader(0).ToString())
                        list.SubItems.Add(sqlReader(1).ToString())
                        list.SubItems.Add(sqlReader(2).ToString())
                        list.SubItems.Add(sqlReader(3).ToString())


                        Frm_lot_by_lot_monitoring.lv_implement.Items.Add(list)
                    End While
                End Using
                sqlCmd.Connection.Close()
            End Using
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
#End Region

#Region "SEARCH DATA RECORD"
    Shared Sub monitoring_lotcode_search(location, cropyear, search)
        Try
            sql = ""
            sql = "SELECT  ROW_NUMBER() over (ORDER BY lot_no) as #,lot_no FROM v_trip_ticket_schedule_form WHERE status=1 and dtl_stats=2 AND location ='" _
                    & "" & location & "' AND fiscal_year='" & cropyear & "' AND lot_no LIKE '%" & search & "%' GROUP BY lot_no"


            Using sqlCnn = New SqlConnection(My.Settings.Conn_string)

                Frm_lot_by_lot_monitoring.lv_lotcodelist.Items.Clear()
                sqlCnn.Open()
                sqlCmd = New SqlCommand(sql, sqlCnn)

                Using sqlReader As SqlDataReader = sqlCmd.ExecuteReader()

                    While (sqlReader.Read())
                        Dim list As New ListViewDataItem
                        list.SubItems.Add(sqlReader(0).ToString())
                        list.SubItems.Add(sqlReader(1).ToString())

                        Frm_lot_by_lot_monitoring.lv_lotcodelist.Items.Add(list)
                    End While
                End Using
                sqlCmd.Connection.Close()
            End Using
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
#End Region
End Class
