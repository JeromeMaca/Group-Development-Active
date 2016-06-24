<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Frm_user_control_maintenace
    Inherits Telerik.WinControls.UI.RadForm

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim RadListDataItem8 As Telerik.WinControls.UI.RadListDataItem = New Telerik.WinControls.UI.RadListDataItem()
        Dim RadListDataItem9 As Telerik.WinControls.UI.RadListDataItem = New Telerik.WinControls.UI.RadListDataItem()
        Dim RadListDataItem10 As Telerik.WinControls.UI.RadListDataItem = New Telerik.WinControls.UI.RadListDataItem()
        Dim RadListDataItem11 As Telerik.WinControls.UI.RadListDataItem = New Telerik.WinControls.UI.RadListDataItem()
        Dim RadListDataItem12 As Telerik.WinControls.UI.RadListDataItem = New Telerik.WinControls.UI.RadListDataItem()
        Dim RadListDataItem13 As Telerik.WinControls.UI.RadListDataItem = New Telerik.WinControls.UI.RadListDataItem()
        Dim RadListDataItem14 As Telerik.WinControls.UI.RadListDataItem = New Telerik.WinControls.UI.RadListDataItem()
        Me.gb_menu = New Telerik.WinControls.UI.RadGroupBox()
        Me.RadLabel9 = New Telerik.WinControls.UI.RadLabel()
        Me.dp_usertype = New Telerik.WinControls.UI.RadDropDownList()
        Me.txt_lname = New Telerik.WinControls.UI.RadTextBox()
        Me.RadLabel7 = New Telerik.WinControls.UI.RadLabel()
        Me.txt_mname = New Telerik.WinControls.UI.RadTextBox()
        Me.RadLabel6 = New Telerik.WinControls.UI.RadLabel()
        Me.txt_fname = New Telerik.WinControls.UI.RadTextBox()
        Me.RadLabel5 = New Telerik.WinControls.UI.RadLabel()
        Me.txt_confirm_pass = New Telerik.WinControls.UI.RadTextBox()
        Me.RadLabel3 = New Telerik.WinControls.UI.RadLabel()
        Me.txt_password = New Telerik.WinControls.UI.RadTextBox()
        Me.RadLabel2 = New Telerik.WinControls.UI.RadLabel()
        Me.txt_username = New Telerik.WinControls.UI.RadTextBox()
        Me.btn_canceluser = New Telerik.WinControls.UI.RadButton()
        Me.RadLabel1 = New Telerik.WinControls.UI.RadLabel()
        Me.btn_saveuser = New Telerik.WinControls.UI.RadButton()
        Me.gb_data = New Telerik.WinControls.UI.RadGroupBox()
        Me.txt_searchuser = New Telerik.WinControls.UI.RadTextBox()
        Me.RadLabel4 = New Telerik.WinControls.UI.RadLabel()
        Me.lv_useraccountlist = New Telerik.WinControls.UI.RadListView()
        Me.cms_usermenu = New Telerik.WinControls.UI.RadContextMenu(Me.components)
        Me.refreshuser = New Telerik.WinControls.UI.RadMenuItem()
        Me.RadMenuSeparatorItem1 = New Telerik.WinControls.UI.RadMenuSeparatorItem()
        Me.createuser = New Telerik.WinControls.UI.RadMenuItem()
        Me.modifyuser = New Telerik.WinControls.UI.RadMenuItem()
        Me.removeuser = New Telerik.WinControls.UI.RadMenuItem()
        Me.RadMenuSeparatorItem2 = New Telerik.WinControls.UI.RadMenuSeparatorItem()
        Me.assignedpermissionuser = New Telerik.WinControls.UI.RadMenuItem()
        CType(Me.gb_menu, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gb_menu.SuspendLayout()
        CType(Me.RadLabel9, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dp_usertype, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_lname, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_mname, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_fname, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_confirm_pass, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_password, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_username, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btn_canceluser, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btn_saveuser, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gb_data, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gb_data.SuspendLayout()
        CType(Me.txt_searchuser, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lv_useraccountlist, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'gb_menu
        '
        Me.gb_menu.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping
        Me.gb_menu.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.gb_menu.Controls.Add(Me.RadLabel9)
        Me.gb_menu.Controls.Add(Me.dp_usertype)
        Me.gb_menu.Controls.Add(Me.txt_lname)
        Me.gb_menu.Controls.Add(Me.RadLabel7)
        Me.gb_menu.Controls.Add(Me.txt_mname)
        Me.gb_menu.Controls.Add(Me.RadLabel6)
        Me.gb_menu.Controls.Add(Me.txt_fname)
        Me.gb_menu.Controls.Add(Me.RadLabel5)
        Me.gb_menu.Controls.Add(Me.txt_confirm_pass)
        Me.gb_menu.Controls.Add(Me.RadLabel3)
        Me.gb_menu.Controls.Add(Me.txt_password)
        Me.gb_menu.Controls.Add(Me.RadLabel2)
        Me.gb_menu.Controls.Add(Me.txt_username)
        Me.gb_menu.Controls.Add(Me.btn_canceluser)
        Me.gb_menu.Controls.Add(Me.RadLabel1)
        Me.gb_menu.Controls.Add(Me.btn_saveuser)
        Me.gb_menu.Enabled = False
        Me.gb_menu.HeaderText = ""
        Me.gb_menu.Location = New System.Drawing.Point(1, 3)
        Me.gb_menu.Name = "gb_menu"
        Me.gb_menu.Size = New System.Drawing.Size(360, 609)
        Me.gb_menu.TabIndex = 1
        '
        'RadLabel9
        '
        Me.RadLabel9.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadLabel9.Location = New System.Drawing.Point(18, 285)
        Me.RadLabel9.Name = "RadLabel9"
        Me.RadLabel9.Size = New System.Drawing.Size(67, 19)
        Me.RadLabel9.TabIndex = 140
        Me.RadLabel9.Text = "User Type:"
        '
        'dp_usertype
        '
        Me.dp_usertype.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dp_usertype.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.dp_usertype.DropDownStyle = Telerik.WinControls.RadDropDownStyle.DropDownList
        Me.dp_usertype.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold)
        RadListDataItem8.Enabled = False
        RadListDataItem8.Text = "SYSTEM DMINISTRATOR"
        RadListDataItem8.TextWrap = True
        RadListDataItem9.Text = "ADMINISTRATOR"
        RadListDataItem9.TextWrap = True
        RadListDataItem10.Text = "MANAGER"
        RadListDataItem10.TextWrap = True
        RadListDataItem11.Text = "FINANCE"
        RadListDataItem11.TextWrap = True
        RadListDataItem12.Text = "FARM MANAGER"
        RadListDataItem12.TextWrap = True
        RadListDataItem13.Text = "FARM SUPERVISOR"
        RadListDataItem13.TextWrap = True
        RadListDataItem14.Text = "BASIC USER"
        RadListDataItem14.TextWrap = True
        Me.dp_usertype.Items.Add(RadListDataItem8)
        Me.dp_usertype.Items.Add(RadListDataItem9)
        Me.dp_usertype.Items.Add(RadListDataItem10)
        Me.dp_usertype.Items.Add(RadListDataItem11)
        Me.dp_usertype.Items.Add(RadListDataItem12)
        Me.dp_usertype.Items.Add(RadListDataItem13)
        Me.dp_usertype.Items.Add(RadListDataItem14)
        Me.dp_usertype.Location = New System.Drawing.Point(38, 305)
        Me.dp_usertype.Name = "dp_usertype"
        Me.dp_usertype.NullText = "<Required>"
        '
        '
        '
        Me.dp_usertype.RootElement.StretchVertically = True
        Me.dp_usertype.Size = New System.Drawing.Size(274, 20)
        Me.dp_usertype.TabIndex = 139
        CType(Me.dp_usertype.GetChildAt(0), Telerik.WinControls.UI.RadDropDownListElement).DropDownStyle = Telerik.WinControls.RadDropDownStyle.DropDownList
        CType(Me.dp_usertype.GetChildAt(0), Telerik.WinControls.UI.RadDropDownListElement).Alignment = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txt_lname
        '
        Me.txt_lname.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_lname.Location = New System.Drawing.Point(38, 259)
        Me.txt_lname.Name = "txt_lname"
        Me.txt_lname.NullText = "<Required>"
        Me.txt_lname.Size = New System.Drawing.Size(274, 20)
        Me.txt_lname.TabIndex = 136
        '
        'RadLabel7
        '
        Me.RadLabel7.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadLabel7.Location = New System.Drawing.Point(18, 241)
        Me.RadLabel7.Name = "RadLabel7"
        Me.RadLabel7.Size = New System.Drawing.Size(100, 19)
        Me.RadLabel7.TabIndex = 135
        Me.RadLabel7.Text = "User Last Name:"
        '
        'txt_mname
        '
        Me.txt_mname.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_mname.Location = New System.Drawing.Point(38, 215)
        Me.txt_mname.Name = "txt_mname"
        Me.txt_mname.NullText = "<Required>"
        Me.txt_mname.Size = New System.Drawing.Size(274, 20)
        Me.txt_mname.TabIndex = 134
        '
        'RadLabel6
        '
        Me.RadLabel6.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadLabel6.Location = New System.Drawing.Point(18, 197)
        Me.RadLabel6.Name = "RadLabel6"
        Me.RadLabel6.Size = New System.Drawing.Size(118, 19)
        Me.RadLabel6.TabIndex = 133
        Me.RadLabel6.Text = "User Middle Name:"
        '
        'txt_fname
        '
        Me.txt_fname.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_fname.Location = New System.Drawing.Point(38, 171)
        Me.txt_fname.Name = "txt_fname"
        Me.txt_fname.NullText = "<Required>"
        Me.txt_fname.Size = New System.Drawing.Size(274, 20)
        Me.txt_fname.TabIndex = 132
        '
        'RadLabel5
        '
        Me.RadLabel5.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadLabel5.Location = New System.Drawing.Point(18, 153)
        Me.RadLabel5.Name = "RadLabel5"
        Me.RadLabel5.Size = New System.Drawing.Size(102, 19)
        Me.RadLabel5.TabIndex = 131
        Me.RadLabel5.Text = "User First Name:"
        '
        'txt_confirm_pass
        '
        Me.txt_confirm_pass.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_confirm_pass.Location = New System.Drawing.Point(38, 127)
        Me.txt_confirm_pass.Name = "txt_confirm_pass"
        Me.txt_confirm_pass.NullText = "<Required>"
        Me.txt_confirm_pass.Size = New System.Drawing.Size(274, 20)
        Me.txt_confirm_pass.TabIndex = 130
        '
        'RadLabel3
        '
        Me.RadLabel3.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadLabel3.Location = New System.Drawing.Point(18, 109)
        Me.RadLabel3.Name = "RadLabel3"
        Me.RadLabel3.Size = New System.Drawing.Size(145, 19)
        Me.RadLabel3.TabIndex = 129
        Me.RadLabel3.Text = "Confirm New Password:"
        '
        'txt_password
        '
        Me.txt_password.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_password.Location = New System.Drawing.Point(38, 83)
        Me.txt_password.Name = "txt_password"
        Me.txt_password.NullText = "<Required>"
        Me.txt_password.Size = New System.Drawing.Size(274, 20)
        Me.txt_password.TabIndex = 128
        '
        'RadLabel2
        '
        Me.RadLabel2.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadLabel2.Location = New System.Drawing.Point(18, 65)
        Me.RadLabel2.Name = "RadLabel2"
        Me.RadLabel2.Size = New System.Drawing.Size(95, 19)
        Me.RadLabel2.TabIndex = 127
        Me.RadLabel2.Text = "New Password:"
        '
        'txt_username
        '
        Me.txt_username.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_username.Location = New System.Drawing.Point(38, 39)
        Me.txt_username.Name = "txt_username"
        Me.txt_username.NullText = "<Required>"
        Me.txt_username.Size = New System.Drawing.Size(274, 20)
        Me.txt_username.TabIndex = 0
        Me.txt_username.TabStop = False
        '
        'btn_canceluser
        '
        Me.btn_canceluser.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_canceluser.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold)
        Me.btn_canceluser.Location = New System.Drawing.Point(244, 580)
        Me.btn_canceluser.Name = "btn_canceluser"
        Me.btn_canceluser.Size = New System.Drawing.Size(110, 24)
        Me.btn_canceluser.TabIndex = 125
        Me.btn_canceluser.Text = "Cancel User"
        '
        'RadLabel1
        '
        Me.RadLabel1.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadLabel1.Location = New System.Drawing.Point(18, 21)
        Me.RadLabel1.Name = "RadLabel1"
        Me.RadLabel1.Size = New System.Drawing.Size(74, 19)
        Me.RadLabel1.TabIndex = 124
        Me.RadLabel1.Text = "User Name:"
        '
        'btn_saveuser
        '
        Me.btn_saveuser.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_saveuser.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold)
        Me.btn_saveuser.Location = New System.Drawing.Point(128, 580)
        Me.btn_saveuser.Name = "btn_saveuser"
        Me.btn_saveuser.Size = New System.Drawing.Size(110, 24)
        Me.btn_saveuser.TabIndex = 123
        Me.btn_saveuser.Text = "Save User"
        '
        'gb_data
        '
        Me.gb_data.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping
        Me.gb_data.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gb_data.Controls.Add(Me.txt_searchuser)
        Me.gb_data.Controls.Add(Me.RadLabel4)
        Me.gb_data.Controls.Add(Me.lv_useraccountlist)
        Me.gb_data.HeaderText = ""
        Me.gb_data.Location = New System.Drawing.Point(361, 3)
        Me.gb_data.Name = "gb_data"
        Me.gb_data.Size = New System.Drawing.Size(889, 609)
        Me.gb_data.TabIndex = 1
        '
        'txt_searchuser
        '
        Me.txt_searchuser.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_searchuser.Location = New System.Drawing.Point(90, 12)
        Me.txt_searchuser.Name = "txt_searchuser"
        Me.txt_searchuser.NullText = "<Find user account>"
        Me.txt_searchuser.Size = New System.Drawing.Size(246, 20)
        Me.txt_searchuser.TabIndex = 122
        '
        'RadLabel4
        '
        Me.RadLabel4.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadLabel4.Location = New System.Drawing.Point(5, 13)
        Me.RadLabel4.Name = "RadLabel4"
        Me.RadLabel4.Size = New System.Drawing.Size(90, 19)
        Me.RadLabel4.TabIndex = 121
        Me.RadLabel4.Text = "Find Lot Code:"
        '
        'lv_useraccountlist
        '
        Me.lv_useraccountlist.AllowColumnReorder = False
        Me.lv_useraccountlist.AllowEdit = False
        Me.lv_useraccountlist.AllowRemove = False
        Me.lv_useraccountlist.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lv_useraccountlist.Font = New System.Drawing.Font("Segoe UI", 8.0!, System.Drawing.FontStyle.Bold)
        Me.lv_useraccountlist.ItemSpacing = -1
        Me.lv_useraccountlist.Location = New System.Drawing.Point(5, 39)
        Me.lv_useraccountlist.Name = "lv_useraccountlist"
        Me.lv_useraccountlist.SelectLastAddedItem = False
        Me.lv_useraccountlist.ShowGridLines = True
        Me.lv_useraccountlist.Size = New System.Drawing.Size(879, 565)
        Me.lv_useraccountlist.TabIndex = 117
        Me.lv_useraccountlist.ViewType = Telerik.WinControls.UI.ListViewType.DetailsView
        '
        'cms_usermenu
        '
        Me.cms_usermenu.Items.AddRange(New Telerik.WinControls.RadItem() {Me.refreshuser, Me.RadMenuSeparatorItem1, Me.createuser, Me.modifyuser, Me.removeuser, Me.RadMenuSeparatorItem2, Me.assignedpermissionuser})
        '
        'refreshuser
        '
        Me.refreshuser.AccessibleDescription = "Refresh Data"
        Me.refreshuser.AccessibleName = "Refresh Data"
        Me.refreshuser.Name = "refreshuser"
        Me.refreshuser.Text = "Refresh Data"
        Me.refreshuser.Visibility = Telerik.WinControls.ElementVisibility.Visible
        '
        'RadMenuSeparatorItem1
        '
        Me.RadMenuSeparatorItem1.AccessibleDescription = "RadMenuSeparatorItem1"
        Me.RadMenuSeparatorItem1.AccessibleName = "RadMenuSeparatorItem1"
        Me.RadMenuSeparatorItem1.Name = "RadMenuSeparatorItem1"
        Me.RadMenuSeparatorItem1.Text = "RadMenuSeparatorItem1"
        Me.RadMenuSeparatorItem1.Visibility = Telerik.WinControls.ElementVisibility.Visible
        '
        'createuser
        '
        Me.createuser.AccessibleDescription = "Create User"
        Me.createuser.AccessibleName = "Create User"
        Me.createuser.Name = "createuser"
        Me.createuser.Text = "Create User"
        Me.createuser.Visibility = Telerik.WinControls.ElementVisibility.Visible
        '
        'modifyuser
        '
        Me.modifyuser.AccessibleDescription = "Modify User"
        Me.modifyuser.AccessibleName = "Modify User"
        Me.modifyuser.Name = "modifyuser"
        Me.modifyuser.Text = "Modify User"
        Me.modifyuser.Visibility = Telerik.WinControls.ElementVisibility.Visible
        '
        'removeuser
        '
        Me.removeuser.AccessibleDescription = "Remove User"
        Me.removeuser.AccessibleName = "Remove User"
        Me.removeuser.Name = "removeuser"
        Me.removeuser.Text = "Remove User"
        Me.removeuser.Visibility = Telerik.WinControls.ElementVisibility.Visible
        '
        'RadMenuSeparatorItem2
        '
        Me.RadMenuSeparatorItem2.AccessibleDescription = "RadMenuSeparatorItem2"
        Me.RadMenuSeparatorItem2.AccessibleName = "RadMenuSeparatorItem2"
        Me.RadMenuSeparatorItem2.Name = "RadMenuSeparatorItem2"
        Me.RadMenuSeparatorItem2.Text = "RadMenuSeparatorItem2"
        Me.RadMenuSeparatorItem2.Visibility = Telerik.WinControls.ElementVisibility.Visible
        '
        'assignedpermissionuser
        '
        Me.assignedpermissionuser.AccessibleDescription = "User Assigned Permission"
        Me.assignedpermissionuser.AccessibleName = "User Assigned Permission"
        Me.assignedpermissionuser.Name = "assignedpermissionuser"
        Me.assignedpermissionuser.Text = "User Assigned Permission"
        Me.assignedpermissionuser.Visibility = Telerik.WinControls.ElementVisibility.Visible
        '
        'Frm_user_control_maintenace
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1252, 613)
        Me.Controls.Add(Me.gb_menu)
        Me.Controls.Add(Me.gb_data)
        Me.Name = "Frm_user_control_maintenace"
        '
        '
        '
        Me.RootElement.ApplyShapeToControl = True
        Me.Text = "Frm_user_control_maintenace"
        CType(Me.gb_menu, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gb_menu.ResumeLayout(False)
        Me.gb_menu.PerformLayout()
        CType(Me.RadLabel9, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dp_usertype, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_lname, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_mname, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_fname, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_confirm_pass, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_password, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_username, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btn_canceluser, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btn_saveuser, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gb_data, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gb_data.ResumeLayout(False)
        Me.gb_data.PerformLayout()
        CType(Me.txt_searchuser, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lv_useraccountlist, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents gb_menu As Telerik.WinControls.UI.RadGroupBox
    Friend WithEvents btn_saveuser As Telerik.WinControls.UI.RadButton
    Friend WithEvents lv_useraccountlist As Telerik.WinControls.UI.RadListView
    Friend WithEvents gb_data As Telerik.WinControls.UI.RadGroupBox
    Friend WithEvents txt_searchuser As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents RadLabel4 As Telerik.WinControls.UI.RadLabel
    Friend WithEvents RadLabel1 As Telerik.WinControls.UI.RadLabel
    Friend WithEvents btn_canceluser As Telerik.WinControls.UI.RadButton
    Friend WithEvents txt_password As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents RadLabel2 As Telerik.WinControls.UI.RadLabel
    Friend WithEvents txt_username As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents txt_confirm_pass As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents RadLabel3 As Telerik.WinControls.UI.RadLabel
    Friend WithEvents txt_lname As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents RadLabel7 As Telerik.WinControls.UI.RadLabel
    Friend WithEvents txt_mname As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents RadLabel6 As Telerik.WinControls.UI.RadLabel
    Friend WithEvents txt_fname As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents RadLabel5 As Telerik.WinControls.UI.RadLabel
    Friend WithEvents RadLabel9 As Telerik.WinControls.UI.RadLabel
    Friend WithEvents dp_usertype As Telerik.WinControls.UI.RadDropDownList
    Friend WithEvents cms_usermenu As Telerik.WinControls.UI.RadContextMenu
    Friend WithEvents refreshuser As Telerik.WinControls.UI.RadMenuItem
    Friend WithEvents createuser As Telerik.WinControls.UI.RadMenuItem
    Friend WithEvents modifyuser As Telerik.WinControls.UI.RadMenuItem
    Friend WithEvents removeuser As Telerik.WinControls.UI.RadMenuItem
    Friend WithEvents RadMenuSeparatorItem1 As Telerik.WinControls.UI.RadMenuSeparatorItem
    Friend WithEvents RadMenuSeparatorItem2 As Telerik.WinControls.UI.RadMenuSeparatorItem
    Friend WithEvents assignedpermissionuser As Telerik.WinControls.UI.RadMenuItem
End Class

