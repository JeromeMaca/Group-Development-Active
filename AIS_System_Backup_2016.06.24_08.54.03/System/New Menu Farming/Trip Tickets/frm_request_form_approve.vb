Imports Telerik.WinControls.UI
Imports Telerik.WinControls
Imports AIS_System.System_mod
Imports System.Data.SqlClient
Imports Telerik.WinControls.Data
Imports System.ComponentModel

Public Class Frm_request_form_approve

    Dim ctr As Integer = 0
    Dim driver As String
    Dim sysmod As New System_mod


#Region "LISTVIEW COLUMN"
    Sub equipment_column()
        Me.lv_equipments.Columns.Clear()

        With Me.lv_equipments
            .Columns.Add("Id", "")
            .Columns.Add("Count", "#")
            .Columns.Add("onwer_name", "EQUIPMENT OWNER")
            .Columns.Add("equip_type", "EQUIPMENT TYPE")
            .Columns.Add("model", "MODEL")
            .Columns.Add("status", "STATUS")

            .Columns("Id").Width = 0
            .Columns("Id").Visible = False
            .Columns("Count").Width = 60
            .Columns("onwer_name").Width = 200
            .Columns("onwer_name").Visible = False
            .Columns("equip_type").Width = 220
            .Columns("model").Width = 150
            .Columns("status").Width = 130


            .FullRowSelect = True
            '.ShowGridLines = True
            .MultiSelect = False

            Me.lv_equipments.EnableGrouping = True
            Me.lv_equipments.ShowGroups = True
        End With
    End Sub

    Sub implement_column()
        Me.lv_implements.Columns.Clear()

        With Me.lv_implements
            .Columns.Add("Id", "")
            .Columns.Add("Count", "#")
            .Columns.Add("onwer_name", "IMPLEMENT OWNER")
            .Columns.Add("imple_desc", "IMPLEMENT TYPE")
            .Columns.Add("code", "CODE")
            .Columns.Add("status", "STATUS")

            .Columns("Id").Width = 0
            .Columns("Id").Visible = False
            .Columns("Count").Width = 60
            .Columns("onwer_name").Width = 200
            .Columns("onwer_name").Visible = False
            .Columns("imple_desc").Width = 300
            .Columns("code").Width = 100
            .Columns("status").Width = 130

            .FullRowSelect = True
            '.ShowGridLines = True
            .MultiSelect = False

            Me.lv_implements.EnableGrouping = True
            Me.lv_implements.ShowGroups = True
        End With
    End Sub
#End Region
    Private Sub Frm_request_form_approve_Load(sender As Object, e As EventArgs) Handles Me.Load
        ThemeResolutionService.ApplicationThemeName = My.Settings.global_themes
        'Farming_Operation.Server_time()

        AddHandler Me.pvp_aprroval_request.SelectedPageChanged, New System.EventHandler(AddressOf pvp_aprroval_request_SelectedPageChanged)

        request_form_view.dp_driver_load()
        request_form_view.driver_validity()

        If driver_validitys <> 0 Then
            Me.dp_driver.Enabled = False
            driver_id = Nothing
            Me.dp_driver.NullText = "<Already assigned a Driver>"
        End If
    End Sub

    Private Sub Frm_request_form_approve_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        Frm_main.Enabled = True
        request_form_view.trip_ticket_listview_load()
        slct_id_req_hdr = 0
    End Sub

    Private Sub pvp_aprroval_request_SelectedPageChanged(sender As Object, e As EventArgs) Handles pvp_aprroval_request.SelectedPageChanged
        ctr += 1
        If ctr <= 1 Then
            Me.tp_load.Enabled = True
        End If
        If ctr >= 2 Then
            If Me.pvp_aprroval_request.Pages.IndexOf(Me.pvp_aprroval_request.SelectedPage).ToString() = "0" Then
                equipment_column()
                request_form_view.equipment_listview()
                grouping()
            ElseIf Me.pvp_aprroval_request.Pages.IndexOf(Me.pvp_aprroval_request.SelectedPage).ToString() = "1" Then
                implement_column()
                request_form_view.implement_listview()
                grouping()
            End If
        End If
    End Sub

    Private Sub tp_load_Tick(sender As Object, e As EventArgs) Handles tp_load.Tick
        If Me.pvp_aprroval_request.SelectedPage Is pvp_page1 Then
            equipment_column()
            request_form_view.equipment_listview()
            grouping()
            Me.tp_load.Enabled = False
            'ElseIf Me.pvp_aprroval_request.SelectedPage Is pvp_page2 Then
            '    implement_column()
            '    request_form_view.implement_listview()
            '    grouping()
            '    Me.tp_load.Enabled = False
        End If
    End Sub

    Sub grouping()
        'Me.lv_equipments.GroupDescriptors.Clear()
        'Dim groupByType As New GroupDescriptor(New SortDescriptor() {New SortDescriptor("onwer_name", ListSortDirection.Descending)})
        'lv_equipments.GroupDescriptors.Add(groupByType)

        If Me.pvp_aprroval_request.SelectedPage Is pvp_page1 Then
            Me.lv_equipments.GroupDescriptors.Clear()
            Dim groupByType As New GroupDescriptor(New SortDescriptor() {New SortDescriptor("onwer_name", ListSortDirection.Ascending)})
            lv_equipments.GroupDescriptors.Add(groupByType)
        ElseIf Me.pvp_aprroval_request.SelectedPage Is pvp_page2 Then
            Me.lv_implements.GroupDescriptors.Clear()
            Dim groupByType As New GroupDescriptor(New SortDescriptor() {New SortDescriptor("onwer_name", ListSortDirection.Ascending)})
            lv_implements.GroupDescriptors.Add(groupByType)
        End If
    End Sub

    Private Sub lv_equipments_CellFormatting(sender As Object, e As ListViewCellFormattingEventArgs) Handles lv_equipments.CellFormatting
        If TypeOf e.CellElement Is DetailListViewHeaderCellElement Then
            e.CellElement.TextAlignment = ContentAlignment.MiddleCenter
        Else
            e.CellElement.ResetValue(LightVisualElement.TextAlignmentProperty, Telerik.WinControls.ValueResetFlags.Local)
        End If

        If (TypeOf e.CellElement Is DetailListViewDataCellElement) Then
            e.CellElement.TextAlignment = ContentAlignment.MiddleCenter
        End If

        If (TypeOf e.CellElement Is DetailListViewCellElement) Then
            e.CellElement.DrawFill = False
            e.CellElement.DrawBorder = False
        Else
            e.CellElement.ResetValue(LightVisualElement.DrawBorderProperty, Telerik.WinControls.ValueResetFlags.Local)
            e.CellElement.ResetValue(LightVisualElement.DrawFillProperty, Telerik.WinControls.ValueResetFlags.Local)
        End If
    End Sub

    Private Sub lv_implements_CellFormatting(sender As Object, e As ListViewCellFormattingEventArgs) Handles lv_implements.CellFormatting
        If TypeOf e.CellElement Is DetailListViewHeaderCellElement Then
            e.CellElement.TextAlignment = ContentAlignment.MiddleCenter
        Else
            e.CellElement.ResetValue(LightVisualElement.TextAlignmentProperty, Telerik.WinControls.ValueResetFlags.Local)
        End If

        If (TypeOf e.CellElement Is DetailListViewDataCellElement) Then
            e.CellElement.TextAlignment = ContentAlignment.MiddleCenter
        End If

        If (TypeOf e.CellElement Is DetailListViewCellElement) Then
            e.CellElement.DrawFill = False
            e.CellElement.DrawBorder = False
        Else
            e.CellElement.ResetValue(LightVisualElement.DrawBorderProperty, Telerik.WinControls.ValueResetFlags.Local)
            e.CellElement.ResetValue(LightVisualElement.DrawFillProperty, Telerik.WinControls.ValueResetFlags.Local)
        End If
    End Sub

    'Private Sub lv_equipments_SelectedItemChanged(sender As Object, e As EventArgs) Handles lv_equipments.SelectedItemChanged
    '    request_form_view.equipment_slct_listview()
    'End Sub

    'Private Sub lv_implements_SelectedItemChanged(sender As Object, e As EventArgs) Handles lv_implements.SelectedItemChanged
    '    request_form_view.implement_slct_listview()
    'End Sub

    Private Sub btn_lockin_equipment_Click(sender As Object, e As EventArgs) Handles btn_lockin_equipment.Click
        If Me.btn_lockin_equipment.Text = "LOCK IN" Then
            request_form_view.equipment_slct_listview()
            If Me.txt_equipment_type.Text = "" Then
                MsgBox("Select Equipment Please.")
                Me.txt_equipment_type.Text = ""
                Me.txt_equipment_no.Text = ""
                Exit Sub
            End If
            If equip_stats = "NOT AVAILABLE" Then
                MsgBox("The selected Equipment is Not Available.")
                Me.txt_equipment_type.Text = ""
                Me.txt_equipment_no.Text = ""
                Exit Sub
            End If
            Me.btn_lockin_equipment.Text = "LOCK OUT"
            Me.lv_equipments.Enabled = False
        Else
            Me.txt_equipment_type.Text = ""
            Me.txt_equipment_no.Text = ""
            Me.btn_lockin_equipment.Text = "LOCK IN"
            Me.lv_equipments.Enabled = True
            approval_equip_ids = Nothing
        End If
    End Sub
    Private Sub btn_lock_in_implement_Click(sender As Object, e As EventArgs) Handles btn_lock_in_implement.Click
        If Me.btn_lock_in_implement.Text = "LOCK IN" Then
            request_form_view.implement_slct_listview()
            If Me.txt_implement_type.Text = "" Then
                MsgBox("Select Implement Please.")
                Me.txt_implement_type.Text = ""
                Me.txt_imple_no.Text = ""
                Exit Sub
            End If
            If imple_stats = "NOT AVAILABLE" Then
                MsgBox("The selected Implement is Not Available.")
                Me.txt_implement_type.Text = ""
                Me.txt_imple_no.Text = ""
                Exit Sub
            End If
            Me.btn_lock_in_implement.Text = "LOCK OUT"
            Me.lv_implements.Enabled = False
        Else
            Me.txt_implement_type.Text = ""
            Me.txt_imple_no.Text = ""
            Me.btn_lock_in_implement.Text = "LOCK IN"
            Me.lv_implements.Enabled = True
            approval_imple_ids = Nothing
        End If
    End Sub
    Private Sub btn_refresh_equipment_Click(sender As Object, e As EventArgs) Handles btn_refresh_equipment.Click
        request_form_view.equipment_listview()
    End Sub

    Private Sub btn_refresh_implement_Click(sender As Object, e As EventArgs) Handles btn_refresh_implement.Click
        request_form_view.implement_listview()
    End Sub

    Private Sub dp_driver_SelectedIndexChanged(sender As Object, e As UI.Data.PositionChangedEventArgs) Handles dp_driver.SelectedIndexChanged
        request_form_view.driver()
    End Sub

    Private Sub btn_ST_save_Click(sender As Object, e As EventArgs) Handles btn_ST_save.Click
        Try
            If Me.dp_driver.NullText = "<Already assigned a Driver>" Then
                driver = ""
            Else
                driver = Me.dp_driver.SelectedItem.ToString
            End If

            sysmod.approve_request(hdr_id_approval, dtl_id_approval, lot_id_approval, Replace(Trim(Me.txt_reqno.Text), "'", "`"), "", dt_ST_date.Value, Replace(Trim(Me.txt_equipment_type.Text), "'", "`") _
                                   , Replace(Trim(Me.txt_equipment_no.Text), "'", "`"), Replace(Trim(Me.txt_implement_type.Text), "'", "`"), Replace(Trim(Me.txt_imple_no.Text), "'", "`") _
                                   , driver, Replace(Trim(Me.txt_ST_purpose.Text), "'", "`"), dt_ST_neededdate.Value, tp_ST_neededtime.Value _
                                   , Replace(Trim(Me.txt_ST_requestedby.Text), "'", "`"), Replace(Trim(Frm_main.txt_fullname.Text), "'", "`"), Replace(Trim(Me.txt_lotno.Text), "'", "`") _
                                   , Replace(Trim(Me.txt_workoperation.Text), "'", "`"), approval_equip_ids, approval_imple_ids, driver_id, user_id)

            If sysmod.msgb <> 1 Then
                MsgBox(sysmod.msgS, vbInformation + vbOKOnly, "AIS: DONE.")
                request_form_view.requested_form_listview()
            Else
                MsgBox(sysmod.msgS, vbExclamation + vbOKOnly, "AIS: ERROR...")
            End If
        Catch ex As Exception
            MsgBox(ex.Message.ToString)
        End Try


    End Sub

    Private Sub lv_equipments_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lv_equipments.SelectedIndexChanged
        request_form_view.approval_equip_id()
    End Sub

    Private Sub lv_implements_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lv_implements.SelectedIndexChanged
        request_form_view.approval_imple_id()
    End Sub
End Class
