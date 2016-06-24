Imports Telerik.WinControls
Imports Telerik.WinControls.Data
Imports AIS_System.System_mod
Imports System.ComponentModel

Public Class Frm_user_control_permission
    Private Sub Frm_user_control_permission_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        Frm_main.Enabled = True
    End Sub

    Private Sub Frm_user_control_permission_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        user_maintenance_view.buildtree(user_maintenance_view.CreateDataTable, Me.tv_useraccessmenu, True)

        'FIND NODES
        For i As Integer = 0 To tv_useraccessmenu.Nodes.Count - 1
            user_maintenance_view.browseTreeNodes(tv_useraccessmenu.Nodes(i), 0)
        Next
    End Sub

    Private Sub tv_useraccessmenu_NodeFormatting(sender As Object, e As UI.TreeNodeFormattingEventArgs) Handles tv_useraccessmenu.NodeFormatting
        user_maintenance_view.tv_format(e)
    End Sub
End Class
