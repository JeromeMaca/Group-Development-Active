Imports System.Data.SqlClient
Imports Telerik.WinControls.UI
Imports Telerik.WinControls
Imports Telerik.Data
Imports Telerik.WinControls.Data
Imports System.ComponentModel
Public Class implement_masterlist_view

    'LOAD DROP DOWN
#Region "LOAD DROP DOWN"
    Shared Sub dp_owner_load()
        Try
            Frm_masterlist_implements.dp_owner.Items.Clear()
            sql = ""
            sql = "SELECT owner_name FROM tbl_owner_name ORDER BY owner_name ASC"

            Using sqlCnn = New SqlConnection(My.Settings.Conn_string)
                sqlCnn.Open()
                Using sqlCmd = New SqlCommand(sql, sqlCnn)
                    Dim sqlReader As SqlDataReader = sqlCmd.ExecuteReader()
                    While (sqlReader.Read())
                        Dim desc = sqlReader.Item("owner_name")
                        Frm_masterlist_implements.dp_owner.Items.Add(desc)
                        'Frm_master_list_location_info.dp_locationinfo_desc.Items.Add(desc)
                    End While
                End Using
                sqlCnn.Close()
            End Using
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Shared Sub dp_implementlist_load()
        Try
            Frm_masterlist_implements.dp_implelist.Items.Clear()
            sql = ""
            sql = "SELECT description FROM tbl_implement_list ORDER BY description ASC"

            Using sqlCnn = New SqlConnection(My.Settings.Conn_string)
                sqlCnn.Open()
                Using sqlCmd = New SqlCommand(sql, sqlCnn)
                    Dim sqlReader As SqlDataReader = sqlCmd.ExecuteReader()
                    While (sqlReader.Read())
                        Dim desc = sqlReader.Item("description")
                        Frm_masterlist_implements.dp_implelist.Items.Add(desc)
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
    Shared Sub main_imple_select_dp_owner()
        Try
            sql = ""
            sql = "SELECT id FROM tbl_owner_name WHERE owner_name='" + Trim(Frm_masterlist_implements.dp_owner.Text) + "'"
            Using sqlCnn = New SqlConnection(My.Settings.Conn_string)
                sqlCnn.Open()
                Using sqlCmd = New SqlCommand(sql, sqlCnn)
                    Dim sqlReader As SqlDataReader = sqlCmd.ExecuteReader

                    sqlReader.Read()
                    dp_owner_id = sqlReader.Item("id")
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

    Shared Sub main_imple_select_dp_list()
        Try
            sql = ""
            sql = "SELECT id FROM tbl_implement_list WHERE description='" + Trim(Frm_masterlist_implements.dp_implelist.Text) + "'"
            Using sqlCnn = New SqlConnection(My.Settings.Conn_string)
                sqlCnn.Open()
                Using sqlCmd = New SqlCommand(sql, sqlCnn)
                    Dim sqlReader As SqlDataReader = sqlCmd.ExecuteReader

                    sqlReader.Read()
                    dp_list_id = sqlReader.Item("id")
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

#Region "IMPLEMENT LISTVIEW "
    Shared Sub implement_listview()
        Try
            sql = ""
            sql = "SELECT  ROW_NUMBER() over (PARTITION BY description,owner_name ORDER BY description,imple_desc,owner_name) as #,id,owner_name,description,code,imple_desc FROM v_implement_masterlist"


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
        slct_id = Nothing
    End Sub

#End Region

    'SELECTED ITEM LISTVIEW
#Region "SELECTED ITEM LISTVIEW"
    Shared Sub Global_loc_masterlist_selected()
        If Frm_masterlist_implements.lv_masterimplement.SelectedItems.Count > 0 Then
            With Frm_masterlist_implements.lv_masterimplement.SelectedItems(0)
                slct_id = .SubItems(0)
            End With
        End If
    End Sub
#End Region

#Region "MAIN IMPLEMENT DISABLED"
    Shared Sub main_implement_disabled()
        With Frm_masterlist_implements
            .gb_menu.Enabled = True
            .gb_data.Enabled = False
        End With
    End Sub
#End Region

#Region "IMPLEMENT INFO ENABLED"
    Shared Sub main_implement_enabled()
        With Frm_masterlist_implements
            .gb_menu.Enabled = False
            .gb_data.Enabled = True
        End With
    End Sub
#End Region

#Region "IMPLEMENT CLEAR FIELD"
    Shared Sub imple_clear_field()

        For Each t As Control In Frm_masterlist_implements.gb_menu.Controls
            If TypeOf (t) Is RadDropDownList = True Then
                t.Text = ""
            End If
        Next

        For Each tx As Control In Frm_masterlist_implements.gb_menu.Controls
            If TypeOf (tx) Is RadTextBox = True Then
                tx.Text = ""
            End If
        Next
        For Each dt As Control In Frm_masterlist_implements.gb_menu.Controls
            If TypeOf (dt) Is RadDateTimePicker = True Then
                dt.Text = Frm_main.txt_actualtime.Text
            End If
        Next
    End Sub
#End Region

    'UPDATE VALUE
#Region "MAIN IMPLEMENT UPDATEVALUE"
    Shared Sub main_implement_updatevalue()
        If Frm_masterlist_implements.lv_masterimplement.SelectedItems.Count > 0 Then
            With Frm_masterlist_implements.lv_masterimplement.SelectedItems(0)
                .Text = .Text
                Frm_masterlist_implements.dp_owner.SelectedValue = .SubItems(2)
                Frm_masterlist_implements.dp_implelist.SelectedValue = .SubItems(3)
                Frm_masterlist_implements.txt_code.Text = .SubItems(4)
                Frm_masterlist_implements.txt_desc.Text = .SubItems(5)
            End With
        End If
    End Sub
#End Region

#Region "MAIN IMPLEMENT SEARCH"
    Shared Sub main_implement_search(search_word)
        Try
            sql = ""
            If search_word <> "" Then
                sql = "SELECT TOP 50 ROW_NUMBER() over (PARTITION BY description,owner_name ORDER BY description,imple_desc,owner_name) as #" _
                    & ",id,owner_name,description,code,imple_desc FROM v_implement_masterlist WHERE code LIKE '%" & search_word & "%' OR description" _
                    & " LIKE '%" & search_word & "%'"
            Else
                sql = "SELECT ROW_NUMBER() over (PARTITION BY description,owner_name ORDER BY description,imple_desc,owner_name) as #" _
                    & ",id,owner_name,description,code,imple_desc FROM v_implement_masterlist WHERE code LIKE '%" & search_word & "%' OR description" _
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
