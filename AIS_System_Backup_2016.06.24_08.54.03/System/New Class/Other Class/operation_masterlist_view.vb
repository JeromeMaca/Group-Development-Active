Imports System.Data.SqlClient
Imports Telerik.WinControls.UI
Imports Telerik.WinControls
Imports Telerik.Data
Imports Telerik.WinControls.Data
Imports System.ComponentModel
Public Class operation_masterlist_view

    'LOAD DROP DOWN
#Region "LOAD DROP DOWN"
    Shared Sub dp_owner_load()
        Try
            Frm_master_list_work_operation.dp_operationcategory.Items.Clear()
            sql = ""
            sql = "SELECT cat_desc FROM tbl_ais_operation_category ORDER BY cat_desc ASC"

            Using sqlCnn = New SqlConnection(My.Settings.Conn_string)
                sqlCnn.Open()
                Using sqlCmd = New SqlCommand(sql, sqlCnn)
                    Dim sqlReader As SqlDataReader = sqlCmd.ExecuteReader()
                    While (sqlReader.Read())
                        Dim desc = sqlReader.Item("cat_desc")
                        Frm_master_list_work_operation.dp_operationcategory.Items.Add(desc)
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
    Shared Sub main_category_select_dp_owner()
        Try
            sql = ""
            sql = "SELECT category_id FROM tbl_ais_operation_category WHERE cat_desc='" + Trim(Frm_master_list_work_operation.dp_operationcategory.Text) + "'"
            Using sqlCnn = New SqlConnection(My.Settings.Conn_string)
                sqlCnn.Open()
                Using sqlCmd = New SqlCommand(sql, sqlCnn)
                    Dim sqlReader As SqlDataReader = sqlCmd.ExecuteReader

                    sqlReader.Read()
                    dp_cat_slct_id = sqlReader.Item("category_id")
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

#Region "WORK OPERATION LISTVIEW "
    Shared Sub work_operation_listview()
        Try
            sql = ""
            sql = "SELECT  ROW_NUMBER() over (PARTITION BY cat_desc ORDER BY cat_desc,operation) as #,id,cat_desc,operation,unit_measure,replace(convert(nvarchar,convert(Money, rate_cost),1),'.0000','') as rate_cost FROM v_ais_work_operation"


            Using sqlCnn = New SqlConnection(My.Settings.Conn_string)

                Frm_master_list_work_operation.lv_masteriworkoperation.Items.Clear()
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

                        Frm_master_list_work_operation.lv_masteriworkoperation.Items.Add(list)
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
    Shared Sub Global_work_operation_masterlist_selected()
        If Frm_master_list_work_operation.lv_masteriworkoperation.SelectedItems.Count > 0 Then
            With Frm_master_list_work_operation.lv_masteriworkoperation.SelectedItems(0)
                slct_id = .SubItems(0)
            End With
        End If
    End Sub
#End Region

#Region "MAIN WORK OPERATION DISABLED"
    Shared Sub main_workoperation_disabled()
        With Frm_master_list_work_operation
            .gb_menu.Enabled = True
            .gb_data.Enabled = False
        End With
    End Sub
#End Region

#Region "MAIN WORK OPERATION ENABLED"
    Shared Sub main_workoperation_enabled()
        With Frm_master_list_work_operation
            .gb_menu.Enabled = False
            .gb_data.Enabled = True
        End With
    End Sub
#End Region

#Region "WORK OPERATION CLEAR FIELD"
    Shared Sub operation_clear_field()

        For Each t As Control In Frm_master_list_work_operation.gb_menu.Controls
            If TypeOf (t) Is RadDropDownList = True Then
                t.Text = ""
            End If
        Next

        For Each tx As Control In Frm_master_list_work_operation.gb_menu.Controls
            If TypeOf (tx) Is RadTextBox = True Then
                tx.Text = ""
            End If
        Next
        For Each dt As Control In Frm_master_list_work_operation.gb_menu.Controls
            If TypeOf (dt) Is CurrencyTextBox.CurrencyTextBox = True Then
                dt.Text = 0
            End If
        Next
    End Sub
#End Region

    'UPDATE VALUE
#Region "MAIN WORK OPERATION UPDATEVALUE"
    Shared Sub main_work_operation_updatevalue()
        If Frm_master_list_work_operation.lv_masteriworkoperation.SelectedItems.Count > 0 Then
            With Frm_master_list_work_operation.lv_masteriworkoperation.SelectedItems(0)
                .Text = .Text
                Frm_master_list_work_operation.dp_operationcategory.SelectedValue = .SubItems(2)
                Frm_master_list_work_operation.txt_workoperation.Text = .SubItems(3)
                Frm_master_list_work_operation.txt_unitmeasure.Text = .SubItems(4)
                Frm_master_list_work_operation.txt_ratecost.Text = .SubItems(5)
            End With
        End If
    End Sub
#End Region

#Region "MAIN WORK OPERATION SEARCH"
    Shared Sub main_work_operation_search(search_word)
        Try
            sql = ""
            If search_word <> "" Then
                sql = "SELECT TOP 50 ROW_NUMBER() over (PARTITION BY description,owner_name ORDER BY description,imple_desc,owner_name) as #" _
                    & ",id,owner_name,description,code,imple_desc FROM v_ais_implement_masterlist WHERE code LIKE '%" & search_word & "%' OR description" _
                    & " LIKE '%" & search_word & "%'"
            Else
                sql = "SELECT ROW_NUMBER() over (PARTITION BY description,owner_name ORDER BY description,imple_desc,owner_name) as #" _
                    & ",id,owner_name,description,code,imple_desc FROM v_ais_implement_masterlist WHERE code LIKE '%" & search_word & "%' OR description" _
                    & " LIKE '%" & search_word & "%'"
            End If

            Using sqlCnn = New SqlConnection(My.Settings.Conn_string)

                Frm_masterlist_implements.lv_masterimplement.Items.Clear()
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

                        Frm_masterlist_implements.lv_masterimplement.Items.Add(list)
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
