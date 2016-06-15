Imports System.Data.SqlClient
Imports Telerik.WinControls.UI
Imports Telerik.WinControls
Imports Telerik.Data
Imports Telerik.WinControls.Data
Imports System.ComponentModel
Public Class request_form_view

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

        'If (e.CellElement).Data.Name = "grand_amount" Then
        '    If (TypeOf e.CellElement Is DetailListViewHeaderCellElement) Then
        '        e.CellElement.TextAlignment = ContentAlignment.MiddleRight
        '        e.CellElement.BackColor = Color.Red
        '    Else
        '        e.CellElement.ResetValue(LightVisualElement.BackColorProperty)
        '    End If

        '    If (TypeOf e.CellElement Is DetailListViewDataCellElement) Then
        '        e.CellElement.TextAlignment = ContentAlignment.MiddleRight
        '    End If
        'End If

        If (TypeOf e.Cellelement Is DetailListViewCellElement) Then
            e.CellElement.DrawFill = False
            e.CellElement.DrawBorder = False
        Else
            e.CellElement.ResetValue(LightVisualElement.DrawBorderProperty, Telerik.WinControls.ValueResetFlags.Local)
            e.CellElement.ResetValue(LightVisualElement.DrawFillProperty, Telerik.WinControls.ValueResetFlags.Local)
        End If

    End Sub
#End Region

#Region "TRIP TICKET REQUEST FORM CREATE"
#Region "LOAD DROP DOWN"
    Shared Sub dp_location_load()
        Try
            Frm_request_form_add.dp_location.Items.Clear()
            sql = ""
            sql = "SELECT DISTINCT location FROM v_location_maindata ORDER BY location ASC"

            Using sqlCnn = New SqlConnection(My.Settings.Conn_string)
                sqlCnn.Open()
                Using sqlCmd = New SqlCommand(sql, sqlCnn)
                    Dim sqlReader As SqlDataReader = sqlCmd.ExecuteReader()
                    While (sqlReader.Read())
                        Dim desc = sqlReader.Item("location")
                        Frm_request_form_add.dp_location.Items.Add(desc)
                        'Frm_master_list_location_info.dp_locationinfo_desc.Items.Add(desc)
                    End While
                End Using
                sqlCnn.Close()
            End Using
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Shared Sub dp_lot_code_load(loc)
        Try
            Frm_request_form_add.dp_location_lot.Items.Clear()
            sql = ""
            sql = "SELECT DISTINCT code,location FROM v_location_maindata  WHERE location='" & loc & "' GROUP BY location,code ORDER BY code ASC"

            Using sqlCnn = New SqlConnection(My.Settings.Conn_string)
                sqlCnn.Open()
                Using sqlCmd = New SqlCommand(sql, sqlCnn)
                    Dim sqlReader As SqlDataReader = sqlCmd.ExecuteReader()
                    While (sqlReader.Read())
                        Dim desc = sqlReader.Item("code")
                        Frm_request_form_add.dp_location_lot.Items.Add(desc)
                        'Frm_master_list_location_info.dp_locationinfo_desc.Items.Add(desc)
                    End While
                End Using
                sqlCnn.Close()
            End Using
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Shared Sub dp_operation_load()
        Try
            Frm_request_form_add.dp_workoperations.Items.Clear()
            sql = ""
            sql = "SELECT DISTINCT operation FROM tbl_work_operations ORDER BY operation ASC"

            Using sqlCnn = New SqlConnection(My.Settings.Conn_string)
                sqlCnn.Open()
                Using sqlCmd = New SqlCommand(sql, sqlCnn)
                    Dim sqlReader As SqlDataReader = sqlCmd.ExecuteReader()
                    While (sqlReader.Read())
                        Dim desc = sqlReader.Item("operation")
                        Frm_request_form_add.dp_workoperations.Items.Add(desc)
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

#Region "DROP DOWN SELECT ITEM"
    Shared Sub request_slct_dp_lot(code)
        Try
            sql = ""
            sql = "SELECT id,owner_name FROM tbl_location WHERE code='" & code & "'"
            Using sqlCnn = New SqlConnection(My.Settings.Conn_string)
                sqlCnn.Open()
                Using sqlCmd = New SqlCommand(sql, sqlCnn)
                    Dim sqlReader As SqlDataReader = sqlCmd.ExecuteReader

                    sqlReader.Read()
                    dp_lot_id = sqlReader.Item("id")
                    Frm_request_form_add.txt_planter.Text = sqlReader.Item("owner_name").ToString
                End Using
            End Using
        Catch ex As Exception
            If ex.Message.ToString = "Invalid attempt to read when no data is present." Then
                Exit Sub
            Else
                MsgBox(ex.Message)
            End If
        End Try
    End Sub

    Shared Sub request_slct_dp_work_operation(desc)
        Try
            sql = ""
            sql = "SELECT id FROM tbl_work_operations WHERE operation='" & desc & "'"
            Using sqlCnn = New SqlConnection(My.Settings.Conn_string)
                sqlCnn.Open()
                Using sqlCmd = New SqlCommand(sql, sqlCnn)
                    Dim sqlReader As SqlDataReader = sqlCmd.ExecuteReader
                    sqlReader.Read()
                    req_cat_id = sqlReader.Item("id")
                End Using
            End Using
        Catch ex As Exception
            If ex.Message.ToString = "Invalid attempt to read when no data is present." Then
                Exit Sub
            Else
                MsgBox(ex.Message)
            End If
        End Try
    End Sub
#End Region

#Region "HIDDEN VALUE SELECT"
    Shared Sub request_order_idcode()
        Try
            sql = ""
            sql = " Select DatePart(YEAR,getdate()) as Year,RIGHT('00' + CAST(DATEPART(MONTH,getdate()) AS VARCHAR(2)) ,2)as Month," _
                     & " RIGHT('00' + CAST(DATEPART(DAY,getdate()) AS VARCHAR(2)) ,2)as Day,RIGHT('00' + CAST(DATEPART(HOUR,getdate()) AS VARCHAR(2)) ,2)as Hour," _
                     & " RIGHT('00' + CAST(DATEPART(MINUTE,getdate()) AS VARCHAR(2)) ,2)as Minutes,RIGHT('00' + CAST(DATEPART(SECOND,getdate()) AS VARCHAR(2)) ,2)as Seconds," _
                    & " RIGHT('00' + CAST(DATEPART(DAY,getdate()) AS VARCHAR(2)) ,2)as Milliseconds"

            Using sqlCnn = New SqlConnection(My.Settings.Conn_string)
                sqlCnn.Open()
                Using sqlCmd = New SqlCommand(sql, sqlCnn)
                    Dim sqlReader As SqlDataReader = sqlCmd.ExecuteReader
                    sqlReader.Read()
                    order_no = sqlReader.Item("Year") & sqlReader.Item("Month") & sqlReader.Item("Day") & sqlReader.Item("Hour") & sqlReader.Item("Minutes") & sqlReader.Item("Seconds") & sqlReader.Item("Milliseconds")
                End Using
            End Using
        Catch ex As Exception
            If ex.Message.ToString = "Invalid attempt to read when no data is present." Then
                Exit Sub
            Else
                MsgBox(ex.Message)
            End If
        End Try
    End Sub

    Shared Sub request_req_no()
        Try
            sql = ""
            sql = " Select DatePart(YEAR,getdate()) as Year,RIGHT('00' + CAST(DATEPART(MONTH,getdate()) AS VARCHAR(2)) ,2)as Month," _
                     & " RIGHT('00' + CAST(DATEPART(DAY,getdate()) AS VARCHAR(2)) ,2)as Day,RIGHT('00' + CAST(DATEPART(HOUR,getdate()) AS VARCHAR(2)) ,2)as Hour," _
                     & " RIGHT('00' + CAST(DATEPART(MINUTE,getdate()) AS VARCHAR(2)) ,2)as Minutes,RIGHT('00' + CAST(DATEPART(SECOND,getdate()) AS VARCHAR(2)) ,2)as Seconds"

            Using sqlCnn = New SqlConnection(My.Settings.Conn_string)
                sqlCnn.Open()
                Using sqlCmd = New SqlCommand(sql, sqlCnn)
                    Dim sqlReader As SqlDataReader = sqlCmd.ExecuteReader
                    sqlReader.Read()
                    req_number = sqlReader.Item("Year") & sqlReader.Item("Month") & sqlReader.Item("Day") & sqlReader.Item("Hour") & sqlReader.Item("Minutes") & sqlReader.Item("Seconds")
                End Using
            End Using
        Catch ex As Exception
            If ex.Message.ToString = "Invalid attempt to read when no data is present." Then
                Exit Sub
            Else
                MsgBox(ex.Message)
            End If
        End Try
    End Sub
#End Region

#Region "TRIP TICKET REQUEST FORM LISTVIEW"
    Shared Sub requested_form_listview()
        Try
            sql = ""
            If Frm_request_form_add.chk_group.Checked = True Then
                sql = "SELECT  ROW_NUMBER() over (PARTITION BY code ORDER BY date_req DESC,code,operation,Owner_name ASC) as #" _
                    & ",id,dtl_id,CONVERT(VARCHAR(12), date_req, 107) as date_req,time_needed,code,location,owner_name,operation FROM v_trip_ticket_request_form WHERE user_id ='" & user_id & "'" _
                     & "AND req_no IS NULL AND stats = '0' AND date_created BETWEEN CONVERT(VARCHAR(12), GETDATE()) AND  GETDATE()"
            Else
                sql = "SELECT  ROW_NUMBER() over (PARTITION BY location ORDER BY date_req DESC,code,operation,Owner_name ASC) as #" _
                    & ",id,dtl_id,CONVERT(VARCHAR(12), date_req, 107) as date_req,time_needed,code,location,owner_name,operation FROM v_trip_ticket_request_form WHERE user_id ='" & user_id & "'" _
                    & "AND req_no IS NULL AND stats = '0' AND date_created BETWEEN CONVERT(VARCHAR(12), GETDATE()) AND  GETDATE()"
            End If

            Using sqlCnn = New SqlConnection(My.Settings.Conn_string)

                Frm_request_form_add.lv_queued.Items.Clear()
                sqlCnn.Open()
                sqlCmd = New SqlCommand(sql, sqlCnn)
                Using sqlReader As SqlDataReader = sqlCmd.ExecuteReader()

                    While (sqlReader.Read())
                        Dim list As New ListViewDataItem
                        list.SubItems.Add(sqlReader(2).ToString())
                        list.SubItems.Add(sqlReader(1).ToString())
                        list.SubItems.Add(sqlReader(0).ToString())
                        list.SubItems.Add(sqlReader(3).ToString())
                        list.SubItems.Add(sqlReader(4).ToString())
                        list.SubItems.Add(sqlReader(5).ToString())
                        list.SubItems.Add(sqlReader(6).ToString())
                        list.SubItems.Add(sqlReader(7).ToString())
                        list.SubItems.Add(sqlReader(8).ToString())

                        Frm_request_form_add.lv_queued.Items.Add(list)
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
    'SELECTED ITEM LISTVIEW
#Region "SELECTED ITEM LISTVIEW"
    Shared Sub Global_loc_masterlist_selected()
        If Frm_request_form_add.lv_queued.SelectedItems.Count > 0 Then
            With Frm_request_form_add.lv_queued.SelectedItems(0)
                slct_id_req_hdr = .SubItems(1)
                slct_id_req_dtl = .SubItems(0)
            End With
        End If
    End Sub
#End Region

#End Region

#Region "TRIP TICKET REQUEST FORM LIST"

#Region "SELECTED ITEM LISTVIEW"
    Shared Sub Global_trip_ticket_request_selected()
        If Frm_trip_ticket_NEWS.lv_request_tt.SelectedItems.Count > 0 Then
            With Frm_trip_ticket_NEWS.lv_request_tt.SelectedItems(0)
                slct_id_req_hdr = .SubItems(0)
                'slct_id_req_dtl = .SubItems(1)
            End With
        End If
    End Sub
#End Region

#Region "REQUEST FORM LISTVIEW LOAD"
    Shared Sub trip_ticket_listview_load()
        Try
            sql = ""
            sql = "SELECT  ROW_NUMBER() over (PARTITION BY req_no ORDER BY CONVERT(VARCHAR(12), date_req, 107) DESC,code,operation,Owner_name ASC) as #" _
                    & ",id,dtl_id,lot_id,req_no,CONVERT(VARCHAR(12), date_created, 107) as date_created,CONVERT(VARCHAR(12), date_req, 107)" _
                    & " as date_req,time_needed,location,code,operation,purpose,(user_lname + ', ' + user_fname + ' ' + user_mname) as fulname FROM v_trip_ticket_request_form" _
                     & " WHERE req_no IS NOT NULL AND stats = '0' AND dtl_status ='0' ORDER BY date_req DESC"

            Using sqlCnn = New SqlConnection(My.Settings.Conn_string)

                Frm_trip_ticket_NEWS.lv_request_tt.Items.Clear()

                sqlCnn.Open()
                sqlCmd = New SqlCommand(sql, sqlCnn)

                Using sqlReader As SqlDataReader = sqlCmd.ExecuteReader()

                    While (sqlReader.Read())
                        Dim list As New ListViewDataItem
                        list.SubItems.Add(sqlReader(1).ToString())
                        list.SubItems.Add(sqlReader(2).ToString())
                        list.SubItems.Add(sqlReader(3).ToString())
                        list.SubItems.Add(sqlReader(0).ToString())
                        list.SubItems.Add(sqlReader(4).ToString())
                        list.SubItems.Add(sqlReader(5).ToString())
                        list.SubItems.Add(sqlReader(6).ToString())
                        list.SubItems.Add(sqlReader(7).ToString())
                        list.SubItems.Add(sqlReader(8).ToString())
                        list.SubItems.Add(sqlReader(9).ToString())
                        list.SubItems.Add(sqlReader(10).ToString())
                        list.SubItems.Add(sqlReader(11).ToString())
                        list.SubItems.Add(sqlReader(12).ToString())

                        Frm_trip_ticket_NEWS.lv_request_tt.Items.Add(list)
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

#End Region

#Region "TRIP TICKET REQUEST FORM APPROVAL"

#Region "LOAD DROP DOWN"
    Shared Sub dp_driver_load()
        Try
            Frm_request_form_add.dp_location.Items.Clear()
            sql = ""
            sql = "SELECT DISTINCT(driver_name) FROM tbl_equipment_driver WHERE status ='0' ORDER BY driver_name ASC"

            Using sqlCnn = New SqlConnection(My.Settings.Conn_string)
                sqlCnn.Open()
                Using sqlCmd = New SqlCommand(sql, sqlCnn)
                    Dim sqlReader As SqlDataReader = sqlCmd.ExecuteReader()
                    While (sqlReader.Read())
                        Dim desc = sqlReader.Item("driver_name")
                        Frm_request_form_approve.dp_driver.Items.Add(desc)
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

#Region "LOAD LISTVIEW EQUIPMENT"
    Shared Sub equipment_listview()
        Try
            sql = ""
            sql = "SELECT ROW_NUMBER() over (PARTITION BY owner_name ORDER BY owner_name,equipment_type) as #,id,owner_name,equipment_type,model,status FROM v_equipment_masterlist"


            Using sqlCnn = New SqlConnection(My.Settings.Conn_string)

                Frm_request_form_approve.lv_equipments.Items.Clear()
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

                        Dim e_q = sqlReader(5).ToString()

                        If e_q = True Then
                            list.SubItems.Add("NOT AVAILABLE")
                        Else
                            list.SubItems.Add("AVAILABLE")
                        End If
                        'list.SubItems.Add(sqlReader(5).ToString())

                        Frm_request_form_approve.lv_equipments.Items.Add(list)
                    End While
                End Using
                sqlCmd.Connection.Close()
            End Using
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        slct_id = Nothing
    End Sub


    Shared Sub implement_listview()
        Try
            sql = ""
            sql = "SELECT ROW_NUMBER() over (PARTITION BY owner_name ORDER BY owner_name,imple_desc ASC) as #,id,owner_name,code,imple_desc,status FROM v_implement_masterlist ORDER BY imple_desc ASC"


            Using sqlCnn = New SqlConnection(My.Settings.Conn_string)

                Frm_request_form_approve.lv_implements.Items.Clear()
                sqlCnn.Open()
                sqlCmd = New SqlCommand(sql, sqlCnn)
                Using sqlReader As SqlDataReader = sqlCmd.ExecuteReader()

                    While (sqlReader.Read())
                        Dim list As New ListViewDataItem
                        list.SubItems.Add(sqlReader(1).ToString())
                        list.SubItems.Add(sqlReader(0).ToString())
                        list.SubItems.Add(sqlReader(2).ToString())
                        list.SubItems.Add(sqlReader(4).ToString())
                        list.SubItems.Add(sqlReader(3).ToString())

                        Dim i_m = sqlReader(5).ToString()
                        If i_m = True Then
                            list.SubItems.Add("NOT AVAILABLE")
                        Else
                            list.SubItems.Add("AVAILABLE")
                        End If
                        'list.SubItems.Add(sqlReader(5).ToString())

                        Frm_request_form_approve.lv_implements.Items.Add(list)
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
    Shared Sub equipment_slct_listview()
        If Frm_request_form_approve.lv_equipments.SelectedItems.Count > 0 Then
            With Frm_request_form_approve.lv_equipments.SelectedItems(0)
                Frm_request_form_approve.txt_equipment_type.Text = .SubItems(3)
                Frm_request_form_approve.txt_equipment_no.Text = .SubItems(4)
                equip_stats = .SubItems(5)
            End With
        End If
    End Sub

    Shared Sub approval_equip_id()
        If Frm_request_form_approve.lv_equipments.SelectedItems.Count > 0 Then
            With Frm_request_form_approve.lv_equipments.SelectedItems(0)
                approval_equip_ids = .SubItems(0)
            End With
        End If
    End Sub

    Shared Sub implement_slct_listview()
        If Frm_request_form_approve.lv_implements.SelectedItems.Count > 0 Then
            With Frm_request_form_approve.lv_implements.SelectedItems(0)
                Frm_request_form_approve.txt_implement_type.Text = .SubItems(3)
                Frm_request_form_approve.txt_imple_no.Text = .SubItems(4)
                imple_stats = .SubItems(5)
            End With
        End If
    End Sub

    Shared Sub approval_imple_id()
        If Frm_request_form_approve.lv_implements.SelectedItems.Count > 0 Then
            With Frm_request_form_approve.lv_implements.SelectedItems(0)
                approval_imple_ids = .SubItems(0)
            End With
        End If
    End Sub
    ''' <summary>
    ''' RETRIEVING INFO. FOR REVIEWing APPROVAL
    ''' </summary>
    ''' <remarks></remarks>
    Shared Sub for_approval_info()
        If Frm_trip_ticket_NEWS.lv_request_tt.SelectedItems.Count > 0 Then
            With Frm_trip_ticket_NEWS.lv_request_tt.SelectedItems(0)
                hdr_id_approval = .SubItems(0)
                dtl_id_approval = .SubItems(1)
                lot_id_approval = .SubItems(2)
                Frm_request_form_approve.txt_reqno.Text = .SubItems(4)
                Frm_request_form_approve.dt_ST_date.Value = .SubItems(5)
                Frm_request_form_approve.txt_ST_purpose.Text = .SubItems(11)
                Frm_request_form_approve.txt_distenation.Text = .SubItems(8)
                Frm_request_form_approve.dt_ST_neededdate.Value = .SubItems(6)
                Frm_request_form_approve.tp_ST_neededtime.Value = .SubItems(7).ToString
                Frm_request_form_approve.txt_ST_requestedby.Text = .SubItems(12)
                Frm_request_form_approve.txt_lotno.Text = .SubItems(9)
                Frm_request_form_approve.txt_workoperation.Text = .SubItems(10)
                'imple_stats = .SubItems(5)
            End With
        End If
    End Sub
#End Region

#Region "DROP DOWN SELECT ITEM"
    Shared Sub driver()
        Try
            sql = ""
            sql = "SELECT id FROM tbl_equipment_driver WHERE driver_name='" + Trim(Frm_request_form_approve.dp_driver.Text) + "'"
            Using sqlCnn = New SqlConnection(My.Settings.Conn_string)
                sqlCnn.Open()
                Using sqlCmd = New SqlCommand(sql, sqlCnn)
                    Dim sqlReader As SqlDataReader = sqlCmd.ExecuteReader

                    sqlReader.Read()
                    driver_id = sqlReader.Item("id")
                End Using
            End Using
        Catch ex As Exception
            If ex.Message.ToString = "Invalid attempt to read when no data is present." Then
                Exit Sub
            Else
                MsgBox(ex.Message)
            End If
        End Try
    End Sub
#End Region

#Region "VALIDITY FOR DUPLICATE HEADER"
    Shared Sub driver_validity()
        Try
            sql = ""
            sql = "SELECT COUNT(id) FROM tbl_trip_ticket_schedule_hdr WHERE reg_no='" + Trim(Frm_request_form_approve.txt_reqno.Text) + "'"
            Using sqlCnn = New SqlConnection(My.Settings.Conn_string)
                sqlCnn.Open()
                Using sqlCmd = New SqlCommand(sql, sqlCnn)
                    Dim sqlReader As SqlDataReader = sqlCmd.ExecuteReader

                    sqlReader.Read()
                    driver_validitys = sqlReader.Item(0)
                End Using
            End Using
        Catch ex As Exception
            If ex.Message.ToString = "Invalid attempt to read when no data is present." Then
                Exit Sub
            Else
                MsgBox(ex.Message)
            End If
        End Try
    End Sub
#End Region
#End Region

#Region "TRIP TICKET REQUEST FORM APPROVED ITEM LIST"

#Region "APROVED ITEM LIST REQUEST FORM LISTVIEW LOAD"
    Shared Sub trip_ticket_request_form_approved_data_load()
        Try
            sql = ""
            sql = "SELECT ROW_NUMBER() over ( PARTITION BY trip_date ORDER BY CONVERT(VARCHAR(12), hdr_create_date, 107) DESC) as #," _
                     & "hdr_id,REPLICATE('0', 6 - LEN(reg_no)) + CAST(reg_no AS varchar) AS reg_no," _
                      & "REPLICATE('0', 6 - LEN(trip_ticket_no)) + CAST(trip_ticket_no AS varchar) AS trip_ticket_no," _
                       & "CONVERT(VARCHAR(12), trip_date, 107) as trip_date,location, equip_type, equip_no, imple_code," _
                        & "driver, purpose, requested_by, approved_by FROM v_trip_ticket_schedule_form " _
                         & " GROUP BY hdr_create_date,hdr_id,reg_no,trip_ticket_no,trip_date,location, equip_type, equip_no, imple_code," _
                          & "driver, purpose, requested_by, approved_by"

            'WHERE dtl_stats <> 2

            Using sqlCnn = New SqlConnection(My.Settings.Conn_string)

                Frm_trip_ticket_NEWS.lv_approved_request_item.Items.Clear()

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

                        Frm_trip_ticket_NEWS.lv_approved_request_item.Items.Add(list)
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
    Shared Sub Global_approve_request_data_selected()
        If Frm_trip_ticket_NEWS.lv_approved_request_item.SelectedItems.Count > 0 Then
            With Frm_trip_ticket_NEWS.lv_approved_request_item.SelectedItems(0)
                slct_id_req_hdr = .SubItems(0)
            End With
        End If
    End Sub
#End Region
#End Region

End Class
