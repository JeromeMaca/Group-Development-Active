Imports System.Data.SqlClient
Imports System.Text

Module Variable_Declaration
    Public sqlConn As SqlConnection
    Public connectionString As String
    Public sqlCnn As SqlConnection
    Public sqlCmd As SqlCommand
    Public sql As String
    Public sqlReader As SqlDataReader

    Public progrss_max As Double = 0
    Public progrss_min As Double = 0

    Public curr_progress As Double = 0

End Module
