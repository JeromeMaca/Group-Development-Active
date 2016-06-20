
Imports System.Data.SqlClient
Imports Telerik.WinControls.UI

Public Class user_maintenance_view

#Region "USER MAINTENANCE"

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

    Shared Sub lvpermission_cellformatting(e)
        If TypeOf e.CellElement Is DetailListViewHeaderCellElement Then
            e.CellElement.TextAlignment = ContentAlignment.MiddleLeft

        Else
            e.CellElement.ResetValue(LightVisualElement.TextAlignmentProperty, Telerik.WinControls.ValueResetFlags.Local)
        End If

        If (TypeOf e.CellElement Is DetailListViewDataCellElement) Then
            e.CellElement.TextAlignment = ContentAlignment.MiddleLeft
        End If

        If (e.CellElement).Data.Name = "count" Then
            If (TypeOf e.CellElement Is DetailListViewHeaderCellElement) Then
                e.CellElement.TextAlignment = ContentAlignment.MiddleCenter
                ' e.CellElement.BackColor = Color.Red
            Else
                e.CellElement.ResetValue(LightVisualElement.BackColorProperty)
            End If

            If (TypeOf e.CellElement Is DetailListViewDataCellElement) Then
                e.CellElement.TextAlignment = ContentAlignment.MiddleCenter
            End If
        End If

        'If (TypeOf e.Cellelement Is DetailListViewCellElement) Then
        '    e.CellElement.DrawFill = False
        '    e.CellElement.DrawBorder = False
        'Else
        '    e.CellElement.ResetValue(LightVisualElement.DrawBorderProperty, Telerik.WinControls.ValueResetFlags.Local)
        '    e.CellElement.ResetValue(LightVisualElement.DrawFillProperty, Telerik.WinControls.ValueResetFlags.Local)
        'End If

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

    Shared Sub access_selected(listview As RadListView)
        If listview.SelectedItems.Count > 0 Then
            With listview.SelectedItems(0)
                access_id = .SubItems(0)
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

#End Region


#Region "USER PERMISSION"

#Region "TREEVIEW FORMATTING"
    Shared Sub tv_format(e)
        If e.Node.Nodes.Count > 0 Then

            If e.Node.Expanded Then
                'e.NodeElement.ImageElement.Image = folderOpen

                ' e.NodeElement.ContentElement.ForeColor = Color.DarkRed
                e.NodeElement.ContentElement.Font = New Font("Tahoma", 8.5, FontStyle.Bold)
            Else
                ' e.NodeElement.ImageElement.Image = folderClose
                '   e.NodeElement.ContentElement.ForeColor = Color.DimGray

                e.NodeElement.ContentElement.Font = New Font("Tahoma", 8.5, FontStyle.Bold)
            End If
        Else
            ' e.NodeElement.ImageElement.Image = file
            ' e.NodeElement.ContentElement.ForeColor = Color.SteelBlue

            e.NodeElement.ContentElement.Font = New Font("Tahoma", 8.5, FontStyle.Bold)
        End If

    End Sub
#End Region

#Region "LOAD TREEVIEW DATA"


    Shared Function CreateDataTable() As DataTable
        Try
            Dim dt As New DataTable()
            sql = ""
            sql = "SELECT id, description,hierarchy1 FROM tbl_main_useraccess_list"


            Using sqlCnn = New SqlConnection(My.Settings.Conn_string)
                sqlCnn.Open()
                sqlCmd = New SqlCommand(sql, sqlCnn)

                Using SqlDataAdapter As New SqlDataAdapter
                    sqlCmd.Connection = sqlCnn
                    SqlDataAdapter.SelectCommand = sqlCmd
                    SqlDataAdapter.Fill(dt)
                End Using
                Return dt
            End Using

        Catch ex As Exception

        End Try
    End Function

    Shared Function Searchnode(ByVal nodetext As String, ByVal trv As RadTreeView) As RadTreeNode
        For Each node As RadTreeNode In trv.Nodes
            If node.Text = nodetext Then
                Return node
            End If
        Next
    End Function

    Shared Sub buildtree(ByVal dt As DataTable, ByVal trv As RadTreeView, ByVal expandAll As [Boolean])
        Dim dts As New DataTable

        dts.Columns.Add("Id", GetType(Integer))
        dts.Columns.Add("description", GetType(String))
        dts.Columns.Add("hierarchy", GetType(String))

        trv.Nodes.Clear()
        Dim desc As RadTreeNode

        Dim subNode As RadTreeNode

        Dim flag As Boolean = False
        Dim flag2 As Boolean = False

        For Each row As DataRow In dt.Rows
            'Dim hierarchyid As String
            'Dim nameid As String
            Dim name = row.Item(1).ToString()

            Dim assss As String
            Dim ids As String
            Dim child_asss As String
            Dim namesss As String


            For Each rr As DataRow In dt.Rows
                assss = rr.Item(0).ToString
                If assss = row.Item(2).ToString Then
                    flag = True
                    ids = rr.Item(0).ToString
                    namesss = rr.Item(1).ToString
                    Exit For
                End If
            Next


            'For i As Integer = 0 To RadTreeView1.Nodes.Count - 1
            '    browseTreeNodes(RadTreeView1.Nodes(i), 0)
            'Next

            desc = Searchnode(row.Item(1).ToString(), trv)

            If flag = True Then

                For Each rs As DataRow In dt.Rows
                    child_asss = rs.Item(2).ToString
                    If child_asss = ids Then
                        flag2 = True
                        Exit For
                    End If
                Next

                If flag2 = True Then
                    'namesss = rr.Item(1).ToString
                End If

                desc = Searchnode(namesss, trv)
                subNode = New RadTreeNode(row.Item(1).ToString())

                desc.Nodes.Add(subNode)
            Else
                desc = New RadTreeNode(row.Item(1).ToString())

                trv.Nodes.Add(desc)
            End If
        Next
        If expandAll Then
            ' Expand the TreeView
            trv.ExpandAll()
        End If
    End Sub
#End Region

#Region "FIND ALL NODES"
    Shared Sub browseTreeNodes(subRoot As RadTreeNode, level As Integer)
        If subRoot Is Nothing Then
            Return
        End If

        ' do what you need here (just print to output for the purpose of demonstration - this is where "level" is used)
        Dim nodeText As String = subRoot.Text.PadLeft(subRoot.Text.Length + level, ControlChars.Tab)
        ' MsgBox(nodeText & " --- " & level)


        ' loop through the children
        For i As Integer = 0 To subRoot.Nodes.Count - 1
            browseTreeNodes(subRoot.Nodes(i), level + 1)
        Next
    End Sub
#End Region
#End Region
End Class
