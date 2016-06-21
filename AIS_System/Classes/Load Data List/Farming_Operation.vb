Imports System.Data.SqlClient
Imports Telerik.WinControls.UI
Imports Telerik.WinControls
Imports Telerik.Data
Public Class Farming_Operation
    'SERVER TIME
    Shared Sub Server_time()
        Try
            sql = ""
            sql = "SELECT GETDATE() AS Date"

            Using sqlCnn = New SqlConnection(My.Settings.Conn_string)
                sqlCnn.Open()
                sqlCmd = New SqlCommand(sql, sqlCnn)

                Using sqlReader As SqlDataReader = sqlCmd.ExecuteReader()

                    sqlReader.Read()
                    server_datetime = sqlReader.Item("Date")
                End Using
                sqlCmd.Connection.Close()
            End Using
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    'load Category View
    'Shared Sub NewCategory()
    '    Try
    '        sql = ""
    '        sql = "SELECT  row_number() over (order by cat_desc asc) as #,category_id,cat_desc FROM tbl_ais_ais_operation_category"

    '        Using sqlCnn = New SqlConnection(My.Settings.Conn_string)

    '            Frm_addcategory.lv_addcategory.Items.Clear()
    '            sqlCnn.Open()
    '            sqlCmd = New SqlCommand(sql, sqlCnn)

    '            Using sqlReader As SqlDataReader = sqlCmd.ExecuteReader()

    '                While (sqlReader.Read())
    '                    Dim list As New ListViewItem(sqlReader(1).ToString())
    '                    list.SubItems.Add(sqlReader(0).ToString())
    '                    list.SubItems.Add(sqlReader(2).ToString())

    '                    Frm_addcategory.lv_addcategory.Items.AddRange(New ListViewItem() {list})
    '                End While
    '            End Using
    '            sqlCmd.Connection.Close()
    '        End Using
    '    Catch ex As Exception
    '        MsgBox(ex.Message)
    '    End Try

    'End Sub

    'load Owner Name View
    'Shared Sub NewOwnerName()
    '    Try
    '        sql = ""
    '        sql = "SELECT row_number() over (order by owner_name asc) as #,owner_name_id,owner_name FROM tbl_ais_equipment_ownername ORDER BY owner_name"

    '        Using sqlCnn = New SqlConnection(My.Settings.Conn_string)

    '            Frm_addownername.lv_ownername.Items.Clear()
    '            sqlCnn.Open()
    '            sqlCmd = New SqlCommand(sql, sqlCnn)

    '            Using sqlReader As SqlDataReader = sqlCmd.ExecuteReader
    '                While (sqlReader.Read())
    '                    Dim list As New ListViewItem(sqlReader(1).ToString())
    '                    With list
    '                        .SubItems.Add(sqlReader(0).ToString())
    '                        .SubItems.Add(sqlReader(2).ToString())
    '                    End With

    '                    Frm_addownername.lv_ownername.Items.AddRange(New ListViewItem() {list})
    '                End While
    '            End Using
    '        End Using
    '    Catch ex As Exception

    '    End Try

    'End Sub

    'Load Category Dropdown
    Shared Sub main_loadcategoryCB()
        Try
            frm_master_list_operation.dropd_category.Items.Clear()
            sql = ""
            sql = "SELECT cat_desc FROM tbl_ais_operation_category ORDER BY cat_desc ASC"

            Using sqlCnn = New SqlConnection(My.Settings.Conn_string)
                sqlCnn.Open()
                Using sqlCmd = New SqlCommand(sql, sqlCnn)
                    Dim sqlReader As SqlDataReader = sqlCmd.ExecuteReader()
                    While (sqlReader.Read())
                        Dim desc = sqlReader.Item("cat_desc")
                        frm_master_list_operation.dropd_category.Items.Add(desc)

                    End While
                End Using
                sqlCnn.Close()
            End Using
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    'Load Owner Name COMBO Equipment
    Shared Sub mainequipment_loadnames()
        Try
            Frm_equipment.cb_ownername.Items.Clear()
            sql = ""

            If equipment_ownerid = 1 Then
                sql = "SELECT owner_name FROM tbl_ais_equipment_ownername WHERE owner_name_id= '1' ORDER BY owner_name ASC"
            ElseIf equipment_ownerid = 2 Then
                sql = "SELECT owner_name FROM tbl_ais_equipment_ownername WHERE owner_name_id= '2' ORDER BY owner_name ASC"
            ElseIf equipment_ownerid = 3 Then
                sql = "SELECT owner_name FROM tbl_ais_equipment_ownername WHERE owner_name_id NOT IN(1,2) ORDER BY owner_name ASC"
            End If


            Using sqlCnn = New SqlConnection(My.Settings.Conn_string)
                sqlCnn.Open()
                Using sqlCmd = New SqlCommand(sql, sqlCnn)
                    Dim sqlReader As SqlDataReader = sqlCmd.ExecuteReader()
                    While (sqlReader.Read())
                        Dim desc = sqlReader.Item("owner_name")
                        Frm_equipment.cb_ownername.Items.Add(desc)
                    End While
                End Using
                sqlCnn.Close()
            End Using
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    'Load Owner Name COMBO Implement
    Shared Sub mainimplement_loadnames()
        Try
            Frm_implement.cb_imp_ownername.Items.Clear()
            sql = ""

            If imple_id = 1 Then
                sql = "SELECT owner_name FROM tbl_ais_equipment_ownername WHERE owner_name_id= '1' ORDER BY owner_name ASC"
            ElseIf imple_id = 2 Then
                sql = "SELECT owner_name FROM tbl_ais_equipment_ownername WHERE owner_name_id= '2' ORDER BY owner_name ASC"
            ElseIf imple_id = 3 Then
                sql = "SELECT owner_name FROM tbl_ais_equipment_ownername WHERE owner_name_id NOT IN(1,2) ORDER BY owner_name ASC"
            End If


            Using sqlCnn = New SqlConnection(My.Settings.Conn_string)
                sqlCnn.Open()
                Using sqlCmd = New SqlCommand(sql, sqlCnn)
                    Dim sqlReader As SqlDataReader = sqlCmd.ExecuteReader()
                    While (sqlReader.Read())
                        Dim desc = sqlReader.Item("owner_name")
                        Frm_implement.cb_imp_ownername.Items.Add(desc)
                    End While
                End Using
                sqlCnn.Close()
            End Using
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    'SELECT CATEGORY OPERATION VALUE
    Shared Sub main_select_category()
        Try
            sql = ""
            sql = "SELECT category_id FROM tbl_ais_operation_category WHERE cat_desc='" + Trim(frm_master_list_operation.dropd_category.Text) + "'"
            Using sqlCnn = New SqlConnection(My.Settings.Conn_string)
                sqlCnn.Open()
                Using sqlCmd = New SqlCommand(sql, sqlCnn)
                    Dim sqlReader As SqlDataReader = sqlCmd.ExecuteReader

                    sqlReader.Read()
                    category_id = sqlReader.Item("category_id")
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

    'SELECT OWNER NAME EQUIPMENT
    Shared Sub main_select_ownername()
        Try
            sql = ""
            sql = "SELECT owner_name_id FROM tbl_ais_equipment_ownername WHERE owner_name='" + Trim(Frm_equipment.cb_ownername.Text) + "'"
            Using sqlCnn = New SqlConnection(My.Settings.Conn_string)
                sqlCnn.Open()
                Using sqlCmd = New SqlCommand(sql, sqlCnn)
                    Dim sqlReader As SqlDataReader = sqlCmd.ExecuteReader

                    sqlReader.Read()
                    ownername_id = sqlReader.Item("owner_name_id")
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


    'SELECT OWNER NAME IMPLEMENT
    Shared Sub main_select_ownername_imple()
        Try
            sql = ""
            sql = "SELECT owner_name_id FROM tbl_ais_equipment_ownername WHERE owner_name='" + Trim(Frm_implement.cb_imp_ownername.Text) + "'"
            Using sqlCnn = New SqlConnection(My.Settings.Conn_string)
                sqlCnn.Open()
                Using sqlCmd = New SqlCommand(sql, sqlCnn)
                    Dim sqlReader As SqlDataReader = sqlCmd.ExecuteReader

                    sqlReader.Read()
                    imple_name_id = sqlReader.Item("owner_name_id")
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


    'LOAD Work Operation VIew
    Shared Sub load_work_operation()
        Try
            sql = ""
            sql = "SELECT  row_number() over (order by cat_desc asc) as #,id,operation_desc, CONVERT(VARCHAR,rate,1) as rate,unit,cat_desc FROM v_ais_work_operation"

            Using sqlCnn = New SqlConnection(My.Settings.Conn_string)

                frm_master_list_operation.lv_operations.Items.Clear()
                sqlCnn.Open()
                sqlCmd = New SqlCommand(sql, sqlCnn)

                Using sqlReader As SqlDataReader = sqlCmd.ExecuteReader()

                    While (sqlReader.Read())
                        Dim list As New ListViewItem(sqlReader(0).ToString())
                        list.SubItems.Add(sqlReader(1).ToString())
                        list.SubItems.Add(sqlReader(2).ToString())
                        list.SubItems.Add(sqlReader(3).ToString())
                        list.SubItems.Add(sqlReader(4).ToString())
                        list.SubItems.Add(sqlReader(5).ToString())

                        frm_master_list_operation.lv_operations.Items.AddRange(New ListViewItem() {list})
                    End While
                End Using
                sqlCmd.Connection.Close()
            End Using
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try


        ' Clear group collection
        frm_master_list_operation.lv_operations.Groups.Clear()

        ' Loop through all existing items to group them properly
        For Each item As ListViewItem In frm_master_list_operation.lv_operations.Items
            frm_master_list_operation.GroupItem(item)
        Next
    End Sub

    'LOAD EQUIPMENT VIEW
    Shared Sub load_equipment_v()
        Try
            sql = ""
            sql = "SELECT ROW_NUMBER() OVER (ORDER BY owner_id ASC) AS #,owner_id,owner_name,equipment_no,equipment_desc,equipment_driver,equipment_fuelcap,owner_name_id FROM v_ais_equipments"

            Using sqlCnn = New SqlConnection(My.Settings.Conn_string)

                Frm_equipment.lv_equipments.Items.Clear()
                sqlCnn.Open()
                sqlCmd = New SqlCommand(sql, sqlCnn)

                Using sqlReader As SqlDataReader = sqlCmd.ExecuteReader
                    While (sqlReader.Read())
                        Dim list As New ListViewItem(sqlReader(1).ToString())
                        With list
                            .SubItems.Add(sqlReader(0).ToString())
                            .SubItems.Add(sqlReader(2).ToString())
                            .SubItems.Add(sqlReader(3).ToString())
                            .SubItems.Add(sqlReader(4).ToString())
                            .SubItems.Add(sqlReader(5).ToString())
                            .SubItems.Add(sqlReader(6).ToString())
                            .SubItems.Add(sqlReader(7).ToString())

                            Frm_equipment.lv_equipments.Items.AddRange(New ListViewItem() {list})
                        End With
                    End While
                End Using
                sqlCmd.Connection.Close()
            End Using
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    'LOAD IMPLEMENTS VIEW
    Shared Sub load_implements_v()
        Try
            sql = ""
            sql = "SELECT ROW_NUMBER() OVER (ORDER BY imp_id ASC) as #,imp_id,imp_name_id,Owner_name,imp_desc FROM v_ais_implements"

            Using sqlCnn = New SqlConnection(My.Settings.Conn_string)

                Frm_implement.lv_implements.Items.Clear()
                sqlCnn.Open()
                sqlCmd = New SqlCommand(sql, sqlCnn)

                Using sqlReader As SqlDataReader = sqlCmd.ExecuteReader
                    While (sqlReader.Read())
                        Dim list As New ListViewItem(sqlReader(1).ToString())
                        With list
                            .SubItems.Add(sqlReader(2).ToString())
                            .SubItems.Add(sqlReader(0).ToString())
                            .SubItems.Add(sqlReader(3).ToString())
                            .SubItems.Add(sqlReader(4).ToString())

                            Frm_implement.lv_implements.Items.AddRange(New ListViewItem() {list})
                        End With
                    End While
                End Using
            End Using

        Catch ex As Exception

        End Try
    End Sub

    'LOAD location LIST
    'Shared Sub load_location_list()
    '    Try
    '        sql = ""
    '        sql = "SELECT ROW_NUMBER() OVER (ORDER BY id ASC) as #,id,location_desc FROM tbl_ais_location_list"

    '        Using sqlCnn = New SqlConnection(My.Settings.Conn_string)

    '            Frm_addlocation.lv_location_list.Items.Clear()
    '            sqlCnn.Open()
    '            sqlCmd = New SqlCommand(sql, sqlCnn)

    '            Using sqlReader As SqlDataReader = sqlCmd.ExecuteReader
    '                While (sqlReader.Read())
    '                    Dim list As New ListViewItem(sqlReader(1).ToString())
    '                    With list
    '                        .SubItems.Add(sqlReader(0).ToString())
    '                        .SubItems.Add(sqlReader(2).ToString())

    '                        Frm_addlocation.lv_location_list.Items.AddRange(New ListViewItem() {list})
    '                    End With
    '                End While
    '            End Using
    '        End Using
    '    Catch ex As Exception

    '    End Try
    'End Sub

    'Load COMBO Location
    Shared Sub load_combo_location()
        Try
            Frm_locations.cb_loc_desc.Items.Clear()
            sql = ""
            sql = "SELECT location_desc FROM tbl_ais_location_list ORDER BY location_desc ASC"

            Using sqlCnn = New SqlConnection(My.Settings.Conn_string)
                sqlCnn.Open()
                Using sqlCmd = New SqlCommand(sql, sqlCnn)
                    Dim sqlReader As SqlDataReader = sqlCmd.ExecuteReader()
                    While (sqlReader.Read())
                        Dim desc = sqlReader.Item("location_desc")
                        Frm_locations.cb_loc_desc.Items.Add(desc)
                    End While
                End Using
                sqlCnn.Close()
            End Using
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    'Combo Select Location List
    Shared Sub Select_Combo_location_list()
        Try
            sql = ""
            sql = "SELECT id FROM tbl_ais_location_list WHERE location_desc='" + Trim(Frm_locations.cb_loc_desc.Text) + "'"
            Using sqlCnn = New SqlConnection(My.Settings.Conn_string)
                sqlCnn.Open()
                Using sqlCmd = New SqlCommand(sql, sqlCnn)
                    Dim sqlReader As SqlDataReader = sqlCmd.ExecuteReader

                    sqlReader.Read()
                    Select_loc_list_id = sqlReader.Item("id")
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

    'Load Location Master List
    Shared Sub Load_locationMasterList()
        Try
            sql = ""
            sql = "SELECT ROW_NUMBER() OVER (ORDER BY id ASC) as #,id,code,location_desc,area,culture FROM v_ais_locations"

            Using sqlCnn = New SqlConnection(My.Settings.Conn_string)

                Frm_locations.lv_location.Items.Clear()
                sqlCnn.Open()
                sqlCmd = New SqlCommand(sql, sqlCnn)

                Using sqlReader As SqlDataReader = sqlCmd.ExecuteReader
                    While (sqlReader.Read())
                        Dim list As New ListViewItem(sqlReader(1).ToString())
                        With list
                            .SubItems.Add(sqlReader(0).ToString())
                            .SubItems.Add(sqlReader(2).ToString())
                            .SubItems.Add(sqlReader(3).ToString())
                            .SubItems.Add(sqlReader(4).ToString())
                            .SubItems.Add(sqlReader(5).ToString())

                            Frm_locations.lv_location.Items.AddRange(New ListViewItem() {list})
                        End With
                    End While
                End Using
            End Using
        Catch ex As Exception

        End Try
    End Sub

    'LOAD Combo Item TRIP TICKET Equipment
    Shared Sub Load_combo_emquipmenttrip_ticket()
        Try
            Frm_triptickets.cb_ST_equipment.Items.Clear()
            sql = ""
            sql = "SELECT equipment_desc,equipment_driver FROM tbl_ais_equipments WHERE owner_name_id='" & e_ownername_id & "' ORDER BY equipment_desc ASC"


            Using sqlCnn = New SqlConnection(My.Settings.Conn_string)
                sqlCnn.Open()
                Using sqlCmd = New SqlCommand(sql, sqlCnn)
                    Dim sqlReader As SqlDataReader = sqlCmd.ExecuteReader()
                    While (sqlReader.Read())
                        Dim desc = sqlReader.Item("equipment_desc")
                        'Dim descs = sqlReader.Item("equipment_driver")
                        Frm_triptickets.cb_ST_equipment.Items.Add(desc)
                        'Frm_triptickets.cb_ST_driver.Items.Add(descs)
                    End While
                End Using
                sqlCnn.Close()
            End Using
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    'LOAD Combo Item TRIP TICKET Implements
    Shared Sub Load_combo_implement_ticket()
        Try
            Frm_triptickets.cb_ST_implement.Items.Clear()
            sql = ""
            sql = "SELECT imp_desc FROM tbl_ais_implements WHERE imp_name_id='" & i_ownername_id & "' ORDER BY imp_desc ASC"


            Using sqlCnn = New SqlConnection(My.Settings.Conn_string)
                sqlCnn.Open()
                Using sqlCmd = New SqlCommand(sql, sqlCnn)
                    Dim sqlReader As SqlDataReader = sqlCmd.ExecuteReader()
                    While (sqlReader.Read())
                        Dim desc = sqlReader.Item("imp_desc")
                        Frm_triptickets.cb_ST_implement.Items.Add(desc)
                    End While
                End Using
                sqlCnn.Close()
            End Using
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    'SELECT COMBO TRIP TICKET Equipment
    Shared Sub Select_Trip_ticket_equipment()
        Try
            sql = ""
            sql = "SELECT owner_id,equipment_no,equipment_driver FROM tbl_ais_equipments WHERE equipment_desc='" + Trim(Frm_triptickets.cb_ST_equipment.Text) + "'"
            Using sqlCnn = New SqlConnection(My.Settings.Conn_string)
                sqlCnn.Open()
                Using sqlCmd = New SqlCommand(sql, sqlCnn)
                    Dim sqlReader As SqlDataReader = sqlCmd.ExecuteReader

                    sqlReader.Read()
                    TT_equip_id = sqlReader.Item("owner_id")
                    Frm_triptickets.txt_ST_equip_no.Text = sqlReader.Item("equipment_no")
                    Frm_triptickets.txt_ST_driver.Text = sqlReader.Item("equipment_driver")
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

    'SELECT COMBO TRIP TICKET Implements
    Shared Sub Select_Trip_ticket_implements()
        Try
            sql = ""
            sql = "SELECT imp_id,imp_desc FROM tbl_ais_implements WHERE imp_desc='" + Trim(Frm_triptickets.cb_ST_implement.Text) + "'"
            Using sqlCnn = New SqlConnection(My.Settings.Conn_string)
                sqlCnn.Open()
                Using sqlCmd = New SqlCommand(sql, sqlCnn)
                    Dim sqlReader As SqlDataReader = sqlCmd.ExecuteReader

                    sqlReader.Read()
                    TT_impl_id = sqlReader.Item("imp_id")
                    Frm_triptickets.txt_ST_imple_no.Text = sqlReader.Item("imp_desc")
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

    'LOAD COmbo Item TRIP TICKET destination
    Shared Sub Load_combo_destination_Trip_tickets()
        Try
            Frm_triptickets.cb_ST_destination.Items.Clear()
            sql = ""
            sql = "SELECT location_desc FROM tbl_ais_location_list ORDER BY location_desc ASC"


            Using sqlCnn = New SqlConnection(My.Settings.Conn_string)
                sqlCnn.Open()
                Using sqlCmd = New SqlCommand(sql, sqlCnn)
                    Dim sqlReader As SqlDataReader = sqlCmd.ExecuteReader()
                    While (sqlReader.Read())
                        Dim desc = sqlReader.Item("location_desc")
                        Frm_triptickets.cb_ST_destination.Items.Add(desc)
                    End While
                End Using
                sqlCnn.Close()
            End Using
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    'Select Combo TRIP TICKET destnation
    Shared Sub Select_trip_ticket_destination()
        Try
            sql = ""
            sql = "SELECT id FROM tbl_ais_location_list WHERE location_desc='" + Trim(Frm_triptickets.cb_ST_destination.Text) + "'"
            Using sqlCnn = New SqlConnection(My.Settings.Conn_string)
                sqlCnn.Open()
                Using sqlCmd = New SqlCommand(sql, sqlCnn)
                    Dim sqlReader As SqlDataReader = sqlCmd.ExecuteReader

                    sqlReader.Read()
                    TT_destination_id = sqlReader.Item("id")
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

    'LOAD Combo Owner Equipment
    Shared Sub Load_combo_equipment_owner()
        Try

            Frm_triptickets.cb_equipment_owner_TT.Items.Clear()

            sql = ""
            sql = "SELECT owner_name FROM tbl_ais_equipment_ownername WHERE owner_name_id IN(1,2)"
            Using sqlCnn = New SqlConnection(My.Settings.Conn_string)
                sqlCnn.Open()
                Using sqlCmd = New SqlCommand(sql, sqlCnn)
                    Dim sqlReader As SqlDataReader = sqlCmd.ExecuteReader

                    While (sqlReader.Read())
                        Dim desc = sqlReader.Item("owner_name")
                        Frm_triptickets.cb_equipment_owner_TT.Items.Add(desc)
                    End While

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

    'LOAD Combo Owner Implement
    Shared Sub Load_combo_implement_owner()
        Try

            Frm_triptickets.cb_implement_owner_TT.Items.Clear()

            sql = ""
            sql = "SELECT owner_name FROM tbl_ais_equipment_ownername WHERE owner_name_id IN(1,2)"
            Using sqlCnn = New SqlConnection(My.Settings.Conn_string)
                sqlCnn.Open()
                Using sqlCmd = New SqlCommand(sql, sqlCnn)
                    Dim sqlReader As SqlDataReader = sqlCmd.ExecuteReader

                    While (sqlReader.Read())
                        Dim desc = sqlReader.Item("owner_name")
                        Frm_triptickets.cb_implement_owner_TT.Items.Add(desc)
                    End While

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

    'LOAD Combo Owner By Sub-Contrator Equipment
    Shared Sub Load_owner_by_SUBCON_equipment()
        Try
            sql = ""
            If Frm_triptickets.chk_subcon_equipment.Checked = True Then
                Frm_triptickets.cb_equipment_owner_TT.Items.Clear()

                sql = "SELECT owner_name FROM tbl_ais_equipment_ownername WHERE owner_name_id NOT IN(1,2)"
                Using sqlCnn = New SqlConnection(My.Settings.Conn_string)
                    sqlCnn.Open()
                    Using sqlCmd = New SqlCommand(sql, sqlCnn)
                        Dim sqlReader As SqlDataReader = sqlCmd.ExecuteReader

                        While (sqlReader.Read())
                            Dim desc = sqlReader.Item("owner_name")
                            Frm_triptickets.cb_equipment_owner_TT.Items.Add(desc)
                        End While

                    End Using
                End Using
            Else
                Farming_Operation.Load_combo_equipment_owner()
            End If


        Catch ex As Exception
            If ex.Message.ToString = "Invalid attempt to read when no data is present." Then
                Exit Sub
            Else
                MsgBox(ex.Message)
            End If
        End Try
    End Sub

    'LOAD Combo Owner By Sub-Contrator Implement
    Shared Sub Load_owner_by_SUBCON_implement()
        Try
            sql = ""
            If Frm_triptickets.chk_subcon_implement.Checked = True Then
                Frm_triptickets.cb_implement_owner_TT.Items.Clear()

                sql = "SELECT owner_name FROM tbl_ais_equipment_ownername WHERE owner_name_id NOT IN(1,2)"
                Using sqlCnn = New SqlConnection(My.Settings.Conn_string)
                    sqlCnn.Open()
                    Using sqlCmd = New SqlCommand(sql, sqlCnn)
                        Dim sqlReader As SqlDataReader = sqlCmd.ExecuteReader

                        While (sqlReader.Read())
                            Dim desc = sqlReader.Item("owner_name")
                            Frm_triptickets.cb_implement_owner_TT.Items.Add(desc)
                        End While

                    End Using
                End Using
            Else
                Farming_Operation.Load_combo_implement_owner()
            End If

        Catch ex As Exception
            If ex.Message.ToString = "Invalid attempt to read when no data is present." Then
                Exit Sub
            Else
                MsgBox(ex.Message)
            End If
        End Try
    End Sub

    'Select Equipment Owner ID Trip Ticket
    Shared Sub Select_equip_owner_id_TT()
        Try
            sql = ""
            sql = "SELECT owner_name_id FROM tbl_ais_equipment_ownername WHERE Owner_name='" + Trim(Frm_triptickets.cb_equipment_owner_TT.Text) + "'"
            Using sqlCnn = New SqlConnection(My.Settings.Conn_string)
                sqlCnn.Open()
                Using sqlCmd = New SqlCommand(sql, sqlCnn)
                    Dim sqlReader As SqlDataReader = sqlCmd.ExecuteReader

                    sqlReader.Read()
                    e_ownername_id = sqlReader.Item("owner_name_id")
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

    'Select Implement Owner ID Trip Ticket
    Shared Sub select_imple_owner_id_TT()
        Try
            sql = ""
            sql = "SELECT owner_name_id FROM tbl_ais_equipment_ownername WHERE Owner_name='" + Trim(Frm_triptickets.cb_implement_owner_TT.Text) + "'"
            Using sqlCnn = New SqlConnection(My.Settings.Conn_string)
                sqlCnn.Open()
                Using sqlCmd = New SqlCommand(sql, sqlCnn)
                    Dim sqlReader As SqlDataReader = sqlCmd.ExecuteReader

                    sqlReader.Read()
                    i_ownername_id = sqlReader.Item("owner_name_id")
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

    'Load TRIP TICKETS SCHEDULE MAIN (Schedule)
    Shared Sub Load_all_Schedule_trip_tickets()
        Try
            sql = ""
            sql = "EXEC p_trip_ticket_schedule_info 1,''"

            Using sqlCnn = New SqlConnection(My.Settings.Conn_string)

                Frm_triptickets.lv_ST_triptickets.Items.Clear()
                sqlCnn.Open()
                sqlCmd = New SqlCommand(sql, sqlCnn)

                Using sqlReader As SqlDataReader = sqlCmd.ExecuteReader
                    While (sqlReader.Read())
                        Dim list As New ListViewItem(sqlReader(1).ToString())
                        With list
                            .SubItems.Add(sqlReader(0).ToString())
                            .SubItems.Add(sqlReader(2).ToString())
                            .SubItems.Add(sqlReader(3).ToString())
                            .SubItems.Add(sqlReader(4).ToString())
                            .SubItems.Add(sqlReader(5).ToString())
                            .SubItems.Add(sqlReader(6).ToString())
                            .SubItems.Add(sqlReader(7).ToString())
                            .SubItems.Add(sqlReader(8).ToString())
                            .SubItems.Add(sqlReader(9).ToString())
                            .SubItems.Add(sqlReader(10).ToString())


                            Frm_triptickets.lv_ST_triptickets.Items.AddRange(New ListViewItem() {list})
                        End With
                    End While
                End Using
            End Using
        Catch ex As Exception

        End Try
    End Sub
End Class
