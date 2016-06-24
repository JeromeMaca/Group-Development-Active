Imports Telerik.WinControls.UI
Imports Telerik.WinControls
Imports AIS_System.System_mod
Imports System.Data.SqlClient
Imports Telerik.WinControls.Data
Imports System.ComponentModel
Public Class Frm_accomplished_posting
    Dim sysmod As New System_mod

#Region "LISTVIEW COLUMN"
    Sub trip_ticket_schetrip_ticket_posting_column()

        Me.lv_posting.Columns.Clear()

        With Me.lv_posting
            .Columns.Add("id", "dtl_id")
            .Columns.Add("count", "#")
            .Columns.Add("lot_no", "LOT NUMBER")
            .Columns.Add("work_operation", "WORK OPERATION")
            .Columns.Add("hours_work", "WORK HOUR/s")
            .Columns.Add("area_finish", "AREA DONE")
            .Columns.Add("rate", "RATE Per AREA")
            .Columns.Add("amount", "TOTAL AMOUNT")
            .Columns.Add("gamount", "GRAND TOTAL AMOUNT")

            .Columns("id").Width = 60
            .Columns("id").Visible = False
            .Columns("count").Width = 30
            .Columns("lot_no").Width = 120
            .Columns("work_operation").Width = 230
            .Columns("hours_work").Width = 180
            .Columns("area_finish").Width = 150
            .Columns("rate").Width = 150
            .Columns("amount").Width = 150
            .Columns("gamount").Width = 150
            .Columns("gamount").Visible = False

            .FullRowSelect = True
            '.ShowGridLines = True
            .ShowGroups = True
            .EnableGrouping = True
            .MultiSelect = False

            Me.lv_posting.EnableGrouping = True
            Me.lv_posting.ShowGroups = True
        End With
    End Sub
#End Region
    Private Sub Frm_accomplished_posting_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ThemeResolutionService.ApplicationThemeName = My.Settings.global_themes
        'Farming_Operation.Server_time()

        trip_ticket_schetrip_ticket_posting_column()
        accomplished_form_view.accomplished_posting_listview_load()

    End Sub

    Private Sub Frm_accomplished_posting_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        Me.txt_trip_ticket_no.Text = Nothing
        slct_id_req_hdr = Nothing
        accomplished_form_view.trip_ticket_accomplished_listview_load()
        Frm_main.Enabled = True
    End Sub

    Private Sub lv_posting_CellFormatting(sender As Object, e As ListViewCellFormattingEventArgs) Handles lv_posting.CellFormatting
        If TypeOf e.CellElement Is DetailListViewHeaderCellElement Then
            e.CellElement.TextAlignment = ContentAlignment.MiddleCenter
        Else
            e.CellElement.ResetValue(LightVisualElement.TextAlignmentProperty, Telerik.WinControls.ValueResetFlags.Local)
        End If

        If (TypeOf e.CellElement Is DetailListViewDataCellElement) Then
            e.CellElement.TextAlignment = ContentAlignment.MiddleCenter
        End If

        If (e.CellElement).Data.Name = "amount" Then
            If (TypeOf e.CellElement Is DetailListViewHeaderCellElement) Then
                e.CellElement.TextAlignment = ContentAlignment.MiddleRight
            End If

            If (TypeOf e.CellElement Is DetailListViewDataCellElement) Then
                e.CellElement.TextAlignment = ContentAlignment.MiddleRight
            End If
        End If

        If (TypeOf e.CellElement Is DetailListViewCellElement) Then
            e.CellElement.DrawFill = False
            e.CellElement.DrawBorder = False
        Else
            e.CellElement.ResetValue(LightVisualElement.DrawBorderProperty, Telerik.WinControls.ValueResetFlags.Local)
            e.CellElement.ResetValue(LightVisualElement.DrawFillProperty, Telerik.WinControls.ValueResetFlags.Local)
        End If
    End Sub

    Private Sub btn_update_Click(sender As Object, e As EventArgs) Handles btn_update.Click
        accomplished_form_view.clear_field_posting()
        If Me.lv_posting.SelectedItems.Count > 0 Then
            With Me.lv_posting.SelectedItems(0)
                slct_id_req_dtl = .SubItems(0)

                Me.txt_lotno.Text = .SubItems(2)
                Me.txt_operation_performed.Text = .SubItems(3)
                Me.txt_rateperarea.Text = .SubItems(6)
                area_done = .SubItems(5)

                Me.txt_totalamount.Text = Val(Me.txt_rateperarea.Value) * Val(area_done)

            End With
        End If


        If slct_id_req_dtl = Nothing Then
            MsgBox("Please select an item in the list to be update.")
            Exit Sub
        End If

        Me.gb_data.Enabled = False
        Me.gb_menu.Enabled = True


    End Sub

    Private Sub btn_cancel_Click(sender As Object, e As EventArgs) Handles btn_cancel.Click
        accomplished_form_view.accomplished_posting_listview_load()

        Me.gb_data.Enabled = True
        Me.gb_menu.Enabled = False
        accomplished_form_view.clear_field_posting()
    End Sub

    Private Sub btn_save_Click(sender As Object, e As EventArgs) Handles btn_save.Click
        sysmod.Update_accomplished_review_form(Me.txt_rateperarea.Value, Me.txt_totalamount.Value, slct_id_req_dtl)
        accomplished_form_view.accomplished_posting_listview_load()

        Me.gb_data.Enabled = True
        Me.gb_menu.Enabled = False
        accomplished_form_view.clear_field_posting()
    End Sub

    Private Sub txt_rateperarea_KeyDown(sender As Object, e As KeyEventArgs) Handles txt_rateperarea.KeyDown
        If e.KeyCode = Keys.Enter Then
            Me.txt_totalamount.Text = Val(area_done) * Val(Me.txt_rateperarea.Value)
            Me.btn_save.Focus()
        End If
    End Sub
End Class
