Imports System.Data.SqlClient
Imports Telerik.WinControls.UI
Imports Telerik.WinControls
Imports Telerik.Data
Imports Telerik.WinControls.Data
Imports System.ComponentModel

Public Class status_only

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

        If (e.CellElement).Data.Name = "grand_amount" Then
            If (TypeOf e.CellElement Is DetailListViewHeaderCellElement) Then
                e.CellElement.TextAlignment = ContentAlignment.MiddleRight
            End If

            If (TypeOf e.CellElement Is DetailListViewDataCellElement) Then
                e.CellElement.TextAlignment = ContentAlignment.MiddleRight
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

#Region "LOADING LISTVIEW DATA"
    Shared Sub approved_data_listview(hdr_id)
        Try
            sql = ""
            sql = "SELECT ROW_NUMBER() over ( PARTITION BY trip_date ORDER BY CONVERT(VARCHAR(12), hdr_create_date, 107) DESC) as #,hdr_id," _
                  & "lot_no, lot_owner_name, ownership, association_desc, CONVERT(VARCHAR(12), date_planted, 107) as date_planted, variety, current_area, soill_type, fiscal_year" _
                   & " FROM v_ais_trip_ticket_schedule_form WHERE hdr_id ='" & hdr_id & "'"

            Using sqlCnn = New SqlConnection(My.Settings.Conn_string)

                Frm_form_status.lv_approved_request.Items.Clear()

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

                        Frm_form_status.lv_approved_request.Items.Add(list)
                    End While
                End Using
                sqlCmd.Connection.Close()
            End Using
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        slct_id = Nothing
    End Sub


    Shared Sub processed_data_listview(hdr_id)
        Try
            sql = ""
            sql = "SELECT ROW_NUMBER() over ( PARTITION BY trip_date ORDER BY CONVERT(VARCHAR(12), hdr_create_date, 107) DESC) as #,hdr_id," _
                  & "lot_no, lot_owner_name, ownership, association_desc, CONVERT(VARCHAR(12), date_planted, 107) as date_planted, variety, current_area, soill_type, fiscal_year" _
                   & " FROM v_ais_trip_ticket_schedule_form WHERE hdr_id ='" & hdr_id & "' AND dtl_stats=2"

            Using sqlCnn = New SqlConnection(My.Settings.Conn_string)

                Frm_form_status.lv_approved_request.Items.Clear()

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

                        Frm_form_status.lv_approved_request.Items.Add(list)
                    End While
                End Using
                sqlCmd.Connection.Close()
            End Using
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        'hdr_id = Nothing
    End Sub

    Shared Sub processed_data_time(hdr_id)
        Try
            sql = ""
            sql = "SELECT CONVERT(varchar(15),CAST(equip_timein AS TIME),100) as equip_timein,CONVERT(varchar(15),CAST(equip_timeout AS TIME),100) as equip_timeout" _
                    & ",CONVERT(varchar(15),CAST(jobsite_arrival_time AS TIME),100) as jobsite_arrival_time,CONVERT(varchar(15),CAST(jobsite_departure_time AS TIME),100) as jobsite_departure_time" _
                     & " FROM v_ais_trip_ticket_schedule_form WHERE hdr_id ='" & hdr_id & "'"

            Using sqlCnn = New SqlConnection(My.Settings.Conn_string)

                Frm_form_status.lv_approved_request.Items.Clear()

                sqlCnn.Open()
                sqlCmd = New SqlCommand(sql, sqlCnn)
                Using sqlReader As SqlDataReader = sqlCmd.ExecuteReader()

                    While (sqlReader.Read())
                        Frm_form_status.txt_equipin.Text = sqlReader(0).ToString
                        Frm_form_status.txt_equipout.Text = sqlReader(1).ToString
                        Frm_form_status.txt_jobsitearrival.Text = sqlReader(2).ToString
                        Frm_form_status.txt_jobsitedeparture.Text = sqlReader(3).ToString
                    End While
                End Using

                sqlCmd.Connection.Close()
            End Using
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        'hdr_id = Nothing
    End Sub

    Shared Sub posted_data_listview(hdr_id)
        Try
            sql = ""
            sql = "SELECT ROW_NUMBER() over ( PARTITION BY trip_date ORDER BY CONVERT(VARCHAR(12), hdr_create_date, 107) DESC) as #,hdr_id," _
                  & "lot_no, lot_owner_name, ownership, association_desc, CONVERT(VARCHAR(12), date_planted, 107) as date_planted, variety, current_area, soill_type, fiscal_year" _
                   & " FROM v_ais_trip_ticket_schedule_form WHERE hdr_id ='" & hdr_id & "'"

            Using sqlCnn = New SqlConnection(My.Settings.Conn_string)

                Frm_form_status.lv_approved_request.Items.Clear()

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

                        Frm_form_status.lv_approved_request.Items.Add(list)
                    End While
                End Using
                sqlCmd.Connection.Close()
            End Using
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        'hdr_id = Nothing
    End Sub

#End Region

End Class
