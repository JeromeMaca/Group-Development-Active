Imports System.Data.SqlClient

Public Class User_Accounts_view
    Dim sysmod As New System_mod
    Public Sub logging_in(username, password)
        Try
            If username = "" And password = "" Then
                'empno.Text = ""
                'req_empno.IsValid = False
                usermsg = "Enter your Username and Password"

            ElseIf password = "" Then
                'pword.Text = ""
                'req_pword.IsValid = False
                usermsg = "Enter your Password"
            ElseIf username = "" Then
                'empno.Text = ""
                'req_empno.IsValid = False
                'pword.Text = ""
                'req_pword.IsValid = False
                usermsg = "Enter your Username "
            Else
                Try
                    Dim pwordhash = sysmod.GenerateHash(password)

                    sysmod.strQuery = "SELECT TOP 1 * FROM tbl_ais_user_account WHERE username = '" & username & "' AND password = '" & pwordhash & "'"
                    sysmod.useDB(sysmod.strQuery)
                    sysmod.resultNum = sysmod.sqlCmd.ExecuteScalar
                    If sysmod.resultNum <> 0 Then

                        sysmod.dr = sysmod.sqlCmd.ExecuteReader
                        sysmod.dr.Read()
                        Dim usern = sysmod.dr.Item("username").ToString()
                        Dim userp = sysmod.dr.Item("password").ToString()
                        sysmod.dr.Close()
                        sysmod.sqlCmd.Dispose()
                        sysmod.dbConn.Close()

                        If usern = username And userp = pwordhash Then
                            sysmod.useDB(sysmod.strQuery)
                            sysmod.dr = sysmod.sqlCmd.ExecuteReader
                            sysmod.dr.Read()
                            user_id = sysmod.dr.Item("id").ToString()
                            Dim namel = sysmod.dr.Item("user_lname").ToString()
                            Dim namef = sysmod.dr.Item("user_fname").ToString()
                            Dim namem = sysmod.dr.Item("user_mname").ToString()
                            'Session("uname") = mymod.dr.Item("uname").ToString()
                            'Session("fullname") = mymod.dr.Item("fullname").ToString()
                            'Session("pos") = mymod.dr.Item("pos").ToString()
                            'Session("officeid") = mymod.dr.Item("officeid").ToString()
                            'Session("userlvl") = mymod.dr.Item("userlvl").ToString()
                            sysmod.dr.Close()
                            sysmod.sqlCmd.Dispose()
                            sysmod.dbConn.Close()

                            msgstats = 2
                            usermsg = "Welcome: " & namel & ", " & namef & " " & namem & " " & vbCrLf & "You've Successfully Logging On."

                            Frm_main.txt_fullname.Text = namel & ", " & namef & " " & namem
                        Else
                            usermsg = "The Username or Password you entered did not match any in our records. Please double check and try again!"
                        End If
                    Else
                        usermsg = "The Username or Password you entered did not match ant in our records. Please double check and try again!"
                    End If
                Catch ex As Exception
                    MsgBox(ex.Message.ToString)
                End Try

            End If
        Catch ex As SqlException
            MsgBox(ex.Message.ToString)
        End Try
    End Sub

End Class
