Imports System.Data.SqlClient
Imports Telerik.WinControls.UI
Imports AIS_System.System_mod
Public Class Validation_trip_ticket_class
    Shared sysmod As New System_mod

#Region "TRIP TICKET REQUEST FORM"
    'Shared Sub validate_adding(lot_code, work_operation)
    '    Try

    '        sysmod.strQuery = "SELECT COUNT(*) FROM v_ais_trip_ticket_request_form WHERE code='" & lot_code & "' AND operation='" & work_operation & "'"
    '        sysmod.useDB(sysmod.strQuery)
    '        sysmod.resultNum = sysmod.sqlCmd.ExecuteScalar
    '        If sysmod.resultNum <> 0 Then

    '            sysmod.dr = sysmod.sqlCmd.ExecuteReader
    '            sysmod.dr.Read()
    '            Dim usern = sysmod.dr.Item("username").ToString()
    '            Dim userp = sysmod.dr.Item("password").ToString()
    '            sysmod.dr.Close()
    '            sysmod.sqlCmd.Dispose()
    '            sysmod.dbConn.Close()
    '        End If


    '    Catch ex As SqlException

    '    End Try
    'End Sub

    Shared Function validate_adding(lot_code, work_operation, userid)
        Try
            sysmod.strQuery = "SELECT COUNT(*) FROM v_ais_trip_ticket_request_form WHERE code='" & lot_code & "'" _
                                & " And operation='" & work_operation & "' AND user_id='" & userid & "' AND req_no IS NULL"
            sysmod.useDB(sysmod.strQuery)
            sysmod.resultNum = sysmod.sqlCmd.ExecuteScalar
            If sysmod.resultNum <> 0 Then
                Return 1
            End If
        Catch ex As SqlException

        End Try
    End Function

#End Region

End Class
