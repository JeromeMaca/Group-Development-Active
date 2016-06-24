Imports Telerik.WinControls.UI
Imports Telerik.WinControls
Imports AIS_System.System_mod
Imports System.Data.SqlClient
Public Class Frm_master_list_location_info
    Dim sysmod As New System_mod
    Dim opt As Integer
    Private Sub Frm_master_list_location_info_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        Frm_main.Enabled = True

        location_masterlist_view.main_location_listview()
    End Sub

    Private Sub Frm_master_list_location_info_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ThemeResolutionService.ApplicationThemeName = My.Settings.global_themes
        'Farming_Operation.Server_time()

        location_masterlist_view.main_loc_dropdown_desc()
        location_masterlist_view.loc_info_dropdown_association()
        location_masterlist_view.loc_info_dropdown_culture()
        location_masterlist_view.location_info_listview()

        Me.cbar_cb_group.SelectedIndex = 0
    End Sub


    Private Sub dp_locationinfo_desc_SelectedIndexChanged(sender As Object, e As UI.Data.PositionChangedEventArgs) Handles dp_locationinfo_desc.SelectedIndexChanged
        'TEMPORARY
        location_masterlist_view.main_loc_select_dp_desc()
        location_masterlist_view.loc_info_dropdown_desc(slct_id_locationdesc)
    End Sub

    Private Sub dp_lotnumber_SelectedIndexChanged(sender As Object, e As UI.Data.PositionChangedEventArgs) Handles dp_lotnumber.SelectedIndexChanged
        location_masterlist_view.info_loc_select_dp_lot()
    End Sub

    Private Sub dp_variety_SelectedIndexChanged(sender As Object, e As UI.Data.PositionChangedEventArgs) Handles dp_variety.SelectedIndexChanged
        location_masterlist_view.info_loc_select_dp_variety()
    End Sub

    Private Sub dp_association_SelectedIndexChanged(sender As Object, e As UI.Data.PositionChangedEventArgs) Handles dp_association.SelectedIndexChanged
        location_masterlist_view.info_loc_select_dp_association()
    End Sub

    Private Sub btn_save_Click(sender As Object, e As EventArgs) Handles btn_save.Click
        If command_contxt = 1 Then
            sysmod.Add_locationinfo(slct_id_locationinfodesc, Me.dt_dateplanted.Value, Me.dp_ownership.SelectedItem.ToString, _
                                    slct_id_variety, slct_id_association, opt, _
                                    Trim(Me.txt_fiscalyear.Text), slct_id_locationinfodesc)
        ElseIf command_contxt = 2 Then
            sysmod.Update_locationinfo(Me.dt_dateplanted.Value, Me.dp_ownership.SelectedItem.ToString, _
                                    slct_id_variety, slct_id_association, opt, _
                                    Trim(Me.txt_fiscalyear.Text), slct_id)
        Else
            MsgBox("No command... need administrator assistant")
            Exit Sub
        End If

        If sysmod.msgb <> 1 Then
            MsgBox(sysmod.msgS, vbInformation + vbOKOnly, "AIS: Successful")
            location_masterlist_view.location_info_listview()
            location_masterlist_view.loc_info_enabled()
        Else
            MsgBox(sysmod.msgS, vbExclamation + vbOKOnly, "AIS: ERROR...")
        End If
    End Sub

    Private Sub rb_yes_ToggleStateChanged(sender As Object, args As StateChangedEventArgs) Handles rb_yes.ToggleStateChanged
        If Me.rb_yes.IsChecked Then
            opt = 1
        End If
    End Sub

    Private Sub rb_no_ToggleStateChanged(sender As Object, args As StateChangedEventArgs) Handles rb_no.ToggleStateChanged
        If Me.rb_no.IsChecked Then
            opt = 0
        End If
    End Sub

    Private Sub lv_loc_info_CellFormatting(sender As Object, e As ListViewCellFormattingEventArgs) Handles lv_loc_info.CellFormatting
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

    Private Sub lv_loc_info_MouseDown(sender As Object, e As MouseEventArgs) Handles lv_loc_info.MouseDown
        If e.Button = Windows.Forms.MouseButtons.Right Then
            Me.cms_locationinfo.Show(Me, Me.PointToClient(MousePosition))
        End If
    End Sub
    Private Sub cbar_cb_group_SelectedIndexChanged(sender As Object, e As UI.Data.PositionChangedEventArgs) Handles cbar_cb_group.SelectedIndexChanged
        Select Case cbar_cb_group.SelectedIndex
            Case 0
                Me.lv_loc_info.GroupDescriptors.Clear()
                location_masterlist_view.group_lv("Column 3")
            Case 1
                Me.lv_loc_info.GroupDescriptors.Clear()
                location_masterlist_view.group_lv("Column 4")
            Case 2
                Me.lv_loc_info.GroupDescriptors.Clear()
                location_masterlist_view.group_lv("Column 5")
            Case 3
                Me.lv_loc_info.GroupDescriptors.Clear()
                location_masterlist_view.group_lv("Column 6")
            Case 4
                Me.lv_loc_info.GroupDescriptors.Clear()
                location_masterlist_view.group_lv("Column 7")
            Case 5
                Me.lv_loc_info.GroupDescriptors.Clear()
                location_masterlist_view.group_lv("Column 8")
            Case 6
                Me.lv_loc_info.GroupDescriptors.Clear()
                location_masterlist_view.group_lv("Column 9")
        End Select
    End Sub

    Private Sub refresh_Click(sender As Object, e As EventArgs) Handles refresh.Click
        location_masterlist_view.location_info_listview()
    End Sub

    Private Sub add_Click(sender As Object, e As EventArgs) Handles add.Click
        command_contxt = 1

        location_masterlist_view.loc_info_disabled()

        Me.dp_locationinfo_desc.Enabled = True
        Me.dp_lotnumber.Enabled = True

        Me.rb_yes.IsChecked = False
        Me.rb_no.IsChecked = False
    End Sub

    Private Sub btn_cancel_Click(sender As Object, e As EventArgs) Handles btn_cancel.Click
        location_masterlist_view.loc_info_enabled()


        Me.rb_yes.IsChecked = False
        Me.rb_no.IsChecked = False
    End Sub

    Private Sub modify_Click(sender As Object, e As EventArgs) Handles modify.Click
        If slct_id = Nothing Then
            MsgBox("No selected data")
        Else
            command_contxt = 2
            location_masterlist_view.loc_info_updatevalue()
            location_masterlist_view.loc_info_disabled()

            'Me.rb_yes.IsChecked = True
            'Me.rb_no.IsChecked = True
        End If
    End Sub
    Private Sub lv_loc_info_SelectedItemChanged(sender As Object, e As EventArgs) Handles lv_loc_info.SelectedItemChanged
        location_masterlist_view.Global_loc_info_selected()
    End Sub

    Private Sub remove_Click(sender As Object, e As EventArgs) Handles remove.Click
        sysmod.Delete_locationinfo(slct_id)
        msgerror = Nothing
    End Sub
End Class
