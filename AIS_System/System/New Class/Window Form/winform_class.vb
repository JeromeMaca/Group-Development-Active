Imports System.Data.SqlClient
Imports Telerik.WinControls.UI
Imports Telerik.WinControls
Imports Telerik.Data
Imports Telerik.WinControls.Data
Imports System.ComponentModel
Imports AIS_System.System_mod
Imports System.Text
Imports System.Security.Cryptography
Public Class winform_class
    Dim sysmod As New System_mod

    Shared Sub enableddisabled_menuaccess(userid)
        Try
            sql = ""
            sql = "Select menuid FROM tbl_ais_ais_usercontrol_permission WHERE useid='" & userid & "' AND menuid IS NOT NULL"

            Using sqlCnn = New SqlConnection(My.Settings.Conn_string)

                sqlCnn.Open()
                sqlCmd = New SqlCommand(sql, sqlCnn)

                Using sqlReader As SqlDataReader = sqlCmd.ExecuteReader()
                    While (sqlReader.Read())
                        Dim access_id = sqlReader.Item("menuid").ToString()
                        Select Case access_id

                            Case 1
                                Frm_main.menufile.Enabled = True
                                submenu(userid, access_id)
                            Case 2
                                Frm_main.menufarming.Enabled = True
                                submenu(userid, access_id)
                            Case 3
                                Frm_main.menumaint.Enabled = True
                                submenu(userid, access_id)
                            Case 4
                                Frm_main.menumonitoring.Enabled = True
                                submenu(userid, access_id)
                            Case 5
                                Frm_main.menuuserc.Enabled = True
                                submenu(userid, access_id)
                            Case 6
                                Frm_main.menureport.Enabled = True
                                submenu(userid, access_id)
                            Case 7
                                Frm_main.menuabout.Enabled = True
                                submenu(userid, access_id)
                        End Select
                    End While
                End Using
            End Using

        Catch ex As Exception

        End Try
    End Sub

    Shared Sub submenu(userid, menuid)
        Try
            sql = ""
            sql = "SELECT DISTINCT submenuid FROM tbl_ais_usercontrol_permission WHERE useid='" & userid & " ' AND menuid='" & menuid & "' AND submenuid IS NOT NULL"

            Using sqlCnn = New SqlConnection(My.Settings.Conn_string)

                sqlCnn.Open()
                sqlCmd = New SqlCommand(sql, sqlCnn)

                Using sqlReader As SqlDataReader = sqlCmd.ExecuteReader()
                    While (sqlReader.Read())
                        Dim access_id = sqlReader.Item("submenuid").ToString()

                        Select Case access_id

                            Case 1
                                Frm_main.subhome.Enabled = True
                            Case 2
                                Frm_main.sublogout.Enabled = True
                            Case 3
                                Frm_main.subexit.Enabled = True
                            Case 5
                                Frm_main.subtripticket.Enabled = True
                                subchildmenu(userid, access_id)
                            Case 6
                                Frm_main.suboperation.Enabled = True
                            Case 7
                                Frm_main.subrequisition.Enabled = True
                            Case 9
                                Frm_main.subcanepoint.Enabled = True
                            Case 10
                                Frm_main.suboperation.Enabled = True
                            Case 11
                                Frm_main.sublocations.Enabled = True
                            Case 12
                                Frm_main.subequipment.Enabled = True
                            Case 13
                                Frm_main.subimplementation.Enabled = True
                            Case 14
                                Frm_main.subotheritem.Enabled = True
                            Case 15
                                Frm_main.menuitemlotstatus.Enabled = True
                            Case 16
                                Frm_main.menuitemtripticket.Enabled = True
                            Case 17
                                Frm_main.menuitemcanepoint.Enabled = True
                            Case 18
                                Frm_main.menuiteminventory.Enabled = True
                            Case 19
                                Frm_main.menuequipment.Enabled = True
                            Case 20
                                Frm_main.menuimplement.Enabled = True
                            Case 21
                                Frm_main.menuuserc.Enabled = True
                            Case 22
                                Frm_main.menuuserc.Enabled = True
                            Case 23
                                Frm_main.menuuserc.Enabled = True

                        End Select
                    End While
                End Using
            End Using

        Catch ex As Exception

        End Try
    End Sub

    Shared Sub subchildmenu(userid, submenu)
        Try
            sql = ""
            sql = "SELECT DISTINCT subchildmenuid FROM tbl_ais_usercontrol_permission WHERE useid='" & userid & "' AND submenuid='" & submenu & "' AND subchildmenuid IS NOT NULL"

            Using sqlCnn = New SqlConnection(My.Settings.Conn_string)

                sqlCnn.Open()
                sqlCmd = New SqlCommand(sql, sqlCnn)

                Using sqlReader As SqlDataReader = sqlCmd.ExecuteReader()
                    While (sqlReader.Read())
                        Dim access_id = sqlReader.Item("subchildmenuid").ToString()
                        Select Case access_id

                            Case 1
                                Frm_trip_ticket_NEWS.pvp_1.Enabled = True

                            Case 2
                                Frm_trip_ticket_NEWS.pvp_2.Enabled = True

                            Case 3
                                Frm_trip_ticket_NEWS.pvp_3.Enabled = True

                        End Select
                    End While
                End Using
            End Using

        Catch ex As Exception

        End Try
    End Sub

    Shared Sub maintenace(userid, subchildmenu)
        Try
            sql = ""
            sql = "SELECT DISTINCT subchildmenuid FROM tbl_ais_usercontrol_permission WHERE useid='" & userid & "' AND submenuid='" & subchildmenu & "' AND subchildmenuid IS NOT NULL"

            Using sqlCnn = New SqlConnection(My.Settings.Conn_string)

                sqlCnn.Open()
                sqlCmd = New SqlCommand(sql, sqlCnn)

                Using sqlReader As SqlDataReader = sqlCmd.ExecuteReader()
                    While (sqlReader.Read())
                        Dim access_id = sqlReader.Item("subchildmenuid").ToString()
                        Select Case access_id

                            Case 1
                                Frm_trip_ticket_NEWS.pvp_1.Enabled = True

                            Case 2
                                Frm_trip_ticket_NEWS.pvp_2.Enabled = True

                            Case 3
                                Frm_trip_ticket_NEWS.pvp_3.Enabled = True

                        End Select
                    End While
                End Using
            End Using

        Catch ex As Exception

        End Try
    End Sub
End Class
