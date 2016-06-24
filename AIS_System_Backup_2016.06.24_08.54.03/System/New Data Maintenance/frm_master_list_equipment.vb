Imports Telerik.WinControls.UI
Imports Telerik.WinControls
Imports AIS_System.System_mod
Imports System.Data.SqlClient
Imports Telerik.WinControls.Data
Imports System.ComponentModel
Imports Telerik.WinControls.Enumerations

Public Class Frm_master_list_equipment
    Dim sysmod As New System_mod

#Region "LISTVIEW COLUMN"
    Sub equipment_column()
        Me.lv_masterequipment.Columns.Clear()

        With Me.lv_masterequipment
            .Columns.Add("Id", "")
            .Columns.Add("Count", "#")
            .Columns.Add("ownername", "OWNER NAME")
            .Columns.Add("Type", "TYPE")
            .Columns.Add("brand", "BRAND")
            .Columns.Add("model", "MODEL")
            .Columns.Add("cr", "CR No.")
            .Columns.Add("engine", "ENGINE/MOTOR No.")
            .Columns.Add("serial", "SERIAL/CHASSIS No.")
            .Columns.Add("mv", "MV FILE No.")
            '.Columns.Add("color", "COLOR")
            .Columns.Add("si", "PROOF OF DOCS SI No.")
            .Columns.Add("dr", "PROOF OF DOCS DR No.")
            .Columns.Add("other", "OTHERS")
            .Columns.Add("date", "DATE")
            .Columns.Add("acquisition", "ACQUISITION COST BASE ON OR & DEED OF SALE")

            .Columns("Id").Width = 0
            .Columns("Id").Visible = False
            .Columns("Count").Width = 60
            .Columns("ownername").Width = 250
            .Columns("Type").Width = 150
            .Columns("brand").Width = 150
            .Columns("model").Width = 100
            .Columns("cr").Width = 100
            .Columns("engine").Width = 100
            .Columns("serial").Width = 100
            .Columns("mv").Width = 100
            '.Columns("color").Width = 200
            .Columns("si").Width = 100
            .Columns("dr").Width = 100
            .Columns("other").Width = 100
            .Columns("date").Width = 100
            .Columns("acquisition").Width = 280


            .FullRowSelect = True
            '.ShowGridLines = True
            .ShowGroups = True
            .EnableGrouping = True
            .MultiSelect = False

            Me.lv_masterequipment.EnableGrouping = True
            Me.lv_masterequipment.ShowGroups = True
        End With
    End Sub
#End Region
    Private Sub Frm_master_list_equipment_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ThemeResolutionService.ApplicationThemeName = My.Settings.global_themes
        'Farming_Operation.Server_time()

        equipment_column()
        equipment_masterlist_view.equipment_masterlist_listview()

        Dim groupByType As New GroupDescriptor("ownername")
        Me.lv_masterequipment.GroupDescriptors.Add(groupByType)

        Me.dt_dateproof.Value = Frm_main.txt_actualtime.Text
    End Sub

    Private Sub btn_save_Click(sender As Object, e As EventArgs) Handles btn_save.Click
        If command_contxt = 1 Then
            sysmod.Add_equipmentmasterlist(dp_owner_slct_id, dp_type_slct_id, dp_brand_slct_id, Replace(Trim(Me.txt_model.Text), "'", "`"), Replace(Trim(txt_cr_no.Text), "'", "`") _
                                              , Replace(Trim(txt_motorno.Text), "'", "`"), Replace(Trim(txt_serialno.Text), "'", "`"), Replace(Trim(txt_mvfileno.Text), "'", "`"), Replace(Trim(txt_sino.Text), "'", "`") _
                                              , Replace(Trim(txt_drno.Text), "'", "`"), Replace(Trim(txt_others.Text), "'", "`"), Me.dt_dateproof.Value, Me.sp_aqui_cost.Value)
        ElseIf command_contxt = 2 Then
            sysmod.Update_equipmentmasterlist(dp_owner_slct_id, dp_type_slct_id, dp_brand_slct_id, Replace(Trim(Me.txt_model.Text), "'", "`"), Replace(Trim(txt_cr_no.Text), "'", "`") _
                                                         , Replace(Trim(txt_motorno.Text), "'", "`"), Replace(Trim(txt_serialno.Text), "'", "`"), Replace(Trim(txt_mvfileno.Text), "'", "`"), Replace(Trim(txt_sino.Text), "'", "`") _
                                                         , Replace(Trim(txt_drno.Text), "'", "`"), Replace(Trim(txt_others.Text), "'", "`"), Me.dt_dateproof.Value, Me.sp_aqui_cost.Value, slct_id)
        Else
            MsgBox("No command... need administrator assistant")
            Exit Sub
        End If

        If sysmod.msgb <> 1 Then
            MsgBox(sysmod.msgS, vbInformation + vbOKOnly, "AIS: Successful")
            equipment_masterlist_view.main_equipment_enabled()
            equipment_masterlist_view.equipment_masterlist_listview()

            Dim groupByType As New GroupDescriptor("ownername")
            Me.lv_masterequipment.GroupDescriptors.Add(groupByType)
        Else
            MsgBox(sysmod.msgS, vbExclamation + vbOKOnly, "AIS: ERROR...")
        End If
    End Sub

    Private Sub lv_masterequipment_MouseDown(sender As Object, e As MouseEventArgs) Handles lv_masterequipment.MouseDown
        If e.Button = Windows.Forms.MouseButtons.Right Then
            Me.cms_equipment.Show(Me, Me.PointToClient(MousePosition))
        End If
    End Sub

    Private Sub dp_owner_SelectedIndexChanged(sender As Object, e As UI.Data.PositionChangedEventArgs) Handles dp_owner.SelectedIndexChanged
        equipment_masterlist_view.select_dp_owner_equipmain()
        equipment_masterlist_view.dp_equiptype_load()
    End Sub

    Private Sub dp_equiptype_SelectedIndexChanged(sender As Object, e As UI.Data.PositionChangedEventArgs) Handles dp_equiptype.SelectedIndexChanged
        equipment_masterlist_view.select_dp_type_equipmain()
        equipment_masterlist_view.dp_equipbrand_load()
    End Sub

    Private Sub dp_equipbrand_SelectedIndexChanged(sender As Object, e As UI.Data.PositionChangedEventArgs) Handles dp_equipbrand.SelectedIndexChanged
        equipment_masterlist_view.select_dp_brand_equipmain()
    End Sub

    Private Sub refresh_Click(sender As Object, e As EventArgs) Handles refresh.Click
        equipment_masterlist_view.equipment_masterlist_listview()

        Dim groupByType As New GroupDescriptor("ownername")
        Me.lv_masterequipment.GroupDescriptors.Add(groupByType)
    End Sub

    Private Sub add_Click(sender As Object, e As EventArgs) Handles add.Click
        Me.dt_dateproof.Value = Frm_main.txt_actualtime.Text
        equipment_masterlist_view.dp_owner_load()
        equipment_masterlist_view.main_equipment_disabled()

        command_contxt = 1
    End Sub

    Private Sub modify_Click(sender As Object, e As EventArgs) Handles modify.Click
        Me.dt_dateproof.Value = Frm_main.txt_actualtime.Text
        equipment_masterlist_view.dp_owner_load()

        If slct_id = Nothing Then
            MsgBox("No selected data")
        Else
            command_contxt = 2
            equipment_masterlist_view.main_equipment_updatevalue()
            equipment_masterlist_view.main_equipment_disabled()
        End If
    End Sub

    Private Sub remove_Click(sender As Object, e As EventArgs) Handles remove.Click
        sysmod.Delete_equipmentmasterlist(slct_id)
        msgerror = Nothing
    End Sub

    Private Sub btn_cancel_Click(sender As Object, e As EventArgs) Handles btn_cancel.Click
        equipment_masterlist_view.main_equipment_enabled()
    End Sub

    Private Sub lv_masterequipment_SelectedItemChanged(sender As Object, e As EventArgs) Handles lv_masterequipment.SelectedItemChanged
        equipment_masterlist_view.Global_main_equipment_selected()
    End Sub

    Private Sub combar_txt_search_TextChanged(sender As Object, e As EventArgs) Handles combar_txt_search.TextChanged
        equipment_masterlist_view.main_equipment_search(Trim(Me.combar_txt_search.Text))
    End Sub

    Private Sub lv_masterequipment_CellFormatting(sender As Object, e As ListViewCellFormattingEventArgs) Handles lv_masterequipment.CellFormatting
        If TypeOf e.CellElement Is DetailListViewHeaderCellElement Then
            e.CellElement.TextAlignment = ContentAlignment.MiddleLeft
        Else
            e.CellElement.ResetValue(LightVisualElement.TextAlignmentProperty, Telerik.WinControls.ValueResetFlags.Local)
        End If

        If (TypeOf e.CellElement Is DetailListViewDataCellElement) Then
            e.CellElement.TextAlignment = ContentAlignment.MiddleLeft
        End If

        If (e.CellElement).Data.Name = "Count" Then
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
End Class
