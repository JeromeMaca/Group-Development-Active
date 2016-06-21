Imports System.Data.SqlClient
Imports System.Text
Module declaration
    Public group_value As Integer
    Public server_datetime As Date
    Public fiscal_year As String

#Region "USER ACCOUNT"
    Public msgstats As Integer = 0
    Public usermsg As String = ""
    Public user_id As Integer = 0
#End Region

#Region "MASTERLIST"
#Region "OTHER MOSTERLIST LOCATION"
    Public slct_id As Integer
    Public command_contxt As Integer = 0
#End Region

#Region "LOCATION MASTERLIST"
    Public slct_id_locationdesc As Integer = 0
    Public msgerror As String
    Public gp As String
    Public sortsss As String
    Public slct_id_code As Integer = 0
#End Region

#Region "LOCATION INFO MASTERLIST"
    Public slct_id_locationinfodesc As Integer = 0
    Public slct_id_variety As Integer = 0
    Public slct_id_association As Integer = 0
#End Region

#Region "EQUIPMENT MASTERLIST"
    Public dp_owner_slct_id As Integer = 0
    Public dp_type_slct_id As Integer = 0
    Public dp_brand_slct_id As Integer = 0
#End Region

#Region "IMPLEMENT MASTERLIST"
    Public dp_owner_id As Integer = 0
    Public dp_list_id As Integer = 0
#End Region

#Region "WORK OPERATION MASTERLIST"
    Public dp_cat_slct_id As Integer = 0
#End Region
#End Region

#Region "TRIP TICKET"

#Region "Others"
    Public form_type As Integer
#End Region

#Region "REQUEST FORM"
    Public dp_lot_id As Integer = 0
    Public order_id As Integer = 0
    Public order_no As String = ""
    Public req_cat_id As Integer = 0
    Public slct_id_req_hdr As Integer = 0
    Public slct_id_req_dtl As Integer = 0
    Public req_number As String = ""
#End Region

#Region "REQUEST APPROVAL"
    Public equip_stats As String
    Public imple_stats As String
    Public hdr_id_approval As Integer = 0
    Public dtl_id_approval As Integer = 0
    Public lot_id_approval As Integer = 0
    Public driver_id As Integer
    Public approval_equip_ids As Integer = 0
    Public approval_imple_ids As Integer = 0
    Public driver_validitys As Integer = 0
#End Region

#Region "SCHEDULED"
    Public slct_id_hdr_schedule As Integer = 0
    Public slct_id_dtl_schedule As Integer = 0
    Public count_remain As Integer = 0
#End Region

#Region "ACCOMPLISHED POSTING"
    Public area_done As String
    Public time_operates_infarm As String
#End Region
#End Region

#Region "MONITORING"
    Public lotno As String = "'"
    Public dtl_id_monitoring As Integer = 0
    Public need_dates As Date
    Public hdr_id_monitoring As Integer = 0
#End Region

#Region "USER ACCOUNT"
    Public usercontrol_id As Integer = 0
    Public user_flag As Integer = 0
    Public access_id As Integer = 0
#End Region

End Module
