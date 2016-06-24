Imports Telerik.WinControls.UI
Imports Telerik.WinControls
Imports AIS_System.System_mod
Imports System.Data.SqlClient
Imports Telerik.WinControls.Data
Imports System.ComponentModel

Public Class Frm_master_list_location
    Dim sysmod As New System_mod

    Private Sub Frm_master_list_location_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ThemeResolutionService.ApplicationThemeName = My.Settings.global_themes
        'Farming_Operation.Server_time()

        location_masterlist_view.main_loc_dropdown_desc()
        location_masterlist_view.main_location_listview()

        Me.combar_dp_group.SelectedIndex = 0
    End Sub

    Private Sub btn_location_info_Click(sender As Object, e As EventArgs) Handles btn_location_info.Click
        Frm_main.Enabled = False
        Frm_master_list_location_info.Show()
    End Sub

    Private Sub cb_loc_desc_SelectedIndexChanged(sender As Object, e As UI.Data.PositionChangedEventArgs) Handles cb_loc_desc.SelectedIndexChanged
        location_masterlist_view.main_loc_select_dp_desc()
    End Sub
    Private Sub btn_save_Click(sender As Object, e As EventArgs) Handles btn_save.Click
        If command_contxt = 1 Then
            sysmod.Add_mainlocation(Replace(Trim(Me.txt_code.Text), "'", "`"), slct_id_locationdesc, sp_area.Value, Trim(Me.dp_soiltype.SelectedItem.ToString), Replace(Trim(Me.txt_ownername.Text), "'", "`"))
        ElseIf command_contxt = 2 Then
            sysmod.Update_mainlocation(slct_id, slct_id_locationdesc, Replace(Trim(Me.txt_code.Text), "'", "`"), sp_area.Value, Trim(Me.dp_soiltype.SelectedItem.Text), Replace(Trim(Me.txt_ownername.Text), "'", "`"))
        Else
            MsgBox("No command... need administrator assistant")
            Exit Sub
        End If

        If sysmod.msgb <> 1 Then
            MsgBox(sysmod.msgS, vbInformation + vbOKOnly, "AIS: Successful")
            location_masterlist_view.main_location_listview()
            location_masterlist_view.main_loc_enabled()
        Else
            MsgBox(sysmod.msgS, vbExclamation + vbOKOnly, "AIS: ERROR...")
        End If
    End Sub

    Private Sub RefreshToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RefreshToolStripMenuItem.Click
        location_masterlist_view.main_location_listview()
    End Sub

    'Private Sub AddToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AddToolStripMenuItem.Click
    '    command_contxt = 1

    '    location_masterlist_view.main_loc_disabled()
    'End Sub

    Private Sub btn_cancel_Click(sender As Object, e As EventArgs) Handles btn_cancel.Click
        location_masterlist_view.main_loc_enabled()
    End Sub

    Private Sub UpdateToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles UpdateToolStripMenuItem.Click
        If slct_id = Nothing Then
            MsgBox("No selected data")
        Else
            command_contxt = 2
            location_masterlist_view.main_loc_updatevalue()
            location_masterlist_view.main_loc_disabled()
        End If
    End Sub

    Private Sub DeleteToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DeleteToolStripMenuItem.Click
        sysmod.Delete_main_loc(slct_id)
        msgerror = Nothing
    End Sub

    Private Sub lv_masterlocation_CellFormatting(sender As Object, e As ListViewCellFormattingEventArgs) Handles lv_masterlocation.CellFormatting

        If TypeOf e.CellElement Is DetailListViewHeaderCellElement Then
            e.CellElement.TextAlignment = ContentAlignment.MiddleLeft
        Else
            e.CellElement.ResetValue(LightVisualElement.TextAlignmentProperty, Telerik.WinControls.ValueResetFlags.Local)
        End If

        If (TypeOf e.CellElement Is DetailListViewDataCellElement) Then
            e.CellElement.TextAlignment = ContentAlignment.MiddleLeft
        End If

        If (e.CellElement).Data.Name = "Column 1" Then
            If (TypeOf e.CellElement Is DetailListViewHeaderCellElement) Then
                e.CellElement.TextAlignment = ContentAlignment.MiddleCenter
            End If

            If (TypeOf e.CellElement Is DetailListViewDataCellElement) Then
                e.CellElement.TextAlignment = ContentAlignment.MiddleCenter
            End If
        End If

        If (TypeOf e.CellElement Is DetailListViewCellElement) Then
            e.CellElement.DrawFill = False
            e.CellElement.DrawBorder = False
        Else
            e.CellElement.ResetValue(LightVisualElement.DrawBorderProperty, Telerik.WinControls.ValueResetFlags.Local)
            e.CellElement.ResetValue(LightVisualElement.DrawFillProperty, Telerik.WinControls.ValueResetFlags.Local)
        End If
    End Sub

    Private Sub lv_masterlocation_MouseDown(sender As Object, e As MouseEventArgs) Handles lv_masterlocation.MouseDown
        If e.Button = Windows.Forms.MouseButtons.Right Then
            Me.cms_locationMaster.Show(Me, Me.PointToClient(MousePosition))
        End If
    End Sub

    Private Sub lv_masterlocation_SelectedItemChanged(sender As Object, e As EventArgs) Handles lv_masterlocation.SelectedItemChanged
        location_masterlist_view.Global_loc_masterlist_selected()
    End Sub

    Private Sub combar_txt_search_TextChanged(sender As Object, e As EventArgs) Handles combar_txt_search.TextChanged
        location_masterlist_view.main_location_search(Replace(Trim(combar_txt_search.Text), "'", "`"))
    End Sub

    Private Sub combar_dp_group_SelectedIndexChanged(sender As Object, e As UI.Data.PositionChangedEventArgs) Handles combar_dp_group.SelectedIndexChanged

        Me.lv_masterlocation.GroupDescriptors.Clear()

        Select Case combar_dp_group.SelectedIndex
            Case 0
                gp = "Column 3"
            Case 1
                gp = "Column 5"
            Case 2
                gp = "Column 6"
            Case 3
                gp = "Column 7"
            Case 4
                gp = "Column 8"
            Case 5
                gp = "Column 9"
            Case 6
                gp = "Column 10"
            Case 7
                gp = "Column 11"

        End Select

        Dim groupByType As New GroupDescriptor(gp)
        Me.lv_masterlocation.GroupDescriptors.Add(groupByType)
    End Sub

    Private Sub combar_dp_sortby_SelectedIndexChanged(sender As Object, e As UI.Data.PositionChangedEventArgs) Handles combar_dp_sortby.SelectedIndexChanged
        Select Case combar_dp_sortby.SelectedIndex
            Case 0
                sortsss = "Column 3"
            Case 1
                sortsss = "Column 2"
            Case 2
                sortsss = "Column 4"
            Case 3
                sortsss = "Column 6"
            Case 4
                sortsss = "Column 8"
        End Select
    End Sub

    Private Sub btn_asc_Click(sender As Object, e As EventArgs) Handles btn_asc.Click
        Me.lv_masterlocation.SortDescriptors.Clear()
        Me.lv_masterlocation.EnableSorting = True
        Dim sort = New SortDescriptor(sortsss, ListSortDirection.Ascending)
        Me.lv_masterlocation.SortDescriptors.Add(sort)

    End Sub

    Private Sub btn_desc_Click(sender As Object, e As EventArgs) Handles btn_desc.Click

        Me.lv_masterlocation.SortDescriptors.Clear()
        Me.lv_masterlocation.EnableSorting = True
        Dim sort = New SortDescriptor(sortsss, ListSortDirection.Descending)
        Me.lv_masterlocation.SortDescriptors.Add(sort)
    End Sub

    Private Sub AddNewlyLotCodeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AddNewlyLotCodeToolStripMenuItem.Click
        command_contxt = 1
        location_masterlist_view.main_loc_disabled()
    End Sub

    Private Sub AddNewLotCodeWithExistingCodeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AddNewLotCodeWithExistingCodeToolStripMenuItem.Click
        Frm_main.Enabled = False
        Frm_masterlist_location_addexisting.Show()
    End Sub
End Class
