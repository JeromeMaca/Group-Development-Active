Imports Telerik.WinControls.UI
Imports Telerik.WinControls
Imports AIS_System.System_mod
Imports System.Data.SqlClient
Imports Telerik.WinControls.Data
Imports System.ComponentModel
Imports Telerik.WinControls.Enumerations
Public Class Frm_masterlist_implements
    Dim sysmod As New System_mod
    Dim cur_group As String

#Region "LISTVIEW COLUMN"
    Sub implement_column()
        Me.lv_masterimplement.Columns.Clear()

        With Me.lv_masterimplement
            .Columns.Add("Id", "")
            .Columns.Add("Count", "#")
            .Columns.Add("owner_name", "OWNER NAME")
            .Columns.Add("implement", "IMPLEMENTS")
            .Columns.Add("code", "CODE")
            .Columns.Add("code_name", "CODE DESCRIPTION")

            .Columns("Id").Width = 0
            .Columns("Id").Visible = False
            .Columns("Count").Width = 60
            .Columns("owner_name").Width = 230
            .Columns("implement").Width = 220
            .Columns("code").Width = 150
            .Columns("code_name").Width = 350



            .FullRowSelect = True
            '.ShowGridLines = True
            .ShowGroups = True
            .EnableGrouping = True
            .MultiSelect = False

            Me.lv_masterimplement.EnableGrouping = True
            Me.lv_masterimplement.ShowGroups = True
        End With
    End Sub
#End Region

    Private Sub Frm_masterlist_implements_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ThemeResolutionService.ApplicationThemeName = My.Settings.global_themes
        'Farming_Operation.Server_time()

        implement_column()
        implement_masterlist_view.implement_listview()
        Me.combar_dp_group.SelectedIndex = 1
    End Sub

    Private Sub lv_masterimplement_MouseDown(sender As Object, e As MouseEventArgs) Handles lv_masterimplement.MouseDown
        If e.Button = Windows.Forms.MouseButtons.Right Then
            Me.cms_implement.Show(Me, Me.PointToClient(MousePosition))
        End If
    End Sub

    Private Sub lv_masterimplement_CellFormatting(sender As Object, e As ListViewCellFormattingEventArgs) Handles lv_masterimplement.CellFormatting
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

    Private Sub combar_dp_group_SelectedIndexChanged(sender As Object, e As UI.Data.PositionChangedEventArgs) Handles combar_dp_group.SelectedIndexChanged
        Me.lv_masterimplement.GroupDescriptors.Clear()
        Select Case Me.combar_dp_group.SelectedIndex
            Case 0
                cur_group = "owner_name "
            Case 1
                cur_group = "implement"
        End Select

        Dim groupByType As New GroupDescriptor(cur_group)
        Me.lv_masterimplement.GroupDescriptors.Add(groupByType)
    End Sub

    Private Sub add_Click(sender As Object, e As EventArgs) Handles add.Click
        command_contxt = 1

        implement_masterlist_view.main_implement_disabled()
        implement_masterlist_view.dp_owner_load()
    End Sub

    Private Sub dp_owner_SelectedIndexChanged(sender As Object, e As UI.Data.PositionChangedEventArgs) Handles dp_owner.SelectedIndexChanged
        implement_masterlist_view.dp_implementlist_load()
        implement_masterlist_view.main_imple_select_dp_owner()
    End Sub

    Private Sub btn_cancel_Click(sender As Object, e As EventArgs) Handles btn_cancel.Click
        implement_masterlist_view.main_implement_enabled()
        implement_masterlist_view.imple_clear_field()
    End Sub

    Private Sub btn_save_Click(sender As Object, e As EventArgs) Handles btn_save.Click
        If command_contxt = 1 Then
            sysmod.Add_implementmasterlist(dp_owner_id, dp_list_id, Replace(Trim(Me.txt_code.Text), "'", "`"), Replace(Trim(Me.txt_desc.Text), "'", "`"))
        ElseIf command_contxt = 2 Then
            sysmod.Update_implementmasterlist(dp_owner_id, dp_list_id, Replace(Trim(Me.txt_code.Text), "'", "`"), Replace(Trim(Me.txt_desc.Text), "'", "`"), slct_id)
        Else
            MsgBox("No command... need administrator assistant")
            Exit Sub
        End If

        If sysmod.msgb <> 1 Then
            MsgBox(sysmod.msgS, vbInformation + vbOKOnly, "AIS: Successful")
            implement_masterlist_view.main_implement_enabled()
            implement_masterlist_view.imple_clear_field()
            implement_masterlist_view.implement_listview()
        Else
            MsgBox(sysmod.msgS, vbExclamation + vbOKOnly, "AIS: ERROR...")
        End If
    End Sub

    Private Sub dp_implelist_SelectedIndexChanged(sender As Object, e As UI.Data.PositionChangedEventArgs) Handles dp_implelist.SelectedIndexChanged
        implement_masterlist_view.main_imple_select_dp_list()
    End Sub

    Private Sub refresh_Click(sender As Object, e As EventArgs) Handles refresh.Click
        implement_masterlist_view.implement_listview()
    End Sub

    Private Sub modify_Click(sender As Object, e As EventArgs) Handles modify.Click
        If slct_id = Nothing Then
            MsgBox("No selected data")
        Else
            implement_masterlist_view.dp_owner_load()
            command_contxt = 2
            implement_masterlist_view.main_implement_updatevalue()
            implement_masterlist_view.main_implement_disabled()
        End If
    End Sub

    Private Sub lv_masterimplement_SelectedItemChanged(sender As Object, e As EventArgs) Handles lv_masterimplement.SelectedItemChanged
        implement_masterlist_view.Global_loc_masterlist_selected()
    End Sub

    Private Sub remove_Click(sender As Object, e As EventArgs) Handles remove.Click
        sysmod.Delete_implementmasterlist(slct_id)
        msgerror = Nothing
    End Sub

    Private Sub combar_txt_search_TextChanged(sender As Object, e As EventArgs) Handles combar_txt_search.TextChanged
        implement_masterlist_view.main_implement_search(Replace(Trim(Me.combar_txt_search.Text), "'", "`"))
    End Sub
End Class
