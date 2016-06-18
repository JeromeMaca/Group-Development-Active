<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Frm_user_control_permission
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
        Me.gb_data = New Telerik.WinControls.UI.RadGroupBox()
        Me.txt_searchuser = New Telerik.WinControls.UI.RadTextBox()
        Me.RadLabel4 = New Telerik.WinControls.UI.RadLabel()
        Me.lv_useraccountpermission = New Telerik.WinControls.UI.RadListView()
        Me.RadGroupBox2 = New Telerik.WinControls.UI.RadGroupBox()
        Me.cms_menuuserpermission = New Telerik.WinControls.UI.RadContextMenu(Me.components)
        Me.btn_next = New Telerik.WinControls.UI.RadMenuItem()
        Me.btn_back = New Telerik.WinControls.UI.RadMenuItem()
        Me.RadMenuSeparatorItem1 = New Telerik.WinControls.UI.RadMenuSeparatorItem()
        Me.btn_enabled = New Telerik.WinControls.UI.RadMenuItem()
        Me.btn_disabled = New Telerik.WinControls.UI.RadMenuItem()
        CType(Me.gb_data, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gb_data.SuspendLayout()
        CType(Me.txt_searchuser, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lv_useraccountpermission, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadGroupBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'gb_data
        '
        Me.gb_data.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping
        Me.gb_data.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gb_data.Controls.Add(Me.txt_searchuser)
        Me.gb_data.Controls.Add(Me.RadLabel4)
        Me.gb_data.Controls.Add(Me.lv_useraccountpermission)
        Me.gb_data.HeaderText = ""
        Me.gb_data.Location = New System.Drawing.Point(2, 3)
        Me.gb_data.Name = "gb_data"
        Me.gb_data.Size = New System.Drawing.Size(494, 544)
        Me.gb_data.TabIndex = 2
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
        'lv_useraccountpermission
        '
        Me.lv_useraccountpermission.AllowColumnReorder = False
        Me.lv_useraccountpermission.AllowEdit = False
        Me.lv_useraccountpermission.AllowRemove = False
        Me.lv_useraccountpermission.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lv_useraccountpermission.Font = New System.Drawing.Font("Segoe UI", 7.5!, System.Drawing.FontStyle.Bold)
        Me.lv_useraccountpermission.ItemSpacing = -1
        Me.lv_useraccountpermission.Location = New System.Drawing.Point(5, 38)
        Me.lv_useraccountpermission.Name = "lv_useraccountpermission"
        Me.lv_useraccountpermission.SelectLastAddedItem = False
        Me.lv_useraccountpermission.ShowGridLines = True
        Me.lv_useraccountpermission.Size = New System.Drawing.Size(484, 501)
        Me.lv_useraccountpermission.TabIndex = 117
        Me.lv_useraccountpermission.ViewType = Telerik.WinControls.UI.ListViewType.DetailsView
        '
        'RadGroupBox2
        '
        Me.RadGroupBox2.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping
        Me.RadGroupBox2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.RadGroupBox2.HeaderText = ""
        Me.RadGroupBox2.Location = New System.Drawing.Point(499, 3)
        Me.RadGroupBox2.Name = "RadGroupBox2"
        Me.RadGroupBox2.Size = New System.Drawing.Size(443, 544)
        Me.RadGroupBox2.TabIndex = 4
        '
        'cms_menuuserpermission
        '
        Me.cms_menuuserpermission.Items.AddRange(New Telerik.WinControls.RadItem() {Me.btn_next, Me.btn_back, Me.RadMenuSeparatorItem1, Me.btn_enabled, Me.btn_disabled})
        '
        'btn_next
        '
        Me.btn_next.AccessibleDescription = "Next"
        Me.btn_next.AccessibleName = "Next"
        Me.btn_next.Name = "btn_next"
        Me.btn_next.Text = "Next"
        Me.btn_next.Visibility = Telerik.WinControls.ElementVisibility.Visible
        '
        'btn_back
        '
        Me.btn_back.AccessibleDescription = "Back"
        Me.btn_back.AccessibleName = "Back"
        Me.btn_back.Name = "btn_back"
        Me.btn_back.Text = "Back"
        Me.btn_back.Visibility = Telerik.WinControls.ElementVisibility.Visible
        '
        'RadMenuSeparatorItem1
        '
        Me.RadMenuSeparatorItem1.AccessibleDescription = "RadMenuSeparatorItem1"
        Me.RadMenuSeparatorItem1.AccessibleName = "RadMenuSeparatorItem1"
        Me.RadMenuSeparatorItem1.Name = "RadMenuSeparatorItem1"
        Me.RadMenuSeparatorItem1.Text = "RadMenuSeparatorItem1"
        Me.RadMenuSeparatorItem1.Visibility = Telerik.WinControls.ElementVisibility.Visible
        '
        'btn_enabled
        '
        Me.btn_enabled.AccessibleDescription = "Enabled"
        Me.btn_enabled.AccessibleName = "Enabled"
        Me.btn_enabled.Name = "btn_enabled"
        Me.btn_enabled.Text = "Enabled"
        Me.btn_enabled.Visibility = Telerik.WinControls.ElementVisibility.Visible
        '
        'btn_disabled
        '
        Me.btn_disabled.AccessibleDescription = "Disabled"
        Me.btn_disabled.AccessibleName = "Disabled"
        Me.btn_disabled.Name = "btn_disabled"
        Me.btn_disabled.Text = "Disabled"
        Me.btn_disabled.Visibility = Telerik.WinControls.ElementVisibility.Visible
        '
        'Frm_user_control_permission
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(945, 551)
        Me.Controls.Add(Me.RadGroupBox2)
        Me.Controls.Add(Me.gb_data)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Frm_user_control_permission"
        '
        '
        '
        Me.RootElement.ApplyShapeToControl = True
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Frm_user_control_permission"
        CType(Me.gb_data, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gb_data.ResumeLayout(False)
        Me.gb_data.PerformLayout()
        CType(Me.txt_searchuser, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lv_useraccountpermission, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadGroupBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents gb_data As Telerik.WinControls.UI.RadGroupBox
    Friend WithEvents txt_searchuser As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents RadLabel4 As Telerik.WinControls.UI.RadLabel
    Friend WithEvents lv_useraccountpermission As Telerik.WinControls.UI.RadListView
    Friend WithEvents RadGroupBox2 As Telerik.WinControls.UI.RadGroupBox
    Friend WithEvents cms_menuuserpermission As Telerik.WinControls.UI.RadContextMenu
    Friend WithEvents btn_next As Telerik.WinControls.UI.RadMenuItem
    Friend WithEvents btn_back As Telerik.WinControls.UI.RadMenuItem
    Friend WithEvents RadMenuSeparatorItem1 As Telerik.WinControls.UI.RadMenuSeparatorItem
    Friend WithEvents btn_enabled As Telerik.WinControls.UI.RadMenuItem
    Friend WithEvents btn_disabled As Telerik.WinControls.UI.RadMenuItem
End Class

