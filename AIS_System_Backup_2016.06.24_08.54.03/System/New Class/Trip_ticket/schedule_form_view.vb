Imports System.Data.SqlClient
Imports Telerik.WinControls.UI
Imports Telerik.WinControls
Imports Telerik.Data
Imports Telerik.WinControls.Data
Imports System.ComponentModel

Public Class schedule_form_view

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

#Region "CLEAR FIELDS"
    Shared Sub clear_field_text()
        For Each t As Control In Frm_schedule_encoding.gb_detail_menu.Controls
            If TypeOf (t) Is RadTextBox = True Then
                t.Text = ""
            End If
        Next
    End Sub
#End Region

#Region "SCHEDULE FORM LISTVIEW LOAD"
    Shared Sub trip_ticket_listview_load()
        Try
            sql = ""
            sql = "SELECT ROW_NUMBER() over ( PARTITION BY trip_date ORDER BY CONVERT(VARCHAR(12), hdr_create_date, 107) DESC) as #," _
                     & "hdr_id,REPLICATE('0', 6 - LEN(trip_ticket_no)) + CAST(trip_ticket_no AS varchar) AS trip_ticket_no," _
                      & "CONVERT(VARCHAR(12), trip_date, 107) as trip_date,location, equip_type, equip_no, imple_code," _
                       & "driver, purpose, requested_by, approved_by FROM v_ais_trip_ticket_schedule_form WHERE dtl_stats <> 2" _
                       & " GROUP BY hdr_create_date,hdr_id,trip_ticket_no,trip_date,location, equip_type, equip_no, imple_code," _
                        & "driver, purpose, requested_by, approved_by"

            Using sqlCnn = New SqlConnection(My.Settings.Conn_string)

                Frm_trip_ticket_NEWS.lv_trip_ticket_scheduled.Items.Clear()

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
                        'list.SubItems.Add(sqlReader(12).ToString())

                        Frm_trip_ticket_NEWS.lv_trip_ticket_scheduled.Items.Add(list)
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

#Region "SELECTED ITEM LISTVIEW SCHEDULE FORM"
    Shared Sub trip_ticket_scheduled_slct_lv()
        If Frm_trip_ticket_NEWS.lv_trip_ticket_scheduled.SelectedItems.Count > 0 Then
            With Frm_trip_ticket_NEWS.lv_trip_ticket_scheduled.SelectedItems(0)
                slct_id_hdr_schedule = .SubItems(0)
                Frm_schedule_encoding.txt_ticketno.Text = .SubItems(2)
            End With
        End If
    End Sub
#End Region

#Region "SELECTED ITEM LISTVIEW SCHEDULE HEADER"
    Shared Sub trip_ticket_scheduled_header_id()
        Dim id As Integer = 0
        If Frm_schedule_encoding.lv_schedule_header.SelectedItems.Count > 0 Then
            With Frm_schedule_encoding.lv_schedule_header.SelectedItems(0)
                id = .SubItems(0)
                slct_id_dtl_schedule = id
            End With
        End If

        Try
            sql = ""
            sql = "SELECT location,lot_no,ownership,current_area,work_operation,lot_owner_name,association_desc,fiscal_year FROM v_ais_trip_ticket_schedule_form " _
                & " WHERE dtl_id ='" & id & "'"


            Using sqlCnn = New SqlConnection(My.Settings.Conn_string)
                sqlCnn.Open()
                sqlCmd = New SqlCommand(sql, sqlCnn)

                Using sqlReader As SqlDataReader = sqlCmd.ExecuteReader()

                    While (sqlReader.Read())
                        With Frm_schedule_encoding
                            .txt_loc.Text = sqlReader(0).ToString
                            .txt_lotno.Text = sqlReader(1).ToString
                            .txt_ownership.Text = sqlReader(2).ToString
                            .txt_cuurent_area.Text = sqlReader(3).ToString
                            .txt_work_operation.Text = sqlReader(4).ToString
                            .txt_owner_name.Text = sqlReader(5).ToString
                            .txt_association.Text = sqlReader(6).ToString
                            .txt_fiscalyear.Text = sqlReader(7).ToString

                        End With
                    End While
                End Using
                sqlCmd.Connection.Close()
            End Using
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub
#End Region

#Region "SCHEDULE ENCODING LISTVIEW HEADER DATA"
    Shared Sub trip_ticket_schedule_header_data()
        Try
            sql = ""
            sql = "  SELECT ROW_NUMBER() over (ORDER BY lot_no) as #,dtl_id,lot_no,work_operation FROM v_ais_trip_ticket_schedule_form WHERE hdr_id = '" & slct_id_hdr_schedule & "' AND accomplished_by IS NULL AND dtl_stats = '0'"

            Using sqlCnn = New SqlConnection(My.Settings.Conn_string)

                Frm_schedule_encoding.lv_schedule_header.Items.Clear()

                sqlCnn.Open()
                sqlCmd = New SqlCommand(sql, sqlCnn)

                Using sqlReader As SqlDataReader = sqlCmd.ExecuteReader()

                    While (sqlReader.Read())
                        Dim list As New ListViewDataItem
                        list.SubItems.Add(sqlReader(1).ToString())
                        list.SubItems.Add(sqlReader(0).ToString())
                        list.SubItems.Add(sqlReader(2).ToString())
                        list.SubItems.Add(sqlReader(3).ToString())


                        Frm_schedule_encoding.lv_schedule_header.Items.Add(list)
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

#Region "SCHEDULE ENCODING LISTVIEW DETAIL DATA"
    Shared Sub trip_ticket_schedule_detail_data()
        Try
            sql = ""
            sql = "SELECT ROW_NUMBER() over (ORDER BY lot_no) as #,lot_no,location,work_operation,time_started,time_stopped,operate_hours,area_done FROM v_ais_trip_ticket_schedule_form WHERE hdr_id = '" & slct_id_hdr_schedule & "' AND dtl_stats = '1' AND accomplished_by IS NULL"

            Using sqlCnn = New SqlConnection(My.Settings.Conn_string)

                Frm_schedule_encoding.lv_schedule_detail.Items.Clear()

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

                        Frm_schedule_encoding.lv_schedule_detail.Items.Add(list)
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

#Region "TRIP TICKET SCHEDULE FORM PROCESSED ITEM LIST"

#Region "PROCESSED ITEM LIST SCHEDULE FORM LISTVIEW LOAD"
    Shared Sub trip_ticket_schedule_form_processed_data_load()
        Try
            sql = ""
            sql = "SELECT ROW_NUMBER() over ( PARTITION BY trip_date ORDER BY CONVERT(VARCHAR(12), hdr_create_date, 107) DESC) as #," _
                     & "hdr_id,REPLICATE('0', 6 - LEN(trip_ticket_no)) + CAST(trip_ticket_no AS varchar) AS trip_ticket_no," _
                       & "CONVERT(VARCHAR(12), trip_date, 107) as trip_date,location, equip_type, equip_no, imple_code," _
                        & "driver, purpose, requested_by, approved_by, accomplished_by FROM v_ais_trip_ticket_schedule_form WHERE dtl_stats = 2" _
                         & " GROUP BY hdr_create_date,hdr_id,reg_no,trip_ticket_no,trip_date,location, equip_type, equip_no, imple_code," _
                          & "driver, purpose, requested_by, approved_by,accomplished_by"

            Using sqlCnn = New SqlConnection(My.Settings.Conn_string)

                Frm_trip_ticket_NEWS.lv_trip_ticket_schedule_processed_data.Items.Clear()

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

                        Frm_trip_ticket_NEWS.lv_trip_ticket_schedule_processed_data.Items.Add(list)
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
        If Frm_trip_ticket_NEWS.lv_trip_ticket_schedule_processed_data.SelectedItems.Count > 0 Then
            With Frm_trip_ticket_NEWS.lv_trip_ticket_schedule_processed_data.SelectedItems(0)
                slct_id_req_hdr = .SubItems(0)
            End With
        End If
    End Sub
#End Region
#End Region

End Class
