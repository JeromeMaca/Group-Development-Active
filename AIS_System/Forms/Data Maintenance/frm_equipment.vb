Imports Telerik.WinControls.UI
Imports Telerik.WinControls
Imports AIS_System.site_mod
Imports System.Data.SqlClient
Public Class Frm_equipment
    Dim mymod As New site_mod
    Dim cb_owner As Integer
    Private Sub btn_save_Click(sender As Object, e As EventArgs) Handles btn_save.Click
        If contextmenu_V = 1 Then
            mymod.Equipment_NewEquipment(Trim(ownername_id), Trim(txt_equipmentno.Text), Trim(txt_equipment_desc.Text), Trim(txt_equipmentdriver.Text), Trim(txt_equipmentfuelcapacity.Text))
        Else
            'mymod.Equipment_UpdateOwnerName(Trim(ownername_id), Trim(Me.txt_name.Text))
            mymod.Equipment_UpdateEquipment(Trim(equip_id), Trim(ownername_id), Trim(Me.txt_equipmentno.Text), Trim(Me.txt_equipment_desc.Text), Trim(Me.txt_equipmentdriver.Text), Trim(Me.txt_equipmentfuelcapacity.Text))
        End If

        If mymod.msgb <> 1 Then
            MsgBox(mymod.msgS)
            Farming_Operation.load_equipment_v()
            Me.cb_equipment_owner.SelectedValue = ""
            Me.cb_ownername.SelectedValue = ""
            Me.txt_equipmentno.Text = ""
            Me.txt_equipment_desc.Text = ""
            Me.txt_equipmentdriver.Text = ""
            Me.txt_equipmentfuelcapacity.Text = ""
            equip_id = Nothing
        Else
            MsgBox(mymod.msgS)
            Me.cb_equipment_owner.SelectedValue = ""
            Me.cb_ownername.SelectedValue = ""
            Me.txt_equipmentno.Text = ""
            Me.txt_equipment_desc.Text = ""
            Me.txt_equipmentdriver.Text = ""
            Me.txt_equipmentfuelcapacity.Text = ""
            equip_id = Nothing
        End If
    End Sub
    Private Sub cb_equipment_owner_SelectedIndexChanged(sender As Object, e As UI.Data.PositionChangedEventArgs) Handles cb_equipment_owner.SelectedIndexChanged
        Select Case Me.cb_equipment_owner.SelectedIndex
            Case 0
                equipment_ownerid = "1"
            Case 1
                equipment_ownerid = "2"
            Case 2
                equipment_ownerid = "3"
        End Select

        Farming_Operation.mainequipment_loadnames()

        Select Case equipment_ownerid
            Case 1
                Me.cb_ownername.SelectedIndex = 0
            Case 2
                Me.cb_ownername.SelectedIndex = 0
            Case 3
                ' Me.cb_ownername.SelectedIndex = Nothing
        End Select
    End Sub

    Private Sub btn_addname_Click(sender As Object, e As EventArgs) Handles btn_addname.Click
        'Frm_addownername.Show()
        'Frm_main.Enabled = False
    End Sub

    Private Sub cb_ownername_SelectedIndexChanged(sender As Object, e As UI.Data.PositionChangedEventArgs) Handles cb_ownername.SelectedIndexChanged
        Farming_Operation.main_select_ownername()
    End Sub

    Private Sub Frm_equipment_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Farming_Operation.load_equipment_v()
    End Sub

    Private Sub lv_equipments_MouseDown(sender As Object, e As MouseEventArgs) Handles lv_equipments.MouseDown
        If e.Button = Windows.Forms.MouseButtons.Right Then
            Me.cms_equipmentcon.Show(Me, Me.PointToClient(MousePosition))
        End If
    End Sub

    Private Sub RefreshToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RefreshToolStripMenuItem.Click
        Farming_Operation.load_equipment_v()
    End Sub

    Private Sub DeleteToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DeleteToolStripMenuItem.Click
        If equip_id <> Nothing Then
            Try
                If MsgBox("Are you sure you want to delete selected record?", MsgBoxStyle.Question + MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                    sql = "DELETE FROM tbl_equipments WHERE owner_id =" & equip_id

                    Using sqlCnn = New SqlConnection(My.Settings.Conn_string)
                        Using sqlCmd = New SqlCommand(sql, sqlCnn)
                            With sqlCmd
                                .Connection.Open()
                                .ExecuteNonQuery()
                            End With
                        End Using
                    End Using
                    sqlCmd.Connection.Close()
                    equip_id = Nothing
                End If
                Farming_Operation.load_equipment_v()
            Catch ex As Exception
                MsgBox(ex.Message.ToString(), vbInformation, "ERROR!!!")
            End Try
        Else
            MsgBox("Select a record please.")
        End If
    End Sub

    Private Sub lv_equipments_ItemSelectionChanged(sender As Object, e As ListViewItemSelectionChangedEventArgs) Handles lv_equipments.ItemSelectionChanged
        If Me.lv_equipments.SelectedItems.Count > 0 Then
            With Me.lv_equipments.SelectedItems(0)
                .Text = .Text
                equip_id = .SubItems(0).Text
            End With
        End If
    End Sub

    Private Sub AddToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AddToolStripMenuItem.Click
        contextmenu_V = 1
    End Sub

    Private Sub UpdateToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles UpdateToolStripMenuItem.Click
        If equip_id = Nothing Then
            MsgBox("Select an record please.")
        Else
            contextmenu_V = 2
            updateequipments()
        End If
    End Sub

    Sub updateequipments()
        If Me.lv_equipments.SelectedItems.Count > 0 Then
            With Me.lv_equipments.SelectedItems(0)
                .Text = .Text
                equip_id = .SubItems(0).Text
                cb_owner = .SubItems(7).Text

                If cb_owner = "1" Then
                    Me.cb_equipment_owner.SelectedValue = "CAT - Central Azucarera De Tarlac"
                ElseIf cb_owner = "2" Then
                    Me.cb_equipment_owner.SelectedValue = "Agrikulto Inc."
                Else
                    Me.cb_equipment_owner.SelectedValue = "SUBCON"

                    Me.cb_ownername.SelectedValue = .SubItems(2).Text.ToString()
                End If
                Me.txt_equipmentno.Text = .SubItems(3).Text.ToString()
                Me.txt_equipment_desc.Text = .SubItems(4).Text.ToString()
                Me.txt_equipmentdriver.Text = .SubItems(5).Text.ToString()
                Me.txt_equipmentfuelcapacity.Text = .SubItems(6).Text.ToString()
            End With
        End If
    End Sub

    Private Sub btn_cancel_Click(sender As Object, e As EventArgs) Handles btn_cancel.Click
        Me.cb_equipment_owner.SelectedItem = Nothing
        Me.cb_ownername.SelectedItem = Nothing
        Me.txt_equipmentno.Text = ""
        Me.txt_equipment_desc.Text = ""
        Me.txt_equipmentdriver.Text = ""
        Me.txt_equipmentfuelcapacity.Text = ""
        equip_id = Nothing
    End Sub
End Class
