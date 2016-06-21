Imports Telerik.WinControls.UI
Imports Telerik.WinControls
Imports AIS_System.site_mod
Imports System.Data.SqlClient

Public Class Frm_triptickets
    Dim mymod As New site_mod
    Dim driver As String
    Private Sub Frm_triptickets_Load(sender As Object, e As EventArgs) Handles Me.Load
        ThemeResolutionService.ApplicationThemeName = My.Settings.global_themes
        Farming_Operation.Server_time()

        Me.dt_ST_date.Value = server_datetime
        Me.dt_ST_neededdate.Value = server_datetime
        Me.tp_ST_neededtime.Value = server_datetime

        Farming_Operation.Load_combo_destination_Trip_tickets()
        Farming_Operation.Load_combo_equipment_owner()
        Farming_Operation.Load_combo_implement_owner()


        Farming_Operation.Load_all_Schedule_trip_tickets()
    End Sub

    Private Sub cb_ST_equipment_SelectedIndexChanged(sender As Object, e As UI.Data.PositionChangedEventArgs) Handles cb_ST_equipment.SelectedIndexChanged
        Farming_Operation.Select_Trip_ticket_equipment()
    End Sub

    Private Sub cb_ST_implement_SelectedIndexChanged(sender As Object, e As UI.Data.PositionChangedEventArgs) Handles cb_ST_implement.SelectedIndexChanged
        Farming_Operation.Select_Trip_ticket_implements()
    End Sub

    Private Sub cb_ST_destination_SelectedIndexChanged(sender As Object, e As UI.Data.PositionChangedEventArgs) Handles cb_ST_destination.SelectedIndexChanged
        Farming_Operation.Select_trip_ticket_destination()
    End Sub
    Private Sub btn_ST_save_Click(sender As Object, e As EventArgs) Handles btn_ST_save.Click
        Try
            If addupdate_cmd = 0 Then
                mymod.trip_tickets_schedule_ADD(Trim(Me.txt_ST_ticketsno.Text), dt_ST_date.Value, TT_equip_id, _
                                                TT_impl_id, txt_ST_driver.Text, Me.txt_ST_purpose.Text, TT_destination_id, _
                                                dt_ST_neededdate.Value, tp_ST_neededtime.Value, Me.txt_ST_passeneger.Text, Me.txt_ST_requestedby.Text, _
                                                Me.txt_ST_approvedby.Text, "1", "0")

            ElseIf addupdate_cmd = 1 Then
                'Updates
            End If
            trip_ticket_id = Nothing
        Catch ex As Exception
            MsgBox(ex.Message.ToString)
        End Try

        If mymod.msgb <> 1 Then
            MsgBox(mymod.msgS)
            Farming_Operation.Load_all_Schedule_trip_tickets()
        Else
            MsgBox(mymod.msgS)
            Farming_Operation.Load_all_Schedule_trip_tickets()
        End If
    End Sub

    Private Sub chk_subcon_equipment_ToggleStateChanged(sender As Object, args As StateChangedEventArgs) Handles chk_subcon_equipment.ToggleStateChanged
        Farming_Operation.Load_owner_by_SUBCON_equipment()
        Me.cb_ST_equipment.Items.Clear()
        Me.txt_ST_driver.Text = ""
    End Sub

    Private Sub chk_subcon_implement_ToggleStateChanged(sender As Object, args As StateChangedEventArgs) Handles chk_subcon_implement.ToggleStateChanged
        Farming_Operation.Load_owner_by_SUBCON_implement()
        Me.cb_ST_implement.Items.Clear()
    End Sub

    Private Sub cb_equipment_owner_TT_SelectedIndexChanged(sender As Object, e As UI.Data.PositionChangedEventArgs) Handles cb_equipment_owner_TT.SelectedIndexChanged
        Me.txt_ST_equip_no.Text = ""
        Me.cb_ST_equipment.SelectedItem = Nothing
        Me.txt_ST_driver.Text = ""

        Farming_Operation.Select_equip_owner_id_TT()
        Farming_Operation.Load_combo_emquipmenttrip_ticket()
    End Sub

    Private Sub cb_implement_owner_TT_SelectedIndexChanged(sender As Object, e As UI.Data.PositionChangedEventArgs) Handles cb_implement_owner_TT.SelectedIndexChanged
        Me.txt_ST_imple_no.Text = ""
        Me.cb_ST_implement.SelectedItem = Nothing
        Farming_Operation.select_imple_owner_id_TT()
        Farming_Operation.Load_combo_implement_ticket()
    End Sub

    Private Sub chk_driver_manual_ToggleStateChanged(sender As Object, args As StateChangedEventArgs) Handles chk_driver_manual.ToggleStateChanged

        If Me.chk_driver_manual.Checked = True Then
            Me.txt_ST_driver.ReadOnly = False
            driver = Me.txt_ST_driver.Text
            Me.txt_ST_driver.Text = ""
        Else
            Me.txt_ST_driver.ReadOnly = True
            If driver IsNot Nothing Then
                Me.txt_ST_driver.Text = driver
            End If
        End If
    End Sub

    Private Sub lv_ST_triptickets_MouseDown(sender As Object, e As MouseEventArgs) Handles lv_ST_triptickets.MouseDown
        If e.Button = Windows.Forms.MouseButtons.Right Then
            Me.cms_menucontrol_TT.Show(Me, Me.PointToClient(MousePosition))
        End If
    End Sub

    Private Sub RadPageView1_SelectedPageChanged(sender As Object, e As EventArgs) Handles RadPageView1.SelectedPageChanged
        'If Me.RadPageView1.SelectedPage = Me.RadPageViewPage1 Then
        '    MsgBox("PAGE 1")
        'ElseIf Me.RadPageView1.SelectedPage = RadPageViewPage2 Then
        '    MsgBox("PAGE 2")
        'Else
        '    MsgBox("NOTHING")
        'End If


        'RadTabStrip1.SelectedIndex = 1
        'RadPageViewOrganizationSearch.Selected = True
    End Sub

    Private Sub lv_ST_triptickets_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lv_ST_triptickets.SelectedIndexChanged
        If Me.lv_ST_triptickets.SelectedItems.Count > 0 Then
            With Me.lv_ST_triptickets.SelectedItems(0)
                Me.lv_ST_triptickets.Text = .Text
                trip_ticket_id = .SubItems(0).Text
            End With



            Try
                mymod.strQuery = "p_ais_trip_ticket_schedule_equipment_info " & trip_ticket_id
                mymod.useDB(mymod.strQuery)


                mymod.dr = mymod.sqlCmd.ExecuteReader
                mymod.dr.Read()
                'lbl_trn_date.Text = " " + Convert.ToDateTime(mymod.dr.Item("trn_date")).ToString("MMM dd, yyyy")
                Me.txt_RO_equip_no.Text = " " + mymod.dr.Item("equipment_no").ToString()
                Me.txt_RO_equip_desc.Text = " " + mymod.dr.Item("equipment_desc").ToString()
                Me.txt_RO_equip_owner.Text = " " + mymod.dr.Item("Owner_name").ToString()
                Me.txt_RO_fuelcap.Text = " " + mymod.dr.Item("equipment_fuelcap").ToString()


                mymod.dr.Close()
                mymod.sqlCmd.Dispose()
                mymod.dbConn.Close()


                mymod.strQuery = "p_ais_trip_ticket_schedule_implement_info " & trip_ticket_id
                mymod.useDB(mymod.strQuery)


                mymod.dr = mymod.sqlCmd.ExecuteReader
                mymod.dr.Read()

                Me.txt_RO_imple_desc.Text = " " + mymod.dr.Item("imp_desc").ToString()
                Me.txt_RO_implement_owner.Text = " " + mymod.dr.Item("Owner_name").ToString()


                mymod.dr.Close()
                mymod.sqlCmd.Dispose()
                mymod.dbConn.Close()
            Catch ex As Exception
                MsgBox(ex.Message.ToString)
            End Try

        End If
    End Sub

    Private Sub DeleteToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DeleteToolStripMenuItem.Click
        If trip_ticket_id <> Nothing Then
            If MsgBox("Are you sure you want to delete this record?", MsgBoxStyle.Question + MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                mymod.strQuery = "DELETE FROM tbl_ais_trip_ticket_schedule WHERE ID =" & trip_ticket_id

                Using sqlCnn = New SqlConnection(My.Settings.Conn_string)
                    Using sqlCmd = New SqlCommand(mymod.strQuery, sqlCnn)
                        sqlCmd.Connection.Open()
                        sqlCmd.ExecuteNonQuery()
                    End Using
                End Using
            End If
            sqlCmd.Connection.Close()
            Farming_Operation.Load_all_Schedule_trip_tickets()
        Else
            MsgBox("Select a record please.")
        End If
        trip_ticket_id = Nothing
    End Sub

    Private Sub RefreshToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RefreshToolStripMenuItem.Click
        Farming_Operation.Load_all_Schedule_trip_tickets()
    End Sub

    Private Sub AddToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AddToolStripMenuItem.Click
        addupdate_cmd = 0
    End Sub

    Private Sub UpdateToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles UpdateToolStripMenuItem.Click
        If trip_ticket_id = Nothing Then
            MsgBox("Select an record please.")
        Else
            addupdate_cmd = 1
            'Disciplinary_Action_class.change_disciplinary_detail()
            MsgBox("Ready TO udate")
        End If
    End Sub


    '''''FOR UPDATES SCHEDULE TICKET
    Sub update_schedule_ticket()

    End Sub
End Class
