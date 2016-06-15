Imports System.Data.SqlClient
Imports System.Text

Module Variable_Declaration
    Public sqlConn As SqlConnection
    Public connectionString As String
    Public sqlCnn As SqlConnection
    Public sqlCmd As SqlCommand
    Public sql As String
    Public sqlReader As SqlDataReader



    Public contextmenu_V As Integer
    Public category_id As Integer

    Public opeartion_id As Integer

    Public equipment_ownerid As Integer

    Public ownername_id As Integer

    Public equip_id As Integer

    Public imple_id As Integer
    Public imple_name_id As Integer

    Public im_id As Integer

    Public loc_list_id As Integer

    Public Select_loc_list_id As Integer
    Public loc_master_id As Integer

    'Trip Tickets
    Public TT_equip_id As Integer
    Public TT_impl_id As Integer

    Public TT_destination_id As Integer

    'Trip Ticket (Select Owner ID to Load Equipemnt and Implement)
    Public e_ownername_id As Integer
    Public i_ownername_id As Integer





    'ALL LIST VIEW VARIABLES
    Public trip_ticket_id As Integer

    'COMMAND ADD/UPDATE ALL
    Public addupdate_cmd As Integer
End Module
