Imports Telerik.WinControls.UI
Imports Telerik.WinControls
Imports AIS_System.site_mod
Imports System.Data.SqlClient

Public Class frm_master_list_operation
    Dim mymod As New site_mod

    Private Sub btn_addcat_Click(sender As Object, e As EventArgs) Handles btn_addcat.Click
        Frm_addcategory.Show()
        Frm_main.Enabled = False
    End Sub

    Private Sub Frm_operations_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Farming_Operation.load_work_operation()
        Farming_Operation.main_loadcategoryCB()
    End Sub
    Private Sub lv_operations_MouseDown_1(sender As Object, e As MouseEventArgs) Handles lv_operations.MouseDown
        If e.Button = Windows.Forms.MouseButtons.Right Then
            Me.cms_operationmenu.Show(Me, Me.PointToClient(MousePosition))
        End If
    End Sub
    Private Sub dropd_category_TextChanged(sender As Object, e As EventArgs) Handles dropd_category.TextChanged
        Farming_Operation.main_select_category()
    End Sub
    Private Sub btn_saveOpera_Click(sender As Object, e As EventArgs) Handles btn_saveOpera.Click
        If contextmenu_V = 1 Then
            mymod.Opearation_NewOpeartion(Trim(category_id), Trim(Me.txt_operation.Text), Trim(Me.spine_operrate.Value), Trim(txt_unitmeasure.Text))
        Else
            mymod.Opeartion_UpdateOperation(Trim(opeartion_id), Trim(category_id), Trim(Me.txt_operation.Text), Trim(Me.spine_operrate.Value), Trim(txt_unitmeasure.Text))
        End If

        If mymod.msgb <> 1 Then
            MsgBox(mymod.msgS)
            Farming_Operation.load_work_operation()
            Me.txt_operation.Text = ""
            Me.spine_operrate.Value = 0
            Me.txt_unitmeasure.Text = ""
            Me.dropd_category.Text = Nothing
        Else
            MsgBox(mymod.msgS)
            Me.txt_operation.Text = ""
            Me.spine_operrate.Value = 0
            Me.txt_unitmeasure.Text = ""
            Me.dropd_category.Text = Nothing
        End If
    End Sub
    Private Sub RefreshToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RefreshToolStripMenuItem.Click
        Farming_Operation.load_work_operation()
    End Sub
    Private Sub DeleteOperationToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DeleteOperationToolStripMenuItem.Click
        If opeartion_id <> Nothing Then
            If MsgBox("Are you sure you want to delete selected record?", MsgBoxStyle.Question + MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                sql = "DELETE FROM tbl_work_operations WHERE id =" & opeartion_id

                Using sqlCnn = New SqlConnection(My.Settings.Conn_string)
                    Using sqlCmd = New SqlCommand(sql, sqlCnn)
                        sqlCmd.Connection.Open()
                        sqlCmd.ExecuteNonQuery()
                    End Using
                End Using
            End If
            sqlCmd.Connection.Close()
            Farming_Operation.load_work_operation()
        Else
            MsgBox("Select a record please.")
        End If
        opeartion_id = Nothing
    End Sub

    Private Sub lv_operations_ItemSelectionChanged(sender As Object, e As ListViewItemSelectionChangedEventArgs) Handles lv_operations.ItemSelectionChanged
        If Me.lv_operations.SelectedItems.Count > 0 Then
            With Me.lv_operations.SelectedItems(0)
                Me.lv_operations.Text = .Text
                opeartion_id = .SubItems(1).Text
            End With
        End If
    End Sub

    Private Sub AddOperationToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AddOperationToolStripMenuItem.Click
        contextmenu_V = 1
        Me.txt_operation.Focus()
    End Sub

    Private Sub UpdateOperationToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles UpdateOperationToolStripMenuItem.Click
        If opeartion_id = Nothing Then
            MsgBox("Select an record please.")
        Else
            contextmenu_V = 2
            update_operation()
        End If
    End Sub

    Sub update_operation()
        Me.dropd_category.Text = ""
        If Me.lv_operations.SelectedItems.Count > 0 Then
            With Me.lv_operations.SelectedItems(0)
                Me.lv_operations.Text = .Text
                Me.txt_operation.Text = .SubItems(2).Text
                Me.spine_operrate.Value = .SubItems(3).Text
                Me.txt_unitmeasure.Text = .SubItems(4).Text
                Me.dropd_category.SelectedText = .SubItems(5).Text
            End With
        End If
    End Sub

    Private Sub btn_cancel_Click(sender As Object, e As EventArgs) Handles btn_cancel.Click
        Farming_Operation.load_work_operation()
        Me.txt_operation.Text = ""
        Me.spine_operrate.Value = 0
        Me.txt_unitmeasure.Text = ""
        Me.dropd_category.Text = Nothing
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs)

    End Sub

    Shared Sub GroupItem(item As ListViewItem)
        Dim aeom = "5"
        ' This flag will tell us if proper group already exists
        Dim group_exists As Boolean = False

        ' Check each group if it fits to the item
        For Each group As ListViewGroup In frm_master_list_operation.lv_operations.Groups
            ' Compare group's header to selected subitem's text
            If group.Header = item.SubItems(CInt(aeom)).Text Then
                ' Add item to the group.
                ' Alternative is: group.Items.Add(item);
                item.Group = group
                group_exists = True
                Exit For
            End If
        Next

        ' Create new group if no proper group was found
        If Not group_exists Then
            ' Create group and specify its header by
            ' getting selected subitem's text
            Dim group As New ListViewGroup(item.SubItems(CInt(aeom)).Text)
            ' We need to add the group to the ListView first
            frm_master_list_operation.lv_operations.Groups.Add(group)
            item.Group = group
        End If
    End Sub
End Class
