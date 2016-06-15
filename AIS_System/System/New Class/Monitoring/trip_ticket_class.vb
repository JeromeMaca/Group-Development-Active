Imports System.Data.SqlClient
Imports Telerik.WinControls.UI

Public Class trip_ticket_class
#Region "LISTVIEW VISUAL FORMATTING"
    Shared Sub group_expantion(groupt_count As String, listv As RadListView)
        Dim ctr = 0
        Dim insss As Integer = groupt_count
        While (ctr < insss)
            If ctr = 0 Then
                listv.Groups(0).Expanded = True
            Else
                listv.Groups(ctr).Expanded = False
            End If
            ctr += 1
        End While
    End Sub

    Shared Sub group_count(e)
        Dim groupItem As BaseListViewGroupVisualItem = TryCast(e.VisualItem, BaseListViewGroupVisualItem)
        If groupItem IsNot Nothing Then
            groupItem.Text = groupItem.Data.Text + " ( " + DirectCast(groupItem.Data, ListViewDataItemGroup).Items.Count.ToString + " Record Count)"
        End If
    End Sub
#End Region

#Region "LISTVIEW FORMATTING"
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

#Region "SELECTED ITEM LISTVIEW"
    Shared Sub Global_need_date_selected()
        If Frm_trip_ticket_monitoring.lv_trip_ticket_list.SelectedItems.Count > 0 Then
            With Frm_trip_ticket_monitoring.lv_trip_ticket_list.SelectedItems(0)
                If .SubItems(4) = "Today" Then
                    Dim condate = Convert.ToDateTime(Frm_main.txt_actualtime.Text)
                    need_dates = condate.Date
                Else
                    need_dates = .SubItems(4)
                End If
            End With
        End If
    End Sub

    Shared Sub dispalyed_selected_listview_item(lv_name As RadListView)
        If lv_name.Items.Count <> 0 Then
            lv_name.SelectedItem = lv_name.Items(0)
        End If
    End Sub

    Shared Sub Global_processed_selected()
        If Frm_trip_ticket_monitoring.lv_tripticket_processed.SelectedItems.Count > 0 Then
            With Frm_trip_ticket_monitoring.lv_tripticket_processed.SelectedItems(0)
                hdr_id_monitoring = .SubItems(0)
            End With
        End If
    End Sub

    Shared Sub Global_unprocessed_selected()
        If Frm_trip_ticket_monitoring.lv_tripticket_unprocessed.SelectedItems.Count > 0 Then
            With Frm_trip_ticket_monitoring.lv_tripticket_unprocessed.SelectedItems(0)
                hdr_id_monitoring = .SubItems(0)
            End With
        End If
    End Sub
#End Region

#Region "LOAD LISTVIEW"
    Shared Sub issued_trip_ticket_listview()
        Try
            sql = ""
            sql = "SELECT  ROW_NUMBER() over (PARTITION BY CONVERT(VARCHAR(12), need_date, 107),trip_ticket_no ORDER BY CONVERT(VARCHAR(12), need_date, 107) DESC,trip_ticket_no,location  ) as #," _
                    & "REPLICATE('0', 6 - LEN(trip_ticket_no)) + CAST(trip_ticket_no AS varchar) AS trip_ticket_no,location," _
                     & "(SELECT Case status  WHEN 0 THEN 'UNPROCESSED' WHEN 1 THEN 'PROCESSED' End) as Statuses,CONVERT(VARCHAR(12), need_date, 107) as need_date," _
                      & "CONVERT(VARCHAR(12), GETDATE(), 107) as cur_date FROM v_trip_ticket_schedule_form GROUP BY trip_ticket_no,need_date,location,status ORDER BY need_date DESC"

            Using sqlCnn = New SqlConnection(My.Settings.Conn_string)

                Frm_trip_ticket_monitoring.lv_trip_ticket_list.Items.Clear()

                sqlCnn.Open()
                sqlCmd = New SqlCommand(sql, sqlCnn)

                Using sqlReader As SqlDataReader = sqlCmd.ExecuteReader()

                    While (sqlReader.Read())
                        Dim list As New ListViewDataItem
                        list.SubItems.Add(sqlReader(0).ToString())
                        list.SubItems.Add(sqlReader(1).ToString())
                        list.SubItems.Add(sqlReader(2).ToString())
                        list.SubItems.Add(sqlReader(3).ToString())
                        'list.SubItems.Add(sqlReader(4).ToString())

                        If sqlReader(5) = sqlReader(4) Then
                            list.SubItems.Add("Today")
                            'list.SubItems.Add(sqlReader(4).ToString())
                        Else
                            list.SubItems.Add(sqlReader(4).ToString())
                        End If

                        Frm_trip_ticket_monitoring.lv_trip_ticket_list.Items.Add(list)
                    End While
                End Using
                sqlCmd.Connection.Close()
            End Using
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Shared Sub processed_trip_ticket_listview(need_date)
        Try
            sql = ""
            sql = "SELECT  ROW_NUMBER() over (PARTITION BY CONVERT(VARCHAR(12), need_date, 107),trip_ticket_no ORDER BY CONVERT(VARCHAR(12), need_date, 107) DESC,trip_ticket_no  ) as #" _
                    & ",hdr_id, REPLICATE('0', 6 - LEN(trip_ticket_no)) + CAST(trip_ticket_no AS varchar) AS trip_ticket_no,equip_type,imple_code,driver,purpose" _
                     & " FROM v_trip_ticket_schedule_form WHERE status=1 AND need_date='" & need_date & "' GROUP BY need_date,hdr_id,trip_ticket_no,equip_type,imple_code,driver,purpose ORDER BY need_date DESC"

            Using sqlCnn = New SqlConnection(My.Settings.Conn_string)

                Frm_trip_ticket_monitoring.lv_tripticket_processed.Items.Clear()

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

                        Frm_trip_ticket_monitoring.lv_tripticket_processed.Items.Add(list)
                    End While
                End Using
                sqlCmd.Connection.Close()
            End Using
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Shared Sub unprocessed_trip_ticket_listview(need_date)
        Try
            sql = ""
            sql = "SELECT  ROW_NUMBER() over (PARTITION BY CONVERT(VARCHAR(12), need_date, 107),trip_ticket_no ORDER BY CONVERT(VARCHAR(12), need_date, 107) DESC,trip_ticket_no  ) as #" _
                    & ",hdr_id, REPLICATE('0', 6 - LEN(trip_ticket_no)) + CAST(trip_ticket_no AS varchar) AS trip_ticket_no,equip_type,imple_code,driver,purpose" _
                     & " FROM v_trip_ticket_schedule_form WHERE status=0 AND need_date='" & need_date & "' GROUP BY need_date,hdr_id,trip_ticket_no,equip_type,imple_code,driver,purpose ORDER BY need_date DESC"

            Using sqlCnn = New SqlConnection(My.Settings.Conn_string)

                Frm_trip_ticket_monitoring.lv_tripticket_unprocessed.Items.Clear()

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

                        Frm_trip_ticket_monitoring.lv_tripticket_unprocessed.Items.Add(list)
                    End While
                End Using
                sqlCmd.Connection.Close()
            End Using
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Shared Sub information_trip_ticket_listview(hdr_id, info_stats)
        Try
            sql = ""

            Select Case info_stats
                Case 0
                    sql = "SELECT  ROW_NUMBER() over (PARTITION BY CONVERT(VARCHAR(12), need_date, 107)ORDER BY CONVERT(VARCHAR(12), need_date, 107) DESC,trip_ticket_no,location  ) as #" _
                                   & ", lot_no,CONVERT(VARCHAR(12), date_planted, 107) AS date_planted,variety,lot_owner_name,work_operation,CONVERT(VARCHAR(12), trip_date, 107)" _
                                    & " AS trip_date,requested_by,CONVERT(VARCHAR(12), hdr_create_date, 107) AS hdr_create_date,approved_by FROM v_trip_ticket_schedule_form WHERE " _
                                     & "hdr_id='" & hdr_id & "' AND dtl_stats = 2 ORDER BY need_date DESC"

                Case 1
                    sql = "SELECT  ROW_NUMBER() over (PARTITION BY CONVERT(VARCHAR(12), need_date, 107)ORDER BY CONVERT(VARCHAR(12), need_date, 107) DESC,trip_ticket_no,location  ) as #" _
                                 & ", lot_no,CONVERT(VARCHAR(12), date_planted, 107) AS date_planted,variety,lot_owner_name,work_operation,CONVERT(VARCHAR(12), trip_date, 107)" _
                                  & " AS trip_date,requested_by,CONVERT(VARCHAR(12), hdr_create_date, 107) AS hdr_create_date,approved_by FROM v_trip_ticket_schedule_form WHERE " _
                                   & "hdr_id='" & hdr_id & "' AND dtl_stats <> 2 ORDER BY need_date DESC"
            End Select



            Using sqlCnn = New SqlConnection(My.Settings.Conn_string)

                Frm_trip_ticket_monitoring.lv_tripticket_information.Items.Clear()

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
                        list.SubItems.Add(sqlReader(9).ToString())
                        'list.SubItems.Add(sqlReader(10).ToString())

                        Frm_trip_ticket_monitoring.lv_tripticket_information.Items.Add(list)
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
