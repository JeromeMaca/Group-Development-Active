Imports Telerik.WinControls.UI
Imports Telerik.WinControls
Imports AIS_System.site_mod
Imports System.Data.SqlClient

Public Class Frm_addlocation
    Dim mymod As New site_mod

    Private Sub Frm_addlocation_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        Frm_main.Enabled = True
        Farming_Operation.load_combo_location()
    End Sub

    Private Sub btn_save_Click(sender As Object, e As EventArgs) Handles btn_save.Click
        If contextmenu_V = 1 Then
            mymod.Location_NewLocation(Trim(Me.txt_locdesc.Text))
        Else
            mymod.Location_UpdateLocation(Trim(txt_locdesc.Text), Trim(loc_list_id))
        End If

        If mymod.msgb <> 1 Then
            MsgBox(mymod.msgS)
            Farming_Operation.load_location_list()
            Me.txt_locdesc.Text = ""
        Else
            MsgBox(mymod.msgS)
            Me.txt_locdesc.Text = ""
        End If
    End Sub

    Private Sub Frm_addlocation_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Farming_Operation.load_location_list()
    End Sub

    Private Sub lv_location_list_MouseDown(sender As Object, e As MouseEventArgs) Handles lv_location_list.MouseDown
        If e.Button = Windows.Forms.MouseButtons.Right Then
            Me.cms_addlocation.Show(Me, Me.PointToClient(MousePosition))
        End If
    End Sub

    Private Sub AddToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AddToolStripMenuItem.Click
        contextmenu_V = 1
        Me.txt_locdesc.Focus()
    End Sub

    Private Sub UpdateToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles UpdateToolStripMenuItem.Click
        If loc_list_id = Nothing Then
            MsgBox("Select an record please.")
        Else
            contextmenu_V = 2
            updatecategory()
        End If
    End Sub

    Private Sub lv_location_list_ItemSelectionChanged(sender As Object, e As ListViewItemSelectionChangedEventArgs) Handles lv_location_list.ItemSelectionChanged
        If Me.lv_location_list.SelectedItems.Count > 0 Then
            With Me.lv_location_list.SelectedItems(0)
                Me.lv_location_list.Text = .Text
                loc_list_id = .SubItems(0).Text
            End With
        End If
    End Sub

    Private Sub RefreshToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RefreshToolStripMenuItem.Click
        Farming_Operation.load_location_list()
    End Sub

    Private Sub DeleteToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DeleteToolStripMenuItem.Click
        If loc_list_id <> Nothing Then
            If MsgBox("Are you sure you want to delete selected record?", MsgBoxStyle.Question + MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                sql = "DELETE FROM tbl_location_list WHERE id =" & loc_list_id

                Using sqlCnn = New SqlConnection(My.Settings.Conn_string)
                    Using sqlCmd = New SqlCommand(sql, sqlCnn)
                        sqlCmd.Connection.Open()
                        sqlCmd.ExecuteNonQuery()
                    End Using
                End Using
            End If
            sqlCmd.Connection.Close()
            Farming_Operation.load_location_list()
        Else
            MsgBox("Select a record please.")
        End If
        loc_list_id = Nothing
    End Sub

    Sub updatecategory()
        If Me.lv_location_list.SelectedItems.Count > 0 Then
            With Me.lv_location_list.SelectedItems(0)
                Me.lv_location_list.Text = .Text
                Me.txt_locdesc.Text = .SubItems(2).Text
            End With
        End If
    End Sub
End Class
