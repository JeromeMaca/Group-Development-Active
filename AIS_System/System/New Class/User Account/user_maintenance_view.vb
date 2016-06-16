
Imports System.Data.SqlClient
Imports Telerik.WinControls.UI

Public Class user_maintenance_view

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

#Region "LOAD LISTVIEW DOWN"
    Shared Sub userlist_load()
        Try
            sql = ""
            sql = "SELECT  ROW_NUMBER() over (PARTITION BY type_index ORDER BY type_index) as #,id,username,password,user_lname,user_fname,user_mname,user_type,type_index FROM tbl_user_account"

            Using sqlCnn = New SqlConnection(My.Settings.Conn_string)

                Frm_user_control_maintenace.lv_useraccountlist.Items.Clear()

                sqlCnn.Open()
                sqlCmd = New SqlCommand(sql, sqlCnn)

                Using sqlReader As SqlDataReader = sqlCmd.ExecuteReader()

                    While (sqlReader.Read())
                        Dim list As New ListViewDataItem
                        list.SubItems.Add(sqlReader(1).ToString())
                        list.SubItems.Add(sqlReader(0).ToString())
                        list.SubItems.Add(sqlReader(2).ToString())
                        'list.SubItems.Add(sqlReader(3).ToString())

                        If (sqlReader(3) IsNot Nothing) Then
                            list.SubItems.Add("*** Confidential ***")
                        Else
                            list.SubItems.Add("NULL")
                        End If

                        list.SubItems.Add(sqlReader(5).ToString())
                        list.SubItems.Add(sqlReader(6).ToString())
                        list.SubItems.Add(sqlReader(4).ToString())

                        Dim a = sqlReader(7)
                        Dim b = sqlReader(8)

                        list.SubItems.Add(b & " --- " & a)
                        'list.SubItems.Add(sqlReader(7).ToString())
                        list.SubItems.Add(sqlReader(8).ToString())

                        Frm_user_control_maintenace.lv_useraccountlist.Items.Add(list)
                    End While
                End Using
                sqlCmd.Connection.Close()
            End Using
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
#End Region

#Region "SELECTED ITEM LISTVIEW"
    Shared Sub Global_selected(listview As RadListView)
        If listview.SelectedItems.Count > 0 Then
            With listview.SelectedItems(0)
                usercontrol_id = .SubItems(0)
            End With
        End If
    End Sub
#End Region

#Region "USERACCOUNT UPDATEVALUE"
    Shared Sub usercontrol_updatevalue()
        If Frm_user_control_maintenace.lv_useraccountlist.SelectedItems.Count > 0 Then
            With Frm_user_control_maintenace.lv_useraccountlist.SelectedItems(0)
                .Text = .Text
                Frm_user_control_maintenace.txt_username.Text = .SubItems(2)
                Frm_user_control_maintenace.txt_fname.Text = .SubItems(4)
                Frm_user_control_maintenace.txt_mname.Text = .SubItems(5)
                Frm_user_control_maintenace.txt_lname.Text = .SubItems(6)
                Frm_user_control_maintenace.dp_usertype.SelectedIndex = .SubItems(8)
                'Frm_master_list_work_operation.dp_operationcategory.SelectedValue = .SubItems(2)
                'Frm_master_list_work_operation.txt_workoperation.Text = .SubItems(3)
                'rm_master_list_work_operation.txt_unitmeasure.Text = .SubItems(4)
                'Frm_master_list_work_operation.txt_ratecost.Text = .SubItems(5)
            End With
        End If
    End Sub
#End Region

#Region "USER ACCOUNT DISABLED"
    Shared Sub usercontrol_disabled()
        With Frm_user_control_maintenace
            .gb_menu.Enabled = True
            .gb_data.Enabled = False
        End With
    End Sub
#End Region

#Region "USER ACCOUNT ENABLED"
    Shared Sub usercontrol_enabled()
        With Frm_user_control_maintenace
            .gb_menu.Enabled = False
            .gb_data.Enabled = True
        End With
    End Sub
#End Region

#Region "USER ACCOUNT CLEAR FIELD"
    Shared Sub usercontrol_clear_field()

        For Each t As Control In Frm_user_control_maintenace.gb_menu.Controls
            If TypeOf (t) Is RadDropDownList = True Then
                t.Text = ""
            End If
        Next

        For Each tx As Control In Frm_user_control_maintenace.gb_menu.Controls
            If TypeOf (tx) Is RadTextBox = True Then
                tx.Text = ""
            End If
        Next
    End Sub
#End Region

#Region "SEARCH DATA RECORD"
    Shared Sub useraccount_search(search)
        Try
            sql = ""
            sql = "SELECT  ROW_NUMBER() over (PARTITION BY type_index ORDER BY type_index) as #,id,username,password,user_lname,user_fname,user_mname,user_type,type_index" _
                    & " FROM tbl_user_account WHERE username LIKE '%" & search & "%' OR user_lname LIKE '%" & search & "%' OR user_fname LIKE '%" & search & "%' OR user_mname LIKE '%" & search & "%'"


            Using sqlCnn = New SqlConnection(My.Settings.Conn_string)

                Frm_user_control_maintenace.lv_useraccountlist.Items.Clear()

                sqlCnn.Open()
                sqlCmd = New SqlCommand(sql, sqlCnn)

                Using sqlReader As SqlDataReader = sqlCmd.ExecuteReader()

                    While (sqlReader.Read())
                        Dim list As New ListViewDataItem
                        list.SubItems.Add(sqlReader(1).ToString())
                        list.SubItems.Add(sqlReader(0).ToString())
                        list.SubItems.Add(sqlReader(2).ToString())
                        'list.SubItems.Add(sqlReader(3).ToString())

                        If (sqlReader(3) IsNot Nothing) Then
                            list.SubItems.Add("*** Confidential ***")
                        Else
                            list.SubItems.Add("NULL")
                        End If

                        list.SubItems.Add(sqlReader(5).ToString())
                        list.SubItems.Add(sqlReader(6).ToString())
                        list.SubItems.Add(sqlReader(4).ToString())

                        Dim a = sqlReader(7)
                        Dim b = sqlReader(8)

                        list.SubItems.Add(b & " --- " & a)
                        'list.SubItems.Add(sqlReader(7).ToString())
                        list.SubItems.Add(sqlReader(8).ToString())

                        Frm_user_control_maintenace.lv_useraccountlist.Items.Add(list)
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
