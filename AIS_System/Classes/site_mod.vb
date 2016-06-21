Imports Microsoft.VisualBasic
Imports System.Data
Imports System.Data.SqlClient
Imports System.IO
Imports System.Text
Imports System.Security.Cryptography

Public Class site_mod
    Public dbConn As New SqlConnection
    Public connStr As String = My.Settings.Conn_string
    Public sqlCmd As New SqlCommand
    Public dr As SqlDataReader
    Public da As New SqlDataAdapter
    Public tbl As New DataTable
    Public i As Integer
    Public strQuery As String = ""

    Public msgb As Integer
    Public msgS As String

    Public Sub useDB(ByVal sql As String)
        Try
            dbConn = New SqlConnection(connStr)
            sqlCmd = New SqlCommand(sql, dbConn)
            dbConn.Open()

        Catch ex As Exception
            MsgBox("Please Contact your Database Admin." + vbCrLf + ex.Message.ToString, MsgBoxStyle.Critical + vbOKOnly, "System Error! ")
        End Try
    End Sub

    'Public Function GenerateHash(ByVal SourceText As String) As String
    '    'Create an encoding object to ensure the encoding standard for the source text
    '    Dim Ue As New UnicodeEncoding()
    '    'Retrieve a byte array based on the source text
    '    Dim ByteSourceText() As Byte = Ue.GetBytes(SourceText)
    '    'Instantiate an MD5 Provider object
    '    Dim Md5 As New MD5CryptoServiceProvider()
    '    'Compute the hash value from the source
    '    Dim ByteHash() As Byte = Md5.ComputeHash(ByteSourceText)
    '    'And convert it to String format for return
    '    Return Convert.ToBase64String(ByteHash)
    'End Function

    'ADD CATEGORY OPERATION

    Sub Operation_NewCategory(cat_desc As String)
        Try
            dbConn = New SqlConnection(connStr)
            With sqlCmd
                .Connection = dbConn
                .CommandText = "INSERT INTO tbl_ais_operation_category(cat_desc) VALUES('" + cat_desc + "')"
                dbConn.Open()
                .ExecuteNonQuery()
                dbConn.Close()
            End With
        Catch ex As SqlException
            If ex.Message <> Nothing Then
                msgb = 1
            End If
        End Try
        If msgb = 1 Then
            msgS = "Error!!! Unable to save the category."
        Else
            msgS = "Successfully Added a New Category."
        End If
    End Sub

    'UPDATE CATEGORY OPERATION
    Sub Operation_UpdateCategory(desc As String, id As Integer)
        Try
            dbConn = New SqlConnection(connStr)
            With sqlCmd
                .Connection = dbConn
                .CommandText = "UPDATE tbl_ais_operation_category SET cat_desc='" & desc & "' WHERE category_id='" & id & "'"
                dbConn.Open()
                .ExecuteNonQuery()
                dbConn.Close()
            End With
        Catch ex As Exception
            If ex.Message <> Nothing Then
                msgb = 1
            End If
        End Try
        If msgb = 1 Then
            msgS = "Error!!! Unable to Modify the category."
        Else
            msgS = "Successfully Modify a Category."
        End If
    End Sub

    'ADD EQUIPMENT OWNER NAME 
    Sub Equipment_NewOwnerName(owner_name)
        Try
            dbConn = New SqlConnection(My.Settings.Conn_string)
            With sqlCmd
                .Connection = dbConn
                .CommandText = "INSERT INTO tbl_ais_equipment_ownername(owner_name) VALUES('" + owner_name + "')"
                dbConn.Open()
                .ExecuteNonQuery()
                dbConn.Close()
            End With
        Catch ex As Exception
            If ex.Message <> Nothing Then
                msgb = 1
            End If
        End Try
        If msgb = 1 Then
            msgS = "Error!!! Unable to save the equipment owner name."
        Else
            msgS = "Successfully added a new equipment owner name."
        End If
    End Sub

    'UPDATE EQUIPMENT OWNER NAME 
    Sub Equipment_UpdateOwnerName(owner_id, owner_name)
        Try
            dbConn = New SqlConnection(My.Settings.Conn_string)

            With sqlCmd
                .Connection = dbConn
                .CommandText = "UPDATE tbl_ais_equipment_ownername SET owner_name='" & owner_name & "' WHERE owner_name_id='" & owner_id & "'"
                dbConn.Open()
                .ExecuteNonQuery()
                dbConn.Close()
            End With
        Catch ex As Exception
            If ex.Message <> Nothing Then
                msgb = 1
            End If
        End Try
        If msgb = 1 Then
            msgS = "Error!!! Unable to modify this record."
        Else
            msgS = "Successfully modified the owner name."
        End If
    End Sub

    'ADD OPEARATION 
    Sub Opearation_NewOpeartion(cat_id, ope_desc, rate, unit)
        Try
            dbConn = New SqlConnection(connStr)
            With sqlCmd
                .Connection = dbConn
                .CommandText = "INSERT INTO tbl_ais_work_operations(category_id,operation_desc,rate,unit) VALUES('" + cat_id + "', '" + ope_desc + "', '" + rate + "','" + unit + "')"
                dbConn.Open()
                .ExecuteNonQuery()
                dbConn.Close()
            End With
        Catch ex As Exception
            If ex.Message <> Nothing Then
                msgb = 1
            End If
        End Try
        If msgb = 1 Then
            msgS = "Error!!! Unable to save a Work Opearation."
        Else
            msgS = "Successfully Added a New Work Operation."
        End If
    End Sub

    'UPDATE OPERATION
    Sub Opeartion_UpdateOperation(id, cat_id, ope_desc, rate, unit)
        Try
            dbConn = New SqlConnection(connStr)
            With sqlCmd
                .Connection = dbConn
                .CommandText = "UPDATE tbl_ais_work_operations SET category_id='" + cat_id + "',operation_desc='" + ope_desc + "',rate='" + rate + "', unit='" + unit + "' WHERE id='" + id + "'"
                dbConn.Open()
                .ExecuteNonQuery()
                dbConn.Close()
            End With
        Catch ex As Exception
            If ex.Message <> Nothing Then
                msgb = 1
            End If
        End Try

        If msgb = 1 Then
            msgS = "Error!!! Unable to Modify the Work Operation."
        Else
            msgS = "Successfully Modify a Work Operation."
        End If
    End Sub

    'ADD NEW EQUIPMENT
    Sub Equipment_NewEquipment(owner_name, equip_no, equip_desc, equip_driver, equip_fueltank)
        Try
            dbConn = New SqlConnection(My.Settings.Conn_string)
            With sqlCmd
                .Connection = dbConn
                .CommandText = "INSERT INTO tbl_ais_equipments(owner_name_id,equipment_no,equipment_desc,equipment_driver,equipment_fuelcap) VALUES" _
                    & "('" + owner_name + "','" + equip_no + "','" + equip_desc + "','" + equip_driver + "','" + equip_fueltank + "')"
                dbConn.Open()
                .ExecuteNonQuery()
                dbConn.Close()
            End With
        Catch ex As Exception
            If ex.Message <> Nothing Then
                msgb = 1
            End If
        End Try
        If msgb = 1 Then
            msgS = "Error!!! Unable to save a Equipment."
        Else
            msgS = "Successfully Added a New Equipments"
        End If
    End Sub

    'Update Equipment
    Sub Equipment_UpdateEquipment(e_id, owner_name, equip_no, equip_desc, equip_driver, equip_fueltank)
        Try
            dbConn = New SqlConnection(connStr)
            With sqlCmd
                .Connection = dbConn
                .CommandText = "UPDATE tbl_ais_equipments SET owner_name_id='" & owner_name & "',equipment_no='" & equip_no & "',equipment_desc='" & equip_desc & "', equipment_driver='" & equip_driver & "', equipment_fuelcap='" & equip_fueltank & "' WHERE owner_id='" & e_id & "'"
                dbConn.Open()
                .ExecuteNonQuery()
                dbConn.Close()
            End With
        Catch ex As Exception
            If ex.Message <> Nothing Then
                msgb = 1
            End If
        End Try

        If msgb = 1 Then
            msgS = "Error!!! Unable to Modify the equipment."
        Else
            msgS = "Successfully modified the equipment.."
        End If
    End Sub

    'ADD NEW IMPLEMENTS
    Sub Implement_NewImplement(imp_name_id, imp_desc)
        Try
            dbConn = New SqlConnection(connStr)
            With sqlCmd
                .Connection = dbConn
                .CommandText = "INSERT INTO tbl_ais_implements(imp_name_id,imp_desc) VALUES('" & imp_name_id & "','" & imp_desc & "')"
                dbConn.Open()
                .ExecuteNonQuery()
                dbConn.Close()
            End With
        Catch ex As Exception
            If ex.Message <> Nothing Then
                msgb = 1
            End If
        End Try
        If msgb = 1 Then
            msgS = "Error!!! Unable to save implement."
        Else
            msgS = "Successfully Added a New Equipment"
        End If
    End Sub

    'Update Implements
    Sub Implement_UpdateImplement(imp_id, imp_name_id, imp_desc)
        Try
            dbConn = New SqlConnection(connStr)
            With sqlCmd
                .Connection = dbConn
                .CommandText = "UPDATE tbl_ais_implements SET imp_name_id='" & imp_name_id & "',imp_desc='" & imp_desc & "' WHERE imp_id='" & imp_id & "'"
                dbConn.Open()
                .ExecuteNonQuery()
                dbConn.Close()
            End With
        Catch ex As Exception
            If ex.Message <> Nothing Then
                msgb = 1
            End If
        End Try

        If msgb = 1 Then
            msgS = "Error!!! Unable to Modify a Implement."
        Else
            msgS = "Successfully modified a Implement.."
        End If
    End Sub

    'ADD New Location List
    Sub Location_NewLocation(loc_desc)
        Try
            dbConn = New SqlConnection(connStr)
            With sqlCmd
                .Connection = dbConn
                .CommandText = "INSERT INTO tbl_ais_location_list(location_desc) VALUES('" & loc_desc & "')"
                dbConn.Open()
                .ExecuteNonQuery()
                dbConn.Close()
            End With
        Catch ex As Exception
            If ex.Message <> Nothing Then
                msgb = 1
            End If
        End Try


        If msgb = 1 Then
            msgS = "Error!!! Unable to save implement."
        Else
            msgS = "Successfully Added a New Equipment"
        End If
    End Sub

    'UPDATE location List
    Sub Location_UpdateLocation(loc_desc, id)
        Try
            dbConn = New SqlConnection(connStr)
            With sqlCmd
                .Connection = dbConn
                .CommandText = "UPDATE tbl_ais_location_list SET location_desc='" & loc_desc & "' WHERE id='" & id & "'"
                dbConn.Open()
                .ExecuteNonQuery()
                dbConn.Close()
            End With
        Catch ex As Exception
            If ex.Message <> Nothing Then
                msgb = 1
            End If
        End Try

        If msgb = 1 Then
            msgS = "Error!!! Unable to Modify a Implement."
        Else
            msgS = "Successfully modified a Implement.."
        End If
    End Sub

    'ADD New Location Master List
    Sub Location_add(code, loc_desc_id, area, culture)
        Try
            dbConn = New SqlConnection(connStr)
            With sqlCmd
                .Connection = dbConn
                .CommandText = "INSERT INTO tbl_ais_location(code,location_id,area,culture) VALUES('" & code & "','" & loc_desc_id & "','" & area & "','" & culture & "')"
                dbConn.Open()
                .ExecuteNonQuery()
                dbConn.Close()
            End With
        Catch ex As Exception
            If ex.Message <> Nothing Then
                msgb = 1
            End If
        End Try
        If msgb = 1 Then
            msgS = "Error!!! Unable to save implement."
        Else
            msgS = "Successfully Added a New Equipment"
        End If
    End Sub

    'UPDATE Location Master list
    Sub Location_Update(id, code, loc_desc_id, area, culture)
        Try
            dbConn = New SqlConnection(connStr)
            With sqlCmd
                .Connection = dbConn
                .CommandText = "UPDATE tbl_ais_location SET code='" & code & "',location_id='" & loc_desc_id & "',area='" & area & "',culture='" & culture & "' WHERE id='" & id & "'"
                dbConn.Open()
                .ExecuteNonQuery()
                dbConn.Close()
            End With
        Catch ex As Exception
            If ex.Message <> Nothing Then
                msgb = 1
            End If
        End Try

        If msgb = 1 Then
            msgS = "Error!!! Unable to Modify a Implement."
        Else
            msgS = "Successfully modified a Implement.."
        End If
    End Sub

    'ADD bNew Schedule TRIP TICKETS
    Sub trip_tickets_schedule_ADD(tic_no, trip_date, equip_id, imple_id, driver, purpose, destination, needed_date, needed_time, passenger, req_by, appro_by, form_id, trip_stats)
        Try
            dbConn = New SqlConnection(connStr)
            With sqlCmd
                .Connection = dbConn
                .CommandText = "p_ais_trip_ticket_insert_schedule '" & tic_no & "','" & trip_date & "','" & equip_id & "','" & imple_id & "','" & driver & "'," _
                   & " '" & purpose & "','" & destination & "','" & needed_date & "','" & needed_time & "','" & passenger & "'," _
                   & " '" & req_by & "','" & appro_by & "','" & form_id & "','" & trip_stats & "'"
                dbConn.Open()
                .ExecuteNonQuery()
                dbConn.Close()
            End With
        Catch ex As Exception
            If ex.Message <> Nothing Then
                msgb = 1
            End If
        End Try
        If msgb = 1 Then
            msgS = "Error!!! Unable to save Ticket Schedule."
        Else
            msgS = "Successfully Added a New Ticket Schedule."
        End If
    End Sub

End Class