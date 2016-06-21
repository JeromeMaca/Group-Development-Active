Public Class Frm_masterlist_location_addexisting
    Private Sub Frm_masterlist_location_addexisting_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        Frm_main.Enabled = True
    End Sub

    Private Sub Frm_masterlist_location_addexisting_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        location_masterlist_view.dp_load_location()
    End Sub

    Private Sub dp_loc_desc_SelectedIndexChanged(sender As Object, e As Telerik.WinControls.UI.Data.PositionChangedEventArgs) Handles dp_loc_desc.SelectedIndexChanged
        location_masterlist_view.loc_select_dp_desc(Trim(Me.dp_loc_desc.SelectedText))
        location_masterlist_view.dp_load_code(slct_id_locationdesc, Me)
    End Sub

    Private Sub dp_lot_code_SelectedIndexChanged(sender As Object, e As Telerik.WinControls.UI.Data.PositionChangedEventArgs) Handles dp_lot_code.SelectedIndexChanged
        location_masterlist_view.code_select_dp_desc(Trim(Me.dp_lot_code.SelectedText))
        location_masterlist_view.Get_current_area(slct_id_code, Me)
        Me.txt_new_code.Focus()
    End Sub

    Private Sub sp_area_ValueChanged(sender As Object, e As EventArgs) Handles sp_area.ValueChanged
        Dim tot As Decimal = 0
        Me.txt_existing_code.Text = Me.dp_lot_code.SelectedText

        tot = Val(Me.txt_current_area.Text) - Val(Me.sp_area.Value)

        If tot >= 0 Then
            Me.txt_new_area.Text = tot
            Me.btn_edit_save.Enabled = True
        Else
            Me.sp_area.Value -= 1
            Me.txt_new_area.Text = 0
        End If

        If sp_area.Value = 0 Then
            Me.txt_existing_code.Text = Nothing
            Me.txt_new_area.Text = Nothing
        End If
    End Sub

    Private Sub btn_edit_save_Click(sender As Object, e As EventArgs) Handles btn_edit_save.Click

        If btn_edit_save.Text = "Save" Then
            Me.txt_existing_code.ReadOnly = True
            Me.btn_edit_save.Text = "Edit"
        ElseIf btn_edit_save.Text = "Edit" Then
            Me.txt_existing_code.ReadOnly = False
            Me.btn_edit_save.Text = "Save"
        End If
    End Sub

    Private Sub btn_cancel_Click(sender As Object, e As EventArgs) Handles btn_cancel.Click
        Me.dp_loc_desc.SelectedIndex = -1
        Me.dp_lot_code.SelectedIndex = -1
        Me.txt_current_area.Text = Nothing
        Me.txt_existing_code.Text = Nothing
        Me.txt_new_area.Text = ""
        Me.txt_new_code.Text = Nothing
        Me.sp_area.Value = Nothing
        Me.btn_edit_save.Enabled = False

        Me.dp_loc_desc.Focus()

        If Me.dp_loc_desc.Focused = True Then
            Me.txt_new_area.Text = ""
            Me.dp_loc_desc.Focus()
        End If
    End Sub
End Class
