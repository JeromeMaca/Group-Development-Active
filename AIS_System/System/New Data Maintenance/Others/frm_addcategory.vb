Imports Telerik.WinControls.UI
Imports Telerik.WinControls
Imports AIS_System.site_mod
Imports System.Data.SqlClient


Public Class Frm_addcategory
    Dim mymod As New site_mod
    Private Sub Frm_addcategory_Load(sender As Object, e As EventArgs) Handles Me.Load
        Farming_Operation.NewCategory()
    End Sub
    Private Sub Frm_addcategory_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        Frm_main.Enabled = True
        Farming_Operation.main_loadcategoryCB()
    End Sub

    Private Sub btn_save_Click(sender As Object, e As EventArgs) Handles btn_save.Click
        If contextmenu_V = 1 Then
            mymod.Operation_NewCategory(Trim(Me.txt_newoperationCat.Text))
        Else
            mymod.Operation_UpdateCategory(Trim(Me.txt_newoperationCat.Text), Trim(category_id))
        End If

        If mymod.msgb <> 1 Then
            MsgBox(mymod.msgS)
            Farming_Operation.NewCategory()
            Me.txt_newoperationCat.Text = ""
        Else
            MsgBox(mymod.msgS)
            Me.txt_newoperationCat.Text = ""
        End If
    End Sub

    Private Sub lv_addcategory_MouseDown(sender As Object, e As MouseEventArgs) Handles lv_addcategory.MouseDown
        If e.Button = Windows.Forms.MouseButtons.Right Then
            Me.cms_addcategory.Show(Me, Me.PointToClient(MousePosition))
        End If
    End Sub

    Private Sub RefreshToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RefreshToolStripMenuItem.Click
        Farming_Operation.NewCategory()
    End Sub

    Private Sub AddToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AddToolStripMenuItem.Click
        contextmenu_V = 1
        Me.txt_newoperationCat.Focus()
    End Sub

    Private Sub UpdateToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles UpdateToolStripMenuItem.Click
        If category_id = Nothing Then
            MsgBox("Select an record please.")
        Else
            contextmenu_V = 2
            updatecategory()
        End If
    End Sub

    Private Sub lv_addcategory_ItemSelectionChanged(sender As Object, e As ListViewItemSelectionChangedEventArgs) Handles lv_addcategory.ItemSelectionChanged
        If Me.lv_addcategory.SelectedItems.Count > 0 Then
            With Me.lv_addcategory.SelectedItems(0)
                Me.lv_addcategory.Text = .Text
                category_id = .SubItems(0).Text
            End With
        End If
    End Sub

    Private Sub DeleteToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DeleteToolStripMenuItem.Click
        If category_id <> Nothing Then
            If MsgBox("Are you sure you want to delete selected record?", MsgBoxStyle.Question + MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                sql = "DELETE FROM tbl_operation_category WHERE category_id =" & category_id

                Using sqlCnn = New SqlConnection(My.Settings.Conn_string)
                    Using sqlCmd = New SqlCommand(sql, sqlCnn)
                        sqlCmd.Connection.Open()
                        sqlCmd.ExecuteNonQuery()
                    End Using
                End Using
            End If
            sqlCmd.Connection.Close()
            Farming_Operation.NewCategory()
        Else
            MsgBox("Select a record please.")
        End If
        category_id = Nothing
    End Sub
    Private Sub btn_cancel_Click(sender As Object, e As EventArgs) Handles btn_cancel.Click
        Me.txt_newoperationCat.Text = ""
    End Sub
    Sub updatecategory()
        If Me.lv_addcategory.SelectedItems.Count > 0 Then
            With Me.lv_addcategory.SelectedItems(0)
                Me.lv_addcategory.Text = .Text
                Me.txt_newoperationCat.Text = .SubItems(2).Text
            End With
        End If
    End Sub
End Class
