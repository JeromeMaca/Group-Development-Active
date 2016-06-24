Imports Telerik.WinControls.UI
Imports Telerik.WinControls
Imports AIS_System.site_mod
Imports System.Data.SqlClient

Public Class Frm_addownername
    Dim mymod As New site_mod

    Private Sub lv_ownername_MouseDown(sender As Object, e As MouseEventArgs) Handles lv_ownername.MouseDown
        If e.Button = Windows.Forms.MouseButtons.Right Then
            Me.cms_name.Show(Me, Me.PointToClient(MousePosition))
        End If
    End Sub

    Private Sub Frm_addownername_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        Frm_main.Enabled = True
    End Sub

    Private Sub btn_save_Click(sender As Object, e As EventArgs) Handles btn_save.Click
        If contextmenu_V = 1 Then
            mymod.Equipment_NewOwnerName(Trim(Me.txt_name.Text))
        Else
            mymod.Equipment_UpdateOwnerName(Trim(ownername_id), Trim(Me.txt_name.Text))
        End If

        If mymod.msgb <> 1 Then
            MsgBox(mymod.msgS)
            Farming_Operation.NewOwnerName()
            Me.txt_name.Text = ""
        Else
            MsgBox(mymod.msgS)
            Me.txt_name.Text = ""
        End If
    End Sub

    Private Sub btn_cancel_Click(sender As Object, e As EventArgs) Handles btn_cancel.Click
        Me.txt_name.Text = ""
    End Sub
    Private Sub Frm_addownername_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Farming_Operation.NewOwnerName()
    End Sub

    Private Sub RefreshToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RefreshToolStripMenuItem.Click
        Farming_Operation.NewOwnerName()
    End Sub

    Private Sub DeleteToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DeleteToolStripMenuItem.Click
        If ownername_id <> Nothing Then
            If (ownername_id <> 1) And (ownername_id <> 2) Then

                Try
                     If MsgBox("Are you sure you want to delete selected record?", MsgBoxStyle.Question + MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                        sql = "DELETE FROM tbl_equipment_ownername WHERE owner_name_id =" & ownername_id

                        Using sqlCnn = New SqlConnection(My.Settings.Conn_string)
                            Using sqlCmd = New SqlCommand(sql, sqlCnn)
                                With sqlCmd
                                    .Connection.Open()
                                    .ExecuteNonQuery()
                                End With
                            End Using
                        End Using
                        sqlCmd.Connection.Close()
                        ownername_id = Nothing
                    End If
                    Farming_Operation.NewOwnerName()
                Catch ex As Exception
                    MsgBox(ex.Message.ToString(), vbInformation, "ERROR!!!")
                End Try
            Else
                MsgBox("Unable to delete this record. Its a default record of the system.")
            End If
        Else
            MsgBox("Select a record please.")
        End If

    End Sub

    Private Sub lv_ownername_ItemSelectionChanged(sender As Object, e As ListViewItemSelectionChangedEventArgs) Handles lv_ownername.ItemSelectionChanged
        If Me.lv_ownername.SelectedItems.Count > 0 Then
            With Me.lv_ownername.SelectedItems(0)
                .Text = .Text
                ownername_id = .SubItems(0).Text
            End With
        End If
    End Sub

    Private Sub AddToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AddToolStripMenuItem.Click
        contextmenu_V = 1
        Me.txt_name.Focus()
    End Sub

    Private Sub UpdateToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles UpdateToolStripMenuItem.Click
        If ownername_id = Nothing Then
            MsgBox("Select an record please.")
        Else
            contextmenu_V = 2
            updateownername()
        End If
    End Sub

    Sub updateownername()
        If Me.lv_ownername.SelectedItems.Count > 0 Then
            With Me.lv_ownername.SelectedItems(0)
                .Text = .Text
                Me.txt_name.Text = .SubItems(2).Text
            End With
        End If
    End Sub

End Class
