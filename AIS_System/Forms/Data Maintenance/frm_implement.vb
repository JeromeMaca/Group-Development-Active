Imports Telerik.WinControls.UI
Imports Telerik.WinControls
Imports AIS_System.site_mod
Imports System.Data.SqlClient

Public Class Frm_implement
    Dim mymod As New site_mod
    Private Sub btn_addname_Click(sender As Object, e As EventArgs) Handles btn_addname.Click
        'Frm_addownername.Show()
        'Frm_main.Enabled = False
    End Sub

    Private Sub cb_implement_owner_SelectedIndexChanged(sender As Object, e As UI.Data.PositionChangedEventArgs) Handles cb_implement_owner.SelectedIndexChanged
        Select Case Me.cb_implement_owner.SelectedIndex
            Case 0
                imple_id = "1"
            Case 1
                imple_id = "2"
            Case 2
                imple_id = "3"
        End Select

        Farming_Operation.mainimplement_loadnames()

        Select Case imple_id
            Case 1
                Me.cb_imp_ownername.SelectedIndex = 0
            Case 2
                Me.cb_imp_ownername.SelectedIndex = 0
            Case 3
                ' Me.cb_ownername.SelectedIndex = Nothing
        End Select
    End Sub

    Private Sub btn_save_Click(sender As Object, e As EventArgs) Handles btn_save.Click
        If contextmenu_V = 1 Then
            mymod.Implement_NewImplement(Trim(imple_name_id), Trim(Me.txt_implement_desc.Text))
        Else
            mymod.Implement_UpdateImplement(Trim(im_id), Trim(imple_name_id), Trim(Me.txt_implement_desc.Text))
        End If

        If mymod.msgb <> 1 Then
            MsgBox(mymod.msgS)
            Farming_Operation.load_implements_v()
            imple_id = Nothing
        Else
            MsgBox(mymod.msgS)
            imple_id = Nothing
        End If
    End Sub

    Private Sub cb_imp_ownername_SelectedIndexChanged(sender As Object, e As UI.Data.PositionChangedEventArgs) Handles cb_imp_ownername.SelectedIndexChanged
        Farming_Operation.main_select_ownername_imple()
    End Sub

    Private Sub Frm_implement_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Farming_Operation.load_implements_v()
    End Sub

    Private Sub lv_implements_MouseDown(sender As Object, e As MouseEventArgs) Handles lv_implements.MouseDown
        If e.Button = Windows.Forms.MouseButtons.Right Then
            Me.cms_impl_menu.Show(Me, Me.PointToClient(MousePosition))
        End If
    End Sub

    Private Sub RefreshToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RefreshToolStripMenuItem.Click
        Farming_Operation.load_implements_v()
    End Sub

    Private Sub lv_implements_ItemSelectionChanged(sender As Object, e As ListViewItemSelectionChangedEventArgs) Handles lv_implements.ItemSelectionChanged
            If Me.lv_implements.SelectedItems.Count > 0 Then
                With Me.lv_implements.SelectedItems(0)
                    .Text = .Text
                    imple_id = .SubItems(0).Text
                    imple_name_id = .SubItems(1).Text
                End With
            End If
    End Sub

    Private Sub DeleteToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DeleteToolStripMenuItem.Click
        If imple_id <> Nothing Then
            Try
                If MsgBox("Are you sure you want to delete selected record?", MsgBoxStyle.Question + MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                    sql = "DELETE FROM tbl_ais_implements WHERE imp_id =" & imple_id

                    Using sqlCnn = New SqlConnection(My.Settings.Conn_string)
                        Using sqlCmd = New SqlCommand(sql, sqlCnn)
                            With sqlCmd
                                .Connection.Open()
                                .ExecuteNonQuery()
                            End With
                        End Using
                    End Using
                    sqlCmd.Connection.Close()
                    imple_id = Nothing
                End If
                Farming_Operation.load_implements_v()
            Catch ex As Exception
                MsgBox(ex.Message.ToString(), vbInformation, "ERROR!!!")
            End Try
        Else
            MsgBox("Select a record please.")
        End If
    End Sub

    Private Sub AddToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AddToolStripMenuItem.Click
        contextmenu_V = 1
    End Sub

    Private Sub UpdateToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles UpdateToolStripMenuItem.Click
        If imple_id = Nothing Then
            MsgBox("Select an record please.")
        Else
            contextmenu_V = 2
            updateimplements()
        End If
    End Sub

    Sub updateimplements()
        If Me.lv_implements.SelectedItems.Count > 0 Then
            With Me.lv_implements.SelectedItems(0)
                .Text = .Text
                im_id = .SubItems(0).Text
                imple_name_id = .SubItems(1).Text

                If imple_name_id = "1" Then
                    Me.cb_implement_owner.SelectedValue = "CAT - Central Azucarera De Tarlac"
                ElseIf imple_name_id = "2" Then
                    Me.cb_implement_owner.SelectedValue = "Agrikulto Inc."
                Else
                    Me.cb_implement_owner.SelectedValue = "SUBCON"

                    Me.cb_imp_ownername.SelectedValue = .SubItems(3).Text.ToString()
                End If
                Me.txt_implement_desc.Text = .SubItems(4).Text.ToString()
            End With
        End If
    End Sub

End Class
