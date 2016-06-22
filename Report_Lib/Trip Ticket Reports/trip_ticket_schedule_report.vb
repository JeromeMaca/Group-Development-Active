Imports System.ComponentModel
Imports System.Drawing
Imports System.Windows.Forms
Imports Telerik.Reporting
Imports Telerik.Reporting.Drawing
Imports System.Data.SqlClient
Partial Public Class trip_ticket_schedule_report
    Inherits Telerik.Reporting.Report
    Public Sub New(hdr_id)
        InitializeComponent()
        '
        Dim sqlConnection As New SqlConnection()
        Dim sqlCommand As New SqlCommand()
        Dim sqlDataAdapter As New SqlDataAdapter()

        sqlConnection.ConnectionString = "Data Source=(local);Initial Catalog=agrikulto;Integrated Security=True"

        '
        sqlCommand.CommandText = "SELECT trip_ticket_no,lot_no,trip_date,work_operation,variety,lot_owner_name,current_area" _
                                    & ",equip_type,imple_code,driver,purpose,location FROM v_ais_trip_ticket_schedule_form WHERE hdr_id='" & hdr_id & "'"

        sqlCommand.CommandType = CommandType.Text

        sqlCommand.Connection = sqlConnection

        sqlDataAdapter.SelectCommand = sqlCommand

        Me.DataSource = sqlDataAdapter
    End Sub
End Class