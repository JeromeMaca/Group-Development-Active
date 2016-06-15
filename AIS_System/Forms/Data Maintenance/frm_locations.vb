Imports Telerik.WinControls.UI
Imports Telerik.WinControls
Imports AIS_System.site_mod
Imports System.Data.SqlClient

Public Class Frm_locations
    Dim mymod As New site_mod
    Private Sub btn_add_Click(sender As Object, e As EventArgs) Handles btn_add.Click
        'Frm_main.Enabled = False
        'Frm_addlocation.Show()
    End Sub

    Private Sub Frm_locations_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Farming_Operation.load_combo_location()
        Farming_Operation.Load_locationMasterList()
    End Sub

    Private Sub btn_save_Click(sender As Object, e As EventArgs) Handles btn_save.Click
        If contextmenu_V = 1 Then
            mymod.Location_add(Trim(Me.txt_code.Text), Trim(Select_loc_list_id), Trim(Me.sp_area.Value), Trim(Me.txt_culture.Text))
        Else
            mymod.Location_Update(loc_master_id, (Me.txt_code.Text), Trim(Select_loc_list_id), Trim(Me.sp_area.Value), Trim(Me.txt_culture.Text))
        End If

        If mymod.msgb <> 1 Then
            MsgBox(mymod.msgS)
            Farming_Operation.Load_locationMasterList()
            Me.txt_code.Text = ""
            Me.cb_loc_desc.SelectedValue = Nothing
            Me.sp_area.Value = 0
            Me.txt_culture.Text = ""
        Else
            MsgBox(mymod.msgS)
            Me.txt_code.Text = ""
            Me.cb_loc_desc.SelectedValue = Nothing
            Me.sp_area.Value = 0
            Me.txt_culture.Text = ""
        End If
    End Sub

    Private Sub cb_loc_desc_SelectedIndexChanged(sender As Object, e As UI.Data.PositionChangedEventArgs) Handles cb_loc_desc.SelectedIndexChanged
        Farming_Operation.Select_Combo_location_list()
    End Sub

    Private Sub lv_location_MouseDown(sender As Object, e As MouseEventArgs) Handles lv_location.MouseDown
        If e.Button = Windows.Forms.MouseButtons.Right Then
            Me.cms_locationMaster.Show(Me, Me.PointToClient(MousePosition))
        End If
    End Sub

    Private Sub DeleteToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DeleteToolStripMenuItem.Click
        If loc_master_id <> Nothing Then
            If MsgBox("Are you sure you want to delete selected record?", MsgBoxStyle.Question + MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                sql = "DELETE FROM tbl_location WHERE id =" & loc_master_id

                Using sqlCnn = New SqlConnection(My.Settings.Conn_string)
                    Using sqlCmd = New SqlCommand(sql, sqlCnn)
                        sqlCmd.Connection.Open()
                        sqlCmd.ExecuteNonQuery()
                    End Using
                End Using
            End If
            sqlCmd.Connection.Close()
            Farming_Operation.Load_locationMasterList()
        Else
            MsgBox("Select a record please.")
        End If
        loc_master_id = Nothing
    End Sub

    Private Sub lv_location_ItemSelectionChanged(sender As Object, e As ListViewItemSelectionChangedEventArgs) Handles lv_location.ItemSelectionChanged
        If Me.lv_location.SelectedItems.Count > 0 Then
            With Me.lv_location.SelectedItems(0)
                Me.lv_location.Text = .Text
                loc_master_id = .SubItems(0).Text
            End With
        End If
    End Sub

    Private Sub RefreshToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RefreshToolStripMenuItem.Click
        Farming_Operation.Load_locationMasterList()
    End Sub

    Private Sub AddToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AddToolStripMenuItem.Click
        contextmenu_V = 1
        Me.txt_code.Focus()
    End Sub

    Private Sub UpdateToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles UpdateToolStripMenuItem.Click
        If loc_master_id = Nothing Then
            MsgBox("Select an record please.")
        Else
            contextmenu_V = 2
            updatecategory()
            Me.txt_code.Focus()
        End If
    End Sub

    Sub updatecategory()
        If Me.lv_location.SelectedItems.Count > 0 Then
            With Me.lv_location.SelectedItems(0)
                Me.lv_location.Text = .Text
                Me.txt_code.Text = .SubItems(2).Text
                Me.cb_loc_desc.SelectedValue = .SubItems(3).Text
                Me.sp_area.Value = .SubItems(4).Text
                Me.txt_culture.Text = .SubItems(5).Text
            End With
        End If
    End Sub

    Private Sub btn_cancel_Click(sender As Object, e As EventArgs) Handles btn_cancel.Click
        Me.txt_code.Text = ""
        Farming_Operation.load_combo_location()
        Me.sp_area.Value = 0
        Me.txt_culture.Text = ""
        Farming_Operation.Load_locationMasterList()
    End Sub
End Class