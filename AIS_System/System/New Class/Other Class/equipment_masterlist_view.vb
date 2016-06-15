Imports System.Data.SqlClient
Imports Telerik.WinControls.UI
Imports Telerik.WinControls
Imports Telerik.Data
Imports Telerik.WinControls.Data
Imports System.ComponentModel
Public Class equipment_masterlist_view

    'DROP DOWN
#Region "LOAD DROP DOWN"
    Shared Sub dp_owner_load()
        Try
            Frm_master_list_equipment.dp_owner.Items.Clear()
            sql = ""
            sql = "SELECT owner_name FROM tbl_owner_name ORDER BY id ASC"

            Using sqlCnn = New SqlConnection(My.Settings.Conn_string)
                sqlCnn.Open()
                Using sqlCmd = New SqlCommand(sql, sqlCnn)
                    Dim sqlReader As SqlDataReader = sqlCmd.ExecuteReader()
                    While (sqlReader.Read())
                        Dim desc = sqlReader.Item("owner_name")
                        Frm_master_list_equipment.dp_owner.Items.Add(desc)
                        'Frm_master_list_location_info.dp_locationinfo_desc.Items.Add(desc)
                    End While
                End Using
                sqlCnn.Close()
            End Using
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Shared Sub dp_equiptype_load()
        Try
            Frm_master_list_equipment.dp_equiptype.Items.Clear()
            sql = ""
            sql = "SELECT equipment_type FROM tbl_equipment_type ORDER BY equipment_type ASC"

            Using sqlCnn = New SqlConnection(My.Settings.Conn_string)
                sqlCnn.Open()
                Using sqlCmd = New SqlCommand(sql, sqlCnn)
                    Dim sqlReader As SqlDataReader = sqlCmd.ExecuteReader()
                    While (sqlReader.Read())
                        Dim desc = sqlReader.Item("equipment_type")
                        Frm_master_list_equipment.dp_equiptype.Items.Add(desc)
                        'Frm_master_list_location_info.dp_locationinfo_desc.Items.Add(desc)
                    End While
                End Using
                sqlCnn.Close()
            End Using
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Shared Sub dp_equipbrand_load()
        Try
            Frm_master_list_equipment.dp_equipbrand.Items.Clear()
            sql = ""
            sql = "SELECT equipment_brand FROM tbl_equipment_brand ORDER BY equipment_brand ASC"

            Using sqlCnn = New SqlConnection(My.Settings.Conn_string)
                sqlCnn.Open()
                Using sqlCmd = New SqlCommand(sql, sqlCnn)
                    Dim sqlReader As SqlDataReader = sqlCmd.ExecuteReader()
                    While (sqlReader.Read())
                        Dim desc = sqlReader.Item("equipment_brand")
                        Frm_master_list_equipment.dp_equipbrand.Items.Add(desc)
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

    'SELECT DROPDOWN
#Region "SELECT DROP DOWN"
    Shared Sub select_dp_owner_equipmain()
        Try
            sql = ""
            sql = "SELECT id FROM tbl_owner_name WHERE owner_name='" + Trim(Frm_master_list_equipment.dp_owner.Text) + "'"
            Using sqlCnn = New SqlConnection(My.Settings.Conn_string)
                sqlCnn.Open()
                Using sqlCmd = New SqlCommand(sql, sqlCnn)
                    Dim sqlReader As SqlDataReader = sqlCmd.ExecuteReader

                    sqlReader.Read()
                    dp_owner_slct_id = sqlReader.Item("id")
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

    Shared Sub select_dp_type_equipmain()
        Try
            sql = ""
            sql = "SELECT id FROM tbl_equipment_type WHERE equipment_type='" + Trim(Frm_master_list_equipment.dp_equiptype.Text) + "'"
            Using sqlCnn = New SqlConnection(My.Settings.Conn_string)
                sqlCnn.Open()
                Using sqlCmd = New SqlCommand(sql, sqlCnn)
                    Dim sqlReader As SqlDataReader = sqlCmd.ExecuteReader

                    sqlReader.Read()
                    dp_type_slct_id = sqlReader.Item("id")
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

    Shared Sub select_dp_brand_equipmain()
        Try
            sql = ""
            sql = "SELECT id FROM tbl_equipment_brand WHERE equipment_brand='" + Trim(Frm_master_list_equipment.dp_equipbrand.Text) + "'"
            Using sqlCnn = New SqlConnection(My.Settings.Conn_string)
                sqlCnn.Open()
                Using sqlCmd = New SqlCommand(sql, sqlCnn)
                    Dim sqlReader As SqlDataReader = sqlCmd.ExecuteReader

                    sqlReader.Read()
                    dp_brand_slct_id = sqlReader.Item("id")
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

    'LISTVIEW LOAD
#Region "LISTVIEWLOAD"
    Shared Sub equipment_masterlist_listview()
        Try
            sql = ""
            sql = "SELECT  ROW_NUMBER() over (PARTITION BY owner_name ORDER BY owner_name,equipment_type,equipment_brand asc) as #,id,owner_name,equipment_type,equipment_brand,model,cr_no,motor_no" _
                & ",serial_no,mv_file_no,si_no,dr_no,others,CONVERT(VARCHAR(12), date_proof, 107) as date_proof, replace(convert(nvarchar,convert(Money, acquisition_cost),1),'.0000','') as acquisition_cost FROM v_equipment_masterlist"


            Using sqlCnn = New SqlConnection(My.Settings.Conn_string)

                Frm_master_list_equipment.lv_masterequipment.Items.Clear()
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

                        If (sqlReader(5).ToString()) <> "" Then
                            list.SubItems.Add(sqlReader(5).ToString())
                        Else
                            list.SubItems.Add("---")
                        End If

                        If (sqlReader(6).ToString()) <> "" Then
                            list.SubItems.Add(sqlReader(6).ToString())
                        Else
                            list.SubItems.Add("---")
                        End If

                        If (sqlReader(7).ToString()) <> "" Then
                            list.SubItems.Add(sqlReader(7).ToString())
                        Else
                            list.SubItems.Add("---")
                        End If

                        If (sqlReader(8).ToString()) <> "" Then
                            list.SubItems.Add(sqlReader(8).ToString())
                        Else
                            list.SubItems.Add("---")
                        End If

                        If (sqlReader(9).ToString()) <> "" Then
                            list.SubItems.Add(sqlReader(9).ToString())
                        Else
                            list.SubItems.Add("---")
                        End If

                        If (sqlReader(10).ToString()) <> "" Then
                            list.SubItems.Add(sqlReader(10).ToString())
                        Else
                            list.SubItems.Add("---")
                        End If

                        If (sqlReader(11).ToString()) <> "" Then
                            list.SubItems.Add(sqlReader(11).ToString())
                        Else
                            list.SubItems.Add("---")
                        End If

                        If (sqlReader(12).ToString()) <> "" Then
                            list.SubItems.Add(sqlReader(12).ToString())
                        Else
                            list.SubItems.Add("---")
                        End If

                        If (sqlReader(13).ToString()) <> "" Then
                            list.SubItems.Add(sqlReader(13).ToString())
                        Else
                            list.SubItems.Add("---")
                        End If

                        If (sqlReader(14).ToString()) <> "" Then
                            list.SubItems.Add(sqlReader(14).ToString())
                        Else
                            list.SubItems.Add("---")
                        End If


                        Frm_master_list_equipment.lv_masterequipment.Items.Add(list)
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

#Region "MAIN EQUIPMENT DISABLED"
    Shared Sub main_equipment_disabled()
        With Frm_master_list_equipment
            .gb_menu.Enabled = True
            .gb_data.Enabled = False
        End With
    End Sub
#End Region

#Region "MAIN EQUIPMENT ENABLED"
    Shared Sub main_equipment_enabled()
        With Frm_master_list_equipment
            .gb_menu.Enabled = False
            .gb_data.Enabled = True

            For Each t As Control In Frm_master_list_equipment.gb_menu.Controls
                If TypeOf (t) Is RadDropDownList = True Then
                    t.Text = ""
                End If
            Next

            For Each tx As Control In Frm_master_list_equipment.gb_menu.Controls
                If TypeOf (tx) Is RadTextBox = True Then
                    tx.Text = ""
                End If
            Next
            For Each dt As Control In Frm_master_list_equipment.gb_menu.Controls
                If TypeOf (dt) Is RadDateTimePicker = True Then
                    dt.Text = Frm_main.txt_actualtime.Text
                End If
            Next

            Frm_master_list_equipment.sp_aqui_cost.Value = 0


        End With
    End Sub
#End Region

#Region "SELECTED ITEM LISTVIEW"
    Shared Sub Global_main_equipment_selected()
        If Frm_master_list_equipment.lv_masterequipment.SelectedItems.Count > 0 Then
            With Frm_master_list_equipment.lv_masterequipment.SelectedItems(0)
                slct_id = .SubItems(0)
            End With
        End If
    End Sub
#End Region

#Region "MAIN EQUIPMENT UPDATEVALUE"
    Shared Sub main_equipment_updatevalue()
        If Frm_master_list_equipment.lv_masterequipment.SelectedItems.Count > 0 Then
            With Frm_master_list_equipment.lv_masterequipment.SelectedItems(0)
                Frm_master_list_equipment.dp_owner.SelectedValue = .SubItems(2)
                Frm_master_list_equipment.dp_equiptype.SelectedValue = .SubItems(3)
                Frm_master_list_equipment.dp_equipbrand.SelectedValue = .SubItems(4)
                Frm_master_list_equipment.txt_model.Text = .SubItems(5)
                Frm_master_list_equipment.txt_cr_no.Text = .SubItems(6)
                Frm_master_list_equipment.txt_motorno.Text = .SubItems(7)
                Frm_master_list_equipment.txt_serialno.Text = .SubItems(8)
                Frm_master_list_equipment.txt_mvfileno.Text = .SubItems(9)
                Frm_master_list_equipment.txt_sino.Text = .SubItems(10)
                Frm_master_list_equipment.txt_drno.Text = .SubItems(11)
                Frm_master_list_equipment.txt_others.Text = .SubItems(12)
                Frm_master_list_equipment.dt_dateproof.Value = .SubItems(13)
                Frm_master_list_equipment.sp_aqui_cost.Value = .SubItems(14)
            End With
        End If
    End Sub
#End Region

#Region "main_equipment_searching"
    Shared Sub main_equipment_search(search_word)
        Try
            sql = ""

            If search_word <> Nothing Then
                sql = "SELECT TOP 50 ROW_NUMBER() over (PARTITION BY owner_name ORDER BY owner_name,equipment_type,equipment_brand asc) as #,id,owner_name,equipment_type,equipment_brand,model,cr_no,motor_no" _
                               & ",serial_no,mv_file_no,si_no,dr_no,others,CONVERT(VARCHAR(12), date_proof, 107) as date_proof, replace(convert(nvarchar,convert(Money, acquisition_cost),1),'.0000','') as acquisition_cost" _
                                & " FROM(SELECT TOP 50 ROW_NUMBER() over (PARTITION BY owner_name ORDER BY owner_name,equipment_type,equipment_brand asc) as #,id,(equipment_type + ' ' + equipment_brand + ' ' + model) AS SEART,owner_name,equipment_type,equipment_brand,model,cr_no,motor_no" _
                               & ",serial_no,mv_file_no,si_no,dr_no,others,CONVERT(VARCHAR(12), date_proof, 107) as date_proof, replace(convert(nvarchar,convert(Money, acquisition_cost),1),'.0000','') as acquisition_cost FROM v_equipment_masterlist" _
                               & ") x" _
                                & " WHERE x.SEART LIKE '%" & search_word & "%'"
            Else
                sql = "SELECT  ROW_NUMBER() over (PARTITION BY owner_name ORDER BY owner_name,equipment_type,equipment_brand asc) as #,id,owner_name,equipment_type,equipment_brand,model,cr_no,motor_no" _
                               & ",serial_no,mv_file_no,si_no,dr_no,others,CONVERT(VARCHAR(12), date_proof, 107) as date_proof, replace(convert(nvarchar,convert(Money, acquisition_cost),1),'.0000','') as acquisition_cost FROM v_equipment_masterlist" _
                               & " WHERE model LIKE '%" & search_word & "%'"
            End If



            Using sqlCnn = New SqlConnection(My.Settings.Conn_string)

                Frm_master_list_equipment.lv_masterequipment.Items.Clear()
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

                        If (sqlReader(5).ToString()) <> "" Then
                            list.SubItems.Add(sqlReader(5).ToString())
                        Else
                            list.SubItems.Add("---")
                        End If

                        If (sqlReader(6).ToString()) <> "" Then
                            list.SubItems.Add(sqlReader(6).ToString())
                        Else
                            list.SubItems.Add("---")
                        End If

                        If (sqlReader(7).ToString()) <> "" Then
                            list.SubItems.Add(sqlReader(7).ToString())
                        Else
                            list.SubItems.Add("---")
                        End If

                        If (sqlReader(8).ToString()) <> "" Then
                            list.SubItems.Add(sqlReader(8).ToString())
                        Else
                            list.SubItems.Add("---")
                        End If

                        If (sqlReader(9).ToString()) <> "" Then
                            list.SubItems.Add(sqlReader(9).ToString())
                        Else
                            list.SubItems.Add("---")
                        End If

                        If (sqlReader(10).ToString()) <> "" Then
                            list.SubItems.Add(sqlReader(10).ToString())
                        Else
                            list.SubItems.Add("---")
                        End If

                        If (sqlReader(11).ToString()) <> "" Then
                            list.SubItems.Add(sqlReader(11).ToString())
                        Else
                            list.SubItems.Add("---")
                        End If

                        If (sqlReader(12).ToString()) <> "" Then
                            list.SubItems.Add(sqlReader(12).ToString())
                        Else
                            list.SubItems.Add("---")
                        End If

                        If (sqlReader(13).ToString()) <> "" Then
                            list.SubItems.Add(sqlReader(13).ToString())
                        Else
                            list.SubItems.Add("---")
                        End If

                        If (sqlReader(14).ToString()) <> "" Then
                            list.SubItems.Add(sqlReader(14).ToString())
                        Else
                            list.SubItems.Add("---")
                        End If

                        Frm_master_list_equipment.lv_masterequipment.Items.Add(list)
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

End Class
