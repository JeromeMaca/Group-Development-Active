Imports Telerik.WinControls
Imports Telerik.WinControls.Data
Imports AIS_System.System_mod

Public Class Frm_user_control_maintenace
    Dim sysmod As System_mod

#Region "LISTVIEW COLUMN"
    Sub userlist_listview_column()
        Me.lv_useraccountlist.Columns.Clear()

        With Me.lv_useraccountlist
            .Columns.Add("id", "")
            .Columns.Add("count", "#")
            .Columns.Add("username", "USERNAME")
            .Columns.Add("password", "PASSWORD")
            .Columns.Add("userfirstname", "FIRST NAME")
            .Columns.Add("usermiddlename", "MIDDLE NAME")
            .Columns.Add("userlastname", "LAST NAME")
            .Columns.Add("usertype", "USER TYPE")


            .Columns("id").Visible = False
            .Columns("count").Width = 60
            .Columns("username").Width = 180
            .Columns("password").Width = 180
            .Columns("userfirstname").Width = 180
            .Columns("usermiddlename").Width = 180
            .Columns("userlastname").Width = 180
            .Columns("usertype").Width = 180


            .FullRowSelect = True
            .ShowGroups = True
            .EnableGrouping = True
            .MultiSelect = False

        End With
    End Sub
#End Region
    Private Sub Frm_user_control_maintenace_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ThemeResolutionService.ApplicationThemeName = My.Settings.global_themes
        'sysmod.Server_time()

        userlist_listview_column()
        refreshuser.PerformClick()
    End Sub

    Private Sub lv_useraccountlist_MouseDown(sender As Object, e As MouseEventArgs) Handles lv_useraccountlist.MouseDown
        If e.Button = Windows.Forms.MouseButtons.Right Then
            Me.cms_usermenu.Show(Me, Me.PointToClient(MousePosition))
        End If
    End Sub

    Private Sub lv_useraccountlist_CellFormatting(sender As Object, e As UI.ListViewCellFormattingEventArgs) Handles lv_useraccountlist.CellFormatting
        user_maintenance_view.lv_cellformatting(e)
    End Sub

    Private Sub refreshuser_Click(sender As Object, e As EventArgs) Handles refreshuser.Click
        user_maintenance_view.userlist_load()

        Me.lv_useraccountlist.GroupDescriptors.Clear()
        Dim groupByType As New GroupDescriptor("usertype")
        Me.lv_useraccountlist.GroupDescriptors.Add(groupByType)
    End Sub

    Private Sub createuser_Click(sender As Object, e As EventArgs) Handles createuser.Click
        command_contxt = 1
        user_maintenance_view.usercontrol_disabled()
    End Sub

    Private Sub modifyuser_Click(sender As Object, e As EventArgs) Handles modifyuser.Click
        If slct_id = Nothing Then
            MsgBox("No selected data")
        Else
            command_contxt = 2
            user_maintenance_view.usercontrol_updatevalue()
            user_maintenance_view.usercontrol_disabled()
        End If
    End Sub

    Private Sub removeuser_Click(sender As Object, e As EventArgs) Handles removeuser.Click
        'sysmod.Delete_workoperationmasterlist(slct_id)
        msgerror = Nothing
    End Sub

    Private Sub btn_saveuser_Click(sender As Object, e As EventArgs) Handles btn_saveuser.Click
        Dim name As String = Frm_main.txt_fullname.Text
        If command_contxt = 1 Then
            sysmod.Add_useraccount(Replace(Trim(txt_username.Text), "'", "`"), Replace(Trim(txt_confirm_pass.Text), "'", "`"), Replace(Trim(txt_fname.Text), "'", "`"), Replace(Trim(txt_mname.Text), "'", "`"), Replace(Trim(txt_lname.Text), "'", "`"), dp_usertype.SelectedItem.ToString, name)
        ElseIf command_contxt = 2 Then
            'sysmod.Update_workoperationmasterlist(dp_cat_slct_id, Replace(Trim(Me.txt_workoperation.Text), "'", "`"), Replace(Trim(Me.txt_unitmeasure.Text), "'", "`"), Trim(Me.txt_ratecost.Value), slct_id)
        Else
            MsgBox("No command... need administrator assistant")
            Exit Sub
        End If

        If sysmod.msgb <> 1 Then
            MsgBox(sysmod.msgS, vbInformation + vbOKOnly, "AIS: Successful")
            ' operation_masterlist_view.main_workoperation_enabled()
            'operation_masterlist_view.operation_clear_field()
            ' operation_masterlist_view.work_operation_listview()
        Else
            MsgBox(sysmod.msgS, vbExclamation + vbOKOnly, "AIS: ERROR...")
        End If
    End Sub

    Private Sub btn_canceluser_Click(sender As Object, e As EventArgs) Handles btn_canceluser.Click
        user_maintenance_view.usercontrol_enabled()
        user_maintenance_view.usercontrol_clear_field()
    End Sub
End Class
