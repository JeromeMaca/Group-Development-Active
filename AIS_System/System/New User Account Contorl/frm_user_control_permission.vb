Imports Telerik.WinControls
Imports Telerik.WinControls.Data
Imports AIS_System.System_mod
Imports System.ComponentModel

Public Class Frm_user_control_permission

#Region "LISTVIEW COLUMN"
    Sub menupermission_listview_column()
        Me.lv_useraccountpermission.Columns.Clear()

        With Me.lv_useraccountpermission
            .Columns.Add("id", "")
            .Columns.Add("count", "#")
            .Columns.Add("name", "MENU DESCRIPTION")
            .Columns.Add("userid", "USERID")
            .Columns.Add("permission", "PERMISSION")

            .Columns("id").Visible = False
            .Columns("count").Width = 60
            .Columns("name").Width = 220
            .Columns("userid").Visible = False
            .Columns("permission").Width = 180

            .FullRowSelect = True
            .ShowGroups = True
            .EnableGrouping = True
            .MultiSelect = False

        End With
    End Sub
#End Region
    Private Sub Frm_user_control_permission_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ThemeResolutionService.ApplicationThemeName = My.Settings.global_themes
        'sysmod.Server_time
        user_flag = 0
        menupermission_listview_column()
        user_maintenance_view.menulist_load(usercontrol_id, "", 0)
        btn_back.Enabled = False
    End Sub

    Private Sub Frm_user_control_permission_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        Frm_main.Enabled = True
    End Sub

    Private Sub lv_useraccountpermission_CellFormatting(sender As Object, e As UI.ListViewCellFormattingEventArgs) Handles lv_useraccountpermission.CellFormatting
        user_maintenance_view.lvpermission_cellformatting(e)
    End Sub

    Private Sub lv_useraccountpermission_MouseDown(sender As Object, e As MouseEventArgs) Handles lv_useraccountpermission.MouseDown
        If e.Button = MouseButtons.Right Then
            Me.cms_menuuserpermission.Show(Me, Me.PointToClient(MousePosition))
        End If
    End Sub

    Private Sub btn_next_Click(sender As Object, e As EventArgs) Handles btn_next.Click
        user_flag += 1
        If user_flag = 3 Then
            MsgBox("")
        End If
        Select Case user_flag
            Case 0
                user_maintenance_view.menulist_load(usercontrol_id, "", 0)
                btn_back.Enabled = False
            Case 1
                user_maintenance_view.menulist_load(usercontrol_id, access_id, 1)
                btn_back.Enabled = True
            Case 2
                user_maintenance_view.menulist_load(usercontrol_id, access_id, 2)
                btn_back.Enabled = True
            Case 3
                user_maintenance_view.menulist_load(usercontrol_id, access_id, 3)
                btn_next.Enabled = False
        End Select
    End Sub
    Private Sub lv_useraccountpermission_SelectedItemChanged(sender As Object, e As EventArgs) Handles lv_useraccountpermission.SelectedItemChanged
        user_maintenance_view.access_selected(lv_useraccountpermission)
    End Sub

    Private Sub btn_back_Click(sender As Object, e As EventArgs) Handles btn_back.Click
        user_flag -= 1
        If user_flag = 0 Then
            MsgBox("")
        End If
        Select Case user_flag
            Case 0
                user_maintenance_view.menulist_load(usercontrol_id, "", 0)
                btn_back.Enabled = False
            Case 1
                user_maintenance_view.menulist_load(usercontrol_id, access_id, 1)
                btn_next.Enabled = True
            Case 2
                user_maintenance_view.menulist_load(usercontrol_id, access_id, 2)
                btn_next.Enabled = True
            Case 3
                user_maintenance_view.menulist_load(usercontrol_id, access_id, 3)
                btn_next.Enabled = False
        End Select
    End Sub
End Class
