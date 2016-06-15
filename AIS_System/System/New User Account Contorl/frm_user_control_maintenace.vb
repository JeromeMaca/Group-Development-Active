Imports Telerik.WinControls

Public Class Frm_user_control_maintenace

#Region "LISTVIEW COLUMN"
    Sub userlist_listview_column()
        Me.lv_useraccountlist.Columns.Clear()

        With Me.lv_useraccountlist
            .Columns.Add("count", "#")
            .Columns.Add("username", "USERNAME")
            .Columns.Add("password", "PASSWORD")
            .Columns.Add("userfirstname", "FIRST NAME")
            .Columns.Add("usermiddlename", "MIDDLE NAME")
            .Columns.Add("userlastname", "LAST NAME")
            .Columns.Add("usertype", "USER TYPE")



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
    End Sub

    Private Sub lv_useraccountlist_MouseDown(sender As Object, e As MouseEventArgs) Handles lv_useraccountlist.MouseDown
        If e.Button = MouseButtons.Right Then
            Me.cms_usermenu.Show(Me, Me.PointToClient(MousePosition))
        End If
    End Sub
End Class
