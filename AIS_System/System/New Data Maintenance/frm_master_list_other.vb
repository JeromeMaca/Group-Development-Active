Imports Telerik.WinControls.UI
Imports Telerik.WinControls
Imports AIS_System.System_mod
Imports System.Data.SqlClient
Imports Telerik.WinControls.Data
Imports System.ComponentModel

Public Class Frm_master_list_other
    Dim sysmod As New System_mod

#Region "LIST VIEW COlUMN"
    'Location
    Sub location_column()
        Me.lv_other_masterlist.Columns.Clear()

        With Me.lv_other_masterlist
            .Columns.Add("Id", "")
            .Columns.Add("Count", "#")
            .Columns.Add("Location", "LOCATION")
            .Columns.Add("Municipality", "MUNICIPALITY")
            .Columns.Add("Province", "PROVINCE")

            .Columns("Id").Width = 0
            .Columns("Id").Visible = False
            .Columns("Count").Width = 60
            .Columns("Location").Width = 200
            .Columns("Municipality").Width = 200
            .Columns("Province").Width = 500

            .FullRowSelect = True
            '.ShowGridLines = True
            .ShowGroups = True
            .EnableGrouping = True
            .MultiSelect = False

            Me.lv_other_masterlist.EnableGrouping = True
            Me.lv_other_masterlist.ShowGroups = True
        End With
    End Sub

    'WORK OPERATION CATEGORY
    Sub operation_category_column()
        Me.lv_other_masterlist.Columns.Clear()

        With Me.lv_other_masterlist
            .Columns.Add("Id", "")
            .Columns.Add("Count", "#")
            .Columns.Add("Category Description", "CATEGORY NAME")

            .Columns("Id").Width = 0
            .Columns("Id").Visible = False
            .Columns("Count").Width = 40
            .Columns("Category Description").Width = 1000

            .FullRowSelect = True
            '.ShowGridLines = True
            .MultiSelect = False

            Me.lv_other_masterlist.EnableGrouping = False
            Me.lv_other_masterlist.ShowGroups = False
        End With

    End Sub

    'LOCATION ASSOCIATION
    Sub association_column()
        Me.lv_other_masterlist.Columns.Clear()

        With Me.lv_other_masterlist
            .Columns.Add("Id", "")
            .Columns.Add("Count", "#")
            .Columns.Add("Association Description", "ASSOCIATION NAME")

            .Columns("Id").Width = 0
            .Columns("Id").Visible = False
            .Columns("Count").Width = 40
            .Columns("Association Description").Width = 1000


            .FullRowSelect = True
            '.ShowGridLines = True
            .MultiSelect = False

            Me.lv_other_masterlist.EnableGrouping = False
            Me.lv_other_masterlist.ShowGroups = False
        End With
    End Sub

    'VARIETY / CULTURE
    Sub culture_column()
        Me.lv_other_masterlist.Columns.Clear()

        With Me.lv_other_masterlist
            .Columns.Add("Id", "")
            .Columns.Add("Count", "#")
            .Columns.Add("Variety/Culture", "CULTURE")

            .Columns("Id").Width = 0
            .Columns("Id").Visible = False
            .Columns("Count").Width = 40
            .Columns("Variety/Culture").Width = 1000

            .FullRowSelect = True
            '.ShowGridLines = True
            .MultiSelect = False

            Me.lv_other_masterlist.EnableGrouping = False
            Me.lv_other_masterlist.ShowGroups = False
        End With
    End Sub

    'SUB CONTRACTOR NAME
    Sub subcon_column()
        Me.lv_other_masterlist.Columns.Clear()

        With Me.lv_other_masterlist
            .Columns.Add("Id", "")
            .Columns.Add("Count", "#")
            .Columns.Add("subcon", "Owner Name")

            .Columns("Id").Width = 0
            .Columns("Id").Visible = False
            .Columns("Count").Width = 40
            .Columns("subcon").Width = 1000

            .FullRowSelect = True
            '.ShowGridLines = True
            .MultiSelect = False

            Me.lv_other_masterlist.EnableGrouping = False
            Me.lv_other_masterlist.ShowGroups = False
        End With
    End Sub

    'EQUIPMENT TYPE
    Sub equiptype_column()
        Me.lv_other_masterlist.Columns.Clear()

        With Me.lv_other_masterlist
            .Columns.Add("Id", "")
            .Columns.Add("Count", "#")
            .Columns.Add("equiptype", "EQUIPMENT TYPE")

            .Columns("Id").Width = 0
            .Columns("Id").Visible = False
            .Columns("Count").Width = 40
            .Columns("equiptype").Width = 1000

            .FullRowSelect = True
            '.ShowGridLines = True
            .MultiSelect = False

            Me.lv_other_masterlist.EnableGrouping = False
            Me.lv_other_masterlist.ShowGroups = False
        End With
    End Sub

    'EQUIPMENT BRAND
    Sub equipbrand_column()
        Me.lv_other_masterlist.Columns.Clear()

        With Me.lv_other_masterlist
            .Columns.Add("Id", "")
            .Columns.Add("Count", "#")
            .Columns.Add("equipbrand", "EQUIPMENT BRAND")

            .Columns("Id").Width = 0
            .Columns("Id").Visible = False
            .Columns("Count").Width = 40
            .Columns("equipbrand").Width = 1000

            .FullRowSelect = True
            '.ShowGridLines = True
            .MultiSelect = False

            Me.lv_other_masterlist.EnableGrouping = False
            Me.lv_other_masterlist.ShowGroups = False
        End With
    End Sub

    'DRIVER NAMES
    Sub driver_column()
        Me.lv_other_masterlist.Columns.Clear()

        With Me.lv_other_masterlist
            .Columns.Add("Id", "")
            .Columns.Add("Count", "#")
            .Columns.Add("driver", "DRIVER NAME")

            .Columns("Id").Width = 0
            .Columns("Id").Visible = False
            .Columns("Count").Width = 40
            .Columns("driver").Width = 1000

            .FullRowSelect = True
            '.ShowGridLines = True
            .MultiSelect = False

            Me.lv_other_masterlist.EnableGrouping = False
            Me.lv_other_masterlist.ShowGroups = False
        End With
    End Sub

    'IMPLEMENT LIST
    Sub implementlist_column()
        Me.lv_other_masterlist.Columns.Clear()

        With Me.lv_other_masterlist
            .Columns.Add("Id", "")
            .Columns.Add("Count", "#")
            .Columns.Add("implelist", "IMPLEMENT DESCRIPTION")

            .Columns("Id").Width = 0
            .Columns("Id").Visible = False
            .Columns("Count").Width = 40
            .Columns("implelist").Width = 1000

            .FullRowSelect = True
            '.ShowGridLines = True
            .MultiSelect = False

            Me.lv_other_masterlist.EnableGrouping = False
            Me.lv_other_masterlist.ShowGroups = False
        End With
    End Sub

    'VARIETY
    Sub variety_column()
        Me.lv_other_masterlist.Columns.Clear()

        With Me.lv_other_masterlist
            .Columns.Add("Id", "")
            .Columns.Add("Count", "#")
            .Columns.Add("Variety/Culture", "VARIETY")

            .Columns("Id").Width = 0
            .Columns("Id").Visible = False
            .Columns("Count").Width = 40
            .Columns("Variety/Culture").Width = 1000

            .FullRowSelect = True
            '.ShowGridLines = True
            .MultiSelect = False

            Me.lv_other_masterlist.EnableGrouping = False
            Me.lv_other_masterlist.ShowGroups = False
        End With
    End Sub

#End Region

    Private Sub Frm_master_list_other_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ThemeResolutionService.ApplicationThemeName = My.Settings.global_themes
        'Farming_Operation.Server_time()

        Me.dp_masterlistitem.SelectedIndex = 0
    End Sub

    Private Sub dp_masterlistitem_SelectedIndexChanged(sender As Object, e As UI.Data.PositionChangedEventArgs) Handles dp_masterlistitem.SelectedIndexChanged
        Select Case Me.dp_masterlistitem.SelectedIndex
            Case 0 'LOCATION
                Me.gb_location.Location = New Point(2, 101)
                Me.gb_location.BringToFront()
                location_column()
                other_masterlist_view.location_listview()


                Dim groupByType As New GroupDescriptor(New SortDescriptor() {New SortDescriptor("Province", ListSortDirection.Descending)})
                Me.lv_other_masterlist.GroupDescriptors.Add(groupByType)

                Me.add.Enabled = True
                Me.update.Enabled = True
                Me.delete.Enabled = True
                Me.txt_location_search.Enabled = True
            Case 1 ' WORK OPERATION CATEGORY

                Me.gb_work_operation.Location = New Point(2, 101)
                Me.gb_work_operation.BringToFront()
                Me.gb_work_operation.Visible = True
                operation_category_column()
                other_masterlist_view.operation_category_listview()
                Me.add.Enabled = True
                Me.update.Enabled = True
                Me.delete.Enabled = True
                Me.txt_location_search.Enabled = True
            Case 2 'ASSOCIATION
                Me.gb_association.Location = New Point(2, 101)
                Me.gb_association.BringToFront()
                Me.gb_association.Visible = True
                association_column()
                other_masterlist_view.association_listview()
                Me.add.Enabled = False
                Me.update.Enabled = False
                Me.delete.Enabled = False
                Me.txt_location_search.Enabled = False
            Case 3 'VARIETY / CULTURE
                Me.gb_variety.Location = New Point(2, 101)
                Me.gb_variety.BringToFront()
                Me.gb_variety.Visible = True
                culture_column()
                other_masterlist_view.variety_listview()
                Me.add.Enabled = True
                Me.update.Enabled = True
                Me.delete.Enabled = True
                Me.txt_location_search.Enabled = False
            Case 4 'SUB CONTRACTOR NAME
                Me.gb_subcon.Location = New Point(2, 101)
                Me.gb_subcon.BringToFront()
                Me.gb_subcon.Visible = True
                subcon_column()
                other_masterlist_view.subcon_listview()
                Me.add.Enabled = True
                Me.update.Enabled = True
                Me.delete.Enabled = True
                Me.txt_location_search.Enabled = True
            Case 5 'EQUIPMENT TYPE
                Me.gb_equiptype.Location = New Point(2, 101)
                Me.gb_equiptype.BringToFront()
                Me.gb_equiptype.Visible = True
                equiptype_column()
                other_masterlist_view.equiptype_listview()
                Me.add.Enabled = True
                Me.update.Enabled = True
                Me.delete.Enabled = True
                Me.txt_location_search.Enabled = True
            Case 6 'EQUIPMENT BRAND
                Me.gb_equipbrand.Location = New Point(2, 101)
                Me.gb_equipbrand.BringToFront()
                Me.gb_equipbrand.Visible = True
                equipbrand_column()
                other_masterlist_view.equipbrand_listview()
                Me.add.Enabled = True
                Me.update.Enabled = True
                Me.delete.Enabled = True
                Me.txt_location_search.Enabled = True
            Case 7 'EQUIPMENT DRIVER
                Me.gb_driver.Location = New Point(2, 101)
                Me.gb_driver.BringToFront()
                Me.gb_driver.Visible = True
                driver_column()
                other_masterlist_view.driver_listview()
                Me.add.Enabled = True
                Me.update.Enabled = True
                Me.delete.Enabled = True
                Me.txt_location_search.Enabled = True

            Case 8 'IMPLEMENT LIST
                Me.gb_implemet_list.Location = New Point(2, 101)
                Me.gb_implemet_list.BringToFront()
                Me.gb_implemet_list.Visible = True
                implementlist_column()
                other_masterlist_view.implementlist_listview()
                Me.add.Enabled = True
                Me.update.Enabled = True
                Me.delete.Enabled = True
                Me.txt_location_search.Enabled = True

                ' Case 9 'VARIETY
                'Me.gb_implemet_list.Location = New Point(2, 101)
                'Me.gb_implemet_list.BringToFront()
                ' Me.gb_implemet_list.Visible = True
                '      variety_column()
                'other_masterlist_view.implementlist_listview()
                'Me.add.Enabled = True
                'Me.update.Enabled = True
                'Me.delete.Enabled = True
                '      Me.txt_location_search.Enabled = True
        End Select
    End Sub

    Private Sub btn_global_save_Click(sender As Object, e As EventArgs) Handles btn_global_save.Click
        Select Case Me.dp_masterlistitem.SelectedIndex
            Case 0 'LOCATION (ADD and UPDATE)
                If command_contxt = 1 Then
                    sysmod.Add_location(Replace(Trim(Me.txt_loc_province.Text), "'", "`"), Replace(Trim(Me.txt_loc_municipality.Text), "'", "`"), Replace((Me.txt_loc_location.Text), "'", "`"))
                ElseIf command_contxt = 2 Then
                    sysmod.Update_location(Replace(Trim(Me.txt_loc_province.Text), "'", "`"), Replace(Trim(Me.txt_loc_municipality.Text), "'", "`"), Replace((Me.txt_loc_location.Text), "'", "`"), slct_id)
                Else
                    MsgBox("No command... need administrator assistant")
                    Exit Sub
                End If

                If sysmod.msgb <> 1 Then

                    MsgBox(sysmod.msgS, vbInformation + vbOKOnly, "AIS: Successful")
                    other_masterlist_view.location_listview()
                    other_masterlist_view.Location_clear_control()
                    other_masterlist_view.disabled_location()
                Else
                    MsgBox(sysmod.msgS, vbExclamation + vbOKOnly, "AIS: ERROR...")
                End If

            Case 1 'WORK OPERATION (ADD and UPDATE)
                If command_contxt = 1 Then
                    sysmod.Add_operation_category(Replace(Trim(Me.txt_category_desc.Text), "'", "`"))
                ElseIf command_contxt = 2 Then
                    sysmod.Update_operation_category(Replace(Trim(Me.txt_category_desc.Text), "'", "`"), slct_id)
                Else
                    MsgBox("No command nedd administrator assistant")
                    Exit Sub
                End If

                If sysmod.msgb <> 1 Then

                    MsgBox(sysmod.msgS, vbInformation + vbOKOnly, "AIS: Successful")
                    other_masterlist_view.operation_category_listview()
                    other_masterlist_view.Operation_category_clear_control()
                    other_masterlist_view.disabled_operation_category()
                Else
                    MsgBox(sysmod.msgS, vbExclamation + vbOKOnly, "AIS: ERROR...")
                End If
            Case 2 'ASSOCIATION (ADD and UPDATE)
                If command_contxt = 2 Then
                    sysmod.Update_association(Replace(Trim(Me.txt_association.Text), "'", "`"), slct_id)
                Else
                    MsgBox("No command nedd administrator assistant")
                    Exit Sub
                End If

                If sysmod.msgb <> 1 Then

                    MsgBox(sysmod.msgS, vbInformation + vbOKOnly, "AIS: Successful")
                    other_masterlist_view.association_listview()
                    other_masterlist_view.association_clear_control()
                    other_masterlist_view.disabled_association()
                Else
                    MsgBox(sysmod.msgS, vbExclamation + vbOKOnly, "AIS: ERROR...")
                End If
            Case 3 'VARIETY / CULTURE
                If command_contxt = 1 Then
                    sysmod.Add_variety(Replace(Trim(Me.txt_variety.Text), "'", "`"))
                ElseIf command_contxt = 2 Then
                    sysmod.Update_variety(Replace(Trim(Me.txt_variety.Text), "'", "`"), slct_id)
                Else
                    MsgBox("No command nedd administrator assistant")
                    Exit Sub
                End If

                If sysmod.msgb <> 1 Then

                    MsgBox(sysmod.msgS, vbInformation + vbOKOnly, "AIS: Successful")
                    other_masterlist_view.variety_listview()
                    other_masterlist_view.variety_clear_control()
                    other_masterlist_view.disabled_variety()
                Else
                    MsgBox(sysmod.msgS, vbExclamation + vbOKOnly, "AIS: ERROR...")
                End If

            Case 4 'SUB CONTRACTOR
                If command_contxt = 1 Then
                    sysmod.Add_subcon(Replace(Trim(Me.txt_subconname.Text), "'", "`"))
                ElseIf command_contxt = 2 Then
                    sysmod.Update_subcon(Replace(Trim(Me.txt_subconname.Text), "'", "`"), slct_id)
                Else
                    MsgBox("No command nedd administrator assistant")
                    Exit Sub
                End If

                If sysmod.msgb <> 1 Then

                    MsgBox(sysmod.msgS, vbInformation + vbOKOnly, "AIS: Successful")
                    other_masterlist_view.subcon_listview()
                    other_masterlist_view.subcon_clear_control()
                    other_masterlist_view.disabled_subcon()
                Else
                    MsgBox(sysmod.msgS, vbExclamation + vbOKOnly, "AIS: ERROR...")
                End If

            Case 5 'EQUIPMENT TYPE
                If command_contxt = 1 Then
                    sysmod.Add_equiptype(Replace(Trim(Me.txt_equiptype.Text), "'", "`"))
                ElseIf command_contxt = 2 Then
                    sysmod.Update_equiptype(Replace(Trim(Me.txt_equiptype.Text), "'", "`"), slct_id)
                Else
                    MsgBox("No command nedd administrator assistant")
                    Exit Sub
                End If

                If sysmod.msgb <> 1 Then

                    MsgBox(sysmod.msgS, vbInformation + vbOKOnly, "AIS: Successful")
                    other_masterlist_view.equiptype_listview()
                    other_masterlist_view.equiptype_clear_control()
                    other_masterlist_view.disabled_equiptype()
                Else
                    MsgBox(sysmod.msgS, vbExclamation + vbOKOnly, "AIS: ERROR...")
                End If

            Case 6 'EQUIPMENT BRAND
                If command_contxt = 1 Then
                    sysmod.Add_equipbrand(Replace(Trim(Me.txt_equipbrand.Text), "'", "`"))
                ElseIf command_contxt = 2 Then
                    sysmod.Update_equipbrand(Replace(Trim(Me.txt_equipbrand.Text), "'", "`"), slct_id)
                Else
                    MsgBox("No command nedd administrator assistant")
                    Exit Sub
                End If

                If sysmod.msgb <> 1 Then

                    MsgBox(sysmod.msgS, vbInformation + vbOKOnly, "AIS: Successful")
                    other_masterlist_view.equipbrand_listview()
                    other_masterlist_view.equipbrand_clear_control()
                    other_masterlist_view.disabled_equipbrand()
                Else
                    MsgBox(sysmod.msgS, vbExclamation + vbOKOnly, "AIS: ERROR...")
                End If

            Case 7 'EQUIPMENT DRIVER
                If command_contxt = 1 Then
                    sysmod.Add_driver(Replace(Trim(Me.txt_driver_name.Text), "'", "`"))
                ElseIf command_contxt = 2 Then
                    sysmod.Update_driver(Replace(Trim(Me.txt_driver_name.Text), "'", "`"), slct_id)
                Else
                    MsgBox("No command nedd administrator assistant")
                    Exit Sub
                End If

                If sysmod.msgb <> 1 Then

                    MsgBox(sysmod.msgS, vbInformation + vbOKOnly, "AIS: Successful")
                    other_masterlist_view.driver_listview()
                    other_masterlist_view.driver_clear_control()
                    other_masterlist_view.disabled_driver()
                Else
                    MsgBox(sysmod.msgS, vbExclamation + vbOKOnly, "AIS: ERROR...")
                End If

            Case 8 'IMPLEMENT LIST
                If command_contxt = 1 Then
                    sysmod.Add_implementlist(Replace(Trim(Me.txt_impledescription.Text), "'", "`"))
                ElseIf command_contxt = 2 Then
                    sysmod.Update_implementlist(Replace(Trim(Me.txt_impledescription.Text), "'", "`"), slct_id)
                Else
                    MsgBox("No command nedd administrator assistant")
                    Exit Sub
                End If

                If sysmod.msgb <> 1 Then

                    MsgBox(sysmod.msgS, vbInformation + vbOKOnly, "AIS: Successful")
                    other_masterlist_view.implementlist_listview()
                    other_masterlist_view.implementlist_clear_control()
                    other_masterlist_view.disabled_implementlist()
                Else
                    MsgBox(sysmod.msgS, vbExclamation + vbOKOnly, "AIS: ERROR...")
                End If
        End Select
    End Sub

    Private Sub refresh_Click(sender As Object, e As EventArgs) Handles refresh.Click
        Select Case Me.dp_masterlistitem.SelectedIndex
            Case 0 'LOCATION
                other_masterlist_view.location_listview()
                command_contxt = 0
                slct_id = Nothing
            Case 1 'WORK OPERATION
                other_masterlist_view.operation_category_listview()
                command_contxt = 0
                slct_id = Nothing
            Case 2 'ASSOCIATION
                other_masterlist_view.association_listview()
                command_contxt = 0
                slct_id = Nothing
            Case 3 'VARIETY
                other_masterlist_view.variety_listview()
                command_contxt = 0
                slct_id = Nothing
            Case 4 'SUB CONTRACTOR
                other_masterlist_view.subcon_listview()
                command_contxt = 0
                slct_id = Nothing
            Case 5 'EQUIPMENT TYPE
                other_masterlist_view.equiptype_listview()
                command_contxt = 0
                slct_id = Nothing
            Case 6 'EQUIPMENT BRAND
                other_masterlist_view.equipbrand_listview()
                command_contxt = 0
                slct_id = Nothing
            Case 7 'EQUIPMENT DRIVER
                other_masterlist_view.driver_listview()
                command_contxt = 0
                slct_id = Nothing
            Case 8 'IMPLEMENT LIST
                other_masterlist_view.implementlist_listview()
                command_contxt = 0
                slct_id = Nothing
        End Select

    End Sub
    Private Sub update_Click(sender As Object, e As EventArgs) Handles update.Click

        If slct_id = Nothing Then
            MsgBox("No selected data")
        Else
            Select Case Me.dp_masterlistitem.SelectedIndex
                Case 0 'LOCATION
                    command_contxt = 2
                    other_masterlist_view.location_updatevalue()
                    other_masterlist_view.enable_location()
                Case 1 'WORK OPERATION CATEGORY
                    command_contxt = 2
                    other_masterlist_view.operation_category_updatevalue()
                    other_masterlist_view.enabled_operation_category()
                Case 2 'ASSOCIATIOn
                    command_contxt = 2
                    other_masterlist_view.association_updatevalue()
                    other_masterlist_view.enabled_association()
                Case 3 'VARIETY
                    command_contxt = 2
                    other_masterlist_view.variety_updatevalue()
                    other_masterlist_view.enabled_variety()
                Case 4 'SUB CONTRACTOR

                    If slct_id = "1" Or slct_id = "2" Or slct_id = "3" Then
                        MsgBox("Unabled to make changes to this Data.", vbInformation + vbOKOnly, "WARNING...")
                    Else
                        command_contxt = 2
                        other_masterlist_view.subcon_updatevalue()
                        other_masterlist_view.enabled_subcon()
                    End If
                Case 5 'EQUIPMENT TYPE
                    command_contxt = 2
                    other_masterlist_view.equiptype_updatevalue()
                    other_masterlist_view.enabled_equiptype()
                Case 6 'EQUIPMENT BRAND
                    command_contxt = 2
                    other_masterlist_view.equipbrand_updatevalue()
                    other_masterlist_view.enabled_equipbrand()
                Case 7 'EQUIPMENT DRIVER
                    command_contxt = 2
                    other_masterlist_view.driver_updatevalue()
                    other_masterlist_view.enabled_driver()
                Case 8 'IMPLEMENT LIST
                    command_contxt = 2
                    other_masterlist_view.implementlist_updatevalue()
                    other_masterlist_view.enabled_implementlist()
            End Select
        End If
    End Sub
    Private Sub add_Click(sender As Object, e As EventArgs) Handles add.Click
        command_contxt = 1

        ' other_masterlist_view.Location_clear_control()

        Select Case Me.dp_masterlistitem.SelectedIndex
            Case 0 'LOCATION
                other_masterlist_view.enable_location()
            Case 1 'WORK OPERATION CATEGORY
                other_masterlist_view.enabled_operation_category()
            Case 2 'ASSOCIATION
                other_masterlist_view.enabled_association()
            Case 3 'VARIETY
                other_masterlist_view.enabled_variety()
            Case 4 'SUB CON
                other_masterlist_view.enabled_subcon()
            Case 5 'EQUIPMENT TYPE
                other_masterlist_view.enabled_equiptype()
            Case 6 'EQUIPMENT BRAND
                other_masterlist_view.enabled_equipbrand()
            Case 7 'EQUIPMENT DRIVER
                other_masterlist_view.enabled_driver()
            Case 8 'IMPLEMENT LIST
                other_masterlist_view.enabled_implementlist()
        End Select
    End Sub
    Private Sub txt_location_search_TextChanged(sender As Object, e As EventArgs) Handles txt_location_search.TextChanged
        Select Case Me.dp_masterlistitem.SelectedIndex
            Case 0 'LOCATION
                other_masterlist_view.location_search(Replace(Trim(Me.txt_location_search.Text), "'", "`"))
            Case 1 'OPERATION CATEGORY
                other_masterlist_view.operation_category_search(Replace(Trim(Me.txt_location_search.Text), "'", "`"))
            Case 4 'SUB CONTRACTOR
                other_masterlist_view.subcon_search(Replace(Trim(Me.txt_location_search.Text), "'", "`"))
            Case 5 'EQUIPMENT TYPE
                other_masterlist_view.equiptype_search(Replace(Trim(Me.txt_location_search.Text), "'", "`"))
            Case 6 'EQUIPMENT BRAND
                other_masterlist_view.equipbrande_search(Replace(Trim(Me.txt_location_search.Text), "'", "`"))
            Case 7 'EQUIPMENT DRIVER
                other_masterlist_view.driver_search(Replace(Trim(Me.txt_location_search.Text), "'", "`"))
            Case 8 'IMPLEMENT LIST
                other_masterlist_view.implementlist_search(Replace(Trim(Me.txt_impledescription.Text), "'", "`"))
        End Select
    End Sub
    Private Sub btn_global_cancel_Click(sender As Object, e As EventArgs) Handles btn_global_cancel.Click
        Select Case Me.dp_masterlistitem.SelectedIndex
            Case 0 'LOCATION
                other_masterlist_view.Location_clear_control()
                other_masterlist_view.disabled_location()
            Case 1 'WORK OPERATION CATEGORY
                other_masterlist_view.Operation_category_clear_control()
                other_masterlist_view.disabled_operation_category()
            Case 2 'ASSOCIATION
                other_masterlist_view.association_clear_control()
                other_masterlist_view.disabled_association()
            Case 3 'VARIETY
                other_masterlist_view.variety_clear_control()
                other_masterlist_view.disabled_variety()
            Case 4 'SUB CONTRACTOR
                other_masterlist_view.subcon_clear_control()
                other_masterlist_view.disabled_subcon()
            Case 5 'EQUIPMENT TYPE
                other_masterlist_view.equiptype_clear_control()
                other_masterlist_view.disabled_equiptype()
            Case 6 'EQUIPMENT BRAND
                other_masterlist_view.equipbrand_clear_control()
                other_masterlist_view.disabled_equipbrand()
            Case 7 'EQUIPMENT DRIVER
                other_masterlist_view.driver_clear_control()
                other_masterlist_view.disabled_driver()
            Case 8 'IMPLEMENT LIST
                other_masterlist_view.driver_clear_control()
                other_masterlist_view.disabled_driver()
        End Select
    End Sub

    Private Sub delete_Click(sender As Object, e As EventArgs) Handles delete.Click
        Select Case Me.dp_masterlistitem.SelectedIndex
            Case 0 'LOCATION
                sysmod.Delete_location(slct_id)
                other_masterlist_view.location_listview()
            Case 1 'OPERATION CATEGORY
                sysmod.Delete_operation_category(slct_id)
                other_masterlist_view.operation_category_listview()
            Case 3 'VARIETY
                sysmod.Delete_variety(slct_id)
                other_masterlist_view.variety_listview()
            Case 4 'SUB CONTRACTOR
                If slct_id = "1" Or slct_id = "2" Or slct_id = "3" Then
                    MsgBox("Unabled to Delete this Data.", vbCritical + vbOKOnly, "WARNING...")
                Else
                    sysmod.Delete_subcon(slct_id)
                    other_masterlist_view.subcon_listview()
                End If
            Case 5 'EQUIPMENT TYPE
                sysmod.Delete_equiptype(slct_id)
                other_masterlist_view.equiptype_listview()
            Case 6 'EQUIPMENT BRAND
                sysmod.Delete_equipbrand(slct_id)
                other_masterlist_view.equipbrand_listview()
            Case 7 'EQUIPMENT DRIVER
                sysmod.Delete_driver(slct_id)
                other_masterlist_view.driver_listview()
            Case 8 'IMPLEMENT LIST
                sysmod.Delete_implementlist(slct_id)
                other_masterlist_view.implementlist_listview()
        End Select
    End Sub

    Private Sub lv_other_masterlist_MouseDown(sender As Object, e As MouseEventArgs) Handles lv_other_masterlist.MouseDown
        If e.Button = Windows.Forms.MouseButtons.Right Then
            Me.cms_global_menu.Show(Me, Me.PointToClient(MousePosition))
        End If
    End Sub

    Private Sub lv_other_masterlist_SelectedItemChanged(sender As Object, e As EventArgs) Handles lv_other_masterlist.SelectedItemChanged
        other_masterlist_view.Global_selected()
    End Sub

    Private Sub lv_other_masterlist_CellFormatting(sender As Object, e As ListViewCellFormattingEventArgs) Handles lv_other_masterlist.CellFormatting
        sysmod.RadLV_format_global(e)

        If (e.CellElement).Data.Name = "Count" Then
            If (TypeOf e.CellElement Is DetailListViewHeaderCellElement) Then
                e.CellElement.TextAlignment = ContentAlignment.MiddleCenter
            End If

            If (TypeOf e.CellElement Is DetailListViewDataCellElement) Then
                e.CellElement.TextAlignment = ContentAlignment.MiddleCenter
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
End Class
